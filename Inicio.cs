using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysFix_Tool
{
    public partial class Inicio : Form
    {
        private bool formularioMostrado = false;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
       int nLeftRect,     // Coordenada X del borde izquierdo
       int nTopRect,      // Coordenada Y del borde superior
       int nRightRect,    // Coordenada X del borde derecho
       int nBottomRect,   // Coordenada Y del borde inferior
       int nWidthEllipse, // Ancho de la elipse (para el redondeo)
       int nHeightEllipse // Altura de la elipse (para el redondeo)
   );
        public Inicio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //Configuracion del tiempo de espera
            TiempoDeAparicion.Interval = 2000; // 2 segundos
            TiempoDeAparicion.Tick += TiempoDeAparicion_Tick;
            TiempoDeAparicion.Start(); // Iniciar el Timer
        }
        private void TiempoDeAparicion_Tick(object sender, EventArgs e)
        {
            if (!formularioMostrado)
            {
                // Mostrar el formulario (si estaba oculto)
                this.Show();
                formularioMostrado = true;
                TiempoDeAparicion.Interval = 3000; // Reiniciar el Timer para cerrar
            }
            else
            {
                // Cerrar el formulario después del tiempo
                this.Close();
                TiempoDeAparicion.Stop(); // Detener el Timer
            }
        }


    }
}
