using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
   public class AdmAdministrador
    {
        public bool RegistrarAdministrador(Administrador admin)
        {
            Administrador registrar = admin;
            registrar.InsertarAdministrador(registrar);
            return true;
        }
    }
}
