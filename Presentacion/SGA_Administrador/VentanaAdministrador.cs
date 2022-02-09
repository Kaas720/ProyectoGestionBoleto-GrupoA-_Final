﻿using FontAwesome.Sharp;
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
    public partial class VentanaAdministrador : Form
    {
        /*Codigo para arrastrar la ventana a cualquier parte de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /*--------------------------------------------------------------------*/
        IconButton iconButton;
        public VentanaAdministrador()
        {
            InitializeComponent();
            IniciarFromdelPanelPrincipal();
        }
        public void IniciarFromdelPanelPrincipal()
        {
            RegistroCliente Frm = new RegistroCliente();
            Frm.TopLevel = false;
            PanelPrincipalContenedor.Controls.Add(Frm);
            Frm.Show();
            iconButton = BotonregistrasAdmin;
            iconButton.ForeColor = Color.Green;
            iconButton.IconColor = Color.Green;
        }
        /*private void BotonEliminarAdmin_Click(object sender, EventArgs e)
        {
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }*/
        ///<summary>
        ///Metodo que se encarga de abrir el from para el registro cliente
        ///</summary>
        ///<param name= "sender"> Objeto almacenado del boton </param>
        /// <param name= "e"> envento generado </param>
        private void BotonregistrasAdmin_Click(object sender, EventArgs e)
        {
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);          
            OcultarPaneles(PanelRegistro);
            PanelEliminar.Visible = false;

        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
            OcultarPaneles(PanelEliminar);
            PanelRegistro.Visible = false; 
        }

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

        private void GenerarNuevoColorBoton(object sender)
        {
            iconButton = (IconButton)sender;
            iconButton.IconColor = Color.Green;
            iconButton.ForeColor = Color.Green;
        }

        private void RestablecerColorOriginalBotones()
        {
            iconButton.IconColor = Color.White;
            iconButton.ForeColor = Color.White;
            
        }

        private void Fecha_Hora_Sistema_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }

        private void BotonCierreDeAplicacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

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
