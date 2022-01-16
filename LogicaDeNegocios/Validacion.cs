using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
    public class Validacion
    {
        public bool ValidarCedula(string cedula)
        {
            bool x = true;
            if (cedula.Length != 10)
            {
                x = false;
            }
            return x;
        }

    }
}
