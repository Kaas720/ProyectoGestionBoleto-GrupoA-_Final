// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Pagar.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using LogicaDeNegocios;
using Presentacion.InicioFroms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Presentacion.UsuarioCliente
{
    /// <summary>
    /// Class Pagar.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Pagar : Form
    {
        int idBusNuevo;
        string cedula;
        AdmPago admpago = new AdmPago();
        Pago p = new Pago();
        /// <summary>
        /// Initializes a new instance of the <see cref="Pagar"/> class.
        /// </summary>
        /// <param name="texto">The texto.</param>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="fechaSalida">The fecha salida.</param>
        /// <param name="horaSalida">The hora salida.</param>
        public Pagar(string texto, int idBusNuevo, string cedula)
        {
            InitializeComponent();
            AdmPago ap = new AdmPago();
            txtTotal.Text += ap.calcularTotalPagar(Comprar.getPrecio());

            InfBoleto.Text += texto;
            this.idBusNuevo = idBusNuevo;
            this.cedula = cedula;
        }
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
        /// Handles the MouseMove event of the guna2Panel1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //metodo para regresar a paginade conpra.
        /// <summary>
        /// Handles the Click event of the BotonRetroceder control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnPagar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (Pago.pagarBoleto(idBusNuevo, cedula))
            {
                btnPagar.Visible = false;
                InfBoleto.Text = null;
                btnImprimir.Visible = true;
                txtTotal.Text = null;

            }
           else{
                MessageBox.Show("Error al comprar");
            }           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnPagar.Visible == true)
            {
                this.Close();
                BuscarBus.Ventana_ventaBoletos.Show();
            }
            else
            {
                this.Close();
                BuscarBus.Ventana_ventaBoletos.Close();
                Program.principal.Show();
                Comprar.VaciarLista();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = "BoletoGenerado" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            guardar.Filter = "Pdf Files|*.pdf";
           // string paginaHtml = Properties.Resources.
            if(guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDocument = new Document(PageSize.A4, 20, 20, 20, 20);
                    PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDocument, stream);
                    pdfDocument.Open();
                    pdfDocument.Add(new Phrase("HOLAAAAAAAAS"));
                    pdfDocument.Close();
                    stream.Close();
                }
                
            }
        }
    }
}
