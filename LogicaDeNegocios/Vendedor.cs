
namespace LogicaDeNegocios.Modulo_de_vendedor
{
    public class Vendedor: Persona
    {
        private string correo;
        private string contrasena;
        private double sueldo;

        public Vendedor() { }
        public Vendedor(string cedula, string nombre, string sexo, string telefono, string correo, string contrasena, double sueldo)
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
            return base.ToString() + "Sueldo: "  + correo + contrasena + sueldo;
        }
    }
}
