using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public class CredencialUsuario : Persona
    {
        private string correo;
        private string contrasena;


        public CredencialUsuario(string cedula, string nombre, string sexo, string telefono, string correo, string contrasena) : base(cedula, nombre, sexo, telefono)
        {
            this.correo = correo;
            this.contrasena = contrasena;
        }

        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
    }
}
