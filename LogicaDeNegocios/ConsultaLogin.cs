using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public class ConsultaLogin
    {
        Procedimientos procedimientos = new Procedimientos();
        public bool Login(string usuario, string password, int rol)
        {
            bool bandera = false;
            if (procedimientos.IniciasSeccion(usuario, password, rol))
            {
                bandera = true;

            }
            return bandera;
        }
    }
}
