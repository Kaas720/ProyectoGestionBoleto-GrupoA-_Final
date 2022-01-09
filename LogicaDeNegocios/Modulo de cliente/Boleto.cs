using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Modulo_de_cliente
{
    public class Boleto
    {
        private string lugarOrigen;
        private string lugarDestino;
        private DateTime fechaSalida;
        private DateTime horaSalida;
        private DateTime fechaEmision;
        private int cantidadBoleto;
        private double precio;
        private double impuesto;

        public Boleto() { }
        public Boleto(string lugarOrigen, string lugarDestino, DateTime fechaSalida, DateTime horaSalida, DateTime fechaEmision, int cantidadBoleto, double precio, double impuesto)
        {
            this.lugarOrigen = lugarOrigen;
            this.lugarDestino = lugarDestino;
            this.fechaSalida = fechaSalida;
            this.horaSalida = horaSalida;
            this.fechaEmision = fechaEmision;
            this.cantidadBoleto = cantidadBoleto;
            this.precio = precio;
            this.impuesto = impuesto;
        }

        public string LugarOrigen { get => lugarOrigen; set => lugarOrigen = value; }
        public string LugarDestino { get => lugarDestino; set => lugarDestino = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public DateTime HoraSalida { get => horaSalida; set => horaSalida = value; }
        public DateTime HoraSalida1 { get => horaSalida; set => horaSalida = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public int CantidadBoleto { get => cantidadBoleto; set => cantidadBoleto = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Impuesto { get => impuesto; set => impuesto = value; }

        public override string ToString() {
            return "lugarSalida: " + lugarOrigen + "lugarDestino: " + lugarDestino + "fechaSalida: " + fechaSalida + "horaSalida" + horaSalida + "fechaEmision: " + fechaEmision +
            "cantidadBoleto: " + cantidadBoleto + "precio: " + precio + "impuesto: " + impuesto;
        }
        public double valorTotal(double total)
        {
          
            string ventaCaja = "caja", compra = "";
            if (compra == ventaCaja)
            {
                total = cantidadBoleto * (precio + impuesto);
            }
            else
            {
                total= precio * cantidadBoleto;
            }
            return total;
        }
    }
}
  
