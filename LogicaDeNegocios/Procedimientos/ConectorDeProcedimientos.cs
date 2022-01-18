using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Procedimientos
{
     class ConectorDeProcedimientos
    {
        Conexion con = new Conexion();
        public MySqlCommand ConectarProcedimiento(string Procedimientos, MySqlConnection mySqlConnection)
        {
            MySqlCommand mySqlCommand;
            mySqlCommand = new MySqlCommand(Procedimientos, mySqlConnection);
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            return mySqlCommand;
        }
    }
}
