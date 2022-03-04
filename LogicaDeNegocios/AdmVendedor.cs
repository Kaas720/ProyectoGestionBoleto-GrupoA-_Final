// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="AdmVendedor.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    /// <summary>
    /// Class AdmVendedor.
    /// </summary>
    public class AdmVendedor
    {
        Vendedor procedimientos = new Vendedor();
        public List<Vendedor> ConsultarVendedor(string datoVendedor)
        {
            List<Vendedor> vendedor = null;
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
                vendedor = procedimientos.BuscarVendedor(datoVendedor);

                if (vendedor.Count == 0)
                {
                    throw new ControlExcepcion("Vendedor no encontrado");
                }
            }

            return vendedor;
        }

        /// <summary>
        /// Registrars the vendedor.
        /// </summary>
        /// <param name="vendedor">The vendedor.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool RegistrarVendedor(Vendedor vendedor)
        {
            Vendedor registrar = vendedor;
            registrar.InsertarVendedor(registrar);
            return true;
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
