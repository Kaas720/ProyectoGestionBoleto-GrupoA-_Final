﻿using LogicaDeNegocios;
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
    public partial class Reorte : Form
    {
        AdmReporte admReporte = new AdmReporte();
        public Reorte()
        {
            InitializeComponent();
            admReporte.LlenarDatagridReporte(DataGridReporte,0, "");
        }

        private void boxCooperativa_CheckedChanged(object sender, EventArgs e)
        {
            txtDato.PlaceholderText = "Ingresar la cooperativa";
        }

        private void boxFecha_CheckedChanged(object sender, EventArgs e)
        {
            txtDato.PlaceholderText = "Ingresar la fecha de compra";
        }

        private void bocCedula_CheckedChanged(object sender, EventArgs e)
        {
            txtDato.PlaceholderText = "Ingresar la cédula";
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                admReporte.LlenarDatagridReporte(DataGridReporte, DarValorCombo(),txtDato.Text);
            }
            catch
            {

            }           
        }

        private int DarValorCombo()
        {
            if (boxFecha.Checked == true)
            {
                return 1;
            }
            if (boxCooperativa.Checked == true)
            {
                return 2;
            }
            if (bocCedula.Checked == true)
            {
                return 3;
            }
            return 0;
        }
    }
}
