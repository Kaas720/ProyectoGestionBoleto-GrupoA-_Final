using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Modulo_de_cliente
{
    public class Bus
    {
        private int numAsiento;
        private int disco;

        public Bus() { }

        public int NumAsiento { get => numAsiento; set => numAsiento = value; }
        public int Disco { get => disco; set => disco = value; }
    }
}
