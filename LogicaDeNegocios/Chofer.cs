using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
   public class Chofer:Persona
    {
        private string licencia;
        private double sueldo;
        private CredencialUsuario credencialUsuario;

        public Chofer() { }
        public Chofer(string cedula, string nombre, string sexo, string telefono, string licencia, double sueldo, CredencialUsuario credencialUsuario)
            :base(cedula, nombre, sexo, telefono)
        {
            this.licencia = licencia;
            this.sueldo = sueldo;
            this.credencialUsuario = credencialUsuario;
        }

        public string Licencia { get => licencia; set => licencia = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public CredencialUsuario CredencialUsuario { get => credencialUsuario; set => credencialUsuario = value; }


        public void InsertarChofer(Chofer chofer)
        {
            // Se llama a la clase conexion para hacer la conexion con la base de dados
            Conexion con = new Conexion();
            // Se llama a la clase  ConectorDeProcedimientos y se crea el objeto conector que permite realizar el procedimiento de inserta un nuevo cliente
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try
            {
                List<Chofer> ListaNueva = new List<Chofer>();
                ListaNueva.Add(chofer);
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_insertarChofer", con.conectar());
                foreach (Chofer Chofer in ListaNueva)
                {
                    mySqlCommand.Parameters.AddWithValue("@CedulaFx", Chofer.Cedula);
                    mySqlCommand.Parameters.AddWithValue("@NombreFx", Chofer.Nombre);
                    mySqlCommand.Parameters.AddWithValue("@SexoFx", Chofer.Sexo);
                    mySqlCommand.Parameters.AddWithValue("@TelefonoFx", Chofer.Telefono);
                    mySqlCommand.Parameters.AddWithValue("@TelefonoFx", Chofer.Licencia);
                    mySqlCommand.Parameters.AddWithValue("@SueldoFx", Chofer.Sueldo);
                    mySqlCommand.Parameters.AddWithValue("@CorreoFx", Chofer.CredencialUsuario.Correo);
                    mySqlCommand.Parameters.AddWithValue("@ContrasenaFx", Chofer.CredencialUsuario.Contrasena);
                    mySqlCommand.Parameters.AddWithValue("@Foreking_RolesUsuarioFx", Chofer.CredencialUsuario.Rol);

                }
                mySqlCommand.ExecuteReader();
                con.cerrar();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex);
            }

        }
    }
}
