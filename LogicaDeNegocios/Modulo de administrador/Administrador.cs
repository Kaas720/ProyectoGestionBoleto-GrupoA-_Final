
namespace LogicaDeNegocios.Modulo_de_cliente
{
   public class Administrador : Usuarios
    {
        
        private string usuario;
        private string contraseña;
        private double sueldo;

        public Administrador() { }
        public Administrador(string cedula, string nombre, string sexo, string telefono, string correo, string ciudad, string usuario, string contraseña, double sueldo)
         :base(cedula, nombre, sexo, telefono, correo, ciudad)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.sueldo = sueldo;
        }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public override string ToString()
        {
            return base.ToString() + "Sueldo: " + sueldo + usuario + contraseña;
        }
    }
}
