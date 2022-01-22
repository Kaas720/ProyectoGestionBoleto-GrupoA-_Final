using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
  public class Boleto
    {
        int busId;
        private string lugarSalida;
        private string lugarDestino;
        private string fechaSalida;
        private string horaSalida;
        private string fechaEmision;
        private int cantidadBoleto;
        private double precio;
        private double impuesto;

        public Boleto() { }
        public Boleto(int busId, string lugarDestino, string lugarSalida, string fechaSalida, string horaSalida, string fechaEmision, int cantidadBoleto, double precio, double impuesto)
        {
            this.busId = busId;
            this.lugarSalida = lugarSalida;
            this.lugarDestino = lugarDestino;
            this.fechaSalida = fechaSalida;
            this.horaSalida = horaSalida;
            this.fechaEmision = fechaEmision;
            this.cantidadBoleto = cantidadBoleto;
            this.precio = precio;
            this.impuesto = impuesto;
        }

        public int BusId { get => busId; set => busId = value; }
        public string LugarOrigen { get => lugarSalida; set => lugarSalida = value; }
        public string LugarDestino { get => lugarDestino; set => lugarDestino = value; }
        public String FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public String HoraSalida { get => horaSalida; set => horaSalida = value; }
        public String FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public int CantidadBoleto { get => cantidadBoleto; set => cantidadBoleto = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Impuesto { get => impuesto; set => impuesto = value; }

        public override string ToString()
        {
            return "lugarSalida: " + lugarSalida + "lugarDestino: " + lugarDestino + "fechaSalida: " + fechaSalida + "horaSalida" + horaSalida + "fechaEmision: " + fechaEmision +
            "cantidadBoleto: " + cantidadBoleto + "precio: " + precio + "impuesto: " + impuesto;
        }

        //public string Guardar()
        //{

        //}
    }
}
