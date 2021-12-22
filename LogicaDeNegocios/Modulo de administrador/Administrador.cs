using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Modulo_de_cliente
{
   public class Administrador:Persona
    {
        private int idAdministrador;
        private string sueldo;

        public Administrador(int idAdministrador, string cedula, string nombre, string sexo, string telefono, string correo, string ciudad, string usuario, string contraseña, string sueldo)
         :base(cedula, nombre, sexo, telefono, correo, ciudad, usuario, contraseña)
        {
            this.idAdministrador = idAdministrador;
            this.sueldo = sueldo;
        }

        public string Sueldo { get => sueldo; set => sueldo = value; }
        public int IdAdministrador { get => idAdministrador; set => idAdministrador = value; }

        public override string ToString()
        {
            return idAdministrador + base.ToString() + "Sueldo: " + sueldo;
        }
    }
}
