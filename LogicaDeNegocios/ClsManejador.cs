
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClsManejador
    {
        private MySqlConnection conexion;

        public  MySqlConnection abrir_conexion()
        {

            try
            {
                string ConnectionString = "server=localhost; database=sga; Uid=root; pwd=kevin1234;";
                conexion = new MySqlConnection(ConnectionString);
                conexion.Open();
                Console.WriteLine("Se abrio la conexion desde la capa de acceso a datos");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return conexion;
        }

        public  void cerrar_conexion(MySqlConnection conexion)
        {
            conexion.Close();
            Console.WriteLine("Se cerro la conexion desde la capa de acceso a datos");
        }




    }
}
