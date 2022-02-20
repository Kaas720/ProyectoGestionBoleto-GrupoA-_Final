// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="AdmChofer.cs" company="">
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
    /// Class AdmChofer.
    /// </summary>
    public class AdmChofer
    {
        /// <summary>
        /// Registrars the chofer.
        /// </summary>
        /// <param name="chofer">The chofer.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool RegistrarChofer(Chofer chofer)
        {
            Chofer registrar = chofer;
            registrar.InsertarChofer(registrar);
            return true;
        }
    }
}
