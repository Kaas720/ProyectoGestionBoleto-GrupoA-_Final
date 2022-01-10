using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Modula_Venta
{
    public class Ruta
    {
        string lugarOrigen;
        string lugarDestino;
        DateTime horarioDisponible;
        string cooperativa;

        public Ruta(string lugarOrigen, string lugarDestino, DateTime horarioDisponible, string cooperativa)
        {
            this.lugarOrigen = lugarOrigen;
            this.lugarDestino = lugarDestino;
            this.horarioDisponible = horarioDisponible;
            this.cooperativa = cooperativa;
        }

        public string LugarOrigen { get => lugarOrigen; set => lugarOrigen = value; }
        public string LugarDestino { get => lugarDestino; set => lugarDestino = value; }
        public DateTime HorarioDisponible { get => horarioDisponible; set => horarioDisponible = value; }
        public string Cooperativa { get => cooperativa; set => cooperativa = value; }
    }
}
