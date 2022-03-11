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
            admCooperativa.LLenarCombos(cbBus,cbRuta);
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            string x = cbRuta.Text;
            char first = x.FirstOrDefault();
            MessageBox.Show(first.ToString());
        }
    }
}
