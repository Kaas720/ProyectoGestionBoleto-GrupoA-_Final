using LogicaDeNegocios;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Presentacion.UsuarioCliente
{ 
    public partial class ActualizarCliente : Form
    {
        AdmClienteProcedimiento adm = new AdmClienteProcedimiento();
        Validacion valida = new Validacion();
       private string cedula =null;

      
        public ActualizarCliente(string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            adm.Inicializar(txtCedula, txtNombre, Sexo, txtTelefono, txtCorreo, txtContraseña);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), nombre= txtNombre.Text, sexo = Sexo.Text, telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(), contrasena = txtContraseña.Text.Trim();
            BorrarAlerta();

            if (validar())
            {
                adm.Modificar(cedula,nombre, sexo, telefono, correo, contrasena);
                MessageBox.Show("Datos actualizados con exito.");
                Limpiar();
               // this.Hide();
            }
            else
            {
                MessageBox.Show("Existe un campo vacio");
            }
        }
        private bool validar()
        {
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
                if (Sexo.Text =="")
                {
                    campo = false;
                    errorProvider1.SetError(Sexo, "Selecione un tipo de genero.");
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

                if (!campo)
                {
                    throw new ControlExcepcion("Datos no validos!");
                }
                return campo;
        }
        private void BorrarAlerta()
        {
            errorProvider1.SetError(txtCedula, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtTelefono, "");
        }
        public void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
        }

        private void ActualizarCliente_Shown(object sender, EventArgs e)
        {
            txtCedula.Text = cedula;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
