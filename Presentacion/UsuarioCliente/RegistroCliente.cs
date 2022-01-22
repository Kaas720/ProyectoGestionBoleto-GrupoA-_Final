
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LogicaDeNegocios;

namespace Presentacion
{
    public partial class RegistroCliente : Form
    {


        private string cedula;
        AdmCliente registroClienteProcedimiento = new AdmCliente();
        //public RegistroCliente(string cedula)
        //{
        //    this.cedula = cedula;
        //}

        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            // Cliente obj = new Cliente(cedula);
            // obj.Show();
            this.Hide();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), nombre = txtNombre.Text.Trim(), sexo = cmbSexo.Text.Trim(),
                telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(),
                contraseña = txtContraseña.Text.Trim();
            BorrarAlerta();
            if (validar())
            {
                Cliente client = new Cliente(cedula, nombre, sexo, telefono, correo, contraseña);
                registroClienteProcedimiento.Guardar(client);
                MessageBox.Show("Registro realizado con exito");
             
                Limpiar();
                this.Hide();
                InterfazCliente cliente = new InterfazCliente(cedula);
                cliente.Show();
            }
           
        }
        private bool validar() {
            Validacion valida = new Validacion();
            bool campo = true;
            if (valida.ValidarCedula(txtCedula.Text) != true)
            {
                campo = false;
                errorProvider1.SetError(txtCedula, "Se esperaba 10 numeros.");
            }
            if (txtNombre.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtNombre, "Ingrese su nombre completo.");
            }
            if (valida.ValidarTelefono(txtTelefono.Text) != true)
            {
                campo = false;
                errorProvider1.SetError(txtTelefono, "Se esperaba 10 numeros.");
            }
            if (cmbSexo.SelectedIndex < 0)
            {
                campo = false;
                errorProvider1.SetError(cmbSexo, "Selecione un tipo de genero.");
            }
            if (valida.validarEmail(txtCorreo.Text) != true)
            {
                campo = false;
                errorProvider1.SetError(txtCorreo, "Ingrese su correo electronico.");
            }
            if (txtContraseña.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtContraseña, "Ingrese una contraseña.");
            }
            return campo;
        }
        private void BorrarAlerta()
        {
            errorProvider1.SetError(txtCedula, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(cmbSexo, "");
            errorProvider1.SetError(txtCorreo, "");
            errorProvider1.SetError(txtContraseña, "");
        }
       
        public void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            cmbSexo.Text = null;
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Usuario principal = new Principal_Usuario();
            principal.Show();
            this.Dispose();
        }

        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal_Usuario principal = new Principal_Usuario();
            principal.Show();
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }

        private void BotonParaMinimizarVentana_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
    }
}
