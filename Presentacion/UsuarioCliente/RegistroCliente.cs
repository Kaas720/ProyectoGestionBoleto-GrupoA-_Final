
using LogicaDeNegocios.Modulo_Procedimiento_Registro;

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EntidadesDelProyecto;
using LogicaDeNegocios;

namespace Presentacion
{
    public partial class RegistroCliente : Form
    {

        
        private string cedula;
        RegistroClienteProcedimiento registroClienteProcedimiento = new RegistroClienteProcedimiento();
        public RegistroCliente(string cedula)
        {
            this.cedula = cedula;
        }

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
            
            if (!EsVacio())
            {
                CredencialUsuario credencial = new CredencialUsuario(cedula, nombre, sexo, telefono, correo, contraseña);
                registroClienteProcedimiento.RegistrarCliente(credencial);
                MessageBox.Show("Registro realizado con exito");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Existe campos incorrectos");
            }
        }
        public bool EsVacio()
        {
            Validacion valida = new Validacion();
            bool campo = false;
           if (valida.ValidarCedula(txtCedula.Text) != true || string.IsNullOrEmpty(txtNombre.Text) || (string.IsNullOrEmpty(cmbSexo.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtContraseña.Text)))
            {
                campo = true;
            }
            return campo;
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
            Program.principal.Show();
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
    }
}
