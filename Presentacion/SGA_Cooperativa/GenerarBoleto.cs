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

namespace Presentacion.SGA_Cooperativa
{
    public partial class GenerarBoleto : Form
    {
        AdmCooperativa admCooperativa = new AdmCooperativa();
        public GenerarBoleto()
        {
            InitializeComponent();
            admCooperativa.LLenarCombos(cbRuta,0);
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (cbBus.Text=="")
            {
                MessageBox.Show("Por favor llenar todos los campos");
            }
            else
            {
                string x = cbRuta.Text;
                char first = x.FirstOrDefault();
                string numero = first.ToString();
                int xx = Convert.ToInt32(numero);
                admCooperativa.GenerarBoleto(xx, cbBus.Text, FechaSalida.Text, HoraSalida.Text, Precio.Text);
            }
            
        }

        private void cbBus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBus.Items.Clear();
            string x = cbRuta.Text;
            char first = x.FirstOrDefault();
            string numero = first.ToString();
            int xx = Convert.ToInt32(numero);
            admCooperativa.LLenarCombos(cbBus,xx);
        }
    }
}
