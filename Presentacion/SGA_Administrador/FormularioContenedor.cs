using Presentacion.SGA_Administrador;
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
    public partial class FormularioContenedor : Form
    {
        public FormularioContenedor()
        {
            InitializeComponent();
            RegistrarClienteporAdmin Frm = new RegistrarClienteporAdmin();
            Frm.TopLevel = false;
            PanelRegistro.Controls.Add(Frm);
            Frm.Show();
        }
    }
}
