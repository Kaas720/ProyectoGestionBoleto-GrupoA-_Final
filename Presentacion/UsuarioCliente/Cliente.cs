﻿using System;
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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Comprar obj = new Comprar();
            obj.ShowDialog();
        }

        private void BotonCierreDeAplicacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
