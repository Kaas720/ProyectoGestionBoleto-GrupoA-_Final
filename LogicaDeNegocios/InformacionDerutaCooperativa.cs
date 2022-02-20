// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="InformacionDerutaCooperativa.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace LogicaDeNegocios
{
    // Se crea la clase InformacionDerutaCooperativa
    /// <summary>
    /// Class InformacionDerutaCooperativa.
    /// </summary>
    public class InformacionDerutaCooperativa
    {
        /// <summary>
        /// The cooperativa
        /// </summary>
        string cooperativa;
        /// <summary>
        /// The hora salida
        /// </summary>
        DateTime hora_salida;
        /// <summary>
        /// The precio
        /// </summary>
        double precio;
        // Constructor parametrizado  
        /// <summary>
        /// Initializes a new instance of the <see cref="InformacionDerutaCooperativa" /> class.
        /// </summary>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="hora_salida">The hora salida.</param>
        /// <param name="precio">The precio.</param>
        public InformacionDerutaCooperativa(string cooperativa, DateTime hora_salida, double precio)
        {
            this.cooperativa = cooperativa;
            this.hora_salida = hora_salida;
            this.precio = precio;
        }

        // metodos getters y setters
        /// <summary>
        /// Gets or sets the cooperativa.
        /// </summary>
        /// <value>The cooperativa.</value>
        public string Cooperativa { get => cooperativa; set => cooperativa = value; }
        /// <summary>
        /// Gets or sets the hora salida.
        /// </summary>
        /// <value>The hora salida.</value>
        public DateTime Hora_salida { get => hora_salida; set => hora_salida = value; }
        /// <summary>
        /// Gets or sets the precio.
        /// </summary>
        /// <value>The precio.</value>
        public double Precio { get => precio; set => precio = value; }
    }
}
