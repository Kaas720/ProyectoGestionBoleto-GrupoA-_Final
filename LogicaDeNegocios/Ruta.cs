using System;

namespace LogicaDeNegocios
{
    public class Ruta
    {
        //Atributos
        private string lugarOrigen;
        private string lugarDestino;
        private DateTime horarioDisponible;

        //Construtor parametrizado
        public Ruta(string lugarOrigen, string lugarDestino, DateTime horarioDisponible)
        {
            this.lugarOrigen = lugarOrigen;
            this.lugarDestino = lugarDestino;
            this.horarioDisponible = horarioDisponible;
        }

        // Metodos getters y setters
        public string LugarOrigen { get => lugarOrigen; set => lugarOrigen = value; }
        public string LugarDestino { get => lugarDestino; set => lugarDestino = value; }
        public DateTime HorarioDisponible { get => horarioDisponible; set => horarioDisponible = value; }
       
    }
}
