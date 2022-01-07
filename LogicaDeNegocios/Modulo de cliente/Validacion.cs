using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LogicaDeNegocios.Modulo_de_cliente
{
    public class Validacion
    {
        public bool ValidarCedula(string cedula)
        {
            bool x = true;
            if (cedula.Length != 10)
            {
                x = false;
                MessageBox.Show("La cedula debe tener 10 digitos");
            }
            return x;
        }

        public bool EsVacioAc(string telefono, string ciudad)
        {
            bool x = false;
            if (string.IsNullOrEmpty(telefono)||string.IsNullOrEmpty(ciudad))
            {
                x = true;
            }
            return x;
        }
    }
}
