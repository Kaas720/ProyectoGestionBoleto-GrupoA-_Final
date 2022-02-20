// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Administrador.cs" company="">
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
    /// Class Administrador.
    /// Implements the <see cref="LogicaDeNegocios.Persona" />
    /// </summary>
    /// <seealso cref="LogicaDeNegocios.Persona" />
    public class Administrador: Persona
    {
        /// <summary>
        /// The credencial usuario
        /// </summary>
        private CredencialUsuario credencialUsuario;

        /// <summary>
        /// Initializes a new instance of the <see cref="Administrador" /> class.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="sexo">The sexo.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="credencialUsuario">The credencial usuario.</param>
        public Administrador(string cedula, string nombre, string sexo, string telefono, CredencialUsuario credencialUsuario)
            :base(cedula, nombre, sexo, telefono)
        {
            this.credencialUsuario = credencialUsuario;
        }
        /// <summary>
        /// Gets or sets the credencial usuario.
        /// </summary>
        /// <value>The credencial usuario.</value>
        public CredencialUsuario CredencialUsuario { get => credencialUsuario; set => credencialUsuario = value; }

        /// <summary>
        /// Consultars the administrador.
        /// </summary>
        /// <param name="idPersona">The identifier persona.</param>
        /// <returns>Administrador.</returns>
        public static Administrador ConsultarAdministrador(int idPersona)
        {
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            Administrador admin = null;
            CredencialUsuario credencial = null;
            try
            {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("BuscarAdministrador", con.conectar());
                mySqlCommand.Parameters.AddWithValue("@IdPersona", idPersona);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    credencial = new CredencialUsuario(lector["Correo"].ToString(), lector["Contraseña"].ToString(), 0);
                    admin = new Administrador(lector["Cedula"].ToString(), lector["Nombre"].ToString(), lector["Sexo"].ToString(), lector["Telefono"].ToString(), credencial);
                }
                con.cerrar();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            return admin;
        }
        /*
        public void InsertarAdministrador(Administrador admin)
        {
            // Se llama a la clase conexion para hacer la conexion con la base de dados
            Conexion con = new Conexion();
            // Se llama a la clase  ConectorDeProcedimientos y se crea el objeto conector que permite realizar el procedimiento de inserta un nuevo cliente
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try
            {
                List<Administrador> ListaNueva = new List<Administrador>();
                ListaNueva.Add(admin);
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_insertarAdministrador", con.conectar());
                foreach (Administrador Admin in ListaNueva)
                {
                    mySqlCommand.Parameters.AddWithValue("@CedulaFx", Admin.Cedula);
                    mySqlCommand.Parameters.AddWithValue("@NombreFx", Admin.Nombre);
                    mySqlCommand.Parameters.AddWithValue("@SexoFx", Admin.Sexo);
                    mySqlCommand.Parameters.AddWithValue("@TelefonoFx", Admin.Telefono);
                    mySqlCommand.Parameters.AddWithValue("@TelefonoFx", Admin.CodigoAcceso);
                    mySqlCommand.Parameters.AddWithValue("@SueldoFx", Admin.Sueldo);
                    mySqlCommand.Parameters.AddWithValue("@CorreoFx", Admin.CredencialUsuario.Correo);
                    mySqlCommand.Parameters.AddWithValue("@ContrasenaFx", Admin.CredencialUsuario.Contrasena);
                    mySqlCommand.Parameters.AddWithValue("@Foreking_RolesUsuarioFx", Admin.CredencialUsuario.Rol);

                }
                mySqlCommand.ExecuteReader();
                con.cerrar();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex);
            }

        }*/
    }
}
