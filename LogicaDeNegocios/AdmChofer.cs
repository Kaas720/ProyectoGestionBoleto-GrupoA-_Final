using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
  public class AdmChofer
    {
        public bool RegistrarChofer(Chofer chofer)
        {
            Chofer registrar = chofer;
            registrar.InsertarChofer(registrar);
            return true;
        }
    }
}
