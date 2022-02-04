﻿using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    /// <summary>
    /// Se crea la clase credencial con los atributos correo y contraseña.
    /// </summary>
    public class CredencialUsuario 
    {
        private string correo;
        private string contrasena;
        private int rol;
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public CredencialUsuario() { }

        /// <summary>
        ///  Se crea el construcor parametrizando.
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="contrasena"></param>
        public CredencialUsuario(string correo, string contrasena, int rol)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            this.rol = rol;
        }
        // Se crea los metodos getters y setters de la clase CredencialUsuario
        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int Rol { get => rol; set => rol = value; }
    }
}
