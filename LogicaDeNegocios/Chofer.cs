using System;

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


    }
}
