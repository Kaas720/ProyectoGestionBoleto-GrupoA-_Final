using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class Procedimientos
    {
        Conexion con = new Conexion();
        
        public List<string> BuscarCliente(string cedula)
        {
            List<string> Cliente = new List<string>();
            try
            {
                MySqlCommand mySqlCommand = ConectarProcedimiento("BuscarCliente");
                mySqlCommand.Parameters.AddWithValue("@cedulaCliente", cedula);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    Cliente.Add(lector["Nombre"].ToString());
                    Cliente.Add(lector["Sexo"].ToString());
                    Cliente.Add(lector["Telefono"].ToString());
                    Cliente.Add(lector["Correo"].ToString());
                    Cliente.Add(lector["Usuario"].ToString());
                }
                con.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }


            return Cliente;
        }

        public string ActualizarCliente(string cedula, string telefono, string correo, string usuario, string contrasena)
        {
            string mensaje = "";
            try
            {
                MySqlCommand comando = ConectarProcedimiento("ModificarCliente");
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Cedula1", cedula);
                comando.Parameters.AddWithValue("@Telefono1", telefono);
                comando.Parameters.AddWithValue("@Correo1", correo);
                comando.Parameters.AddWithValue("@Usuario1", usuario);
                comando.Parameters.AddWithValue("@Contraseña1", contrasena);
                comando.ExecuteNonQuery();
                con.Cerrar();
                mensaje = "Se actualizaron los campos correctamente";
            }
            catch(MySqlException ex)
            {

                mensaje = "Se ha producido un error al actualizar los datos"+ ex;
            }
            return mensaje;
        }

        private MySqlCommand ConectarProcedimiento(string Procedimientos)
        {
            MySqlCommand mySqlCommand;
            mySqlCommand = new MySqlCommand(Procedimientos, con.conectar());
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            return mySqlCommand;
        }

    }
}