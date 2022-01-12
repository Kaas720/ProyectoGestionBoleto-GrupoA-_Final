
using LogicaDeNegocios;
using LogicaDeNegocios.Modulo_de_cliente;
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
    public partial class Principal_Usuario : Form
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }

        private void cbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                EliminarComboElementos();
                procedimientos.LlenarComboCooperativa(cbCooperativa,origen,Destino);
            }
        }
        private void cbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                EliminarComboElementos();
                procedimientos.LlenarComboCooperativa(cbCooperativa, origen, Destino);

            }
        }
        private bool Comprobar_combo_vacio()
        {
            bool bandera = false;
            if (!cbOrigen.SelectedIndex.Equals(-1) && !cbDestino.SelectedIndex.Equals(-1))
            {
                bandera = true;
            }
            return bandera;
        }
        private void EliminarComboElementos()
        {
                cbCooperativa.Items.Clear();
                DataGridInf.Rows.Clear();
        }

        private void BotonInicioSesion_Click(object sender, EventArgs e)
        {
            InicioSeccion iniciosesion = new InicioSeccion();
            iniciosesion.Show();
        }

        private void cbCooperativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validacion_Cooperativa() && Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                string cooperativa = cbCooperativa.Text;
                procedimientos.LLenarGrit(origen, Destino, cooperativa,DataGridInf);
            }
        }

        private bool Validacion_Cooperativa()
        {   
            if (!cbCooperativa.SelectedIndex.Equals(-1))
            {
                return true;
            }
            return false;
        }
    }
}
