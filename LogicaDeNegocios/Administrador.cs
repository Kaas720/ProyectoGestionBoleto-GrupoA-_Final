using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    public class Administrador: Persona
    {
        private string codigoAcceso;
        private double sueldo;
        private CredencialUsuario credencialUsuario;

        public Administrador(string cedula, string nombre, string sexo, string telefono, string codigoAcceso, double sueldo, CredencialUsuario credencialUsuario)
            :base(cedula, nombre, sexo, telefono)
        {
            this.codigoAcceso = codigoAcceso;
            this.sueldo = sueldo;
            this.credencialUsuario = credencialUsuario;
        }

        public string CodigoAcceso { get => codigoAcceso; set => codigoAcceso = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public CredencialUsuario CredencialUsuario { get => credencialUsuario; set => credencialUsuario = value; }


        public void InsertarAdministrador(Administrador admin)
        {
            // Se llama a la clase conexion para hacer la conexion con la base de dados
            Conexion con = new Conexion();
            // Se llama a la clase  ConectorDeProcedimientos y se crea el objeto conector que permite realizar el procedimiento de inserta un nuevo cliente
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try
            {
                List<Administrador> ListaNueva = new List<Administrador>();
                ListaNueva.Add(admin);
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_insertarAdministrador", con.conectar());
                foreach (Administrador Admin in ListaNueva)
                {
                    mySqlCommand.Parameters.AddWithValue("@CedulaFx", Admin.Cedula);
                    mySqlCommand.Parameters.AddWithValue("@NombreFx", Admin.Nombre);
                    mySqlCommand.Parameters.AddWithValue("@SexoFx", Admin.Sexo);
                    mySqlCommand.Parameters.AddWithValue("@TelefonoFx", Admin.Telefono);
                    mySqlCommand.Parameters.AddWithValue("@TelefonoFx", Admin.CodigoAcceso);
                    mySqlCommand.Parameters.AddWithValue("@SueldoFx", Admin.Sueldo);
                    mySqlCommand.Parameters.AddWithValue("@CorreoFx", Admin.CredencialUsuario.Correo);
                    mySqlCommand.Parameters.AddWithValue("@ContrasenaFx", Admin.CredencialUsuario.Contrasena);
                    mySqlCommand.Parameters.AddWithValue("@Foreking_RolesUsuarioFx", Admin.CredencialUsuario.Rol);

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
