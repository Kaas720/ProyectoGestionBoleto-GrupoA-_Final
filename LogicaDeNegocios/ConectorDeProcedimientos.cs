// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="ConectorDeProcedimientos.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using Datos;
using MySqlConnector;
using System;

namespace LogicaDeNegocios
{
    /// <summary>
    /// Class ConectorDeProcedimientos.
    /// </summary>
    class ConectorDeProcedimientos
    {
        /// <summary>
        /// Conectars the procedimiento.
        /// </summary>
        /// <param name="Procedimientos">The procedimientos.</param>
        /// <param name="mySqlConnection">My SQL connection.</param>
        /// <returns>MySqlCommand.</returns>
        public MySqlCommand ConectarProcedimiento(string Procedimientos, MySqlConnection mySqlConnection)
        {
            MySqlCommand mySqlCommand;
            mySqlCommand = new MySqlCommand(Procedimientos, mySqlConnection);
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            return mySqlCommand;
        }
    }
}
