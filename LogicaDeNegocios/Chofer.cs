// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Chofer.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    /// <summary>
    /// Class Chofer.
    /// Implements the <see cref="LogicaDeNegocios.Persona" />
    /// </summary>
    /// <seealso cref="LogicaDeNegocios.Persona" />
    public class Chofer:Persona
    {
        /// <summary>
        /// The licencia
        /// </summary>
        private string licencia;
        /// <summary>
        /// The sueldo
        /// </summary>
        private double sueldo;
        /// <summary>
        /// The credencial usuario
        /// </summary>
        private CredencialUsuario credencialUsuario;

        /// <summary>
        /// Initializes a new instance of the <see cref="Chofer" /> class.
        /// </summary>
        public Chofer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Chofer" /> class.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="sexo">The sexo.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="licencia">The licencia.</param>
        /// <param name="sueldo">The sueldo.</param>
        /// <param name="credencialUsuario">The credencial usuario.</param>
        public Chofer(string cedula, string nombre, string sexo, string telefono, string licencia, double sueldo, CredencialUsuario credencialUsuario)
            :base(cedula, nombre, sexo, telefono)
        {
            this.licencia = licencia;
            this.sueldo = sueldo;
            this.credencialUsuario = credencialUsuario;
        }

        /// <summary>
        /// Gets or sets the licencia.
        /// </summary>
        /// <value>The licencia.</value>
        public string Licencia { get => licencia; set => licencia = value; }
        /// <summary>
        /// Gets or sets the sueldo.
        /// </summary>
        /// <value>The sueldo.</value>
        public double Sueldo { get => sueldo; set => sueldo = value; }
        /// <summary>
        /// Gets or sets the credencial usuario.
        /// </summary>
        /// <value>The credencial usuario.</value>
        public CredencialUsuario CredencialUsuario { get => credencialUsuario; set => credencialUsuario = value; }


        /// <summary>
        /// Insertars the chofer.
        /// </summary>
        /// <param name="chofer">The chofer.</param>
        public void InsertarChofer(Chofer chofer)
        {
            // Se llama a la clase conexion para hacer la conexion con la base de dados
            Conexion con = new Conexion();
            // Se llama a la clase  ConectorDeProcedimientos y se crea el objeto conector que permite realizar el procedimiento de inserta un nuevo cliente
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try
            {
                List<Chofer> ListaNueva = new List<Chofer>();
                ListaNueva.Add(chofer);
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_insertarChofer", con.conectar());
                foreach (Chofer Chofer in ListaNueva)
                {
                    mySqlCommand.Parameters.AddWithValue("@CedulaFx", Chofer.Cedula);
                    mySqlCommand.Parameters.AddWithValue("@NombreFx", Chofer.Nombre);
                    mySqlCommand.Parameters.AddWithValue("@SexoFx", Chofer.Sexo);
                    mySqlCommand.Parameters.AddWithValue("@TelefonoFx", Chofer.Telefono);
                    mySqlCommand.Parameters.AddWithValue("@Licencia", Chofer.Licencia);
                    mySqlCommand.Parameters.AddWithValue("@SueldoFx", Chofer.Sueldo);
                    mySqlCommand.Parameters.AddWithValue("@CorreoFx", Chofer.CredencialUsuario.Correo);
                    mySqlCommand.Parameters.AddWithValue("@ContrasenaFx", Chofer.CredencialUsuario.Contrasena);
                    mySqlCommand.Parameters.AddWithValue("@Foreking_RolesUsuarioFx", Chofer.CredencialUsuario.Rol);

                }
                mySqlCommand.ExecuteReader();
                con.cerrar();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex);
            }

        }
    }
}
