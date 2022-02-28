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
