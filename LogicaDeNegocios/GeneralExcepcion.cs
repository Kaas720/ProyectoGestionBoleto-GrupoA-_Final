using System;
namespace LogicaDeNegocios
{
    // se crea la clase ControlExcepcion que se hereda de la Exception
    public class ControlExcepcion : Exception
    {
        String message=null;
      //constructor parametrizado
        public ControlExcepcion(String message) : base(message)
        {
            Console.WriteLine(this.message);
        }
    }
}
