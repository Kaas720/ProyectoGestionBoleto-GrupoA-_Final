using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
    public class ProcedimientosPaginaprincipal
    {
        Conexion con = new Conexion();
        public int IniciasSeccion(string correo, string password)
        {
            int rol = 0;
            try
            {
                MySqlCommand mySqlCommand = ConectarProcedimiento("ProcesoInicioSeccion");
                mySqlCommand.Parameters.AddWithValue("@CorreoFx", correo);
                mySqlCommand.Parameters.AddWithValue("@contrasenaFx", password);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    rol = Convert.ToInt32(lector["Foreking_RolesUsuario"]);
                }
                con.cerrar(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error intentolo mas tarde" + ex);

            }
            return rol;
        }

        public List<string> BuscarNumerosAsientos(int busId)
        {
            List<string> asientos = new List<string>();
            try
            {
                MySqlCommand mySqlCommand = ConectarProcedimiento("BuscarAsientos");
                mySqlCommand.Parameters.AddWithValue("@idBus", busId);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    asientos.Add(lector["DescripcionBus"].ToString());
                }
                con.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error intentolo mas tarde" + ex);

            }
            return asientos;
        }

        public List<GenerarInformacionBoleto> BuscarBoleto(string cooperativa, string fechasalida, string horasalida)
        {
            List<GenerarInformacionBoleto> newlist = new List<GenerarInformacionBoleto>();
            GenerarInformacionBoleto generarInformacionBoleto = null;
            try
            {
                MySqlCommand mySqlCommand = ConectarProcedimiento("LlenarVentanaCompra");
                mySqlCommand.Parameters.AddWithValue("@cooperativaFX", cooperativa);
                mySqlCommand.Parameters.AddWithValue("@horaSalidaFX", fechasalida);
                mySqlCommand.Parameters.AddWithValue("@fechaSalidaFX", Convert.ToDateTime(horasalida));
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {               
                    generarInformacionBoleto = new GenerarInformacionBoleto(
                    Convert.ToInt32(lector["Idbus"].ToString()),lector["salida"].ToString(), lector["FechaSalida"].ToString(),
                    lector["destino"].ToString(), lector["HoraSalida"].ToString(),
                    lector["nombreCooperativa"].ToString(), lector["Disco"].ToString(), lector["Precio"].ToString()
                    );
                    newlist.Add(generarInformacionBoleto);
                }
                con.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error intentolo mas tarde" + ex);

            }
            return newlist;
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
                con.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error intentolo mas tarde" + ex);

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
                    dataGridInf.Rows[numerofila].Cells[4].Value = "Seleccionar...";
                }
                con.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error intentolo mas tarde" + ex);
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
                con.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error intentolo mas tarde"+ex);

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
