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

namespace Presentacion.SGA_Administrador
{
    public partial class RegistrarClienteporAdmin : Form
    {
        private string cedula;
        AdmClienteProcedimiento registroClienteProcedimiento = new AdmClienteProcedimiento();
        public RegistrarClienteporAdmin()
        {
            InitializeComponent();
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), nombre = txtNombre.Text.Trim(), sexo = cmbSexo.Text.Trim(),
                telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(),
                contraseña = txtContraseña.Text.Trim();
            BorrarAlerta();
            try
            {
                if (validar())
                {
                    Cliente cliente = new Cliente(cedula, nombre, sexo, telefono, correo, contraseña);
                    registroClienteProcedimiento.RegistrarCliente(cliente);
                    MessageBox.Show("Registro realizado con exito");
                    Limpiar();         
                }
            }
            catch (ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
