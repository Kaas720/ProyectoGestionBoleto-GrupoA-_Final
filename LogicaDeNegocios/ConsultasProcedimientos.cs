using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
    public class ConsultasProcedimientos
    {
        Procedimientos procedimientos = new Procedimientos();
        public bool Login(string usuario, string password, int rol)
        {
            bool bandera = false;
            if (procedimientos.IniciasSeccion(usuario, password, rol))
            {
                bandera = true;
            }
            return bandera;
        }

        public void LlenarCombos(ComboBox cbOrigen, ComboBox cbDestino)
        {
            List<string> ciudad = new List<string>();
            ciudad = procedimientos.CargarCiudad();
            if (ciudad.Count==0)
            {
                Console.WriteLine("ListaVacia");
            }
            else
            {
                foreach(string ciudadfx in ciudad)
                {
                    cbOrigen.Items.Add(ciudadfx);
                    cbDestino.Items.Add(ciudadfx);
                }
            }
        }
    }
}
