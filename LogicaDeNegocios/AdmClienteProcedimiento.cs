using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    public class AdmClienteProcedimiento
    {
        // Se crea el metodo Registrar cliente para conectar con el procedimiento de insertarCliente
        /// <summary>
        /// Guarda los datos de un nuevo <see cref="Cliente"/>.
        /// </summary>
        /// <param name="cedula">Cedula del nuevo <see cref="Cliente"/>.</param>
        /// <param name="nombre">Nombres del nuevo <see cref="Cliente"/>.</param>
        /// <param name="sexo">Sexo del nuevo <see cref="Cliente"/>.</param>
        /// <param name="telefono">Telefono del nuevo <see cref="Cliente"/>.</param>
        /// <param name="correo">Correo del nuevo <see cref="Cliente"/>.</param>
        /// <param name="contraseña">Contraseña del nuevo <see cref="Cliente"/>.</param>
        /// <returns>Si el <see cref="Cliente"/> se registró correctamente devuelve <see cref="true"/>,si no, devlueve <see cref="false"/>.</returns>
      
        public bool RegistrarCliente(string cedula, string nombre, string sexo, string telefono, string correo, string contraseña)
        {
            
            Cliente clienteregistrar = new Cliente(cedula, nombre, sexo, telefono, correo, contraseña);
            clienteregistrar.InsertarCliente(clienteregistrar);
            return true;
        }
        //public void RegistrarCliente(Cliente cliente)
        //{
        //    Cliente clienteregistrar = cliente;
        //    clienteregistrar.InsertarCliente(clienteregistrar);
        //}


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
