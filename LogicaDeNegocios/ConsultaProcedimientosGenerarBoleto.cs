using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
  public class ConsultaProcedimientosGenerarBoleto
    {
        Procedimientos procedimientos = new Procedimientos();
        public List<GenerarInformacionBoleto> generarInformacionBoleto(string cooperativa, string fechasalida, string horasalida)
        {
            List<GenerarInformacionBoleto> ListaBoletosGenerados = new List<GenerarInformacionBoleto>();
            ListaBoletosGenerados = procedimientos.BuscarBoleto(cooperativa, fechasalida, horasalida);
            return ListaBoletosGenerados;
        }

        public void LlenarComboAsientos(int busId, ComboBox cbNumeroAsientos)
        {
            List<string> NumeroAsiento = procedimientos.BuscarNumerosAsientos(busId);
            if (NumeroAsiento.Count != 0)
            {
                foreach (string asiento in NumeroAsiento)
                {
                    cbNumeroAsientos.Items.Add(asiento);
                }
            }

        }
    }
}
