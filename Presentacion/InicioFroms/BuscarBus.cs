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

namespace Presentacion.InicioFroms
{
    public partial class BuscarBus : Form
    {
        ConsultasProcedimientos procedimientos = new ConsultasProcedimientos();
        public BuscarBus()
        {
            InitializeComponent();
            procedimientos.LlenarCombos(cbOrigen, cbDestino);
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
        private void DataGridInf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                try
                {
                    if (procedimientos.ValidarDataGridVacio(DataGridInf))
                    {
                        int x = DataGridInf.CurrentCell.RowIndex;
                        string cooperativa = DataGridInf.Rows[x].Cells[0].Value.ToString();
                        string fecha_salida = DataGridInf.Rows[x].Cells[1].Value.ToString();
                        string horario_salida = DataGridInf.Rows[x].Cells[2].Value.ToString();
                        Comprar comprar = new Comprar(cooperativa, fecha_salida, horario_salida);
                        Program.principal.Hide();
                        comprar.Show();
                    }
                }
                catch (ControlExcepcion ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
        private void cbCooperativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validacion_Cooperativa() && Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                string cooperativa = cbCooperativa.Text;
                DataGridInf.Rows.Clear();
                procedimientos.LLenarGrit(origen, Destino, cooperativa, DataGridInf);
                DataGridInf.ClearSelection();
            }
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
    }
}
