using System;
using System.Collections.Generic;

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
