// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="ConsultaProcedimientosGenerarBoleto.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
    /// <summary>
    /// Class ConsultaProcedimientosGenerarBoleto.
    /// </summary>
    public class ConsultaProcedimientosGenerarBoleto
    {
        // Se llama al clase  ProcedimientosPaginaprincipal y se crea el objeto procedimientos para llamar a los metodos que contiene
        /// <summary>
        /// The procedimientos
        /// </summary>
        ProcedimientosPaginaprincipal procedimientos = new ProcedimientosPaginaprincipal();

        // Se crea una lista GenerarInformacionBoleto llamada  generarInformacionBoleto llamando al metodo BuscarBoleto
        /// <summary>
        /// Generars the informacion boleto.
        /// </summary>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="fechasalida">The fechasalida.</param>
        /// <param name="horasalida">The horasalida.</param>
        /// <returns>List&lt;GenerarInformacionBoleto&gt;.</returns>
        public List<Ruta> generarInformacionBoleto(string cooperativa, string fechasalida, string horasalida)
        {
            List<Ruta> ListaBoletosGenerados = new List<Ruta>();
            ListaBoletosGenerados = procedimientos.BuscarBoleto(cooperativa, fechasalida, horasalida);   
            return ListaBoletosGenerados;
        }

        // Se crea el metodo llamado LlenarComboAsientos para obtener el numero de asientos de un bus en particular
        /// <summary>
        /// Llenars the combo asientos.
        /// </summary>
        /// <param name="busId">The bus identifier.</param>
        /// <param name="cbNumeroAsientos">The cb numero asientos.</param>
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
