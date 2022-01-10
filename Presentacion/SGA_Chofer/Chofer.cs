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
    public partial class Chofer : Form
    {
        ClsChofer chofer = new ClsChofer();

        public Chofer()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            try
            {

                int resultado = chofer.actualizar_x_cedula( txtcedula.Text, txtnombre.Text, txtlicencia.Text, txtsexo.Text, Int16.Parse(txttelefono.Text), txtcorreo.Text, txtusuario.Text, txtcontraseña.Text);
                if (resultado == 0)
                {
                    MessageBox.Show("Los datos se actualizon correctamente");
                    this.Close();
 

                }
                if (resultado == 1)
                {

                    MessageBox.Show("Error en la actualizacion");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
