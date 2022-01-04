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
    public partial class Comprar : Form
    {
        Boleto boleto = new Boleto();
        public Comprar()
        {
            InitializeComponent();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Dispose();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            System.DateTime date = new System.DateTime();
            string cedula = txtCedula.Text.Trim(),
                nombre = txtNombre.Text.Trim(),
                lugarOrigen = txtOrigen.Text.Trim(),
                lugarDestino = txtDestino.Text.Trim();
            //DateTime fechaSalida = date.ToShortDateString(txtFsalida.Text),
            DateTime fechaSalida = DateTime.Parse(txtFsalida.Text),
                horaSalida = DateTime.Parse(txtHsalida.Text),
                fechaEmision = DateTime.Parse(txtFemision.Text);
            int cantidadBoleto = Convert.ToInt32(cbNasiento.Text);
            string valorUnitario = txtVunitario.Text,// Convert.ToDouble(txtVunitario.Text.Trim()),
                impuesto = txtImpuesto.Text, //Convert.ToDouble(txtImpuesto.Text.Trim()),
                valorTotal = txtImpuesto.Text;//Convert.ToDouble(txtTotal.Text.Trim());
            string contenido = "";
            contenido = (cedula+nombre+ lugarOrigen +lugarDestino +fechaSalida + horaSalida + fechaEmision + cantidadBoleto+
                valorUnitario + impuesto + valorTotal);
                //cantidadBoleto, valorUnitario,
                //impuesto, valorTotal);
            string datos = txtArea.Text; 
            txtArea.Text += datos + contenido;
          

        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) &&
              (e.KeyChar != Convert.ToChar(Keys.Space)))
            {
                e.Handled = true;
                return;
            }
           
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
