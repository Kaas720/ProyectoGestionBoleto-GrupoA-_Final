using System;

namespace LogicaDeNegocios
{
    public class Ruta
    {
        //Atributos
        string lugarOrigen;
        string lugarDestino;
        DateTime horarioDisponible;
        string cooperativa;

        //Construtor parametrizado
        public Ruta(string lugarOrigen, string lugarDestino, DateTime horarioDisponible, string cooperativa)
        {
            this.lugarOrigen = lugarOrigen;
            this.lugarDestino = lugarDestino;
            this.horarioDisponible = horarioDisponible;
            this.cooperativa = cooperativa;
        }

        // Metodos getters y setters
        public string LugarOrigen { get => lugarOrigen; set => lugarOrigen = value; }
        public string LugarDestino { get => lugarDestino; set => lugarDestino = value; }
        public DateTime HorarioDisponible { get => horarioDisponible; set => horarioDisponible = value; }
        public string Cooperativa { get => cooperativa; set => cooperativa = value; }
    }
}
