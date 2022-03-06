using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
   public class AdmPago
    {
        public double calcularTotalPagar(List<double> precio)
        {
            double totalPagar = 0;
            foreach(double p in precio)
            {
                totalPagar += p;
            }
            return totalPagar;
        }
     
    }
}
