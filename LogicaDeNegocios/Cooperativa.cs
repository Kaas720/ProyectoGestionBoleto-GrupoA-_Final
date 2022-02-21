// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Cooperativa.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    /// <summary>
    /// Class Cooperativa.
    /// </summary>
    public class Cooperativa
    {
        /// <summary>
        /// The propietario
        /// </summary>
        private string propietario;
        /// <summary>
        /// The nombre cooperativa
        /// </summary>
        private string nombreCooperativa;
        /// <summary>
        /// The ruc
        /// </summary>
        private string ruc;
        /// <summary>
        /// The telefono
        /// </summary>
        private string telefono;
        /// <summary>
        /// The credencial usuario
        /// </summary>
        private CredencialUsuario credencialUsuario;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cooperativa" /> class.
        /// </summary>
        /// <param name="ruc">The ruc.</param>
        /// <param name="propietario">The propietario.</param>
        /// <param name="nombreCooperativa">The nombre cooperativa.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="credencialUsuario">The credencial usuario.</param>
        public Cooperativa(string ruc, string propietario, string nombreCooperativa, string telefono, CredencialUsuario credencialUsuario)
        {
            this.propietario = propietario;
            this.nombreCooperativa = nombreCooperativa;
            this.ruc = ruc;
            this.telefono = telefono;
            this.credencialUsuario = credencialUsuario;
        }

        /// <summary>
        /// Gets or sets the propietario.
        /// </summary>
        /// <value>The propietario.</value>
        public string Propietario { get => propietario; set => propietario = value; }
        /// <summary>
        /// Gets or sets the nombre cooperativa.
        /// </summary>
        /// <value>The nombre cooperativa.</value>
        public string NombreCooperativa { get => nombreCooperativa; set => nombreCooperativa = value; }
        /// <summary>
        /// Gets or sets the ruc.
        /// </summary>
        /// <value>The ruc.</value>
        public string Ruc { get => ruc; set => ruc = value; }
        /// <summary>
        /// Gets or sets the telefono.
        /// </summary>
        /// <value>The telefono.</value>
        public string Telefono { get => telefono; set => telefono = value; }
        /// <summary>
        /// Gets or sets the credencial usuario.
        /// </summary>
        /// <value>The credencial usuario.</value>
        public CredencialUsuario CredencialUsuario { get => credencialUsuario; set => credencialUsuario = value; }

        /// <summary>
        /// Insertars the cooperativa.
        /// </summary>
        /// <param name="cooperativa">The cooperativa.</param>
        public void InsertarCooperativa(Cooperativa cooperativa)
        { //spl_insertarCooperativa

            // Se llama a la clase conexion para hacer la conexion con la base de dados
            Conexion con = new Conexion();
            // Se llama a la clase  ConectorDeProcedimientos y se crea el objeto conector que permite realizar el procedimiento de inserta un nuevo cliente
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try
            {
                List<Cooperativa> lista = new List<Cooperativa>();
                lista.Add(cooperativa);
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_insertarCooperativa", con.conectar());
                foreach (Cooperativa Coop in lista)
                {
                    mySqlCommand.Parameters.AddWithValue("@Ruc", Coop.Ruc);
                    mySqlCommand.Parameters.AddWithValue("@Propietario", Coop.Propietario);
                    mySqlCommand.Parameters.AddWithValue("@NombreCooperativa", Coop.NombreCooperativa);
                    mySqlCommand.Parameters.AddWithValue("@Telefono", Coop.Telefono);
                    mySqlCommand.Parameters.AddWithValue("@Correo", Coop.CredencialUsuario.Correo);
                    mySqlCommand.Parameters.AddWithValue("@Contrasena", Coop.CredencialUsuario.Contrasena);
                    mySqlCommand.Parameters.AddWithValue("@Foreking_RolesUsuario", Coop.CredencialUsuario.Rol);
                }
                mySqlCommand.ExecuteReader();
                con.cerrar();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex);
            }
        }
        }
    }
