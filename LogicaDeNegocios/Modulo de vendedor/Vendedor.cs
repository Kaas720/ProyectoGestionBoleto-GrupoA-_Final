using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Modulo_de_vendedor
{
    public class Vendedor: Persona
    {
        private int idVendedor;
        private double sueldo;

        public Vendedor(int idVendedor, string cedula, string nombre, string sexo, string telefono, string correo, string ciudad, string usuario, string contraseña, double sueldo)
            :base(cedula, nombre, sexo, telefono, correo, ciudad, usuario, contraseña)
        {
            this.idVendedor = idVendedor;
            this.sueldo = sueldo;
        }

        public double Sueldo { get => sueldo; set => sueldo = value; }
        public int IdVendedor { get => idVendedor; set => idVendedor = value; }

        public override string ToString()
        {
            return idVendedor + base.ToString()+"Sueldo: " +sueldo;
        }
    }
}
