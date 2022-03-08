using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public class AdmRuta
    {
        Ruta procedimientos = new Ruta();
        /// <summary>
        /// Registrars the chofer.
        /// </summary>
        /// <param name="chofer">The ruta.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool RegistrarRuta(Ruta ruta)
        {
            Ruta registrar = ruta;
            registrar.InsertarRuta(registrar);
            return true;
        }
    }
}
