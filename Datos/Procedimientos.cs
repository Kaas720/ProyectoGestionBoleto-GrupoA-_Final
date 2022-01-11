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
