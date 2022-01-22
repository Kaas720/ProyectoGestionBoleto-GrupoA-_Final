using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Modulo_de_cooperativa
{
   public  class Cooperativa
    {
        private string nombreCooperativa;
        private string nombrePropietario;
        private string ruc;
        private string usuario;
        private string contraseña;

        public Cooperativa(){ }

        public string NombreCooperativa { get => nombreCooperativa; set => nombreCooperativa = value; }
        public string NombrePropietario { get => nombrePropietario; set => nombrePropietario = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }


    }
}
