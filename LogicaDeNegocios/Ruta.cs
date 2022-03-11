// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Ruta.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    // Se crea la clase  Ruta
    /// <summary>
    /// Class Ruta.
    /// </summary>
    public class Ruta
    {
        // Atributos
        /// <summary>
        /// The bus identifier
        /// </summary>
        int busId;
        /// <summary>
        /// The lugar salida
        /// </summary>
        string lugarSalida;
        /// <summary>
        /// The fecha salida
        /// </summary>
        string fechaSalida;
        /// <summary>
        /// The lugardestino
        /// </summary>
        string lugardestino;
        /// <summary>
        /// The hora salida
        /// </summary>
       string horaSalida;
        /// <summary>
        /// The cooperativa
        /// </summary>
       string cooperativa;
        /// <summary>
        /// The numerodico
        /// </summary>
         string asiento;
        /// <summary>
        /// The numerodico
        /// </summary>
         string numerodico;
        /// <summary>
        /// The precio
        /// </summary>
       string precio;
        int boletoID;
        // se crea el constructor parametrizado
        /// <summary>
        /// Initializes a new instance of the <see cref="Ruta" /> class.
        /// </summary>
        /// <param name="busId">The bus identifier.</param>
        /// <param name="lugarSalida">The lugar salida.</param>
        /// <param name="fechaSalida">The fecha salida.</param>
        /// <param name="lugardestino">The lugardestino.</param>
        /// <param name="horaSalida">The hora salida.</param>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="asiento">The numerodico.</param>
        /// <param name="numerodico">The numerodico.</param>
        /// <param name="precio">The precio.</param>
        
        public Ruta(int boletoID, int busId, string lugarSalida, string fechaSalida, string lugardestino, string horaSalida, string cooperativa, string numerodico, string asiento, string precio)
        {
            this.boletoID = boletoID;
            this.busId= busId;
            this.lugarSalida = lugarSalida;
            this.fechaSalida = fechaSalida;
            this.lugardestino = lugardestino;
            this.horaSalida = horaSalida;
            this.cooperativa = cooperativa;
            this.asiento = asiento;
            this.numerodico = numerodico;
            this.precio = precio;
        }
        public Ruta() { }
        // Se crean los metodos getters y setters
        /// <summary>
        /// Gets or sets the lugar salida.
        /// </summary>
        /// <value>The lugar salida.</value>
        public string LugarSalida { get => lugarSalida; set => lugarSalida = value; }
        /// <summary>
        /// Gets or sets the fecha salida.
        /// </summary>
        /// <value>The fecha salida.</value>
        public string FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        /// <summary>
        /// Gets or sets the lugardestino.
        /// </summary>
        /// <value>The lugardestino.</value>
        public string Lugardestino { get => lugardestino; set => lugardestino = value; }
        /// <summary>
        /// Gets or sets the hora salida.
        /// </summary>
        /// <value>The hora salida.</value>
        public String HoraSalida { get => horaSalida; set => horaSalida = value; }
        /// <summary>
        /// Gets or sets the cooperativa.
        /// </summary>
        /// <value>The cooperativa.</value>
        public string Cooperativa { get => cooperativa; set => cooperativa = value; }
        /// <summary>
        /// Gets or sets the numerodico.
        /// </summary>
        /// <value>The numerodico.</value>
        public string Numerodico { get => numerodico; set => numerodico = value; }
        /// <summary>
        /// Gets or sets the precio.
        /// </summary>
        /// <value>The precio.</value>
        public String Precio { get => precio; set => precio = value; }
        /// <summary>
        /// Gets or sets the bus identifier.
        /// </summary>
        /// <value>The bus identifier.</value>
        public int BusId { get => busId; set => busId = value; }
        public string Asiento { get => asiento; set => asiento = value; }
        public int BoletoID { get => boletoID; set => boletoID = value; }

        // public string Cooperativa { get => cooperativa; set => cooperativa = value; }
        Bus bus = new Bus();
        public void InsertarRuta(Ruta ruta)
        {
            // Se llama a la clase conexion para hacer la conexion con la base de dados
            Conexion con = new Conexion();
            // Se llama a la clase  ConectorDeProcedimientos y se crea el objeto conector que permite realizar el procedimiento de inserta un nuevo cliente
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try
            {
                List<Ruta> Lista = new List<Ruta>();
                Lista.Add(ruta);
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_insertarRuta", con.conectar());
                foreach (Ruta Ruta in Lista)
                {
                    mySqlCommand.Parameters.AddWithValue("@Cooperativa", Ruta.Cooperativa);
                    mySqlCommand.Parameters.AddWithValue("@NumeroDisco", Ruta.Numerodico);
                    mySqlCommand.Parameters.AddWithValue("@lugarOrigen", Ruta.LugarSalida);
                    mySqlCommand.Parameters.AddWithValue("@lugarDestino", Ruta.Lugardestino);
                    mySqlCommand.Parameters.AddWithValue("@horaSalida", Ruta.HoraSalida);
                    mySqlCommand.Parameters.AddWithValue("@NumAsiento", Ruta.Asiento);
                    mySqlCommand.Parameters.AddWithValue("@Precio", Ruta.Precio);

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
