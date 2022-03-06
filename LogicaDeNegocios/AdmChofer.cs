// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="AdmChofer.cs" company="">
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
    /// Class AdmChofer.
    /// </summary>
    public class AdmChofer
    {
        Chofer procedimientos = new Chofer();
        /// <summary>
        /// Registrars the chofer.
        /// </summary>
        /// <param name="chofer">The chofer.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool RegistrarChofer(Chofer chofer)
        {
            Chofer registrar = chofer;
            registrar.InsertarChofer(registrar);
            return true;
        }
        /// <summary>
        /// Consultas the chofer.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <returns>List&lt;Chofer&gt;.</returns>

        public List<Chofer> ConsularChofer(string cedula)
        {
            List<Chofer> lista = new List<Chofer>();
            Chofer chofer = null;
            chofer = Chofer.BuscarChofer(cedula);
            lista.Add(chofer);
            return lista;
        }

        /// <summary>
        /// Modificars the specified cedula.
        /// </summary>
        /// <param name="telefono">The telefono.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns>System.String.</returns>
        public string Modificar(string cedula, string telefono, string correo, string contrasena)
        {
            return procedimientos.ActualizarChofer(cedula, telefono, correo, contrasena);
        }

        public List<Chofer> ConsultarChofer(string datoVendedor)
        {
            List<Chofer> chofer = null;
            if (String.IsNullOrEmpty(datoVendedor))
            {
                throw new ControlExcepcion("Campo vacio por favor rellenar");
            }
            else
            {
                if (datoVendedor == "Iniciar_data_grid_datos")
                {
                    datoVendedor = "";
                }
                chofer = procedimientos.ConsultarChofer(datoVendedor);

                if (chofer.Count == 0)
                {
                    throw new ControlExcepcion("Vendedor no encontrado");
                }
            }

            return chofer;
        }

        public void EliminarChofer(string cedula)
        {
            if (!Chofer.EliminarChofer(cedula))
            {
                throw new ControlExcepcion("Error al eliminar intetar más tarde");
            }
        }
    }
}
