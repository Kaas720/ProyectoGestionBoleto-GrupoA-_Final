
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

namespace Presentacion
{
    
    public partial class InicioSeccion : Form
    {
        ConsultaLogin consulta = new ConsultaLogin();
        public InicioSeccion()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string Usuario = NombreUsuario.Text;
            string password = Contrasenausuario.Text; 
            consulta.Login(Usuario,password);
            
            
        }

        private void Fecha_Hora_Sistema_Tick(object sender, EventArgs e)
        {

            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
