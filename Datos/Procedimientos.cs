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
        public bool IniciasSeccion(string usuario, string password)
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
                mySqlCommand.Parameters.AddWithValue("@rolUsuario", 1);
                Console.WriteLine(usuario+"           m      "+password);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();

                while (lector.Read())
                {
                    nom = lector.GetString(1);
                }
                Console.WriteLine(nom);

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
