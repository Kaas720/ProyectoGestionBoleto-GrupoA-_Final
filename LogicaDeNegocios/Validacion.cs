using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
     // se crea la clase validacion
    public class Validacion
    {
        // Se crea el metodo ValidarCedula para que los numeros de cedula sean igual a 10 digitos
        public bool ValidarCedula(string cedula)
        {
            bool x = true;
            if (cedula.Length != 10)
            {
                x = false;
            }
            return x;
        }

        // Se crea el metodo ValidarTelefono para que el numero de telefono para que permita solo ingresar 10 digitos
        public bool ValidarTelefono(string telefono)
        {
            bool campo = true;
            if (telefono.Length != 10)
            {
                campo = false;
            }
            return campo;
        }

        // Se crea el metodo validarEmail
        public bool validarEmail(string email)
        {
            if (email == null)
            {
                return false;
            }
            if (new EmailAddressAttribute().IsValid(email) )
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        public bool ValidarSueldo(string sueldo)
        {
            bool bandera = true;
            double valor = 0.0;
            try
            {
                valor = Double.Parse(sueldo);
                
            }catch(FormatException ex)
            {
                bandera = false;
                MessageBox.Show(ex.Message); 
            }
            return bandera;
        }
    }
}
