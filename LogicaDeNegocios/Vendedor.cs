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
        /// Initializes a new instance of the <see cref="Vendedor" /> class.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="sexo">The sexo.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="sueldo">The sueldo.</param>
        /// <param name="credencialUsuario">The credencial usuario.</param>
        public Vendedor(string cedula, string nombre, string sexo, string telefono, double sueldo, CredencialUsuario credencialUsuario)
            :base(cedula, nombre, sexo, telefono)
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

        //public void InsertarVendedor(Vendedor vendedor)
        //{
        //    MySqlCommand mySqlCommand;
        //    Conexion conexion = new Conexion();

        //    mySqlCommand = new MySqlCommand();
        //    mySqlCommand.CommandText = "RegistroClienteGeneral";
        //    mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //    mySqlCommand.Parameters.AddWithValue("@CedulaFx", vendedor.Cedula);
        //    mySqlCommand.Parameters.AddWithValue("@NombreFx", vendedor.Nombre);
        //    mySqlCommand.Parameters.AddWithValue("@SexoFx", vendedor.Sexo);
        //    mySqlCommand.Parameters.AddWithValue("@TelefonoFx", vendedor.Telefono);
        //    mySqlCommand.Parameters.AddWithValue("@TelefonoFx", vendedor.Sueldo);
        //    mySqlCommand.Parameters.AddWithValue("@CorreoFx", vendedor.CredencialUsuario.Correo);
        //    mySqlCommand.Parameters.AddWithValue("@ContrasenaFx", vendedor.CredencialUsuario.Contrasena);
        //    mySqlCommand.Parameters.AddWithValue("@Foreking_RolesUsuarioFx",vendedor.CredencialUsuario.Rol);
        //    try
        //    {
        //        conexion.conectar();
        //        mySqlCommand.Connection = conexion.Connection;
        //        mySqlCommand.ExecuteNonQuery();

        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("No se encontro la base de datos" + ex.ToString());
        //    }
        //    conexion.cerrar();
        //}



    }
}
