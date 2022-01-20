
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
    public partial class Principal_Usuario : Form
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
        // Se llama a la clase  ConsultasProcedimientos, para hacer uso de los metodos que contiene creamos una instacia llamada procedimientos
        ConsultasProcedimientos procedimientos = new ConsultasProcedimientos();
        public Principal_Usuario()
        {
            InitializeComponent();
            // Se llama al metodo LlenarCombos que obtine los datos almacenados en la base de datos
            procedimientos.LlenarCombos(cbOrigen, cbDestino);
        }
       
        private void btnComprar_Click(object sender, EventArgs e)
        {
            // Se llama al formulario para registrar nuevos clientes y la pantalla principal se la deja inviible
            RegistroCliente registroCliente = new RegistroCliente();
            registroCliente.Show();
            Program.principal.Hide();
        }
       
        // Se llama al metodo Exit para cerrar la aplicacion y se muestra un mensaje de alerta para confirmar el cierre de la aplicacion
        private void BotonCierreDeAplicacion_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }

        private void cbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                EliminarComboElementos();
                procedimientos.LlenarComboCooperativa(cbCooperativa,origen,Destino);
            }
        }
        private void cbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                EliminarComboElementos();
                procedimientos.LlenarComboCooperativa(cbCooperativa, origen, Destino);

            }
        }
        private bool Comprobar_combo_vacio()
        {
            bool bandera = false;
            if (!cbOrigen.SelectedIndex.Equals(-1) && !cbDestino.SelectedIndex.Equals(-1))
            {
                bandera = true;
            }
            return bandera;
        }
        private void EliminarComboElementos()
        {
                cbCooperativa.Items.Clear();
                DataGridInf.Rows.Clear();
        }
        // Se llama al formulario para realizar el inicio de sesion 
        private void BotonInicioSesion_Click(object sender, EventArgs e)
        {
            InicioSeccion iniciosesion = new InicioSeccion();
            iniciosesion.Show();
            Program.principal.Hide();
        }
        // Se crea el metodo para llenar la datagrid cuando los combobox no se encuentran vacios
        private void cbCooperativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validacion_Cooperativa() && Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                string cooperativa = cbCooperativa.Text;
                procedimientos.LLenarGrit(origen, Destino, cooperativa,DataGridInf);
                DataGridInf.ClearSelection();
            }
        }
        // Se crea el metodo para validar el combobox cooperativa que no se encuentre vacio 
        private bool Validacion_Cooperativa()
        {   
            if (!cbCooperativa.SelectedIndex.Equals(-1))
            {
                return true;
            }
            return false;
        }
        // Se realiza el metodo para minimizar la aplicacion 
        private void BotonParaMinimizarVentana_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        // Se llama al formulario Comprar en donde se realiza la validacion de que se seleccione datos del datagrid para que sean cargados 
        // en los textbox del formulario compra.
        private void BotonComprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (procedimientos.ValidarDataGridVacio(DataGridInf))
                {
                    int x = DataGridInf.CurrentCell.RowIndex;
                    string cooperativa = DataGridInf.Rows[x].Cells[0].Value.ToString();
                    string fecha_salida = DataGridInf.Rows[x].Cells[1].Value.ToString();
                    string horario_salida = DataGridInf.Rows[x].Cells[2].Value.ToString();
                    Comprar comprar = new Comprar(cooperativa, fecha_salida, horario_salida);
                    Program.principal.Hide();
                    comprar.Show();
                }
            }
            catch (ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

    }
}
