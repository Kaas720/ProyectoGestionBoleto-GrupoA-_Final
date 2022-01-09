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
        public void Login(string usuario, string password)
        {
            if (procedimientos.IniciasSeccion(usuario, password))
            {
                Console.WriteLine("VIVAHP");

            }
            else
            {
                Console.WriteLine("IGUALMENTEHP");
            }
        }
    }
}
