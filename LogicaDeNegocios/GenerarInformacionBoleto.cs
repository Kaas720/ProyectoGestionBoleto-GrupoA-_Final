using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    // Se crea la clase  GenerarInformacionBoleto
    public class GenerarInformacionBoleto
    {
        // Atributos
        int busId;
        string lugarSalida;
        string fechaSalida;
        string lugardestino;
        string horaSalida;
        string cooperativa;
        string numerodico;
        string precio;

        // se crea el constructor parametrizado
        public GenerarInformacionBoleto(int busId, string lugarSalida, string fechaSalida, string lugardestino, string horaSalida, string cooperativa, string numerodico, string precio)
        {
            this.busId = busId;
            this.lugarSalida = lugarSalida;
            this.fechaSalida = fechaSalida;
            this.lugardestino = lugardestino;
            this.horaSalida = horaSalida;
            this.cooperativa = cooperativa;
            this.numerodico = numerodico;
            this.precio = precio;
        }

        // Se crean los metodos getters y setters
        public string LugarSalida { get => lugarSalida; set => lugarSalida = value; }
        public string FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public string Lugardestino { get => lugardestino; set => lugardestino = value; }
        public string HoraSalida { get => horaSalida; set => horaSalida = value; }
        public string Cooperativa { get => cooperativa; set => cooperativa = value; }
        public string Numerodico { get => numerodico; set => numerodico = value; }
        public string Precio { get => precio; set => precio = value; }
        public int BusId { get => busId; set => busId = value; }
    }
}
