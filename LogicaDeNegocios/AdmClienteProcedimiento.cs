using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    public class AdmClienteProcedimiento
    {
        // Se crea el metodo Registrar cliente para conectar con el procedimiento de insertarCliente
        public void RegistrarCliente(Cliente cliente)
        {
            Cliente clienteregistrar = cliente;
            clienteregistrar.InsertarCliente(clienteregistrar);
        }

        public Cliente ConsultarCliente(string cedula )
        {
            Cliente client = Cliente.ConsultarCliente(cedula);
            if (client==null)
            {
                throw new ControlExcepcion("Cliente no registrado");
            }
            return client;
        }
    }
}
