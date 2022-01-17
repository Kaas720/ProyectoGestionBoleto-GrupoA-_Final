using Datos;
using LogicaDeNegocios.Modulo_Boleto;
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
            else
            {
                throw new ControlExcepcion("Usuario y/o contrasena incorrecta");
            }
            return bandera;
        }

        public void LlenarCombos(ComboBox cbOrigen, ComboBox cbDestino)
        {
            List<string> ciudad = new List<string>();
            ciudad = procedimientos.CargarCiudad();
            if (ciudad.Count!=0)
            {
                foreach (string ciudadfx in ciudad)
                {
                    cbOrigen.Items.Add(ciudadfx);
                    cbDestino.Items.Add(ciudadfx);
                }
            }

        }

        public void LlenarComboCooperativa(ComboBox cbCooperativa, string origen, string destino)
        {
            List<string> coopeativa = new List<string>();
            coopeativa = procedimientos.CargarCooperativa(origen,destino);
            if (coopeativa.Count != 0)
            {
                foreach (string coopeativafx in coopeativa)
                {
                    cbCooperativa.Items.Add(coopeativafx);
                }
            }
        }
        public void LLenarGrit(string origen, string destino, string cooperativa, DataGridView dataGridInf)
        {
            procedimientos.LllenarDataGrid(origen, destino, cooperativa, dataGridInf);
        }


        /*Validaciones Para el dataGrid*/

        public bool ValidarDataGridVacio(DataGridView dataGridInf)
        {
            if (dataGridInf.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                throw new ControlExcepcion(" Por favor seleccionar un horario!");
            }
            return false;
        }
    }
}
