using LogicaDeNegocios.Procedimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public class RegistroClienteProcedimiento
    {

       
        public void RegistrarCliente(Cliente cliente)
        {
            Cliente clienteregistrar = cliente;
            clienteregistrar.InsertarCliente(clienteregistrar);
        }
    }
}
