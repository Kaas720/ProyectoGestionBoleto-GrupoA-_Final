
using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
    public class Cliente :Persona
    {
        Conexion conexion;
       Conector conector = new Conector();
        private string correo;
        private string contrasena;
        public Cliente() { }
        public Cliente(string cedula, string nombre, string sexo, string telefono, string correo, string contrasena) : base(cedula, nombre, sexo, telefono)
        {
            this.correo = correo;
            this.contrasena = contrasena;
        }

        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
    
    public override string ToString() {
         return base.ToString() + "Correo: " + correo + "Contraseña: " + contrasena;
     }

        public void InsertarCliente(Cliente cliente)
        {
            MySqlCommand mySqlCommand;
             conexion = new Conexion();
          
            mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandText = "Procedimiento_insertar_cliente";
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            mySqlCommand.Parameters.AddWithValue("@Cedula", cliente.Cedula);
            mySqlCommand.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            mySqlCommand.Parameters.AddWithValue("@Sexo", cliente.Sexo);
            mySqlCommand.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            mySqlCommand.Parameters.AddWithValue("@Correo", cliente.Correo);
            mySqlCommand.Parameters.AddWithValue("@Contraseña", cliente.Contrasena);
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
            conexion.Cerrar();
        }

    public List<Cliente> BuscarCliente(string cedula)
    {
            List<Cliente> lista = new List<Cliente>();
            Cliente client = null;
            try
            {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("BuscarCliente",conexion.conectar());
                mySqlCommand.Parameters.AddWithValue("@cedulaCliente", cedula);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    client = new Cliente();
                    client.Nombre = lector["Nombre"].ToString();
                    client.Sexo = lector["Sexo"].ToString();
                    client.Telefono = lector["Telefono"].ToString();
                    client.Correo = lector["Correo"].ToString();
                    client.Contrasena = lector["Contraseña"].ToString();
                    lista.Add(client);
                }
                conexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return lista;
    }


        public string ActualizarCliente(string cedula, string telefono, string correo, string contrasena)
        {
            string mensaje = "";

            try
            {
                MySqlCommand comando = conector.ConectarProcedimiento("ModificarCliente", conexion.conectar());
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Cedula1", cedula);
                comando.Parameters.AddWithValue("@Telefono1", telefono);
                comando.Parameters.AddWithValue("@Correo1", correo);
                comando.Parameters.AddWithValue("@Contraseña1", contrasena);
                comando.ExecuteNonQuery();
                conexion.Cerrar();
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
