using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
   public class AdmVendedor
    {
        public bool RegistrarVendedor(Vendedor vendedor)
        {
            Vendedor registrar = vendedor;
            registrar.InsertarVendedor(registrar);
            return true;
        }
    }
}
