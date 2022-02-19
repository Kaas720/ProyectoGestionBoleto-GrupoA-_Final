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
    public partial class PerfilAdminidtrador : Form
    {
        AdmAdministrador admAdministrador = new AdmAdministrador();
        public PerfilAdminidtrador(int idPersona)
        {
            InitializeComponent();
            LlenarInformacion(idPersona);
        }

        private void LlenarInformacion(int idPersona)
        {
            List<Administrador> Admin = admAdministrador.ConsultaAdmin(idPersona);
            if (Admin.Count==0)
            {
                MessageBox.Show("NO HAY OBJETO");
            }
            else
            {
                MessageBox.Show("si HAY OBJETO");
            }
            foreach(Administrador admin in Admin)
            {
                Console.WriteLine("HOLA" + admin.Cedula);
            }
            
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
