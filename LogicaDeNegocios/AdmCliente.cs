using Datos;
using Guna.UI2.WinForms;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    public class AdmCliente
    {
        Cliente procedimientos = new Cliente();
       
        public void Inicializar(Guna2TextBox txtCedula, Guna2TextBox txtNombre, Guna2TextBox cmbSexo, Guna2TextBox txtTelefono, Guna2TextBox txtCorreo, Guna2TextBox txtContraseña)
        {
             string cedula = txtCedula.Text;

            List<Cliente> client = procedimientos.BuscarCliente(cedula);
            List<Cliente> lista = new List<Cliente>();
           // lista.Add(client);
          //  txtNombre.Text = TraerInformacion[0].ToString();
            txtNombre.Text = lista[lista.Count -1].Nombre;
            cmbSexo.Text = lista[lista.Count - 1].Sexo;
            txtTelefono.Text = lista[lista.Count - 1].Telefono;
            txtCorreo.Text = lista[lista.Count - 1].Correo;
            txtContraseña.Text = lista[lista.Count - 1].Contrasena;
        }

      
        public string Modificar(string cedula, string telefono, string correo, string contrasena)
        {
            return procedimientos.ActualizarCliente(cedula, telefono, correo, contrasena);
        }
        public void Guardar(Cliente cliente)
        {
            Cliente registrar = cliente;
            cliente.InsertarCliente(registrar);
        }
      

    }
}
