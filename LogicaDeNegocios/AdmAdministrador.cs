// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="AdmAdministrador.cs" company="">
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
    /// Class AdmAdministrador.
    /// </summary>
    public class AdmAdministrador
    {
        /// <summary>
        /// Registrars the administrador.
        /// </summary>
        /// <param name="admin">The admin.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool RegistrarAdministrador(Administrador admin)
        {
            Administrador registrar = admin;
            //registrar.InsertarAdministrador(registrar);
            return true;
        }
        /// <summary>
        /// Consultas the admin.
        /// </summary>
        /// <param name="idPersona">The identifier persona.</param>
        /// <returns>List&lt;Administrador&gt;.</returns>
        public List<Administrador> ConsultaAdmin(int idPersona)
        {
            List<Administrador> newLista = new List<Administrador>();
            Administrador admin = null;
            admin = Administrador.ConsultarAdministrador(idPersona);
            newLista.Add(admin);
            return newLista;
        }
    }
}
