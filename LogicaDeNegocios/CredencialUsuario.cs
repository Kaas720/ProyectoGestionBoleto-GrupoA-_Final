// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="CredencialUsuario.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    /// <summary>
    /// Se crea la clase credencial con los atributos correo y contraseña.
    /// </summary>
    public class CredencialUsuario 
    {
        /// <summary>
        /// The correo
        /// </summary>
        private string correo;
        /// <summary>
        /// The contrasena
        /// </summary>
        private string contrasena;
        /// <summary>
        /// The rol
        /// </summary>
        private int rol;
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public CredencialUsuario() { }

        /// <summary>
        /// Se crea el construcor parametrizando.
        /// </summary>
        /// <param name="correo">The correo.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <param name="rol">The rol.</param>
        public CredencialUsuario(string correo, string contrasena, int rol)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            this.rol = rol;
        }
        // Se crea los metodos getters y setters de la clase CredencialUsuario
        /// <summary>
        /// Gets or sets the correo.
        /// </summary>
        /// <value>The correo.</value>
        public string Correo { get => correo; set => correo = value; }
        /// <summary>
        /// Gets or sets the contrasena.
        /// </summary>
        /// <value>The contrasena.</value>
        public string Contrasena { get => contrasena; set => contrasena = value; }
        /// <summary>
        /// Gets or sets the rol.
        /// </summary>
        /// <value>The rol.</value>
        public int Rol { get => rol; set => rol = value; }
    }
}
