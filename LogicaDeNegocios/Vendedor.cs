// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Vendedor.cs" company="">
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
    /// Class Vendedor.
    /// Implements the <see cref="LogicaDeNegocios.Persona" />
    /// </summary>
    /// <seealso cref="LogicaDeNegocios.Persona" />
    public class Vendedor: Persona
    {
        /// <summary>
        /// The sueldo
        /// </summary>
        private double sueldo;
        /// <summary>
        /// The credencial usuario
        /// </summary>
        CredencialUsuario credencialUsuario;
        /// <summary>
        /// Initializes a new instance of the <see cref="Vendedor" /> class.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="sexo">The sexo.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="sueldo">The sueldo.</param>
        /// <param name="credencialUsuario">The credencial usuario.</param>
        public Vendedor(string cedula, string nombre, string sexo, string telefono, double sueldo, CredencialUsuario credencialUsuario)
            : base(cedula, nombre, sexo, telefono)
        {
            this.sueldo = sueldo;
            this.credencialUsuario = credencialUsuario;
        }
        public Vendedor() { }

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
        /// Buscars the chofer.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <returns>List&lt;Chofer&gt;.</returns>
        public static Vendedor BuscarVended(string cedula)
        {

            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            Vendedor vendedor = null;
            CredencialUsuario credencial = null;
            try
            {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_BuscarVendedor", con.conectar());
                mySqlCommand.Parameters.AddWithValue("@Cedula", cedula);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    credencial = new CredencialUsuario(lector["Correo"].ToString(), lector["Contrasena"].ToString(), 3);
                    vendedor = new Vendedor(lector["Cedula"].ToString(), lector["Nombre"].ToString(), lector["Sexo"].ToString(), lector["Telefono"].ToString(), Convert.ToDouble(lector["Sueldo"].ToString()), credencial);
                }
                con.cerrar();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error emitido por: " + ex);
            }
            return vendedor;
        }

        /// <summary>
        /// Actualizars the vendedor.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="sexo">The sexo.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns>System.String.</returns>
        public string ActualizarVendedor(string cedula, string telefono, string correo, string contrasena)
        {
            string mensaje = "";
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();

            try
            {
                MySqlCommand comando = conector.ConectarProcedimiento("spl_ModificarVendedor", con.conectar());
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Cedula1", cedula);
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
        internal List<Vendedor> BuscarVendedor(string datoVendedor)
        {
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            Vendedor vendedor = null;
            CredencialUsuario credencial = null;
            List<Vendedor> ListVendedor = new List<Vendedor>();
            try
            {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("ConsultarVendedor", con.conectar());
                mySqlCommand.Parameters.AddWithValue("@DatoFx", datoVendedor);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    credencial = new CredencialUsuario(lector["Correo"].ToString(), lector["Contrasena"].ToString(), 0);
                    vendedor = new Vendedor(lector["Cedula"].ToString(), lector["Nombre"].ToString(), lector["Sexo"].ToString(), lector["Telefono"].ToString(),420 ,credencial);
                    ListVendedor.Add(vendedor);
                }
                con.cerrar();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error emitido por: " + ex);
            }
            return ListVendedor;
        }

        internal static bool EliminarVendedor(string cedulaNombre)
        {

            bool x = false;
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try
            {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("EliminarVendedor", con.conectar());
                mySqlCommand.Parameters.AddWithValue("@CedulaFx", cedulaNombre);
                mySqlCommand.ExecuteNonQuery();
                x = true;
                con.cerrar();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error emitido por: " + ex);
            }
            return x;
        }

       

        /// <summary>
        /// Insertars the vendedor.
        /// </summary>
        /// <param name="vendedor">The vendedor.</param>
        public void InsertarVendedor(Vendedor vendedor)
        {
            // Se llama a la clase conexion para hacer la conexion con la base de dados
            Conexion con = new Conexion();
            // Se llama a la clase  ConectorDeProcedimientos y se crea el objeto conector que permite realizar el procedimiento de inserta un nuevo cliente
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try
            {
                List<Vendedor> ListaNueva = new List<Vendedor>();
                ListaNueva.Add(vendedor);
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_insertarVendedor", con.conectar());
                foreach (Vendedor Vendedor in ListaNueva)
                {
                    mySqlCommand.Parameters.AddWithValue("@CedulaFx", Vendedor.Cedula);
                    mySqlCommand.Parameters.AddWithValue("@NombreFx", Vendedor.Nombre);
                    mySqlCommand.Parameters.AddWithValue("@SexoFx", Vendedor.Sexo);
                    mySqlCommand.Parameters.AddWithValue("@TelefonoFx", Vendedor.Telefono);
                    mySqlCommand.Parameters.AddWithValue("@SueldoFx", Vendedor.Sueldo);
                    mySqlCommand.Parameters.AddWithValue("@CorreoFx", Vendedor.CredencialUsuario.Correo);
                    mySqlCommand.Parameters.AddWithValue("@ContrasenaFx", Vendedor.CredencialUsuario.Contrasena);
                    mySqlCommand.Parameters.AddWithValue("@Foreking_RolesUsuarioFx", Vendedor.CredencialUsuario.Rol);
                   
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
