using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
    public class ConsultaProcedimientosGenerarBoleto
    {
        // Se llama al clase  ProcedimientosPaginaprincipal y se crea el objeto procedimientos para llamar a los metodos que contiene
        ProcedimientosPaginaprincipal procedimientos = new ProcedimientosPaginaprincipal();

        // Se crea una lista GenerarInformacionBoleto llamada  generarInformacionBoleto llamando al metodo BuscarBoleto
        public List<GenerarInformacionBoleto> generarInformacionBoleto(string cooperativa, string fechasalida, string horasalida)
        {
            List<GenerarInformacionBoleto> ListaBoletosGenerados = new List<GenerarInformacionBoleto>();
            ListaBoletosGenerados = procedimientos.BuscarBoleto(cooperativa, fechasalida, horasalida);   
            return ListaBoletosGenerados;
        }

        // Se crea el metodo llamado LlenarComboAsientos para obtener el numero de asientos de un bus en particular
        public void LlenarComboAsientos(int busId, ComboBox cbNumeroAsientos)
        {
            // Se crea una lista string llamada  NumeroAsiento en la que se almacenara los numeros de asientos de un bus en particular.
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
