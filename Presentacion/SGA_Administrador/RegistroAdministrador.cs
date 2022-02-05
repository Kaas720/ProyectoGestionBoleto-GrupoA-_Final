
using LogicaDeNegocios;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Presentacion
{
    public partial class RegistroAdministrador : Form
    {
        private string cedula;
        // Se llama al clase  RegistroClienteProcedimiento y se crea el objeto registroClienteProcedimiento para llamar a los metodos que contiene
        AdmAdministrador registroClienteProcedimiento = new AdmAdministrador();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        public RegistroAdministrador()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Metodo para guardar la informacion del registro de un cliente 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), nombre = txtNombre.Text.Trim(),
                    sexo = cmbSexo.Text.Trim(), telefono = txtTelefono.Text.Trim(),
                    sueldo = txtSueldo.Text, codAcceso = txtAcceso.Text,
                    correo = txtCorreo.Text.Trim(), contraseña = txtContraseña.Text.Trim();
            BorrarAlerta();
            try
            {
            // Al validar que los campos se llenaron correctamente se guarda el regitro y se envia al formulario cliente
                if (validar())
                {
                    CredencialUsuario credencial = new CredencialUsuario(correo, contraseña,1);
                    Administrador registrar = new Administrador(cedula, nombre, sexo, telefono, codAcceso, Convert.ToDouble(sueldo), credencial);
                    registroClienteProcedimiento.RegistrarAdministrador(registrar);
                    MessageBox.Show("Registro de administrador realizado con éxito");
                    Limpiar();
                     Program.principal.Hide();
                    InterfazCliente interfazCliente= new InterfazCliente();
                    interfazCliente.Show();
                }
            }
            catch(ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // El metodo validar realiza la validacion de cada uno de los textBox y se muestra la alerta del campo que falta completar
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
                if (valida.ValidarCodAcceso(txtAcceso.Text) != true)
                {
                    campo = false;
                    errorProvider1.SetError(txtAcceso, "Se esperaba 10 caracteres.");
                }
                if (valida.ValidarSueldo(txtSueldo.Text) != true)
                {
                    errorProvider1.SetError(txtSueldo, "Ingrese un monto de sueldo.");
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
                if (!campo)
                {
                     throw new ControlExcepcion("Datos no validos!");
                }

            return campo;
        }
        // El metodo Borrar alerta elimina las alertas una vez que se lleno bien la informacion en el textbox
        private void BorrarAlerta()
        {
            errorProvider1.SetError(txtCedula, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(txtAcceso, "");
            errorProvider1.SetError(txtSueldo, "");
            errorProvider1.SetError(cmbSexo, "");
            errorProvider1.SetError(txtCorreo, "");
            errorProvider1.SetError(txtContraseña, "");
        }

        // Metodo limpiar elimina los datos de los texbox una vez que se ingreso el registro
        public void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            cmbSexo.Text = null;
            txtTelefono.Clear();
            txtAcceso.Clear();
            txtSueldo.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
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

        // El evento valida que el textBox solo reciba numeros 
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }
        // El evento valida que el textBox solo reciba letras
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) &&
                 (e.KeyChar != Convert.ToChar(Keys.Space)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) && (e.KeyChar
               != Convert.ToChar(Keys.Space) && (e.KeyChar != '@' && (e.KeyChar != '.')) && !char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) && (e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtLicencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back))
                && (e.KeyChar  != Convert.ToChar(Keys.Space) && (e.KeyChar != '@' && (e.KeyChar != '.'))))
            {
                e.Handled = true;
                return;
            }
        }

        private void BotonParaMinimizarVentana_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
    }
}
