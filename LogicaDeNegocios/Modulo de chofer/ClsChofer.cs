using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Modulo_de_chofer
{
    public class ClsChofer: Persona
    {
        

        private String licencia;
        private Int16 idCooperativa;
        private String estado;



        ClsManejador M = new ClsManejador();

        /* Lucio Johann*/

        public  ClsChofer() {
        
        
        }

        public ClsChofer(String cedula, String nombre, String sexo, String telefono, String correo, String ciudad, String usuario, String contraseña, String licencia, Int16 idCooperativa, String estado) : base(cedula, nombre, sexo, telefono, correo, ciudad, usuario, contraseña)
        {
           
            this.licencia = licencia;
            this.idCooperativa = idCooperativa;
            this.estado = estado;
        }
   

        public String Licencia
        {
            get { return licencia; }
            set { licencia = value; }
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



        public int actualizar_x_cedula(String cedula, String nombre, String sexo, String telefono, String correo, String ciudad, String usuario, String contraseña, String licencia, Int16 idCooperativa, String estado)
        {
            return M.actualizar_chofer_individual(cedula, nombre, licencia, sexo, telefono, correo,ciudad, usuario, contraseña, idCooperativa, estado);
        }

        /* Lucio Johann*/
        public override string registrar()
        {
            string msj;

            List<ClsParametroChofer> lst = new List<ClsParametroChofer>();
            lst.Add(new ClsParametroChofer(Cedula, Nombre, Licencia, Sexo, Telefono, Correo, Ciudad,Usuario, Contraseña, IdCooperativa, Estado));
            msj = M.insertar(lst);
            return msj;
        }
    }
}
