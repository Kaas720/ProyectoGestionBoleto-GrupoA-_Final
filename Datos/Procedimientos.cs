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
        public bool IniciasSeccion(string usuario, string password,int rol)
        {
            string nom=null;
            MySqlCommand mySqlCommand;
            Conexion con = new Conexion();
            try
            {
                mySqlCommand = new MySqlCommand("ProcesoInicioSeccion", con.conectar());
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("@usuarioFx",usuario);
                mySqlCommand.Parameters.AddWithValue("@contrasenaFx", password);
                mySqlCommand.Parameters.AddWithValue("@rolUsuario", rol);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    nom = lector.GetString(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            if (String.IsNullOrEmpty(nom))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
