﻿using LogicaDeNegocios.Modulo_de_cliente;
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
    public partial class RegistroCliente : Form
    {
        AdmCliente adm = AdmCliente.GetAdm();
        Validacion v = new Validacion();
        private string cedula;

        public RegistroCliente(string cedula)
        {
            this.cedula = cedula;
        }

        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            Cliente obj = new Cliente(cedula);
            obj.Show();
            this.Hide();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           // int id = 0;
            string cedula = txtCedula.Text.Trim(), nombre = txtNombre.Text.Trim(), sexo = cmbSexo.Text.Trim(),
                telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(), ciudad = txtCiudad.Text.Trim(),
                usuario = txtUsuario.Text.Trim(), contraseña = txtContraseña.Text.Trim();
            string contenido = "";
            contenido = (cedula + nombre + sexo+ telefono+ correo+ ciudad+ usuario+ contraseña);
            //{
                bool existe = v.ValidarCedula(cedula);
                if (existe == false)
                {
                    return;
                }
                else
                {
                   contenido = adm.Guardar(cedula, nombre, sexo, telefono, correo, ciudad, usuario, contraseña);
                    int n = dgvCliente.Rows.Add();
                    dgvCliente.Rows[n].Cells[0].Value = txtCedula.Text;
                    dgvCliente.Rows[n].Cells[1].Value = txtNombre.Text;
                    dgvCliente.Rows[n].Cells[2].Value = cmbSexo.Text;
                    dgvCliente.Rows[n].Cells[3].Value = txtTelefono.Text;
                    dgvCliente.Rows[n].Cells[4].Value = txtCorreo.Text;
                    dgvCliente.Rows[n].Cells[5].Value = txtCiudad.Text;
                    dgvCliente.Rows[n].Cells[6].Value = txtUsuario.Text;
                    dgvCliente.Rows[n].Cells[7].Value = txtContraseña.Text;
                    adm.Limpiar(txtCedula, txtNombre, cmbSexo, txtTelefono, txtCorreo, txtCiudad, txtUsuario, txtContraseña);
                this.Hide();
                Cliente ob = new Cliente(cedula);
                    ob.Show();
                
                }
           
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Usuario principal = new Principal_Usuario();
            principal.Show();
            this.Dispose();
        }
    }
}
