using LogicaDeNegocios;
using System;
using System.Runtime.InteropServices;
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
        // Se llama al clase  ConsultasProcedimientos y se crea el objeto consulta para llamar a los metodos que contiene
        ConsultasProcedimientos consulta = new ConsultasProcedimientos();
        public InicioSeccion()
        {
            InitializeComponent();
        }

        // Se realiza la validacion de las credenciales que son ingresadas por los usuarios dentro del sistema al realizar el inicio de sesion
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string Usuario = NombreUsuario.Text;
            string password = Contrasenausuario.Text;
            int rol = Rol();
            if (ValidacionCamposVacios(Usuario, password))
            {
             // Se hace uso del control de excepciones conde se llama a la clase ControlExcepcion, si el usuario no ingresa las credenciales 
                try
                {
                    ConsultarLoginBD(Usuario, password);
                }
                catch (ControlExcepcion ex)
                {
            // Se envia un aviso indicando que sus credenciales no son las correctas
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NombreUsuario.Text = null;
                    Contrasenausuario.Text = null;
                }       
            }
            else
            // en caso de querer ingresar sin ingresar ningun dato se mostrara el siguiente mensaje
            {
                MessageBox.Show("Campos vacios");
            }  
        }

        /*Metodo ConsultarLoginBD recibe como parametro correo, password y rol para consultar en la base dedatos el rol de cada 
         usuario y validar sus credenciales*/
        private void ConsultarLoginBD(string correo, string password)
        {
            int result = consulta.Login(correo, password);
            if (result != 0)
            {
                this.Close();
                switch (result)
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
        private bool ValidacionCamposVacios(string usuario, string password)
        {
            bool bandera = false;
            if (!String.IsNullOrEmpty(usuario) && !String.IsNullOrEmpty(password))
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

       // Se llama al metodo Exit para cerrar la aplicacion y se muestra un mensaje de alerta para confirmar el cierre de la aplicacion
        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Se realiza el metodo para minimizar la aplicacion 
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       // Se llama al metodo Close() para cerrar el formulario login y mostrar el formulario principal
        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.principal.Show();
        }
    }
}
