using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public class GeneralExcepcion:Exception
    {
        String message;
        public GeneralExcepcion(String message) : base(message)
        {
            this.message = "Hola";
            Console.WriteLine(this.message);
        }
    }
}
