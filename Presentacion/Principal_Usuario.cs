
using FontAwesome.Sharp;
using LogicaDeNegocios;
using Presentacion.InicioFroms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal_Usuario : Form
    {
        ConsultasProcedimientos procedimientos = new ConsultasProcedimientos();
        ProcedimientosPaginaprincipal procedimiento = new ProcedimientosPaginaprincipal();
        /// <summary>
        /// Codigo para arrastrar la ventana a cualquier parte de la pantalla
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        IconButton iconButton;
        public Principal_Usuario()
        {
            InitializeComponent();
            IniciarFromPrinciapl();


        }
        private void IniciarFromPrinciapl()
        {
            BuscarBus Frm = new BuscarBus();
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            iconButton = BotonHome;
            iconButton.ForeColor = Color.Green;
            iconButton.IconColor = Color.Green;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            this.PanelContenedor.Controls.Clear();
            RegistroCliente Frm = new RegistroCliente();
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }
        private void GenerarNuevoColorBoton(object sender)
        {
            iconButton = (IconButton)sender;
            iconButton.IconColor = Color.Green;
            iconButton.ForeColor = Color.Green;
        }

        private void RestablecerColorOriginalBotones()
        {
            iconButton.IconColor = Color.White;
            iconButton.ForeColor = Color.White;

        }
        private void BotonHome_Click(object sender, EventArgs e)
        {
            this.PanelContenedor.Controls.Clear();
            BuscarBus Frm = new BuscarBus();
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }
        /*-------------------------------------------------------------------------------------------------------*/
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
        /// <summary>
        /// Se realiza el metodo para minimizar la aplicacion 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonParaMinimizarVentana_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BotonInicioSesion_Click_1(object sender, EventArgs e)
        {
            this.PanelContenedor.Controls.Clear();
            InicioSeccion Frm = new InicioSeccion();
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
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
        // Se crea el metodo para validar el combobox cooperativa que no se encuentre vacio 
        private bool Validacion_Cooperativa()
        {
            if (!cbCooperativa.SelectedIndex.Equals(-1))
            {
                return true;
            }
            return false;
        }


        // Se llama al formulario Comprar y se pasa los datos desde el fomulario principal que se selecciono desde la datagrid para que sean cargados 
        // en los textbox del formulario compra.
        private void DataGridInf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
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
        /// <summary>
        ///Se crea un evento llamado cbCooperativa_SelectedIndexChanged para llenar la datagrid cuando los combobox no se encuentran vacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
    }
}
