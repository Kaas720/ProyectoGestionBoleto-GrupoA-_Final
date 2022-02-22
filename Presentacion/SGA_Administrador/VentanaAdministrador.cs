// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="VentanaAdministrador.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using Presentacion.SGA_Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    /// <summary>
    /// Class VentanaAdministrador.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class VentanaAdministrador : Form
    {
        /// <summary>
        /// The color botone seleccionado
        /// </summary>
        Color colorBotoneSeleccionado = Color.FromArgb(36, 66, 86);
        /// <summary>
        /// The color botone original
        /// </summary>
        Color colorBotoneOriginal = Color.FromArgb(241, 246, 249);
        /// <summary>
        /// The identifier persona
        /// </summary>
        int idPersona;
        /*Codigo para arrastrar la ventana a cualquier parte de la pantalla*/
        /// <summary>
        /// Releases the capture.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="hwnd">The HWND.</param>
        /// <param name="wmsg">The WMSG.</param>
        /// <param name="wparam">The wparam.</param>
        /// <param name="lparam">The lparam.</param>
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /// <summary>
        /// Handles the MouseMove event of the PanelSuperior control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void PanelSuperior_MouseMove(object sender, MouseEventArgs e)
        {     
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /*--------------------------------------------------------------------*/
        /// <summary>
        /// The icon button
        /// </summary>
        IconButton iconButton;
        /// <summary>
        /// Initializes a new instance of the <see cref="VentanaAdministrador"/> class.
        /// </summary>
        /// <param name="idPersona">The identifier persona.</param>
        public VentanaAdministrador(int idPersona)//(int idPersona)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            IniciarFromdelPanelPrincipal();
        }
        /// <summary>
        /// Iniciars the fromdel panel principal.
        /// </summary>
        public void IniciarFromdelPanelPrincipal()
        {
            MessageBox.Show(idPersona + "");
            PerfilAdminidtrador Frm = new PerfilAdminidtrador(idPersona);
            Frm.TopLevel = false;
            PanelPrincipalContenedor.Controls.Add(Frm);
            Frm.Show();
            iconButton = Home;            
            iconButton.ForeColor = colorBotoneSeleccionado;
            iconButton.IconColor = colorBotoneSeleccionado;
        }
        /*private void BotonEliminarAdmin_Click(object sender, EventArgs e)
        {
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }*/
        /// <summary>
        /// Metodo que se encarga de abrir el from para el registro cliente
        /// </summary>
        /// <param name="sender"> Objeto almacenado del boton </param>
        /// <param name="e"> envento generado </param>
        bool verificarBoton = true;
        /// <summary>
        /// Handles the Click event of the BotonregistrasAdmin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonregistrasAdmin_Click(object sender, EventArgs e)
        {
            RestablecerColorOriginalBotones();
            iconButton = (IconButton)sender;
            if (verificarBoton) {
                GenerarNuevoColorBoton(sender);
                verificarBoton = false;
            }
            else
            {
                verificarBoton = true;
            }
            OcultarPaneles(PanelRegistro);
            PanelEliminar.Visible = false;
            
        }
        /// <summary>
        /// The verificar boton eliminar
        /// </summary>
        bool verificarBotonEliminar = true;
        /// <summary>
        /// Handles the Click event of the Eliminar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Eliminar_Click(object sender, EventArgs e)
        {
            RestablecerColorOriginalBotones();
            iconButton = (IconButton)sender;
            if (verificarBotonEliminar)
            {
                GenerarNuevoColorBoton(sender);
                verificarBotonEliminar = false;
            }
            else
            {
                verificarBotonEliminar = true;
            }
            OcultarPaneles(PanelEliminar);
            PanelRegistro.Visible = false; 
        }
        /// <summary>
        /// Handles the Click event of the Home control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Home_Click(object sender, EventArgs e)
        {
            GenerarNuevoColorBoton(sender);
            RestablecerColorOriginalBotones();
            this.PanelPrincipalContenedor.Controls.Clear();
            PerfilAdminidtrador Frm = new PerfilAdminidtrador(idPersona);
            Frm.TopLevel = false;
            PanelPrincipalContenedor.Controls.Add(Frm);
            Frm.Show();
        }

        /// <summary>
        /// Ocultars the paneles.
        /// </summary>
        /// <param name="panel">The panel.</param>
        private void OcultarPaneles(Guna2Panel panel)
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }
        }

        /// <summary>
        /// Generars the nuevo color boton.
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void GenerarNuevoColorBoton(object sender)
        {
            iconButton = (IconButton)sender;
            iconButton.IconColor = colorBotoneSeleccionado;
            iconButton.ForeColor = colorBotoneSeleccionado;
        }

        /// <summary>
        /// Restablecers the color original botones.
        /// </summary>
        private void RestablecerColorOriginalBotones()
        {
            iconButton.IconColor = colorBotoneOriginal;
            iconButton.ForeColor = colorBotoneOriginal;

        }

        /// <summary>
        /// Handles the Tick event of the Fecha_Hora_Sistema control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Fecha_Hora_Sistema_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// Handles the Click event of the BotonCierreDeAplicacion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonCierreDeAplicacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Handles the Click event of the BotonParaMinimizarVentana control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonParaMinimizarVentana_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        



        /* private void iconButton4_Click(object sender, EventArgs e)
         {
             this.Close();
             Program.principal.Show();
         }*/
    }
}
