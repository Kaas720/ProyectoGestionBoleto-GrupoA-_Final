using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{ 
    /// <summary>
    /// Se crea la clase persona con cuatro atributos
    /// </summary>
    public class Persona
    {
        private string cedula;
        private string nombre;
        private string sexo;
        private string telefono;

        /// <summary>
        /// Se crea el costructor por defecto
        /// </summary>
        public Persona() { } 
        /// <summary>
        /// Se crea el costructor de la clase persona parametrizado 
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="sexo"></param>
        /// <param name="telefono"></param>
        public Persona(string cedula, string nombre, string sexo, string telefono)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.sexo = sexo;
            this.telefono = telefono;

          }
        // Se crea los metodos getters y setters
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        
        public override string ToString()
        {
            return "Cedula: " + cedula + "Nombre: " + nombre + "Sexo: " + sexo + "Telefono: " + telefono;

        }
    }
}
