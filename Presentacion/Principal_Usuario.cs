
using LogicaDeNegocios.Modulo_de_cliente;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal_Usuario : Form
    {
        AdmCliente cliente = AdmCliente.GetAdm();
        public Principal_Usuario()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            RegistroCliente cliente = new RegistroCliente();
            cliente.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistroCliente cl = new RegistroCliente();
            cl.Show();
            this.Hide();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Comprar ob = new Comprar();
            ob.Show();
            this.Hide();
        }

        private void cbOrigen_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrEmpty(cbOrigen.Text) && String.IsNullOrEmpty(cbDestino.Text))
            {
                cbHorario.Visible = false;
            }
            else
            {
                cbHorario.Visible = true;
            }
        }

        private void cbDestino_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbOrigen.Text) && String.IsNullOrEmpty(cbDestino.Text))
            {
                cbHorario.Visible = false;
            }
            else
            {
                cbHorario.Visible = true;
            }
        }

    }
}
