using EntidadesDelProyecto;
using LogicaDeNegocios;
using LogicaDeNegocios.Modulo_de_cliente;
using Presentacion.UsuarioCliente;
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
        Validacion validacion = new Validacion();
        string boletos;
        ConsultaProcedimientosGenerarBoleto consultasProcedemientos = new ConsultaProcedimientosGenerarBoleto();
        List<string> boletosNuveos = new List<string>();
        public Comprar(string cooperativa, string fechaSalida, string horaSalida)
        {
            InitializeComponent();
            LlenarInformacionAutomaticamente(cooperativa, fechaSalida, horaSalida);        
        }

        private void LlenarInformacionAutomaticamente(string cooperativa, string fechaSalida, string horaSalida)
        {
            List<GenerarInformacionBoleto> generarInformacionBoleto = consultasProcedemientos.generarInformacionBoleto(cooperativa, fechaSalida, horaSalida);
            foreach (GenerarInformacionBoleto item in generarInformacionBoleto)
            {
                TxtCooperativa.Text = item.Cooperativa;
                TxtDestino.Text = item.Lugardestino;
                TxtFechaSalida.Text = item.FechaSalida;
                TxtHoraSalida.Text = item.HoraSalida;
                TxtLugarSalida.Text = item.LugarSalida;
                TxtNumeroDisco.Text = item.Numerodico;
                TxtPrecio.Text = item.Precio;
                consultasProcedemientos.LlenarComboAsientos(item.BusId,CbNumeroAsientos);
            }
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


        private void LLenarInformacionBoletoCarro()
        {
            boletos += Environment.NewLine + "/-----------------------------------/" + Environment.NewLine + "Cedula: "+ txtCedula.Text + Environment.NewLine + "Nombre: " + TxtNombre.Text + Environment.NewLine
            + "Cooperativa: " + TxtCooperativa.Text + Environment.NewLine + "Hora Salida: " + TxtHoraSalida.Text + Environment.NewLine
            + "Fecha Salida: " + TxtFechaSalida.Text + Environment.NewLine + "Disco del bus: " + TxtNumeroDisco.Text + Environment.NewLine
            + "Asiento:" + CbNumeroAsientos.Text;
            boletosNuveos.Add(CbNumeroAsientos.Text);
        }

        private void VaciarCampos()
        {
            txtCedula.Text = null;
            TxtNombre.Text = null;
            CbNumeroAsientos.Items.Remove(CbNumeroAsientos.Text);
        }

        private void CambiarTextoCarrito()
        {
            int valor = Convert.ToInt32(CarritoBtn.Text);
            valor += 1;
            CarritoBtn.Text = Convert.ToString(valor);
        }

        private bool verificarCamposVacios()
        {
            bool campo = false;
            if(validacion.ValidarCedula(txtCedula.Text)!= true ||  String.IsNullOrEmpty(TxtNombre.Text)  ||  String.IsNullOrEmpty(CbNumeroAsientos.Text))
            {
                campo = true;
                throw new ControlExcepcion(" Campos invalidos!");
            }
            return campo;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (!verificarCamposVacios())
                {
                    CambiarTextoCarrito();
                    LLenarInformacionBoletoCarro();
                    VaciarCampos();
                }
            }
            catch(ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void CarritoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCarrito())
                {
                    Pagar pagar = new Pagar(boletos, TxtCooperativa.Text, TxtFechaSalida.Text, TxtHoraSalida.Text);
                    pagar.ShowDialog();
                }
            }
            catch (ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool ValidarCarrito()
        {
            if (Convert.ToInt32(CarritoBtn.Text) == 0)
            {
                throw new ControlExcepcion("No hay boletos agregados al carrito");
                return false;
            }
            return true;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) &&
                 (e.KeyChar != Convert.ToChar(Keys.Space)))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
