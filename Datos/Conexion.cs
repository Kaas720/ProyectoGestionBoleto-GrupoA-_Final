//using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using MySqlConnector;

namespace Datos
{
    public class Conexion
    {
        private static string conexion_DB_externa = "Server=MYSQL5045.site4now.net;Database=db_a7eb45_sga;Uid=a7eb45_sga;Pwd=1234emelec";
        private MySqlConnection conection = null;
        public MySqlConnection Connection { get => this.conection; set => this.conection = value; }
        /**/
        public MySqlConnection conectar()
        {
            try
            {
                Connection = new MySqlConnection();
                Connection.ConnectionString = conexion_DB_externa;
                Connection.Open();
              //  MessageBox.Show("Se conecto");
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }
            return Connection;
        }

        public string Cerrar()
        {
            string conection ="" ;
            try
            {
               Connection.Close();
              return  conection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return conection;
            }
           
        }
    }
}
