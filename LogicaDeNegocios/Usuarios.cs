
namespace LogicaDeNegocios
{
    public class Usuarios:Persona
    {
        private string correo;
        private string ciudad;
        public Usuarios() { }
        public Usuarios(string cedula, string nombre, string sexo, string telefono, string correo, string ciudad)
        :base(cedula, nombre, sexo, telefono)
        {
            this.ciudad = ciudad;
            this.correo = correo;
            
        }
        public string Correo { get => correo; set => correo = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }

        public override string ToString()
        {
            return base.ToString()+ "Correo: " + correo + "Ciudad: " + ciudad;
        }
    }

}

