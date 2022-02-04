﻿using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    public class AdmClienteProcedimiento
    {
        /// <summary>
        /// Se crea el metodo Registrar cliente que guarda los datos de un nuevo <see cref="Cliente"/>
        /// </summary>
        /// <param name="cliente">Datos del nuevo <see cref="Cliente"/>.</param>
        /// <param name="credencial">Datos de la nueva <see cref="CredencialUsuario"/></param>
        /// <returns>Si el <see cref="Cliente"/> se registró correctamente devuelve <see cref="true"/>,si no, devlueve <see cref="false"/>.</returns>
        public bool RegistrarCliente(Cliente cliente, CredencialUsuario credencial)
        {
            Cliente clienteregistrar = cliente;
            CredencialUsuario registroCredencial = credencial;
            clienteregistrar.InsertarCliente(registroCredencial, clienteregistrar);
            return true;
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