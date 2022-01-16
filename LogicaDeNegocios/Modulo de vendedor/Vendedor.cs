using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Modulo_de_vendedor
{
    public class Vendedor: Usuarios
    {
        private string usuario;
        private string contraseña;
        private double sueldo;

        public Vendedor() { }
        public Vendedor(string usuario, string contraseña, double sueldo)
            //:base(cedula, nombre, sexo, telefono, correo, ciudad, usuario, contraseña)
        {
            this.sueldo = sueldo;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public override string ToString()
        {
            return base.ToString() + "Sueldo: " + sueldo + usuario + contraseña;
        }
    }
}
