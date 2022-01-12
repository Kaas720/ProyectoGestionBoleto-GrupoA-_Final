
using LogicaDeNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    
    public partial class InicioSeccion : Form
    {
        /*Codigo para arrastrar la ventana a cualquier parte de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /*--------------------------------------------------------------------*/
        ConsultasProcedimientos consulta = new ConsultasProcedimientos();
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
                try
                {
                    ConsultarLoginBD(Usuario, password, rol);
                }
                catch (ControlExcepcion ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NombreUsuario.Text = null;
                    Contrasenausuario.Text = null;
                }       
            }
            else
            {
                MessageBox.Show("Campos vacios");
            }  
        }
        /*Metodo para consultar en la bd y de respuesta*/
        private void ConsultarLoginBD(string usuario, string password, int rol)
        {
            if(consulta.Login(usuario, password, rol))
            {
                
                switch (rol)
                {
                    case 1: 
                        VentanaAdministrador ventanaAdministrador = new VentanaAdministrador();
                        ventanaAdministrador.ShowDialog();
                        break;
                    case 2:
                        VentanaAdministrador v = new VentanaAdministrador();
                        v.ShowDialog();
                        break;
                    case 3:
                        VentanaAdministrador c = new VentanaAdministrador();
                        c.ShowDialog();
                        break;
                    case 4:
                        VentanaAdministrador cs = new VentanaAdministrador();
                        cs.ShowDialog();
                        Console.WriteLine("4");
                        break;
                }
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

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.principal.Show();
        }
    }
}
