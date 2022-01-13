using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using LogicaDeNegocios.RegistroDB;
using MySqlConnector;

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
            txtTelefono.Text = TraerInformacion[2].ToString();
            cmbSexo.Text = TraerInformacion[1].ToString();
            txtTelefono.Text = TraerInformacion[2].ToString();
            txtUsuario.Text = TraerInformacion[3].ToString();
        }

        public static AdmCliente GetAdm()
        {
            if (adm == null)
                adm = new AdmCliente();
            return adm;
        }

        public void Modificar(string telefono, string ciudad, string cedula)
        {
            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Cedula.CompareTo(cedula) == 0)
                {
                    lista[i].Telefono = telefono;
                    lista[i].Ciudad = ciudad;
                }
            }
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
            cliente = new Cliente(cedula, nombre, sexo, telefono, correo, ciudad, usuario, contraseña);
            datos.InsertarCliente(cliente);
            x = cliente.ToString();
            lista.Add(cliente);
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
        public MySqlConnection Conectar()
        {
           MySqlConnection conectado = new MySqlConnection();
            conexion.conectar();
            return conectado;
        }
    }
}
