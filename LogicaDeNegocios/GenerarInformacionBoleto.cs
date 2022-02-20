// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="GenerarInformacionBoleto.cs" company="">
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
    // Se crea la clase  GenerarInformacionBoleto
    /// <summary>
    /// Class GenerarInformacionBoleto.
    /// </summary>
    public class GenerarInformacionBoleto
    {
        // Atributos
        /// <summary>
        /// The bus identifier
        /// </summary>
        int busId;
        /// <summary>
        /// The lugar salida
        /// </summary>
        string lugarSalida;
        /// <summary>
        /// The fecha salida
        /// </summary>
        string fechaSalida;
        /// <summary>
        /// The lugardestino
        /// </summary>
        string lugardestino;
        /// <summary>
        /// The hora salida
        /// </summary>
        string horaSalida;
        /// <summary>
        /// The cooperativa
        /// </summary>
        string cooperativa;
        /// <summary>
        /// The numerodico
        /// </summary>
        string numerodico;
        /// <summary>
        /// The precio
        /// </summary>
        string precio;

        // se crea el constructor parametrizado
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerarInformacionBoleto" /> class.
        /// </summary>
        /// <param name="busId">The bus identifier.</param>
        /// <param name="lugarSalida">The lugar salida.</param>
        /// <param name="fechaSalida">The fecha salida.</param>
        /// <param name="lugardestino">The lugardestino.</param>
        /// <param name="horaSalida">The hora salida.</param>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="numerodico">The numerodico.</param>
        /// <param name="precio">The precio.</param>
        public GenerarInformacionBoleto(int busId, string lugarSalida, string fechaSalida, string lugardestino, string horaSalida, string cooperativa, string numerodico, string precio)
        {
            this.busId = busId;
            this.lugarSalida = lugarSalida;
            this.fechaSalida = fechaSalida;
            this.lugardestino = lugardestino;
            this.horaSalida = horaSalida;
            this.cooperativa = cooperativa;
            this.numerodico = numerodico;
            this.precio = precio;
        }

        // Se crean los metodos getters y setters
        /// <summary>
        /// Gets or sets the lugar salida.
        /// </summary>
        /// <value>The lugar salida.</value>
        public string LugarSalida { get => lugarSalida; set => lugarSalida = value; }
        /// <summary>
        /// Gets or sets the fecha salida.
        /// </summary>
        /// <value>The fecha salida.</value>
        public string FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        /// <summary>
        /// Gets or sets the lugardestino.
        /// </summary>
        /// <value>The lugardestino.</value>
        public string Lugardestino { get => lugardestino; set => lugardestino = value; }
        /// <summary>
        /// Gets or sets the hora salida.
        /// </summary>
        /// <value>The hora salida.</value>
        public string HoraSalida { get => horaSalida; set => horaSalida = value; }
        /// <summary>
        /// Gets or sets the cooperativa.
        /// </summary>
        /// <value>The cooperativa.</value>
        public string Cooperativa { get => cooperativa; set => cooperativa = value; }
        /// <summary>
        /// Gets or sets the numerodico.
        /// </summary>
        /// <value>The numerodico.</value>
        public string Numerodico { get => numerodico; set => numerodico = value; }
        /// <summary>
        /// Gets or sets the precio.
        /// </summary>
        /// <value>The precio.</value>
        public string Precio { get => precio; set => precio = value; }
        /// <summary>
        /// Gets or sets the bus identifier.
        /// </summary>
        /// <value>The bus identifier.</value>
        public int BusId { get => busId; set => busId = value; }
    }
}
