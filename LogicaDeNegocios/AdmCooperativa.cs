// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="AdmCooperativa.cs" company="">
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
    /// Class AdmCooperativa.
    /// </summary>
    public class AdmCooperativa
    {
        /// <summary>
        /// Registrars the cooperativa.
        /// </summary>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool RegistrarCooperativa(Cooperativa cooperativa)
        {
            Cooperativa registrar = cooperativa;
            registrar.InsertarCooperativa(registrar);
            return true;
        }
    }
}
