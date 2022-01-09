
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

namespace Presentacion
{
    
    public partial class InicioSeccion : Form
    {
        ConsultaLogin consulta = new ConsultaLogin();
        public InicioSeccion()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string Usuario = NombreUsuario.Text;
            string password = Contrasenausuario.Text;
            int rol = Rol();
            if (ValidacionCamposVacios(Usuario, password, rol))
            {
                consulta.Login(Usuario, password, rol);
            }
            else
            {
                MessageBox.Show("Campos vacios");
            }
            
            
            
        }
        /*Metodo para validar si existen campos vacios*/
        private bool ValidacionCamposVacios(string usuario, string password, int rol)
        {
            bool bandera = false;
            if (!String.IsNullOrEmpty(usuario) && !String.IsNullOrEmpty(password) && rol!=0)
            {
                bandera = true;
            }
            return bandera;
        }

        /*Metodo para seleccionar el tipo de rol en el radio button*/
        private int Rol()
        {
            int rol = 0;
            if (RadioButtonAdministrador.Checked == true)
            {
                rol = 1;
            }
            if (RadioButtonChofer.Checked == true)
            {
                rol = 2;
            }
            if (RadioButtonCooperativa.Checked == true)
            {
                rol = 3;
            }
            if (RadioButtonCliente.Checked == true)
            {
                rol = 4;
            }
            return rol;
        }

        /*Metodo para la obtencion de la hora y fecha actual*/
        private void Fecha_Hora_Sistema_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
