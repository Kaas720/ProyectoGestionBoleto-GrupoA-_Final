using FontAwesome.Sharp;
using LogicaDeNegocios;
using Presentacion.InicioFroms;
using Presentacion.UsuarioCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InterfazCliente : Form
    {
        ConsultasProcedimientos procedimientos = new ConsultasProcedimientos();
        Color colorBotoneSeleccionado = Color.FromArgb(48, 88, 115);
        Color colorBotoneOriginal = Color.FromArgb(241, 246, 249);
        IconButton iconButton;
        int idPersona;
        public InterfazCliente(int idPersona)
        {
            InitializeComponent();
            InicializarPanelConFromRutas();
            this.idPersona = idPersona;
        }

        private void InicializarPanelConFromRutas()
        {
            BuscarBus Frm = new BuscarBus();
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            iconButton = Home;
            iconButton.BackColor = Color.FromArgb(154, 189, 213);
            iconButton.IconColor = colorBotoneSeleccionado;
            iconButton.ForeColor = colorBotoneSeleccionado;
        }
        private void GenerarNuevoColorBoton(object sender)
        {
            iconButton = (IconButton)sender;
            iconButton.IconColor = colorBotoneSeleccionado;
            iconButton.ForeColor = colorBotoneSeleccionado;
            iconButton.BackColor = Color.FromArgb(154, 189, 213);
        }
        private void RestablecerColorOriginalBotones()
        {
            iconButton.IconColor = colorBotoneOriginal;
            iconButton.ForeColor = colorBotoneOriginal;
            iconButton.BackColor = Color.FromArgb(66, 121, 158);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }

        private void CloseSesion_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }

        private void EditPerfil_Click(object sender, EventArgs e)
        {
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }

        private void History_Click(object sender, EventArgs e)
        {
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }

        private void RutasFavoritas_Click(object sender, EventArgs e)
        {
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }
    }
}
