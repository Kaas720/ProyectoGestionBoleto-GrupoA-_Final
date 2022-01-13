using LogicaDeNegocios.Modulo_de_cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.UsuarioCliente
{
    public partial class ActualizarCliente : Form
    {
        AdmCliente adm = AdmCliente.GetAdm();
        Validacion v = new Validacion();
        string cedula;
        
        public ActualizarCliente(string cedula)
        {
            InitializeComponent();
            adm.Inicializar(txtCedula, txtNombre, Sexo, txtTelefono, txtCorreo, txtCiudad, 
                txtUsuario, txtContraseña, cedula);
            this.cedula = cedula;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(), usuario = txtUsuario.Text.Trim(), contrasena = txtContraseña.Text.Trim();
            if (!v.EsVacioAc(telefono, correo, usuario, contrasena))
            {
                MessageBox.Show(adm.Modificar(cedula, telefono, correo, usuario, contrasena));
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
