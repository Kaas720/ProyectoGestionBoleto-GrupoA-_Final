using EntidadesDelProyecto;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Procedimientos_Registrar
{
    
    public class RegistrarClienteProcesosBaseDatos
    {
        Conexion con = new Conexion();
        private MySqlCommand ConectarProcedimiento(string Procedimientos)
        {
            MySqlCommand mySqlCommand;
            mySqlCommand = new MySqlCommand(Procedimientos, con.conectar());
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            return mySqlCommand;
        }

        public void RegistroClientesEnProcedimientos(CredencialUsuario credencial)
        {
            try
            {
                MySqlCommand mySqlCommand = ConectarProcedimiento("Procedimiento_insertar_cliente");
                List<CredencialUsuario> ListaNueva = new List<CredencialUsuario>();
                ListaNueva.Add(credencial);
                foreach (CredencialUsuario Cliente in ListaNueva)
                {
                    mySqlCommand.Parameters.AddWithValue("@Cedula", Cliente.Cedula);
                    mySqlCommand.Parameters.AddWithValue("@Nombre", Cliente.Nombre);
                    mySqlCommand.Parameters.AddWithValue("@Sexo", Cliente.Sexo);
                    mySqlCommand.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
                    mySqlCommand.Parameters.AddWithValue("@Correo", Cliente.Correo);
                    mySqlCommand.Parameters.AddWithValue("@Contraseña", Cliente.Contrasena);
                    Console.WriteLine(Cliente.Cedula, Cliente.Nombre);
                }
                mySqlCommand.ExecuteReader();
                con.cerrar();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
