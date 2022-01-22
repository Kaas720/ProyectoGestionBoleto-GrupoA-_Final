using LogicaDeNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.SGA_Administrador
{
    public partial class EliminarClienteporAdmin : Form
    {
        AdmClienteProcedimiento admClienteProcedimiento = new AdmClienteProcedimiento();
        public EliminarClienteporAdmin()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            string cedula = TxtCedulaCliente.Text;
            try
            {
                Cliente client = admClienteProcedimiento.ConsultarCliente(cedula);
                List<Cliente> listaCliente = new List<Cliente>();
                listaCliente.Add(client);
                foreach (Cliente c in listaCliente)
                {
                    Console.WriteLine(client.Cedula+ client.Nombre+ client.Correo+"//////////////////");
                    DataGridCliente.Rows.Add(1);
                    DataGridCliente.Rows[0].Cells[0].Value = client.Cedula.ToString();
                    DataGridCliente.Rows[0].Cells[1].Value = client.Nombre.ToString();
                    DataGridCliente.Rows[0].Cells[2].Value = client.Correo.ToString();
                    DataGridCliente.Rows[0].Cells[3].Value = "Eliminar";
                }  
            }
            catch (ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
