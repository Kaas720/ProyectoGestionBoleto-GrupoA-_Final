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
    public partial class Comprar : Form
    {
        public Comprar(string cooperativa, string fechaSalida, string horaSalida)
        {
            InitializeComponent();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
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

        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.principal.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(verificarCamposVacios())
            {

                CambiarTextoCarrito();
            }
        }

        private void CambiarTextoCarrito()
        {
            int valor = Convert.ToInt32(CarritoBtn.Text);
            valor += 1;
            CarritoBtn.Text = Convert.ToString(valor);
        }

        private bool verificarCamposVacios()
        {
            if (txtCedula.Text.Length != 0 && TxtNombre.Text.Length != 0 && !TxTNumeroAsientos.SelectedIndex.Equals(-1))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Campos vacios llenar todos los campos.");
                return false;
            }
        }
        /*--------------------------------------------------------------------*/
    }
}
