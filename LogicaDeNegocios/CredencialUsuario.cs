using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    //Se crea la clase credencial que hereda de persona
    public class CredencialUsuario 
    {
        private string correo;
        private string contrasena;
        public CredencialUsuario() { }

        ///  Se crea el construcor parametrizando
        
        public CredencialUsuario(string correo, string contrasena)
        {
            this.correo = correo;
            this.contrasena = contrasena;
        }
        // Se crea los metodos getters y setters de la clase CredencialUsuario
        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
    }
}
