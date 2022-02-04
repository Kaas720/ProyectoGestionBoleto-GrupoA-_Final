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


    }
}
