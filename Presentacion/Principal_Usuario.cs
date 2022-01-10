
using LogicaDeNegocios;
using LogicaDeNegocios.Modulo_de_cliente;
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
    public partial class Principal_Usuario : Form
    {
        ConsultasProcedimientos procedimientos = new ConsultasProcedimientos();
        public Principal_Usuario()
        {
            InitializeComponent();
            procedimientos.LlenarCombos(cbOrigen, cbDestino);
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
        /*Metodos para la venta en general*/
        private void BotonCierreDeAplicacion_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
