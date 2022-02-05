using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
   public class Cooperativa
    {
        private string propietario;
        private string nombreCooperativa;
        private string ruc;
        private CredencialUsuario credencialUsuario;

        public Cooperativa(string propietario, string nombreCooperativa, string ruc, CredencialUsuario credencialUsuario)
        {
            this.propietario = propietario;
            this.nombreCooperativa = nombreCooperativa;
            this.ruc = ruc;
            this.credencialUsuario = credencialUsuario;
        }

        public string Propietario { get => propietario; set => propietario = value; }
        public string NombreCooperativa { get => nombreCooperativa; set => nombreCooperativa = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public CredencialUsuario CredencialUsuario { get => credencialUsuario; set => credencialUsuario = value; }


    }
}
