// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="PerfilAdminidtrador.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using LogicaDeNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.UsuarioCliente
{
    /// <summary>
    /// Class PerfilCliente.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class PerfilCliente : Form
    {
        /// <summary>
        /// The adm administrador
        /// </summary>
        AdmClienteProcedimiento adm = new AdmClienteProcedimiento();
        /// <summary>
        /// Initializes a new instance of the <see cref="PerfilAdminidtrador"/> class.
        /// </summary>
        /// <param name="(idPersona">The identifier persona.</param>
        public PerfilCliente(int idPersona)
        {
           InitializeComponent();
            LlenarInformacion(idPersona);
        }

        /// <summary>
        /// Llenars the informacion.
        /// </summary>
        /// <param name="idPersona">The identifier persona.</param>
       private void LlenarInformacion(int idPersona)
        {
            List<Cliente> Cliente = adm.ConsultaClient(idPersona);
            foreach(Cliente client in Cliente)
            {
                txtCedula.Text = client.Cedula;
                txtNom.Text = client.Nombre;
                txtSexo.Text = client.Sexo;
                txtTelefono.Text = client.Telefono;
                txtCorreo.Text = client.CredencialUsuario.Correo;
                txtPassword.Text = client.CredencialUsuario.Contrasena;
            }
            
        }

        /// <summary>
        /// Handles the Click event of the guna2HtmlLabel6 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the guna2TextBox3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarButon_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), nombre = txtNombre.Text, sexo = txtSexo.Text, telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(), contrasena = txtPassword.Text.Trim();
            BorrarAlerta();

            if (validar())
            {
               // CredencialUsuario credencial = new CredencialUsuario(correo, contrasena, 4);
               // Cliente clienteregistrar = new Cliente(cedula, nombre, sexo, telefono, credencial);
                adm.Modificar(telefono, correo, contrasena);
                MessageBox.Show("Datos actualizados con exito.");
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Existe un campo vacio");
            }
        }
        /// <summary>
        /// Validars this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="LogicaDeNegocios.ControlExcepcion">Datos no validos!</exception>
        private bool validar()
        {
            Validacion valida = new Validacion();
            bool campo = true;
            
            if (valida.ValidarTelefono(txtTelefono.Text) != true)
            {
                campo = false;
                errorProvider1.SetError(txtTelefono, "Se esperaba 10 numeros.");
            }
            
            if (valida.validarEmail(txtCorreo.Text) != true)
            {
                campo = false;
                errorProvider1.SetError(txtCorreo, "Ingrese su correo electronico.");
            }
            if (txtPassword.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtPassword, "Ingrese una contraseña.");
            }
            if (!campo)
            {
                throw new ControlExcepcion("Datos no validos!");
            }

            if (!campo)
            {
                throw new ControlExcepcion("Datos no validos!");
            }
            return campo;
        }
        /// <summary>
        /// Borrars the alerta.
        /// </summary>
        private void BorrarAlerta()
        {
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(txtCorreo, "");
            errorProvider1.SetError(txtPassword, "");
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
