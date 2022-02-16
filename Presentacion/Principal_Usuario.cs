
using FontAwesome.Sharp;
using LogicaDeNegocios;
using Presentacion.InicioFroms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal_Usuario : Form
    {
        /// <summary>
        /// Codigo para arrastrar la ventana a cualquier parte de la pantalla
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        IconButton iconButton;
        public Principal_Usuario()
        {
            InitializeComponent();
            IniciarFromPrinciapl();


        }
        private void IniciarFromPrinciapl()
        {
            BuscarBus Frm = new BuscarBus();
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            iconButton = BotonHome;
            iconButton.ForeColor = Color.Green;
            iconButton.IconColor = Color.Green;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            this.PanelContenedor.Controls.Clear();
            RegistroCliente Frm = new RegistroCliente();
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
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
        private void BotonHome_Click(object sender, EventArgs e)
        {
            this.PanelContenedor.Controls.Clear();
            BuscarBus Frm = new BuscarBus();
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }
        /*-------------------------------------------------------------------------------------------------------*/
        private void BotonCierreDeAplicacion_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }
        /// <summary>
        /// Se realiza el metodo para minimizar la aplicacion 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonParaMinimizarVentana_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BotonInicioSesion_Click_1(object sender, EventArgs e)
        {
            this.PanelContenedor.Controls.Clear();
            InicioSeccion Frm = new InicioSeccion();
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }
    }
}
