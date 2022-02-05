using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
 public class Bus
    {
        private string placa;
        private int numDisco;
        private int asiento;

        public Bus(string placa, int numDisco, int asiento)
        {
            this.placa = placa;
            this.numDisco = numDisco;
            this.asiento = asiento;
        }

        public string Placa { get => placa; set => placa = value; }
        public int NumDisco { get => numDisco; set => numDisco = value; }
        public int Asiento { get => asiento; set => asiento = value; }


    }
}
