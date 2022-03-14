// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Program.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using LogicaDeNegocios;
using Presentacion.InicioFroms;
using Presentacion.SGA_Administrador;
using Presentacion.SGA_Cooperativa;
using Presentacion.UsuarioCliente;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    /// <summary>
    /// Class Program.
    /// </summary>
    static class Program
    {
        /////
        /// <summary>
        /// The principal
        /// </summary>
        public static Principal_Usuario principal = null;
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //
           Application.Run(principal = new Principal_Usuario());
            //Application.Run(new VentanaAdministrador(2));
            //Application.Run(new VentanaAdministrador(1));
            //  Application.Run(new RegistroCliente());
            //Application.Run(new InterfazCliente(4));
            //Application.Run(new RegistroCooperativa());
            //  Application.Run(new RegistroAdministrador());
            //Application.Run(new GenerarBoleto());
        }
    }
}
