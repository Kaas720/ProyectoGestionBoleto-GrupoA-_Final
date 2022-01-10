using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Modulo_de_chofer
{
    public class ClsChofer
    {
        private string cedula;
        private String nombre;
        private String licencia;
        private String sexo;
        private Int16 telefono;
        private String correo;
        private String usuario;
        private String contraseña;

        ClsManejador M = new ClsManejador();

        public ClsChofer(string cedula, string nombre, string licencia, string sexo, Int16 telefono, string correo, string usuario, string contraseña)
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
        public ClsChofer() { }


        public int actualizar_x_cedula(string cedula, String nombre, String licencia, String sexo, Int16 telefono, String correo, String usuario, String contraseña)
        {
            return M.actualizar_chofer_individual(cedula, nombre, licencia, sexo, telefono, correo, usuario, contraseña);
        }


    }
}
