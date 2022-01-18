using Datos;
using LogicaDeNegocios.Procedimientos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public class Cliente : CredencialUsuario
    {
        public Cliente(string cedula, string nombre, string sexo, string telefono, string correo, string contrasena) : base(cedula, nombre, sexo, telefono, correo, contrasena)
        {

        }
        public void InsertarCliente(Cliente client)
        {
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try
            {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("Procedimiento_insertar_cliente",con.conectar());
                List<Cliente> ListaNueva = new List<Cliente>();
                ListaNueva.Add(client);
                foreach (CredencialUsuario Cliente in ListaNueva)
                {
                    mySqlCommand.Parameters.AddWithValue("@Cedula", Cliente.Cedula);
                    mySqlCommand.Parameters.AddWithValue("@Nombre", Cliente.Nombre);
                    mySqlCommand.Parameters.AddWithValue("@Sexo", Cliente.Sexo);
                    mySqlCommand.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
                    mySqlCommand.Parameters.AddWithValue("@Correo", Cliente.Correo);
                    mySqlCommand.Parameters.AddWithValue("@Contraseña", Cliente.Contrasena);
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
