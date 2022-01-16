using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Modulo_de_cliente
{
    public class Cliente :Usuarios
    {
        private string usuario;
        private string contraseña;

        public Cliente() { }
        public Cliente(string cedula, string nombre, string sexo, string telefono, string correo, string ciudad, string usuario, string contraseña)
        :base(cedula, nombre, sexo, telefono, correo, ciudad)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        /* public Cliente(string cedula, string nombre, string sexo, string telefono, string correo, string ciudad, string usuario, string contraseña) : base(cedula, nombre, sexo, telefono, correo, ciudad, usuario, contraseña)
         {
         }

         public Cliente(string cedula, string nombre, string sexo, string telefono, string correo, string ciudad, string usuario, string contraseña, int idCliente)
          : base(cedula, nombre, sexo, telefono, correo, ciudad,  usuario, contraseña)
         {
           this.idCliente = idCliente;

         }

         public int IdCliente { get => idCliente; set => idCliente = value; }*/

        public override string ToString() {
         return base.ToString() + "Usuario: " + usuario + "Contraseña: " + contraseña;
     }
    }
}
