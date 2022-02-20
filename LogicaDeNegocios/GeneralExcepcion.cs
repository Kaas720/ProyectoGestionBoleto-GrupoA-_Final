// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="GeneralExcepcion.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
namespace LogicaDeNegocios
{
    // se crea la clase ControlExcepcion que se hereda de la Exception
    /// <summary>
    /// Class ControlExcepcion.
    /// Implements the <see cref="System.Exception" />
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ControlExcepcion : Exception
    {
        /// <summary>
        /// The message
        /// </summary>
        String message =null;
        //constructor parametrizado
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlExcepcion" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public ControlExcepcion(String message) : base(message)
        {
            Console.WriteLine(this.message);
        }
    }
}
