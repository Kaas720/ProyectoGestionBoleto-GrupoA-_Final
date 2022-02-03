using Datos;
using LogicaDeNegocios.Procedimientos;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    // Se crea la clase cliente que hereda de la clase credencial
    public class Cliente : CredencialUsuario
    {
        public Cliente() { }
        // Se crea el constructor parametrizado y se invoca a base para hacer uso de la herencia
        public Cliente(string cedula, string nombre, string sexo, string telefono, string correo, string contrasena,int credencial) : base(cedula, nombre, sexo, telefono, correo, contrasena,credencial)
        {

        }
        // Se crea el metodo insertar cliente 
        public void InsertarCliente(Cliente client)
        {
            // Se llama a la clase conexion para hacer la conexion con la base de dados
            Conexion con = new Conexion();
            // Se llama a la clase  ConectorDeProcedimientos y se crea el objeto conector que permite realizar el procedimiento de inserta un nuevo cliente
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try
            {
                List<Cliente> ListaNueva = new List<Cliente>();
                ListaNueva.Add(client);
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("RegistroClienteGeneral", con.conectar());
                 foreach (CredencialUsuario Cliente in ListaNueva)
                 {
                    mySqlCommand.Parameters.AddWithValue("@CedulaFx", Cliente.Cedula);
                    mySqlCommand.Parameters.AddWithValue("@NombreFx", Cliente.Nombre);
                    mySqlCommand.Parameters.AddWithValue("@SexoFx", Cliente.Sexo);
                    mySqlCommand.Parameters.AddWithValue("@TelefonoFx", Cliente.Telefono);
                    mySqlCommand.Parameters.AddWithValue("@CorreoFx", Cliente.Correo);
                    mySqlCommand.Parameters.AddWithValue("@ContrasenaFx", Cliente.Contrasena);
                    mySqlCommand.Parameters.AddWithValue("@Foreking_RolesUsuarioFx", Cliente.Rol);
                }
                 mySqlCommand.ExecuteReader();
                 con.cerrar();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }
        public static Cliente ConsultarCliente(String cedula)
        {
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            Cliente client = null;
            try
            {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("ConsultarCliente", con.conectar());
                mySqlCommand.Parameters.AddWithValue("@CedulaFx", cedula);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    //client = new Cliente(lector["Cedula"].ToString(), lector["Nombre"].ToString(),"","", lector["Correo"].ToString(),""); 
                }
                con.cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error emitido por: "+ex);
            }
            return client;
        }
    }
}
