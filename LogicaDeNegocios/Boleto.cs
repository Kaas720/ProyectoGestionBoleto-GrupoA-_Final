using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
   public class Boleto
    {
        private DateTime fechaSalida;
        private DateTime fechaEmision;
        private string horaSalida;

        public Boleto(DateTime fechaSalida, DateTime fechaEmision, string horaSalida)
        {
            this.fechaSalida = fechaSalida;
            this.fechaEmision = fechaEmision;
            this.horaSalida = horaSalida;
        }

        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public string HoraSalida { get => horaSalida; set => horaSalida = value; }
    }
}
