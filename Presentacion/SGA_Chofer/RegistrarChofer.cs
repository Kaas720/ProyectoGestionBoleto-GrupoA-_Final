using LogicaDeNegocios.Modulo_de_chofer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.SGA_Chofer
{
    public partial class RegistrarChofer : Form
    {
        ClsChofer ch = new ClsChofer();
        public RegistrarChofer()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {

                ch.Cedula = txtcedula.Text;
                ch.Nombre = txtnombre.Text;
                ch.Licencia = txtlicencia.Text;
                ch.Sexo = txtsexo.Text;
                ch.Telefono = txttelefono.Text;
                ch.Correo = txtcorreo.Text
                ch.Usuario = txtusuario.Text;
                ch.Contraseña = txtcontraseña.Text;

               /* if (this.rutaImagen == null)
                {

                    cl.RutaImagen = Path.Combine(Environment.CurrentDirectory, "..\\..\\default.png");

                }
                else
                {
                    cl.RutaImagen = this.rutaImagen;
                }*/
                MessageBox.Show(ch.registrar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar, verifique que todos los datos sean ingresados.");
            }
        }
    }
}
