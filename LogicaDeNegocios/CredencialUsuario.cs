using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    //Se crea la clase credencial que hereda de persona
    public class CredencialUsuario : Persona
    {
        private string correo;
        private string contrasena;

        public CredencialUsuario() { }

        //  Se crea el construcor parametrizando y se llama a base para ingresar los parametros de la clase persona
        public CredencialUsuario(string cedula, string nombre, string sexo, string telefono, string correo, string contrasena) : base(cedula, nombre, sexo, telefono)
        {
            this.correo = correo;
            this.contrasena = contrasena;
        }
        // Se crea los metodos getters y setters de la clase CredencialUsuario
        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
    }
}
