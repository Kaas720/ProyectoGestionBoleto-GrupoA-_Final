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
            adm.Inicializar(txtCedula, txtNombre, cmbSexo, txtTelefono, txtCorreo, txtCiudad, txtUsuario, txtContraseña, cedula);
            this.cedula = cedula;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text.Trim(), ciudad = txtCiudad.Text.Trim();
            if (!v.EsVacioAc(telefono, ciudad))
            {
                adm.Modificar(cedula, telefono, ciudad);
                MessageBox.Show("Datos actualizados correctamente");
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
    }
}
