using Datos;
using Guna.UI2.WinForms;
using LogicaDeNegocios.RegistroDB;
using System.Collections.Generic;

namespace LogicaDeNegocios.Modulo_de_cliente
{
    public class AdmCliente
    {
        Procedimientos procedimientos = new Procedimientos();
        RegistroCliente datos = new RegistroCliente();
        Conexion conexion = new Conexion();
        List<Cliente> lista = null;
        private static AdmCliente adm = null;
        Cliente cliente = null;
        Validacion v = new Validacion();

        public List<Cliente> Lista { get => lista; set => lista = value; }

        private AdmCliente()
        {
            lista = new List<Cliente>();
        }

        public void Inicializar(Guna2TextBox txtCedula, Guna2TextBox txtNombre, Guna2TextBox cmbSexo, Guna2TextBox txtTelefono, Guna2TextBox txtCorreo, Guna2TextBox txtCiudad, Guna2TextBox txtUsuario, Guna2TextBox txtContraseña, string cedula)
        {
            List<string> TraerInformacion = new List<string>();
            TraerInformacion = procedimientos.BuscarCliente(cedula);
            txtNombre.Text = TraerInformacion[0].ToString();
            cmbSexo.Text = TraerInformacion[1].ToString();
            txtCiudad.Text = TraerInformacion[4].ToString();
        }

        public static AdmCliente GetAdm()
        {
            if (adm == null)
                adm = new AdmCliente();
            return adm;
        }

        public string Modificar(string cedula, string telefono, string correo, string usuario, 
            string contrasena)
        {
            return procedimientos.ActualizarCliente(cedula, telefono, correo, usuario, contrasena);
        }

        public int GetLista()
        {
            return lista.Count;
        }

        public string Guardar(string cedula, string nombre, string sexo, string telefono, string correo, string ciudad, string usuario, string contraseña)
        {
            string x = "No se creo el objeto";
            cliente = new Cliente(cedula, nombre, sexo, telefono, correo, ciudad, usuario, contraseña);
           datos.InsertarCliente(cliente);
            x = cliente.ToString();
            lista.Add(cliente);
            return x;
        }

    }
}
