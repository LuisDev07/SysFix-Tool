using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Principal;



namespace SysFix_Tool
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Verificamos si ya se ejecuta como administrador
            if (!IsRunningAsAdministrator())
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = Application.ExecutablePath, // ejecuta de nuevo el programa
                        UseShellExecute = true,
                        Verb = "runas" // esto hace que pida permisos de administrador
                    };
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se requieren permisos de administrador para ejecutar esta herramienta.\n\n" + ex.Message, "Permisos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return; // Detenemos esta instancia
            }

            // Ya es administrador, se ejecuta normalmente
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
            Application.Run(new SysFixTool());

        }

        static bool IsRunningAsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
    }
}
