using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
   public class Persona
    {
        private string cedula;
        private string nombre;
        private string sexo;
        private string telefono;
        private string correo;
        private string ciudad;
        private string usuario;
        private string contraseña;

        public Persona(string cedula, string nombre, string sexo, string telefono, string correo, string ciudad, string usuario, string contraseña)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.sexo = sexo;
            this.telefono = telefono;
            this.ciudad = ciudad;
            this.correo = correo;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }

        public override string ToString()
        {
            return "Cedula: " + cedula + "Nombre: " + nombre + "Sexo: " + sexo + "Telefono: " + telefono + "Correo: " + correo + "Ciudad: " + ciudad + "Usuario: " + usuario +"Contraseña: "+ contraseña;

        }
        /* Lucio Johann*/
        public virtual string registrar() { return ""; }
    }
}
