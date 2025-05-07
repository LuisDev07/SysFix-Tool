using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysFix_Tool
{
    public partial class SysFixTool : Form
    {
        string handlePath = Path.Combine(Application.StartupPath, "Handle", "handle.exe");


        // Importaciones para manipular la forma y comportamiento de la ventana
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        // ✓ UTILIZADO en los botones de minimizar, maximizar y restaurar



        // Constantes para ShowWindow - Controlan el estado de visualización de la ventana
        private const int SW_MAXIMIZE = 3;         // ✓ UTILIZADO en button4_Click (maximizar)

        private const int SW_SHOWMINNOACTIVE = 7;  // ✓ UTILIZADO en button3_Click (minimizar)

        private const int SW_RESTORE = 9;          // ✓ UTILIZADO en button6_Click (restaurar)


        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsZoomed(IntPtr hWnd);
        // ✓ UTILIZADO en UpdateFormShape para detectar si está maximizada

        // Estructura y funciones para hacer parpadear la ventana
        [StructLayout(LayoutKind.Sequential)]
        private struct FLASHWINFO
        {
            public uint cbSize; public IntPtr hwnd; public uint dwFlags; public uint uCount; public uint dwTimeout;
        }
        // ✓ UTILIZADO en FlashWindow

        private const uint FLASHW_ALL = 0x3;
        // ✓ UTILIZADO como valor predeterminado en FlashWindow



        // Configuración para permitir minimizar la ventana sin bordes
        private const int WS_MINIMIZEBOX = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                return cp;
            }
        }
        // ✓ UTILIZADO para habilitar el botón de minimizar en la barra de tareas

        // Constantes para AnimateWindow - Controlan el tipo de animación

        private const int AW_HIDE = 0x00010000;         // ✓ UTILIZADO en button3_Click (minimizar)

        private const int AW_BLEND = 0x00080000;        // ✓ UTILIZADO en button3_Click (minimizar)

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        // ✓ UTILIZADO en button3_Click para animar la minimización

        // Constantes para mover y redimensionar la ventana
        private const int WM_NCLBUTTONDOWN = 0xA1;  // ✓ UTILIZADO en panelDragHandle_MouseDown
        private const int HT_CAPTION = 0x2;         // ✓ UTILIZADO en panelDragHandle_MouseDown
        private const int WM_NCHITTEST = 0x84;      // ✓ UTILIZADO en WndProc

        // Constantes para detectar bordes al redimensionar
        private const int HTLEFT = 0xA;             // ✓ UTILIZADO en WndProc
        private const int HTRIGHT = 0xB;            // ✓ UTILIZADO en WndProc
        private const int HTTOP = 0xC;              // ✓ UTILIZADO en WndProc
        private const int HTTOPLEFT = 0xD;          // ✓ UTILIZADO en WndProc
        private const int HTTOPRIGHT = 0xE;         // ✓ UTILIZADO en WndProc
        private const int HTBOTTOM = 0xF;           // ✓ UTILIZADO en WndProc
        private const int HTBOTTOMLEFT = 0x10;      // ✓ UTILIZADO en WndProc
        private const int HTBOTTOMRIGHT = 0x11;     // ✓ UTILIZADO en WndProc
        private const int HTCLIENT = 0x1;           // ✓ UTILIZADO en WndProc

        // Importaciones para crear y manipular regiones de ventana (bordes redondeados)
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        // ✓ UTILIZADO en UpdateFormShape para crear bordes redondeados

        [DllImport("user32.dll", EntryPoint = "SetWindowRgn")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);
        // ✓ UTILIZADO en UpdateFormShape para aplicar la región

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);
        // ✓ UTILIZADO en UpdateFormShape y OnFormClosed para liberar recursos

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        // ✓ UTILIZADO en panelDragHandle_MouseDown para mover la ventana

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        // ✓ UTILIZADO en panelDragHandle_MouseDown para liberar el mouse



        // Variable para rastrear el estado de maximización
        private bool isMaximized = false;

        // Variables para la forma y comportamiento de la ventana////////
        private IntPtr currentRegion = IntPtr.Zero;
        private int cornerRadius = 20;
        private int resizeBorderWidth = 10;
        //timer apra la animacion del formulario //////////////
        private Timer fadeOutTimer;  // Para el fade out (desaparecer)
        private Timer fadeInTimer;   // Para el fade in (aparecer)
        private double opacityIncrement;
        private double finalOpacity;
        //animacion para el label de titulo
        //animacion de escritura en label 
        private string textoOriginal;
        private int index = 0;

        public SysFixTool()
        {
            InitializeComponent();


            // Inicializa los temporizadores de fade out y fade in
            fadeOutTimer = new Timer();
            fadeOutTimer.Interval = 30;  // Intervalo entre cada cambio de opacidad (ms)
            fadeOutTimer.Tick += FadeOutTimer_Tick;

            fadeInTimer = new Timer();
            fadeInTimer.Interval = 30;   // Intervalo entre cada cambio de opacidad (ms)
            fadeInTimer.Tick += FadeInTimer_Tick;

            // Define el incremento de opacidad para el efecto (más pequeño = más lento)
            opacityIncrement = 0.05;  // Incremento más pequeño para una transición suave

            // Define la opacidad final (puedes cambiar este valor)
            finalOpacity = 0.95;  // 99% de visibilidad

            // Inicializa la opacidad del formulario
            this.Opacity = 0;  // Empieza con opacidad 0 (invisible)


            // Asegúrate de que el evento Resize esté suscrito




            this.Resize += Principal_Resize;


           
            // Configuración básica del formulario
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;

            // Eventos
            this.Load += ApplyRoundedCorners;
            this.Resize += ApplyRoundedCorners;

            // Configuración del panel para arrastrar
            if (this.PanelHerramienta != null)
            {
                this.PanelHerramienta.MouseDown += PanelHerramienta_MouseDown;
            }
            else
            {
                MessageBox.Show("Error: El panel para arrastrar (panelDragHandle) no se encontró en el formulario.");
            }


            //iniciamos el texto de escritura en el label 
            // Recupera el texto preestablecido del Label
            textoOriginal = lblTitulo.Text;

            // Inicializa el Timer
            Timer timer = new Timer();
            timer.Interval = 200; // Intervalo de 100ms entre cada letra
            timer.Tick += Timer_Tick; // Evento cada vez que el timer "tickea"
            timer.Start();

            Restaurar.Visible = false;

            

          
        }



        private void EnableDoubleBuffering(Control control)
        {
            // Usar reflexión para acceder y cambiar el valor de DoubleBuffered
            var propertyInfo = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propertyInfo.SetValue(control, true, null);
        }


        //funcion para la escritura en el label 
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Si aún no se ha escrito todo el texto, lo vamos agregando letra por letra
            if (index < textoOriginal.Length)
            {
                lblTitulo.Text = textoOriginal.Substring(0, index + 1); // Actualiza el Label con las primeras letras
                index++; // Incrementa el índice para la siguiente letra
            }
            else
            {
                // Si ya se escribió todo el texto, detenemos el Timer
                Timer timer = sender as Timer;
                timer.Stop();
            }
        }
        //Metodo para la animacion del formulario
        // Temporizador para el fade out (desaparecer)
        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)  // Si la opacidad es mayor que 0, seguimos disminuyéndola
            {
                this.Opacity -= opacityIncrement;  // Reducimos la opacidad
            }
            else
            {
                fadeOutTimer.Stop();  // Detenemos el temporizador
                this.WindowState = FormWindowState.Minimized;  // Minimizar el formulario
            }
        }

        // Evento para el temporizador de fade in (aparecer)
        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            // Verificar si el formulario no está cerrado (disposed) y si está visible
            if (!this.IsDisposed && this.Visible && this.Opacity < finalOpacity)
            {
                this.Opacity += opacityIncrement;  // Aumentamos la opacidad
            }
            else
            {
                fadeInTimer.Stop();  // Detenemos el temporizador cuando se alcanza la opacidad final
            }
        }


        //// Evento cuando restauramos el formulario (hacer fade in)
        private void Principal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                fadeInTimer.Start();  // Iniciar la animación de aparecer (fade in)
            }
        }

        // Método para permitir arrastrar la ventana desde el panel personalizado
        private void PanelHerramienta_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Si está maximizada, primero restaurar a tamaño normal
                // y luego permitir el arrastre desde la posición del cursor
                if (isMaximized)
                {
                    // Calcular la proporción de la posición del cursor en la ventana
                    float proportionX = e.X / (float)this.Width;

                    // Restaurar a tamaño normal
                    Rectangle savedBounds = (Rectangle)this.Tag;
                    this.Width = savedBounds.Width;
                    this.Height = savedBounds.Height;

                    // Calcular nueva posición para que el cursor quede en el mismo lugar relativo
                    int newLeft = e.X - (int)(savedBounds.Width * proportionX);
                    this.Left = Cursor.Position.X - newLeft;
                    this.Top = Cursor.Position.Y - e.Y;

                    isMaximized = false;
                    UpdateFormShape();
                }
                Restaurar.Visible = false;
                Maximizar.Visible = true;
                // Permitir arrastrar la ventana
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Manejo de redimensionamiento mediante detección de bordes
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
            {
                // Si la ventana está maximizada, no permitir redimensionamiento
                if (isMaximized)
                {
                    return;
                }

                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = this.PointToClient(screenPoint);

                // Detecta en qué borde está el cursor para permitir redimensionar
                if (clientPoint.X <= resizeBorderWidth && clientPoint.Y <= resizeBorderWidth)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (clientPoint.X >= ClientSize.Width - resizeBorderWidth && clientPoint.Y <= resizeBorderWidth)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (clientPoint.X <= resizeBorderWidth && clientPoint.Y >= ClientSize.Height - resizeBorderWidth)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (clientPoint.X >= ClientSize.Width - resizeBorderWidth && clientPoint.Y >= ClientSize.Height - resizeBorderWidth)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (clientPoint.X <= resizeBorderWidth)
                    m.Result = (IntPtr)HTLEFT;
                else if (clientPoint.X >= ClientSize.Width - resizeBorderWidth)
                    m.Result = (IntPtr)HTRIGHT;
                else if (clientPoint.Y <= resizeBorderWidth)
                    m.Result = (IntPtr)HTTOP;
                else if (clientPoint.Y >= ClientSize.Height - resizeBorderWidth)
                    m.Result = (IntPtr)HTBOTTOM;
            }
        }

        // Actualiza la forma de la ventana (bordes redondeados)
        private void UpdateFormShape()
        {
            // Si la ventana está maximizada, quitar bordes redondeados
            if (isMaximized)
            {
                if (currentRegion != IntPtr.Zero)
                {
                    DeleteObject(currentRegion);
                    currentRegion = IntPtr.Zero;
                }
                SetWindowRgn(this.Handle, IntPtr.Zero, true);
                return;
            }

            // Libera la región anterior
            if (currentRegion != IntPtr.Zero)
            {
                DeleteObject(currentRegion);
                currentRegion = IntPtr.Zero;
            }

            // Aplica bordes redondeados si no está maximizada
            if (this.cornerRadius > 0 && this.Width > 0 && this.Height > 0)
            {
                currentRegion = CreateRoundRectRgn(0, 0, this.Width, this.Height, this.cornerRadius, this.cornerRadius);
                SetWindowRgn(this.Handle, currentRegion, true);
            }
            else
            {
                SetWindowRgn(this.Handle, IntPtr.Zero, true);
            }
        }

        // Método llamado al cargar y redimensionar
        private void ApplyRoundedCorners(object sender, EventArgs e)
        {
            UpdateFormShape();
        }

     




        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {

                // Guarda el tamaño y posición actual
                this.Tag = new Rectangle(this.Left, this.Top, this.Width, this.Height);

                // Obtiene el área de trabajo (pantalla excluyendo la barra de tareas)
                Rectangle workingArea = Screen.FromHandle(this.Handle).WorkingArea;

                // Maximiza al tamaño del área de trabajo
                this.Left = workingArea.Left;
                this.Top = workingArea.Top;
                this.Width = workingArea.Width;
                this.Height = workingArea.Height;

                isMaximized = true;



                Restaurar.Visible = true;
                Maximizar.Visible = false;
            }

            UpdateFormShape();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {

            AnimateWindow(this.Handle, 10, AW_HIDE | AW_BLEND);
            ShowWindow(this.Handle, SW_SHOWMINNOACTIVE);
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            if (isMaximized && this.Tag is Rectangle savedBounds)
            {
                // Restaura al tamaño y posición guardados
                this.Left = savedBounds.Left;
                this.Top = savedBounds.Top;
                this.Width = savedBounds.Width;
                this.Height = savedBounds.Height;

                isMaximized = false;

                Restaurar.Visible = false;
                Maximizar.Visible = true;
            }

            UpdateFormShape();
        }


        private void SysFixTool_Load(object sender, EventArgs e)
        {
            AplicarBordesRedondeados(SFC, 5);
            AplicarBordesRedondeados(Diagnosticar, 5);
            AplicarBordesRedondeados(ReparacionIMG, 5);
            AplicarBordesRedondeados(ReparacionCompleta, 5);
            AplicarBordesRedondeados(VerProcesos, 5);

        }


        public void AplicarBordesRedondeados(Button boton, int radio = 15)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, boton.Width, boton.Height);
            int diameter = radio * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            boton.Region = new Region(path);
        }



        private async Task EjecutarComandoCMD(string comando, bool cerrarTerminal = false)
        {
            try
            {
                await Task.Run(() =>
                {
                    string argumento = cerrarTerminal ? "/c" : "/k";
                    ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", $"{argumento} {comando}")
                    {
                        Verb = "runas", // Ejecutar como administrador
                        WindowStyle = ProcessWindowStyle.Normal
                    };

                    Process proceso = Process.Start(psi);
                    proceso.WaitForExit(); // Espera que el proceso termine
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el comando: " + ex.Message);
            }
        }

        private async Task EjecutarComandoPowerShell(string comando, bool cerrarTerminal = false)
        {
            try
            {
                await Task.Run(() =>
                {
                    string argumento = cerrarTerminal ? "-Command" : "-NoExit -Command";
                    ProcessStartInfo psi = new ProcessStartInfo("powershell.exe", $"{argumento} \"{comando}\"")
                    {
                        Verb = "runas", // Ejecutar como administrador
                        WindowStyle = ProcessWindowStyle.Normal
                    };

                    Process proceso = Process.Start(psi);
                    proceso.WaitForExit(); // Espera que el proceso termine
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el comando en PowerShell: " + ex.Message);
            }
        }


        private async void Diagnosticar_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("DISM /Online /Cleanup-Image /CheckHealth");
        }

        private async void ReparacionIMG_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("DISM /Online /Cleanup-Image /RestoreHealth");
        }

        private async void SFC_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("sfc /scannow");
        }

        private async void ReparacionCompleta_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("DISM /Online /Cleanup-Image /CheckHealth", true);
            await EjecutarComandoCMD("DISM /Online /Cleanup-Image /RestoreHealth", true);
            await EjecutarComandoCMD("sfc /scannow", true);
        }

        private async void VerProcesos_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("tasklist");
        }

        private  void DetenerProcesos_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtPID.Text.Trim(), out int pid))
                {
                    Process proceso = Process.GetProcessById(pid);
                    proceso.Kill();
                    MessageBox.Show($"Proceso con PID {pid} terminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número de PID válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No se encontró ningún proceso con ese PID.", "Proceso no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al terminar el proceso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números (y control como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        // Método para ejecutar handle.exe y obtener la salida de los procesos que usan el archivo o carpeta
        private async Task<string> EjecutarHandle(string rutaArchivo)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = handlePath,
                Arguments = $"\"{rutaArchivo}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process proceso = Process.Start(psi))
            {
                string salida = await Task.Run(() =>
                {
                    proceso.WaitForExit(); // Reemplaza WaitForExitAsync con WaitForExit  
                    return proceso.StandardOutput.ReadToEnd();
                });
                return salida;
            }
        }

        // Método para cerrar los procesos que están usando el archivo o carpeta y eliminarlo
        private async void CerrarProcesosYEliminarArchivoOCarpeta(string salida, string ruta)
        {
            // Extraemos los PID de la salida de handle.exe
            var pids = ExtraerPidsDeSalida(salida);

            foreach (var pid in pids)
            {
                // Intentar finalizar el proceso
                try
                {
                    // Comando para terminar el proceso por PID
                    string comando = $"taskkill /PID {pid} /F";
                    await EjecutarComandoCMD(comando); // Se agrega 'await' para esperar la ejecución del comando
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar terminar el proceso con PID {pid}: {ex.Message}");
                }
            }

            // Ahora intentar eliminar el archivo o la carpeta
            try
            {
                if (Directory.Exists(ruta))
                {
                    Directory.Delete(ruta, true); // Eliminar carpeta y su contenido
                    MessageBox.Show("La carpeta fue eliminada correctamente.");
                }
                else if (File.Exists(ruta))
                {
                    File.Delete(ruta); // Eliminar archivo
                    MessageBox.Show("El archivo fue eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el archivo o la carpeta: {ex.Message}");
            }
        }

        // Extraer los PIDs de la salida del comando handle.exe
        private List<int> ExtraerPidsDeSalida(string salida)
        {
            List<int> pids = new List<int>();

            // Buscar las líneas que contienen la información del PID
            var lineas = salida.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (var linea in lineas)
            {
                if (linea.Contains("pid:"))
                {
                    var pidString = linea.Split(new[] { "pid:" }, StringSplitOptions.None)[1].Trim();
                    if (int.TryParse(pidString, out int pid))
                    {
                        pids.Add(pid);
                    }
                }
            }

            return pids;
        }

  

        // Evento del botón para seleccionar archivo o carpeta y ejecutar todo
        private async void SeleccionarArchivo_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            string rutaSeleccionada = "";

            // Primero preguntar si el usuario quiere seleccionar un archivo o una carpeta
            resultado = MessageBox.Show("¿Quieres seleccionar un archivo? Si no, se seleccionará una carpeta.", "Seleccionar archivo o carpeta", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaSeleccionada = openFileDialog.FileName;
                }
            }
            else
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaSeleccionada = folderBrowserDialog.SelectedPath;
                }
            }

            // Si se seleccionó una ruta válida
            if (!string.IsNullOrEmpty(rutaSeleccionada))
            {
                // Ejecutar handle.exe con el archivo o carpeta seleccionado
                string salida = await EjecutarHandle(rutaSeleccionada);

                // Mostrar la salida en consola o en un TextBox
                MessageBox.Show(salida, "Procesos que usan el archivo o carpeta");

                // Aquí podrías ofrecer preguntar si desea finalizar los procesos
                if (salida.Contains("pid:")) // Hay procesos que usan el archivo o carpeta
                {
                    DialogResult confirmarResultado = MessageBox.Show("¿Deseas intentar cerrar los procesos y eliminar el archivo o carpeta?", "Confirmar", MessageBoxButtons.YesNo);

                    if (confirmarResultado == DialogResult.Yes)
                    {
                        CerrarProcesosYEliminarArchivoOCarpeta(salida, rutaSeleccionada);
                    }
                }
                else
                {
                    MessageBox.Show("Ningún proceso parece estar usando el archivo o carpeta.");
                }
            }
        }

        private async void InfoRed_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("ipconfig /all");
        }

        private  async void ConexActivas_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("netstat -ano");
        }

        private  async void LimpiarDNS_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("ipconfig /flushdns");
        }

        private async void HistorialNav_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("ipconfig /displaydns");
        }

        private async void RepararRed_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("netsh int ip reset");
        }

        private async void ArchivosInecesarios_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("cleanmgr\r\n");
        }

        private  async void Procesosospechosos_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("tasklist /v | findstr /i \"unknown\"");
        }

        private  async void EleminarArchivosDeInstalacion_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("dism /online /Cleanup-Image /StartComponentCleanup");
        }

        private async void ActualizacionDisponible_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("winget upgrade\r\n");
        }

        private async void ActualizarAll_Click(object sender, EventArgs e)
        {
            await EjecutarComandoCMD("winget upgrade --all\r\n");
        }

        private async void DesactivarProcesos_Click(object sender, EventArgs e)
        {
            await EjecutarComandoPowerShell("# Desactivar SysMain (Superfetch) - Mejora el rendimiento en discos HDD\r\nStop-Service -Name \"SysMain\" -Force\r\nSet-Service -Name \"SysMain\" -StartupType Disabled\r\n\r\n# Desactivar DiagTrack (telemetría de Microsoft)\r\nStop-Service -Name \"DiagTrack\" -Force\r\nSet-Service -Name \"DiagTrack\" -StartupType Disabled\r\n\r\n# Desactivar Fax (si no usas fax)\r\nStop-Service -Name \"Fax\" -Force\r\nSet-Service -Name \"Fax\" -StartupType Disabled\r\n\r\n# Desactivar RemoteRegistry (innecesario en PCs personales)\r\nStop-Service -Name \"RemoteRegistry\" -Force\r\nSet-Service -Name \"RemoteRegistry\" -StartupType Disabled\r\n", true);
            await EjecutarComandoPowerShell("Get-Service SysMain, DiagTrack, Fax, RemoteRegistry | Select Name, Status, StartType\r\n");
        }

        private  async void VerficarDisco_Click(object sender, EventArgs e)
        {
            await EjecutarComandoPowerShell("chkdsk C: / f / r / x");
        }

        private async void EstadoRAM_Click(object sender, EventArgs e)
        {
            await EjecutarComandoPowerShell("mdsched.exe\r\n");
        }
    }
    
}

