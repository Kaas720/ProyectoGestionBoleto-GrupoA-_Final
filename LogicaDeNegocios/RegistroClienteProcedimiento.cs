using System;
namespace LogicaDeNegocios
{
    public class RegistroClienteProcedimiento
    {
        // Se crea el metodo Registrar cliente para conectar con el procedimiento de insertarCliente
        public void RegistrarCliente(Cliente cliente)
        {
            Cliente clienteregistrar = cliente;
            clienteregistrar.InsertarCliente(clienteregistrar);
        }
    }
}
