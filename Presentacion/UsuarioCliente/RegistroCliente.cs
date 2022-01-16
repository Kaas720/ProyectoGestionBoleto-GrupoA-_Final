
using LogicaDeNegocios.Modulo_de_cliente;
using Presentacion.UsarioCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Presentacion
{
    public partial class RegistroCliente : Form
    {
        AdmCliente adm = AdmCliente.GetAdm();
        Validacion valida = new Validacion();
        private string cedula;

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

            Cliente obj = new Cliente(cedula);
            obj.Show();
            this.Hide();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), nombre = txtNombre.Text.Trim(), sexo = cmbSexo.Text.Trim(),
                telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(), ciudad = txtCiudad.Text.Trim(),
                usuario = txtUsuario.Text.Trim(), contraseña = txtContraseña.Text.Trim();
            string contenido = "";
            if (!EsVacio())
            {
               contenido = adm.Guardar(cedula, nombre, sexo, telefono, correo, ciudad, usuario, contraseña);
                int n = dgvCliente.Rows.Add();
                dgvCliente.Rows[n].Cells[0].Value = txtCedula.Text;
                dgvCliente.Rows[n].Cells[1].Value = txtNombre.Text;
                dgvCliente.Rows[n].Cells[2].Value = cmbSexo.Text;
                dgvCliente.Rows[n].Cells[3].Value = txtTelefono.Text;
                dgvCliente.Rows[n].Cells[4].Value = txtCorreo.Text;
                dgvCliente.Rows[n].Cells[5].Value = txtCiudad.Text;
                dgvCliente.Rows[n].Cells[6].Value = txtUsuario.Text;
                dgvCliente.Rows[n].Cells[7].Value = txtContraseña.Text;
                Limpiar();
                this.Hide();
                Cliente ob = new Cliente(cedula);
                ob.Show();
            }
            else
            {
                MessageBox.Show("Existen campos vacios");
            }
        }
        public bool EsVacio()
        {
            bool campo = false;
            if (valida.ValidarCedula(txtCedula.Text) != true || string.IsNullOrEmpty(txtNombre.Text) || (string.IsNullOrEmpty(cmbSexo.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtCiudad.Text) ||
                string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text)))
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
            txtCiudad.Clear();
            txtUsuario.Clear();
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Usuario principal = new Principal_Usuario();
            principal.Show();
            this.Dispose();
        }

    }
}
