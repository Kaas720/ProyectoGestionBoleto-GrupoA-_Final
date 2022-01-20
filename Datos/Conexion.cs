﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Datos
{
    public class Conexion
    {

        private static string conexion_DB_externa = "Server=MYSQL5045.site4now.net;Database=db_a7eb45_sga;Uid=a7eb45_sga;Pwd=1234emelec";

        private MySqlConnection sqlconnection = null;
        //metodo get y set
        public MySqlConnection Connection { get => sqlconnection; set => sqlconnection = value; }

        //metodo para conectar con la base de datos
        public MySqlConnection conectar()
        {
            try
            {
                Connection = new MySqlConnection();
                Connection.ConnectionString = conexion_DB_externa;
                Connection.Open();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
               
            }
            return Connection;
        }
        // metodo para cerrar la conexion
        public void cerrar()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString());
            }
        }


    }
}
