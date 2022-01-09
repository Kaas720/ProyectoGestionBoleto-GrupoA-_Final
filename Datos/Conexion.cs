using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        private static string conexionDB = "Server=MYSQL5045.site4now.net;Database=db_a7eb45_sga;Uid=a7eb45_sga;Pwd=1234emelec";
            //"user id=a7eb45_sga;server=MYSQL5045.site4now.net;database=db_a7eb45_sga";
            
        private MySqlConnection conection = null;
        public MySqlConnection Conection { get => this.conection; set => this.conection = value; }
        /**/
        public string Conectar()
        {
            try
            {
                conection = new MySqlConnection();
                Conection.ConnectionString  = conexionDB;
                Conection.Open();
                return "1";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return "0";
            }
            
        }
        public string Cerrar()
        {
            try
            {
                Conection.Close();
                return "1";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return "0";
            }
           
        }
    }
}
