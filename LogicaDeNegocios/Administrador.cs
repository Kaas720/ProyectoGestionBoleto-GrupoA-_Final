
namespace LogicaDeNegocios.Modulo_de_cliente
{
   public class Administrador : Persona
    {
        
        private string correo;
        private string contrasena;
        private double sueldo;

        public Administrador() { }
        public Administrador(string cedula, string nombre, string sexo, string telefono, string correo,  string contrasena, double sueldo)
         :base(cedula, nombre, sexo, telefono)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            this.sueldo = sueldo;
        }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public override string ToString()
        {
            return base.ToString() + "Sueldo: " + sueldo + correo + contrasena;
        }
    }
}
