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
        private int idChofer;
        private String licencia;
        private Double sueldo;




        ClsManejador M = new ClsManejador();

        /* Lucio Johann*/

        public  ClsChofer() {}

        public ClsChofer(string cedula, string nombre, string sexo, string telefono, string correo, string ciudad, string usuario, string contraseña, int idChofer, string Licencia, double Sueldo)
         : base(cedula, nombre, sexo, telefono, correo, ciudad, usuario, contraseña)
        {
            this.idChofer = idChofer;
            this.Licencia = Licencia;
            this.sueldo = Sueldo;

        }
        public int IdChofer
        {
            get { return idChofer; }
            set { idChofer = value; }
        }

        public String Licencia
        {
            get { return licencia; }
            set { licencia = value; }
        }

        public Double Sueldo
        {
            get { return sueldo; }
            set { sueldo= value; }
        }



        public int actualizar_x_cedula(string cedula, String nombre, String licencia, String sexo, Int16 telefono, String correo, String usuario, String contraseña)
        {
            return M.actualizar_chofer_individual(cedula, nombre, licencia, sexo, telefono, correo, usuario, contraseña);
        }

        /* Lucio Johann*/
        public override string registrar()
        {
            string msj;

            List<ClsParametroChofer> lst = new List<ClsParametroChofer>();
            lst.Add(new ClsParametroChofer(Cedula, Nombre, Licencia, Sexo, Telefono, Correo,Usuario, Contraseña));
            msj = M.insertar(lst);
            return msj;
        }
    }
}
