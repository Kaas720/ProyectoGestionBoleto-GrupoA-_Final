// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Persona.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
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
        /// <summary>
        /// The cedula
        /// </summary>
        private string cedula;
        /// <summary>
        /// The nombre
        /// </summary>
        private string nombre;
        /// <summary>
        /// The sexo
        /// </summary>
        private string sexo;
        /// <summary>
        /// The telefono
        /// </summary>
        private string telefono;

        /// <summary>
        /// Se crea el costructor por defecto
        /// </summary>
        public Persona() { }
        /// <summary>
        /// Se crea el costructor de la clase persona parametrizado
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="sexo">The sexo.</param>
        /// <param name="telefono">The telefono.</param>
        public Persona(string cedula, string nombre, string sexo, string telefono)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.sexo = sexo;
            this.telefono = telefono;

          }
        // Se crea los metodos getters y setters
        /// <summary>
        /// Gets or sets the cedula.
        /// </summary>
        /// <value>The cedula.</value>
        public string Cedula { get => cedula; set => cedula = value; }
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        public string Nombre { get => nombre; set => nombre = value; }
        /// <summary>
        /// Gets or sets the sexo.
        /// </summary>
        /// <value>The sexo.</value>
        public string Sexo { get => sexo; set => sexo = value; }
        /// <summary>
        /// Gets or sets the telefono.
        /// </summary>
        /// <value>The telefono.</value>
        public string Telefono { get => telefono; set => telefono = value; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return "Cedula: " + cedula + "Nombre: " + nombre + "Sexo: " + sexo + "Telefono: " + telefono;

        }
    }
}
