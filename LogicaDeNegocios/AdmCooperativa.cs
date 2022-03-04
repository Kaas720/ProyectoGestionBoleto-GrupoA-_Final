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
        Cooperativa procedimientos = new Cooperativa();
        public bool RegistrarCooperativa(Cooperativa cooperativa)
        {
            Cooperativa registrar = cooperativa;
            registrar.InsertarCooperativa(registrar);
            return true;
        }

        /// <summary>
        /// Consultas the Cooperativa.
        /// </summary>
        /// <param name="idCooperativa">The cedula.</param>
        /// <returns>List&lt;Chofer&gt;.</returns>

        public List<Cooperativa> ConsultarCooperativa(int idCooperativa)
        {
            List<Cooperativa> lista = new List<Cooperativa>();
            Cooperativa cooperativa = null;
            cooperativa = Cooperativa.BuscarCooperativa(idCooperativa);
            lista.Add(cooperativa);
            return lista;
        }

        /// <summary>
        /// Modificars the specified cedula.
        /// </summary>
        /// <param name="telefono">The telefono.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns>System.String.</returns>
        public string Modificar(string ruc, string telefono, string correo, string contrasena)
        {
            return procedimientos.ActualizarCooperativa(ruc, telefono, correo, contrasena);
        }
        public void EliminarVendedor(string cedulaNombre)
        {
            if (!Vendedor.EliminarVendedor(cedulaNombre))
            {
                throw new ControlExcepcion("Error al eliminar intetar más tarde");
            }
        }
    }
}
