﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Modulo_de_cliente
{
    public class AdmCliente
    {
        List<Cliente> lista = null;
        private static AdmCliente adm = null;
        Cliente c = null;
        Validacion v = new Validacion();

        public List<Cliente> Lista { get => lista; set => lista = value; }

        private AdmCliente()
        {
            lista = new List<Cliente>();
        }

        public static AdmCliente GetAdm()
        {
            if (adm == null)
                adm = new AdmCliente();
            return adm;
        }

        public int GetLista()
        {
            return lista.Count;
        }

        public bool Vacio(string cedula, string nombre, string sexo, string telefono, string correo, string ciudad, string usuario, string contraseña)
        {
            bool x = false;
            if(string.IsNullOrEmpty(cedula.Trim())||string.IsNullOrEmpty(nombre.Trim())||string.IsNullOrEmpty(sexo.Trim())||
                string.IsNullOrEmpty(telefono.Trim())||string.IsNullOrEmpty(correo.Trim())||string.IsNullOrEmpty(ciudad.Trim())||
                string.IsNullOrEmpty(usuario.Trim()) || string.IsNullOrEmpty(contraseña.Trim()))
            {
                x = true;
            }
            return x;
        }

        public string Guardar(string cedula, string nombre, string sexo, string telefono, string correo, string ciudad, string usuario, string contraseña)
        {
            string x = "No se creo el objeto";
            c = new Cliente(cedula, nombre, sexo, telefono, correo, ciudad, usuario, contraseña);
            x = c.ToString();
            lista.Add(c);
            return x;
        }

        public void Limpiar(Guna2TextBox txtCedula, Guna2TextBox txtNombre, Guna2ComboBox cmbSexo, Guna2TextBox txtTelefono, Guna2TextBox txtCorreo, Guna2TextBox txtCiudad, Guna2TextBox txtUsuario, Guna2TextBox txtContraseña)
        {
            txtCedula.Clear();
            txtNombre.Clear();
            cmbSexo.Text = null;
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtCiudad.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
        }
    }
}
