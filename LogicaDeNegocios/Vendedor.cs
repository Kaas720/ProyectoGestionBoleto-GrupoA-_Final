using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
   public class Vendedor: Persona
    {
        private int idTipoUsuario;
        private double sueldo;
        CredencialUsuario credencialUsuario;

        public Vendedor(string cedula, string nombre, string sexo, string telefono, int idTipoUsuario, double sueldo, CredencialUsuario credencialUsuario)
            :base(cedula, nombre, sexo, telefono)
        {
            this.idTipoUsuario = 3;
            this.sueldo = sueldo;
            this.credencialUsuario = credencialUsuario;
        }

        public int IdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public CredencialUsuario CredencialUsuario { get => credencialUsuario; set => credencialUsuario = value; }
    
    
    
    
    
    }
}
