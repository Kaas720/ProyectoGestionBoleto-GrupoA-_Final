using LogicaDeNegocios;
using Presentacion.UsuarioCliente;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Comprar : Form
    {
        // Se llama al clase Validacion  y se crea el objeto validacion  para llamar a los metodos que contiene
        Validacion validacion = new Validacion();
        string boletos;
        // Se llama al clase ConsultaProcedimientosGenerarBoleto y se crea el objeto consultasProcedemientos para llamar a los metodos que contiene
        ConsultaProcedimientosGenerarBoleto consultasProcedemientos = new ConsultaProcedimientosGenerarBoleto();
        List<string> boletosNuveos = new List<string>();
        public Comprar(string cooperativa, string fechaSalida, string horaSalida)
        {
            InitializeComponent();
          // Se llama al metodo en el constructor para que los datos se caguen de manera automatica al ingresar al formulario compra
            LlenarInformacionAutomaticamente(cooperativa, fechaSalida, horaSalida);        
        }

        // Se crea el metodo LlenarInformacionAutomaticamente que recibe como parametro cooperativa, fechaSalida, horaSalida, se crea una lista almacenada GenerarInformacionBoleto
        // llamada generarInformacionBoleto la cual se llena al llamar al metodo LlenarComboAsientos 
        private void LlenarInformacionAutomaticamente(string cooperativa, string fechaSalida, string horaSalida)
        {
            List<GenerarInformacionBoleto> generarInformacionBoleto = consultasProcedemientos.generarInformacionBoleto(cooperativa, fechaSalida, horaSalida);
       // Se utiliza el bucle foreach para realizar la agregacion de los datos que poseee un boleto y el usuario pueda completar con sus datos para posterior a ello almacenadas dentro de la base de datos
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

        // Se realiza el evento tick para mostrar la fecha y hora actual en el sistema
        private void timer1_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }

        // Se llama al metodo Exit para cerrar la aplicacion y se muestra un mensaje de alerta para confirmar el cierre de la aplicacion
        private void BotonCierreDeAplicacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        // Se realiza el metodo para minimizar la aplicacion 
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

        // Se llama al metodo Close() para cerrar el formulario login y mostrar el formulario principal
        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.principal.Show();
        }

        // Se realiza el metodo LLenarInformacionBoletoCarro para agregar la compra de un boleto 
        private void LLenarInformacionBoletoCarro()
        {
            boletos += Environment.NewLine + "/-----------------------------------/" + Environment.NewLine + "Cedula: "+ txtCedula.Text + Environment.NewLine + "Nombre: " + TxtNombre.Text + Environment.NewLine
            + "Cooperativa: " + TxtCooperativa.Text + Environment.NewLine + "Hora Salida: " + TxtHoraSalida.Text + Environment.NewLine
            + "Fecha Salida: " + TxtFechaSalida.Text + Environment.NewLine + "Disco del bus: " + TxtNumeroDisco.Text + Environment.NewLine
            + "Asiento:" + CbNumeroAsientos.Text;
            boletosNuveos.Add(CbNumeroAsientos.Text);
        }

        // Se crea el metodo VaciarCampos para limpiar los campos que seran ingresados por el cliente
        private void VaciarCampos()
        {
            txtCedula.Text = null;
            TxtNombre.Text = null;
            CbNumeroAsientos.Items.Remove(CbNumeroAsientos.Text);
        }

        // Se crea el metodo CambiarTextoCarrito para agreagar la informacion por cada boleto y aumentar la cantidad de boletos con un contador 
        private void CambiarTextoCarrito()
        {
            int valor = Convert.ToInt32(CarritoBtn.Text);
            valor += 1;
            CarritoBtn.Text = Convert.ToString(valor);
        }

        // Metodo para validar que no hayan campos vacios en el fromulario.
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

        // se crea el metodo para agregar la compra de un boleto
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

        // Se crea el metodo para mostrar la informacion almacenada en el carrito
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

        // Se crea el metodo ValidarCarrito para mostrar la informacion si no se agregado ningunboleto se lanza la excepcion
        private bool ValidarCarrito()
        {
            if (Convert.ToInt32(CarritoBtn.Text) == 0)
            {
                throw new ControlExcepcion("No hay boletos agregados al carrito");
                return false;
            }
            return true;
        }

        // El evento valida que el textBox solo reciba numeros 
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        // El evento valida que el textBox solo reciba letras
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
