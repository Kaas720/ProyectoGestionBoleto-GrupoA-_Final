﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
    public class Validacion
    {
        public bool ValidarCedula(string cedula)
        {
            bool x = true;
            if (cedula.Length != 10)
            {
                x = false;
            }
            return x;
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

    }
}
