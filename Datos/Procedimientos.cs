﻿using MySqlConnector;
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
        public bool IniciasSeccion(string usuario, string password, int rol)
        {
            bool bandera = false;
            string nom = null;
            try
            {
                MySqlCommand mySqlCommand = ConectarProcedimiento("ProcesoInicioSeccion");
                mySqlCommand.Parameters.AddWithValue("@usuarioFx", usuario);
                mySqlCommand.Parameters.AddWithValue("@contrasenaFx", password);
                mySqlCommand.Parameters.AddWithValue("@rolUsuario", rol);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    nom = lector.GetString(1);
                }
                con.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            if (!String.IsNullOrEmpty(nom))
            {
                bandera = true;
            }
            return bandera;
        }

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


        public List<string> CargarCooperativa(string origen, string destino)
        {
            List<string> cooperativa = new List<string>();
            try
            {
                MySqlCommand mySqlCommand = ConectarProcedimiento("ProcesoBuscarCooperativa");
                mySqlCommand.Parameters.AddWithValue("@SalidaFx", origen);
                mySqlCommand.Parameters.AddWithValue("@SestinoFX", destino);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    cooperativa.Add(lector["nombreCooperativa"].ToString());
                }
                con.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            return cooperativa;
        }

        public void LllenarDataGrid(string origen, string destino, string cooperativa, DataGridView dataGridInf)
        {
            try
            {
                MySqlCommand mySqlCommand = ConectarProcedimiento("ProcesoLlenarDataGrid");
                mySqlCommand.Parameters.AddWithValue("@SalidaFx", origen);
                mySqlCommand.Parameters.AddWithValue("@DestinoFX", destino);
                mySqlCommand.Parameters.AddWithValue("@CooperativaFX", cooperativa);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    int numerofila = dataGridInf.Rows.Count;
                    dataGridInf.Rows.Add(1);
                    dataGridInf.Rows[numerofila].Cells[0].Value = lector["nombreCooperativa"].ToString();
                    dataGridInf.Rows[numerofila].Cells[1].Value = lector["HoraSalida"].ToString();
                    dataGridInf.Rows[numerofila].Cells[2].Value = lector["FechaSalida"].ToString();
                    dataGridInf.Rows[numerofila].Cells[3].Value = lector["Precio"].ToString();
                }
                con.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public List<string> CargarCiudad()
        {
            List<string> ciudad = new List<string>();
            try
            {
                MySqlCommand mySqlCommand = ConectarProcedimiento("ProcesoBusquedaCiudad");
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    ciudad.Add(lector["DescripcionCiudad"].ToString());
                }
                con.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            return ciudad;
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