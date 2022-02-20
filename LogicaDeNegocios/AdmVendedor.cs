// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="AdmVendedor.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    /// <summary>
    /// Class AdmVendedor.
    /// </summary>
    public class AdmVendedor
    {
        /// <summary>
        /// Registrars the vendedor.
        /// </summary>
        /// <param name="vendedor">The vendedor.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool RegistrarVendedor(Vendedor vendedor)
        {
            Vendedor registrar = vendedor;
            registrar.InsertarVendedor(registrar);
            return true;
        }
    }
}
