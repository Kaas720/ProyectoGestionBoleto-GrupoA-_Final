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



        ClsManejadorChofer M = new ClsManejadorChofer();

        /* Lucio Johann*/

        public  ClsChofer() {
        
        
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
            ClsParametroChofer coferp = new ClsParametroChofer();
            List<ClsParametroChofer> lst = new List<ClsParametroChofer>();
            string msj;
            try
            {

                coferp.Nombre = this.Nombre;
                coferp.Cedula = this.Cedula;
                coferp.Licencia = this.Licencia;
                coferp.Sexo = this.Sexo;
                coferp.Telefono = this.Telefono;
                coferp.Correo = this.Correo;
                coferp.Ciudad = this.Ciudad;
                coferp.Usuario = this.Usuario;
                coferp.Contraseña = this.Contraseña;
                coferp.IdCooperativa = this.IdCooperativa;
                
                coferp.Estado = this.Estado;


                //Pasar los parámetros hacia la capa de acceso a datos
                lst.Add(coferp);
                M.insertar_chofer(lst);


                msj = "Insertado correctamente";

            }
            catch (Exception ex)
            {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }


    }
}
