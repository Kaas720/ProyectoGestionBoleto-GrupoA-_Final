// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="EliminarClienteporAdmin.cs" company="">
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

namespace Presentacion.SGA_Administrador
{
    /// <summary>
    /// Class EliminarClienteporAdmin.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EliminarClienteporAdmin : Form
    {
        /// <summary>
        /// The adm cliente procedimiento
        /// </summary>
        AdmClienteProcedimiento admClienteProcedimiento = new AdmClienteProcedimiento();
        /// <summary>
        /// Initializes a new instance of the <see cref="EliminarClienteporAdmin"/> class.
        /// </summary>
        public EliminarClienteporAdmin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the iconPictureBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            //string cedula = TxtCedulaCliente.Text;
            //try
            //{
            //    //  Cliente client = admClienteProcedimiento.ConsultarCliente(cedula);
            //    Cliente client = admClienteProcedimiento.BuscarCliente(cedula);
            //    List<Cliente> listaCliente = new List<Cliente>();
            //    listaCliente.Add(client);
            //    foreach (Cliente c in listaCliente)
            //    {
            //        Console.WriteLine(client.Cedula+ client.Nombre+ client.CredencialUsuario.Correo+"//////////////////");
            //        DataGridCliente.Rows.Add(1);
            //        DataGridCliente.Rows[0].Cells[0].Value = client.Cedula.ToString();
            //        DataGridCliente.Rows[0].Cells[1].Value = client.Nombre.ToString();
            //        DataGridCliente.Rows[0].Cells[2].Value = client.CredencialUsuario.Correo.ToString();
            //        DataGridCliente.Rows[0].Cells[3].Value = "Eliminar";
            //    }  
            //}
            //catch (ControlExcepcion ex)
            //{
            //    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
