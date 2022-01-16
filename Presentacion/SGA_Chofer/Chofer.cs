using LogicaDeNegocios.Modulo_de_chofer;
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

namespace Presentacion.SGA_Chofer
{
    public partial class Chofer : Form
    {

        /*Codigo para arrastrar la ventana a cualquier parte de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        ClsChofer chofer = new ClsChofer();
      
        public Chofer()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            try
            {

                int resultado = chofer.actualizar_x_cedula( txtcedula.Text, txtnombre.Text, txtlicencia.Text, txtsexo.Text, txttelefono.Text, txtcorreo.Text, txtciudad.Text,  txtusuario.Text, txtcontraseña.Text, Int16.Parse(CmbBoxCo.Text), CmbBoxEs.Text);
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

        private void BotonCierreDeAplicacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BotonParaMinimizarVentana_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Fecha_Hora_Sistema_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }

        private void PanelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Chofer_Load(object sender, EventArgs e)
        {

        }
    }
}
