using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public class ControlExcepcion : Exception
    {
        String message;
        public ControlExcepcion(String message) : base(message)
        {
            Console.WriteLine(this.message);
        }
    }
}
