using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClsParametroChofer
    {

        private string cedula;
        private String nombre;
        private String licencia;
        private String sexo;
        private String telefono;
        private String correo;
        private String usuario;
        private String contraseña;


        public ClsParametroChofer() {}
        public ClsParametroChofer(string cedula, string nombre, string licencia, string sexo, string telefono, string correo, string usuario, string contraseña)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.licencia = licencia;
            this.sexo = sexo;
            this.telefono = telefono;
            this.correo = correo;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }

        //Getter and Setter fields
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Licencia
        {
            get { return licencia; }
            set { licencia = value; }
        }

        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }


        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public String Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

    }
}
