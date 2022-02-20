// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Cliente.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
    /// <summary>
    /// <br />
    /// </summary>
    /// Se crea la clase cliente que hereda de la clase persona

    public class Cliente: Persona
    {

        /// <summary>
        /// The credencial usuario
        /// </summary>
        private CredencialUsuario credencialUsuario;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cliente" /> class.
        /// </summary>
        public Cliente() 
        { }
        // Se crea el constructor parametrizado y se invoca a base para hacer uso de la herencia

        /// <summary>
        /// Initializes a new instance of the <see cref="T:LogicaDeNegocios.Cliente" /> class.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="sexo">The sexo.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="credencialUsuario">The credencial usuario.</param>
        public Cliente(string cedula, string nombre, string sexo, string telefono, CredencialUsuario credencialUsuario) : base(cedula, nombre, sexo, telefono)
        {         
            this.credencialUsuario = credencialUsuario;
        }

        /// <summary>
        /// Gets or sets the credencial usuario.
        /// </summary>
        /// <value>The credencial usuario.</value>
        public CredencialUsuario CredencialUsuario { get => credencialUsuario; set => credencialUsuario = value; }

        /// <summary>
        /// Insertars the cliente.
        /// </summary>
        /// <param name="client">The client.</param>
        public void InsertarCliente(Cliente client)
            {
                // Se llama a la clase conexion para hacer la conexion con la base de dados
                Conexion con = new Conexion();
                // Se llama a la clase  ConectorDeProcedimientos y se crea el objeto conector que permite realizar el procedimiento de inserta un nuevo cliente
                ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
                try
                {
                    List<Cliente> ListaNueva = new List<Cliente>();
                    ListaNueva.Add(client);
                    MySqlCommand mySqlCommand = conector.ConectarProcedimiento("RegistroClienteGeneral", con.conectar());
                     foreach (Cliente Cliente in ListaNueva)
                     {
                        mySqlCommand.Parameters.AddWithValue("@CedulaFx", Cliente.Cedula);
                        mySqlCommand.Parameters.AddWithValue("@NombreFx", Cliente.Nombre);
                        mySqlCommand.Parameters.AddWithValue("@SexoFx", Cliente.Sexo);
                        mySqlCommand.Parameters.AddWithValue("@TelefonoFx", Cliente.Telefono);
                        mySqlCommand.Parameters.AddWithValue("@CorreoFx", Cliente.CredencialUsuario.Correo);
                        mySqlCommand.Parameters.AddWithValue("@ContrasenaFx", Cliente.CredencialUsuario.Contrasena);
                        mySqlCommand.Parameters.AddWithValue("@Foreking_RolesUsuarioFx", Cliente.CredencialUsuario.Rol);
                    }
                     mySqlCommand.ExecuteReader();
                     con.cerrar();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine(ex);
                }

            }
        //public static Cliente ConsultarCliente(String cedula)
        /// <summary>
        /// Buscars the cliente.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <returns>List&lt;Cliente&gt;.</returns>
        public List<Cliente> BuscarCliente(String cedula)
        {
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            List<Cliente> lista = new List<Cliente>();
            Cliente client = null;
            CredencialUsuario credencial = null;
            try
            {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("ConsultarCliente", con.conectar());
                mySqlCommand.Parameters.AddWithValue("@CedulaFx", cedula);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    credencial = new CredencialUsuario(lector["Correo"].ToString(), lector["Contraseña"].ToString(), 0);
                    client = new Cliente(lector["Cedula"].ToString(), lector["Nombre"].ToString(), lector["Sexo"].ToString(), lector["Telefono"].ToString(), credencial);
                    //client = new Cliente(lector["Cedula"].ToString(), lector["Nombre"].ToString(),"","", lector["Correo"].ToString(),""); 
                }
                con.cerrar();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error emitido por: "+ex);
            }
             return lista;
        }
        /// <summary>
        /// Actualizars the cliente.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="sexo">The sexo.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns>System.String.</returns>
        public string ActualizarCliente(string cedula, string nombre, string sexo, string telefono, string correo, string contrasena)
        {
            string mensaje = "";
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();

            try
            {
                MySqlCommand comando = conector.ConectarProcedimiento("ModificarCliente", con.conectar());
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Cedula1", cedula);
                comando.Parameters.AddWithValue("@Nombre1", nombre);
                comando.Parameters.AddWithValue("@Sexo1", sexo);
                comando.Parameters.AddWithValue("@Telefono1", telefono);
                comando.Parameters.AddWithValue("@Correo1", correo);
                comando.Parameters.AddWithValue("@Contraseña1", contrasena);
                comando.ExecuteNonQuery();
                con.cerrar();
                mensaje = "Se actualizaron los campos correctamente";
            }
            catch (MySqlException ex)
            {

                mensaje = "Se ha producido un error al actualizar los datos" + ex;
            }
            return mensaje;
        }
    
    }
}
