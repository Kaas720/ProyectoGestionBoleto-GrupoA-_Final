
namespace LogicaDeNegocios.Modulo_de_cliente
{
    public class Cliente :Usuarios
    {
        private string usuario;
        private string contraseña;

        public Cliente() { }
        
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public override string ToString() {
         return base.ToString() + "Usuario: " + usuario + "Contraseña: " + contraseña;
     }
    }
}
