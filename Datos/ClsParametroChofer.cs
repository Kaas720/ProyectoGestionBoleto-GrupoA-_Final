using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClsParametroChofer
    {

        private String cedula;
        private String nombre;
        private String licencia;
        private String sexo;
        private String telefono;
        private String correo;
        private String ciudad;
        private String usuario;
        private String contraseña;
        private Int16 idCooperativa;
        private String estado;


        public ClsParametroChofer() {}
        public ClsParametroChofer(String cedula, String nombre, String sexo, String telefono, String correo, String ciudad, String usuario, String contraseña, String licencia, Int16 idCooperativa, String estado) 
        {

            this.cedula = cedula;
            this.nombre = nombre;
            this.sexo = sexo;
            this.telefono = telefono;
            this.ciudad = ciudad;
            this.correo = correo;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.licencia = licencia;
            this.idCooperativa = idCooperativa;
            this.estado = estado;
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

        public String Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
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

        public Int16 IdCooperativa
        {
            get { return idCooperativa; }
            set { idCooperativa = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
