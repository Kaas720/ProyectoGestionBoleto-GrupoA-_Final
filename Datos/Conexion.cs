using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace Datos.Coneccion
{
    public class Conexion
    {
        private static string conexionDB = "server=localhost;user id=root;password=admin;database=sga";
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
