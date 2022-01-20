using System;

namespace LogicaDeNegocios
{
    // Se crea la clase InformacionDerutaCooperativa
    public class InformacionDerutaCooperativa
    {
        string cooperativa;
        DateTime hora_salida;
        double precio;
     // Constructor parametrizado  
        public InformacionDerutaCooperativa(string cooperativa, DateTime hora_salida, double precio)
        {
            this.cooperativa = cooperativa;
            this.hora_salida = hora_salida;
            this.precio = precio;
        }

        // metodos getters y setters
        public string Cooperativa { get => cooperativa; set => cooperativa = value; }
        public DateTime Hora_salida { get => hora_salida; set => hora_salida = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
