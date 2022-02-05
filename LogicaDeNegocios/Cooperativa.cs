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
        private string telefono;
        private CredencialUsuario credencialUsuario;

        public Cooperativa(string ruc, string propietario, string nombreCooperativa, string telefono, CredencialUsuario credencialUsuario)
        {
            this.propietario = propietario;
            this.nombreCooperativa = nombreCooperativa;
            this.ruc = ruc;
            this.telefono = telefono;
            this.credencialUsuario = credencialUsuario;
        }

        public string Propietario { get => propietario; set => propietario = value; }
        public string NombreCooperativa { get => nombreCooperativa; set => nombreCooperativa = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public CredencialUsuario CredencialUsuario { get => credencialUsuario; set => credencialUsuario = value; }

        public void InsertarCooperativa(Cooperativa cooperativa)
        {

        }
        }
    }
