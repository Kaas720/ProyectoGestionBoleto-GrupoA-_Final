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
            try
            {
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
            }
            catch (ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        private void ConsultarLoginBD(string correo, string password)
        {
            List<int> IdPeronsaAndRol2 = consulta.Login(correo, password);
            if (IdPeronsaAndRol2[0] != 0)
            {
                this.Close();
                switch (IdPeronsaAndRol2[0])
                {
                    case 1: 
                        VentanaAdministrador ventanaAdministrador = new VentanaAdministrador();
                        Program.principal.Hide();
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
            bool bandera;
            if (!String.IsNullOrEmpty(usuario) && !String.IsNullOrEmpty(password))
            {
                bandera = true;
            }
            else
            {
                throw new ControlExcepcion("Campos vacios");
            }
            return bandera;
        }
    }
}
