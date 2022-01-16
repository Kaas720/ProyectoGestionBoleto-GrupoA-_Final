
using Presentacion.UsarioCliente;
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
    public partial class FrmCliente : Form
    {
        
        string cedula;
        public FrmCliente(string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Comprar obj = new Comprar();
            obj.ShowDialog();
        }

        private void BotonCierreDeAplicacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesión?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Principal_Usuario principal = new Principal_Usuario();
                principal.Show();
                this.Dispose();
            }
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Usuario principal = new Principal_Usuario();
            principal.Show();
            this.Dispose();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarCliente cliente = new ActualizarCliente(this.cedula);
            cliente.Show();
        }
    }
}
