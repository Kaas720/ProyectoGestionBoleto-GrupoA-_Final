using LogicaDeNegocios.Modulo_de_cliente;
using System;
using System.Windows.Forms;

namespace Presentacion.UsarioCliente
{
    public partial class ActualizarCliente : Form
    {
        AdmCliente adm = AdmCliente.GetAdm();
        Validacion valida = new Validacion();
        string cedula;
        
        public ActualizarCliente(string cedula)
        {
            InitializeComponent();
            adm.Inicializar(txtCedula, txtNombre, Sexo, txtTelefono, txtCorreo, txtContraseña, cedula);
            this.cedula = cedula;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(), contrasena = txtContraseña.Text.Trim();
            if (!valida.EsVacioAc(telefono, correo,contrasena))
            {
                MessageBox.Show(adm.Modificar(cedula, telefono, correo, contrasena));
                this.Close();
            }
            else
            {
                MessageBox.Show("Existe un campo vacio");
            }
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
