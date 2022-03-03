// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="AdmClienteProcedimiento.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using Guna.UI2.WinForms;
namespace LogicaDeNegocios
{
    /// <summary>
    /// Class AdmClienteProcedimiento.
    /// </summary>
    public class AdmClienteProcedimiento
    {
        /// <summary>
        /// The procedimientos
        /// </summary>
        Cliente procedimientos = new Cliente();
        /// <summary>
        /// Se crea el metodo Registrar cliente que guarda los datos de un nuevo <see cref="Cliente" />
        /// </summary>
        /// <param name="cliente">Datos del nuevo <see cref="Cliente" />.</param>
        /// <returns>Si el <see cref="Cliente" /> se registró correctamente devuelve <see cref="true" />,si no, devlueve <see cref="false" />.</returns>
        public bool RegistrarCliente(Cliente cliente)
        {
            Cliente clienteregistrar = cliente;
            clienteregistrar.InsertarCliente(clienteregistrar);
            return true;
        }

        /// <summary>
        /// Modificars the specified cedula.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns>System.String.</returns>
        public string Modificar(string cedula, string telefono, string correo, string contrasena)
        {
            return procedimientos.ActualizarCliente(cedula, telefono, correo, contrasena);
        }

        /// <summary>
        /// Consultars the cliente.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <exception cref="LogicaDeNegocios.ControlExcepcion">Cliente no registrado</exception>
       public Cliente ConsultarCliente(string cedula )
        {
            //  Cliente client = Cliente.BuscarCliente(cedula);
            Cliente client = procedimientos.BuscarCliente(cedula);

            if (client == null)
            {
                throw new ControlExcepcion("Cliente no registrado");
            }
            return client;
        }

        public List<Cliente> ConsultaClient(string cedula)
        {
            List<Cliente> lista = new List<Cliente>();
            Cliente client = null;
            client = Cliente.BuscarClient(cedula);
            lista.Add(client);
            return lista;
        }
    }
}
