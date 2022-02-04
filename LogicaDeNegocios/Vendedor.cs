using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
   public class Vendedor: Persona
    {
        private double sueldo;
        CredencialUsuario credencialUsuario;

        public Vendedor(string cedula, string nombre, string sexo, string telefono,  double sueldo, CredencialUsuario credencialUsuario)
            :base(cedula, nombre, sexo, telefono)
        {
            this.sueldo = sueldo;
            this.credencialUsuario = credencialUsuario;
        }

        public double Sueldo { get => sueldo; set => sueldo = value; }
        public CredencialUsuario CredencialUsuario { get => credencialUsuario; set => credencialUsuario = value; }

        public void InsertarVendedor(Vendedor vendedor)
        {
            MySqlCommand mySqlCommand;
            Conexion conexion = new Conexion();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandText = "RegistroClienteGeneral";
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            mySqlCommand.Parameters.AddWithValue("@CedulaFx", vendedor.Cedula);
            mySqlCommand.Parameters.AddWithValue("@NombreFx", vendedor.Nombre);
            mySqlCommand.Parameters.AddWithValue("@SexoFx", vendedor.Sexo);
            mySqlCommand.Parameters.AddWithValue("@TelefonoFx", vendedor.Telefono);
            mySqlCommand.Parameters.AddWithValue("@TelefonoFx", vendedor.Sueldo);
            mySqlCommand.Parameters.AddWithValue("@CorreoFx", vendedor.CredencialUsuario.Correo);
            mySqlCommand.Parameters.AddWithValue("@ContrasenaFx", vendedor.CredencialUsuario.Contrasena);
            mySqlCommand.Parameters.AddWithValue("@Foreking_RolesUsuarioFx",vendedor.CredencialUsuario.Rol);
            try
            {
                conexion.conectar();
                mySqlCommand.Connection = conexion.Connection;
                mySqlCommand.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se encontro la base de datos" + ex.ToString());
            }
            conexion.cerrar();
        }



    }
}
