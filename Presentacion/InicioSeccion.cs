using LogicaDeNegocios;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{  
    public partial class InicioSeccion : Form
    {
        ConsultasProcedimientos consulta = new ConsultasProcedimientos();
        public InicioSeccion()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string Usuario = NombreUsuario.Text;
            string password = Contrasenausuario.Text;
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
        private void ConsultarLoginBD(string correo, string password)
        {
            List<int> IdPeronsaAndRol = consulta.Login(correo, password);
            int roll = IdPeronsaAndRol[0];
            if ( roll != 0)
            {
                this.Close();
                switch (roll)
                {
                    case 1: 
                        VentanaAdministrador ventanaAdministrador = new VentanaAdministrador();
                        Program.principal.Hide();
                        ventanaAdministrador.ShowDialog();
                        break;
                    case 2:
                        VentanaAdministrador v = new VentanaAdministrador();
                        Program.principal.Hide();
                        v.ShowDialog();
                        break;
                    case 3:
                        VentanaAdministrador c = new VentanaAdministrador();
                        Program.principal.Hide();
                        c.ShowDialog();
                        break;
                    case 4:
                        InterfazCliente cs = new InterfazCliente(2);
                        Program.principal.Hide();
                        cs.ShowDialog();
                        //Console.WriteLine("4");
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
    }
}
