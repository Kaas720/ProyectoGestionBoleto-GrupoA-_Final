using Presentacion.InicioFroms;
using Presentacion.SGA_Administrador;
using Presentacion.UsuarioCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// 
        public static Principal_Usuario principal = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(principal = new Principal_Usuario());
            //Application.Run(new PerfilAdminidtrador());
            // Application.Run(new RegistroVendedor());
            //  Application.Run(new RegistroCliente());
            Application.Run(new VentanaAdministrador());
        }
    }
}
