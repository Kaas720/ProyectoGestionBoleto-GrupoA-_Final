// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Ruta.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace LogicaDeNegocios
{
    /// <summary>
    /// Class Ruta.
    /// </summary>
    public class Ruta
    {
        //Atributos
        /// <summary>
        /// The lugar origen
        /// </summary>
        private string lugarOrigen;
        /// <summary>
        /// The lugar destino
        /// </summary>
        private string lugarDestino;
        /// <summary>
        /// The horario disponible
        /// </summary>
        private DateTime horarioDisponible;

        //Construtor parametrizado
        /// <summary>
        /// Initializes a new instance of the <see cref="Ruta" /> class.
        /// </summary>
        /// <param name="lugarOrigen">The lugar origen.</param>
        /// <param name="lugarDestino">The lugar destino.</param>
        /// <param name="horarioDisponible">The horario disponible.</param>
        public Ruta(string lugarOrigen, string lugarDestino, DateTime horarioDisponible)
        {
            this.lugarOrigen = lugarOrigen;
            this.lugarDestino = lugarDestino;
            this.horarioDisponible = horarioDisponible;
        }

        // Metodos getters y setters
        /// <summary>
        /// Gets or sets the lugar origen.
        /// </summary>
        /// <value>The lugar origen.</value>
        public string LugarOrigen { get => lugarOrigen; set => lugarOrigen = value; }
        /// <summary>
        /// Gets or sets the lugar destino.
        /// </summary>
        /// <value>The lugar destino.</value>
        public string LugarDestino { get => lugarDestino; set => lugarDestino = value; }
        /// <summary>
        /// Gets or sets the horario disponible.
        /// </summary>
        /// <value>The horario disponible.</value>
        public DateTime HorarioDisponible { get => horarioDisponible; set => horarioDisponible = value; }
       
    }
}
