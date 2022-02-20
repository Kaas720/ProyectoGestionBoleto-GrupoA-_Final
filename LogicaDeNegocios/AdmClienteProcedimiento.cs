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
        /// <param name="nombre">The nombre.</param>
        /// <param name="sexo">The sexo.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns>System.String.</returns>
        public string Modificar(string cedula, string nombre, string sexo, string telefono, string correo, string contrasena)
        {
            return procedimientos.ActualizarCliente(cedula, nombre, sexo, telefono, correo, contrasena);
        }

        /// <summary>
        /// Inicializars the specified text cedula.
        /// </summary>
        /// <param name="txtCedula">The text cedula.</param>
        /// <param name="txtNombre">The text nombre.</param>
        /// <param name="cmbSexo">The CMB sexo.</param>
        /// <param name="txtTelefono">The text telefono.</param>
        /// <param name="txtCorreo">The text correo.</param>
        /// <param name="txtContraseña">The text contraseña.</param>
        public void Inicializar(Guna2TextBox txtCedula, Guna2TextBox txtNombre, Guna2TextBox cmbSexo, Guna2TextBox txtTelefono, Guna2TextBox txtCorreo, Guna2TextBox txtContraseña)
        {
            string cedula = txtCedula.Text;

            //List<Cliente> client = procedimientos.BuscarCliente(cedula);
            // List<Cliente> lista = new List<Cliente>();
             List<Cliente> client = procedimientos.BuscarCliente(cedula);
            //   lista.Add(client);
           // client = procedimientos.ConsultarCliente(cedula);
            //txtCedula.Text = TraerInformacion[0].ToString();
            //txtCedula.Text = lista[lista.Count - 1].Cedula.ToString();
            //txtNombre.Text = lista[lista.Count - 1].Nombre.ToString();
            //cmbSexo.Text = lista[lista.Count - 1].Sexo.ToString();
            //txtTelefono.Text = lista[lista.Count - 1].Telefono.ToString();
            //txtCorreo.Text = lista[lista.Count - 1].CredencialUsuario.Correo.ToString();
            //txtContraseña.Text = lista[lista.Count - 1].CredencialUsuario.Contrasena.ToString();
            // return lista[lista.Count - 1].IdTipoUsuario;

            //  txtCedula.Text = client[0].Cedula.ToString();
            txtNombre.Text = client[1].ToString();
            cmbSexo.Text = client[2].ToString();
            txtTelefono.Text = client[3].ToString();
            txtCorreo.Text = client[4].ToString();
            txtContraseña.Text = client[5].ToString();
        }

        /// <summary>
        /// Consultars the cliente.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <exception cref="LogicaDeNegocios.ControlExcepcion">Cliente no registrado</exception>
        public void ConsultarCliente(string cedula )
        {
            //  Cliente client = Cliente.BuscarCliente(cedula);
            List<Cliente> client = procedimientos.BuscarCliente(cedula);

            if (client == null)
            {
                throw new ControlExcepcion("Cliente no registrado");
            }
        }
    }
}
