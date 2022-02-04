using LogicaDeNegocios;
using Presentacion.UsuarioCliente;
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
    public partial class InterfazCliente : Form
    {
        // Se llama al clase ConsultasProcedimientos  y se crea el objeto procedimientos  para llamar a los metodos que contiene
        ConsultasProcedimientos procedimientos = new ConsultasProcedimientos();
        public InterfazCliente()
        {
            InitializeComponent();
            procedimientos.LlenarCombos(cbOrigen, cbDestino);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Comprar obj = new Comprar();
            // obj.ShowDialog();
        }

        /* Se crea el evento cbOrigen_SelectedIndexChanged para validar el combobox de lugar de origen no se encuentre vacio
         si esta vacio se llama al metodo LlenarComboCooperativa que permite obtener informacion desde la base de datos para
        seleccionar un dato especifico dentro de cada combobox tambien se llama al metodo  EliminarComboElementos() los datos */
        private void cbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                EliminarComboElementos();
                procedimientos.LlenarComboCooperativa(cbCooperativa, origen, Destino);
            }
        }

        /* Se crea el evento cbDestino_SelectedIndexChanged para validar el combobox de lugar de destino no se encuentre vacio
          si esta vacio se llama al metodo LlenarComboCooperativa que permite obtener informacion desde la base de datos para
          seleccionar un dato especifico dentro de cada combobox tambien se llama al metodo  EliminarComboElementos() los datos seleccionados*/
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

        // Se crea el metodo comprobar_combo_vacio si el combobox tiene seleccionado un iten se queda cargado dentro del combo
        private bool Comprobar_combo_vacio()
            {
                bool bandera = false;
                if (!cbOrigen.SelectedIndex.Equals(-1) && !cbDestino.SelectedIndex.Equals(-1))
                {
                    bandera = true;
                }
                return bandera;
            }

        // Se crea el metodo EliminarComboElemento para limpiar los datos cargados en la datagrid y el combobox de cooperativa
        private void EliminarComboElementos()
            {
                cbCooperativa.Items.Clear();
                DataGridInf.Rows.Clear();
            }

        // Se realiza el metodo para minimizar la aplicacion 
        private void BotonParaMinimizarVentana_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Se crea un evnto llamado cbCooperativa_SelectedIndexChanged para llenar la datagrid cuando los combobox no se encuentran vacios
        private void cbCooperativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validacion_Cooperativa() && Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                string cooperativa = cbCooperativa.Text;
                procedimientos.LLenarGrit(origen, Destino, cooperativa, DataGridInf);
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

        // Se llama al metodo Exit para cerrar la aplicacion y se muestra un mensaje de alerta para confirmar el cierre de la aplicacion
        private void BotonCierreDeAplicacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Principal_Usuario pricipal = new Principal_Usuario();
                pricipal.Show();
               
            }

        }

        // Se realiza el evento tick para mostrar la fecha y hora actual en el sistema
        private void timer1_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string cedula = "";
            this.Hide();
            ActualizarCliente objeto = new ActualizarCliente(cedula);
            objeto.Show();
        }
    }
}
