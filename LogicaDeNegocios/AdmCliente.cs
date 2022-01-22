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
     //  Cliente datos = new Regi();
        Conexion conexion = new Conexion();
        //List<Cliente> lista = null;
        //private static AdmCliente adm = null;
        //Cliente cliente = null;
        //Validacion v = new Validacion();

        //public List<Cliente> Lista { get => lista; set => lista = value; }

        //private AdmCliente()
        //{
        //    lista = new List<Cliente>();
        //}

        public void Inicializar(Guna2TextBox txtCedula, Guna2TextBox txtNombre, Guna2TextBox cmbSexo, Guna2TextBox txtTelefono, Guna2TextBox txtCorreo, Guna2TextBox txtContraseña, string cedula)
        {
            List<string> TraerInformacion = new List<string>();
            TraerInformacion = procedimientos.BuscarCliente(cedula);
          //  txtNombre.Text = TraerInformacion[0].ToString();
            txtNombre.Text = TraerInformacion[1].ToString();
            cmbSexo.Text = TraerInformacion[2].ToString();
            txtTelefono.Text = TraerInformacion[3].ToString();
            txtCorreo.Text = TraerInformacion[4].ToString();
            txtContraseña.Text = TraerInformacion[5].ToString();
        }

        //public static AdmCliente GetAdm()
        //{
        //    if (adm == null)
        //        adm = new AdmCliente();
        //    return adm;
        //}

        public string Modificar(string cedula, string telefono, string correo, string contrasena)
        {
            return procedimientos.ActualizarCliente(cedula, telefono, correo, contrasena);
        }

        //public int GetLista()
        //{
        //    return lista.Count;
        //}

        public void Guardar(Cliente cliente)
        {
            Cliente registrar = cliente;
            cliente.InsertarCliente(registrar);
        }
        public MySqlCommand ConectarProcedimiento(string Procedimientos, MySqlConnection mySqlConnection)
        {
            MySqlCommand mySqlCommand;
            mySqlCommand = new MySqlCommand(Procedimientos, mySqlConnection);
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            return mySqlCommand;
        }

    }
}
