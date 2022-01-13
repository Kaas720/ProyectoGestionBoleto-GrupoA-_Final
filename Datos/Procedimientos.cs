using EntidadesDelProyecto;
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
        public bool IniciasSeccion(string usuario, string password,int rol)
        {
            bool bandera = false;
            string nom=null;
            try
            {
                MySqlCommand mySqlCommand = ConectarProcedimiento("ProcesoInicioSeccion");
                mySqlCommand.Parameters.AddWithValue("@usuarioFx",usuario);
                mySqlCommand.Parameters.AddWithValue("@contrasenaFx", password);
                mySqlCommand.Parameters.AddWithValue("@rolUsuario", rol);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    nom = lector.GetString(1);
                }
                con.cerrar(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            if (!String.IsNullOrEmpty(nom))
            {
                bandera= true;
            }
            return bandera;
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
                MessageBox.Show(ex.ToString());

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
                MessageBox.Show(ex.ToString()+"ERRRORRR");

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
                con.cerrar();
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
                con.cerrar();
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
