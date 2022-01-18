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

namespace Presentacion
{
    public partial class InterfazCliente : Form
    {
        ConsultasProcedimientos procedimientos = new ConsultasProcedimientos();
        public InterfazCliente()
        {
            InitializeComponent();
            procedimientos.LlenarCombos(cbOrigen, cbDestino);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Comprar obj = new Comprar();
           // obj.ShowDialog();
        }

        private void cbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                EliminarComboElementos();
                procedimientos.LlenarComboCooperativa(cbCooperativa, origen, Destino);
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

        private void BotonParaMinimizarVentana_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cbCooperativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validacion_Cooperativa() && Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                string cooperativa = cbCooperativa.Text;
                procedimientos.LLenarGrit(origen, Destino, cooperativa, DataGridInf);
                DataGridInf.ClearSelection();
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

        private void BotonCierreDeAplicacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Principal_Usuario pricipal = new Principal_Usuario();
                pricipal.Show();
               
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
