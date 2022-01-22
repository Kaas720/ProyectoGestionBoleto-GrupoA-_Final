
using System.ComponentModel.DataAnnotations;
using System.Windows;

namespace LogicaDeNegocios
{
    public class Validacion
    {
        public bool ValidarCedula(string cedula)
        {
            bool cadena = true;
            if (cedula.Length != 10)
            {
                cadena = false;
            }
            return cadena;
        }
        public bool ValidarTelefono(string telefono)
        {
            bool campo = true;
            if (telefono.Length != 10)
            {
                campo = false;
            }
            return campo;
        }
        public bool validarEmail(string email)
        {
            if (email == null)
            {
                return false;
            }
            if (new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        public bool EsVacioAc(string telefono, string ciudad, string contrasena)
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
