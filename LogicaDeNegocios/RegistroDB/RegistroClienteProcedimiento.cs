using System.Windows.Forms;
using LogicaDeNegocios.Modulo_de_cliente;
using Datos;
using MySqlConnector;

namespace LogicaDeNegocios.RegistroDB
{
    public class RegistroClienteProcedimiento
    {
        Conexion conexion;
         public  RegistroClienteProcedimiento(){
         conexion = new Conexion(); }
        public void InsertarCliente(Cliente cliente)
        {
            MySqlCommand mySqlCommand;
            Conexion conexion = new Conexion();
                   
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
        }
}
