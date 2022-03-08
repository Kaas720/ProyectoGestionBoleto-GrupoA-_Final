// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="ProcedimientosPaginaprincipal.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
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
    /// <summary>
    /// Class ProcedimientosPaginaprincipal.
    /// </summary>
    public class ProcedimientosPaginaprincipal
    {
        /// <summary>
        /// The con
        /// </summary>
        Conexion con = new Conexion();
        private static string cedula = "";

        public static string getCedula()
        {
            return cedula;
        }

        public static void setCedula(string cedulas)
        {
            cedula = cedulas;
        }

        /// <summary>
        /// Iniciases the seccion.
        /// </summary>
        /// <param name="correo">The correo.</param>
        /// <param name="password">The password.</param>
        /// <returns>List&lt;System.Int32&gt;.</returns>
        public List<int> IniciasSeccion(string correo, string password)
        {
            List<int> IdPeronsaAndRol = new List<int>();
            List<string> IdCedula = new List<string>();
            try
            {
                MySqlCommand mySqlCommand = ConectarProcedimiento("sspl_ProcesoInicioSeccion");
                mySqlCommand.Parameters.AddWithValue("@CorreoFx", correo);
                mySqlCommand.Parameters.AddWithValue("@contrasenaFx", password);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    int x = Convert.ToInt32(lector["Foreking_RolesUsuario"]);
                    IdPeronsaAndRol.Add(Convert.ToInt32(lector["Foreking_RolesUsuario"]));
                    if (x == 1 || x==3)
                    {
                        IdPeronsaAndRol.Add(Convert.ToInt32(lector["idPersona"]));
                    }
                    else
                    {
                        IdCedula.Add(Convert.ToString(lector["Cedula"]));
                        setCedula(IdCedula[0]);
                    }                  
                }
                con.cerrar(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error intentolo mas tarde" + ex);

            }          
            return IdPeronsaAndRol;
        }

        /// <summary>
        /// Buscars the numeros asientos.
        /// </summary>
        /// <param name="busId">The bus identifier.</param>
        /// <returns>List&lt;System.String&gt;.</returns>
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

        /// <summary>
        /// Buscars the boleto.
        /// </summary>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="fechasalida">The fechasalida.</param>
        /// <param name="horasalida">The horasalida.</param>
        /// <returns>List&lt;GenerarInformacionBoleto&gt;.</returns>
        public List<Ruta> BuscarBoleto(string cooperativa, string fechasalida, string horasalida)
        {
            List<Ruta> newlist = new List<Ruta>();
            Ruta generarInformacionBoleto = null;
            try
            {
                MySqlCommand mySqlCommand = ConectarProcedimiento("LlenarVentanaCompra");
                mySqlCommand.Parameters.AddWithValue("@cooperativaFX", cooperativa);
                mySqlCommand.Parameters.AddWithValue("@horaSalidaFX", fechasalida);
                mySqlCommand.Parameters.AddWithValue("@fechaSalidaFX", Convert.ToDateTime(horasalida));
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {               
                    generarInformacionBoleto = new Ruta(
                    Convert.ToInt32(lector["Idbus"].ToString()),lector["salida"].ToString(), lector["destino"].ToString(),
                    lector["nombreCooperativa"].ToString(), lector["Asiento"].ToString(), lector["Disco"].ToString(), lector["Precio"].ToString(), lector["HoraSalida"].ToString(), lector["FechaSalida"].ToString()
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

        /// <summary>
        /// Cargars the cooperativa.
        /// </summary>
        /// <param name="origen">The origen.</param>
        /// <param name="destino">The destino.</param>
        /// <returns>List&lt;System.String&gt;.</returns>
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

        /// <summary>
        /// Lllenars the data grid.
        /// </summary>
        /// <param name="origen">The origen.</param>
        /// <param name="destino">The destino.</param>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="dataGridInf">The data grid inf.</param>
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
        /// <summary>
        /// Cargars the ciudad.
        /// </summary>
        /// <returns>List&lt;System.String&gt;.</returns>
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

        /// <summary>
        /// Conectars the procedimiento.
        /// </summary>
        /// <param name="Procedimientos">The procedimientos.</param>
        /// <returns>MySqlCommand.</returns>
        private MySqlCommand ConectarProcedimiento(string Procedimientos)
        {
            MySqlCommand mySqlCommand;
            mySqlCommand = new MySqlCommand(Procedimientos, con.conectar());
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            return mySqlCommand;
        }

    }
}
