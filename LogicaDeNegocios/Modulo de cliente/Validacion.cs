
using System.Windows;

namespace LogicaDeNegocios.Modulo_de_cliente
{
    public class Validacion
    {
        public bool ValidarCedula(string cedula)
        {
            bool cadena = true;
            if (cedula.Length != 10)
            {
                cadena = false;
                MessageBox.Show("La cedula debe tener 10 digitos");
            }
            return cadena;
        }

        public bool EsVacioAc(string telefono, string ciudad, string usuario, string contrasena)
        {
            bool cadena = false;
            if (string.IsNullOrEmpty(telefono)||string.IsNullOrEmpty(ciudad))
            {
                cadena = true;
            }
            return cadena;
        }
    }
}
