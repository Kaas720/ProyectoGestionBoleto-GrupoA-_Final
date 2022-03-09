using Datos;
using Guna.UI2.WinForms;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public class AdmReporte
    {
        public void LlenarDatagridReporte(Guna2DataGridView dataGridReporte, int idConsulta,string dato)
        {
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            string consulta = "";
            switch (idConsulta)
            {
                case 1:  consulta = "BuscarReporteFecha";  break;
                case 2:  consulta = "BuscarReporteCooperativa"; break;
                case 3: consulta = "BuscarReporteCedula"; break;
                default: consulta = "BuscarReporte"; break;
            }
            try
            {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento(consulta, con.conectar());
                    mySqlCommand.Parameters.AddWithValue("@Dato", dato);
                    MySqlDataReader lector = mySqlCommand.ExecuteReader();
                    while (lector.Read())
                    {
                        int numerofila = dataGridReporte.Rows.Count;
                        dataGridReporte.Rows.Add(1);
                        dataGridReporte.Rows[numerofila].Cells[0].Value = lector["nombreCooperativa"].ToString();
                        dataGridReporte.Rows[numerofila].Cells[1].Value = lector["HoraSalida"].ToString();
                        dataGridReporte.Rows[numerofila].Cells[2].Value = lector["FechaSalida"].ToString();
                        dataGridReporte.Rows[numerofila].Cells[3].Value = lector["Precio"].ToString();
                }
                con.cerrar();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
