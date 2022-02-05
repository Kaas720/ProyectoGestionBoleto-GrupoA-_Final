using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
   public class AdmCooperativa
    {
        public bool RegistrarCooperativa(Cooperativa cooperativa)
        {
            Cooperativa registrar = cooperativa;
            registrar.InsertarCooperativa(registrar);
            return true;
        }
    }
}
