// ***********************************************************************
// Assembly         : Datos
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Conexion.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using MySqlConnector;
using System;
using System.Windows.Forms;
namespace Datos
{
    /// <summary>
    /// Class Conexion.
    /// </summary>
    public class Conexion
    {

        /// <summary>
        /// The conexion database externa
        /// </summary>
        private static string conexion_DB_externa = "Server=MYSQL5040.site4now.net;Database=db_a83d0f_a7eb45;Uid=a83d0f_a7eb45;Pwd=1234emelec";

        /// <summary>
        /// The sqlconnection
        /// </summary>
        private MySqlConnection sqlconnection = null;

        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>The connection.</value>
        public MySqlConnection Connection { get => sqlconnection; set => sqlconnection = value; }

        //metodo para conectar con la base de datos

        /// <summary>
        /// Conectars this instance.
        /// </summary>
        /// <returns>MySqlConnection.</returns>
        public MySqlConnection conectar()
        {
            try
            {
                Connection = new MySqlConnection();
                Connection.ConnectionString = conexion_DB_externa;
                Connection.Open();
            }
            catch (MySqlException x)
            {
                MessageBox.Show(x.ToString());
               
            }
            return Connection;
        }
        // metodo para cerrar la conexion
        /// <summary>
        /// Cerrars this instance.
        /// </summary>
        public void cerrar()
        {
            try
            {
                Connection.Close();
            }
            catch (MySqlException x)
            {

                MessageBox.Show(x.ToString());
            }
        }


    }
}
