using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
    public class ConsultasProcedimientos
    {
        // Se llama al clase  ProcedimientosPaginaprincipal y se crea el objeto procediminetos para llamar a los metodos que contiene
        ProcedimientosPaginaprincipal procedimientos = new ProcedimientosPaginaprincipal();

        // Se crea el metodo para validar que el usuario y la contraseña sean autenticos y validos
        public int Login(string usuario, string password)
        {
            int resultado= procedimientos.IniciasSeccion(usuario, password);
            if(resultado == 0)
            {
                throw new ControlExcepcion("Usuario y/o contrasena incorrecta");
            }
            return resultado;
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
        public bool ValidarDataGridVacio(DataGridView dataGridInf)
        {
            bool bandera = false;

            if (dataGridInf.SelectedRows.Count > 0)
            {
                bandera= true;
            }
            else
            {
                throw new ControlExcepcion(" Por favor seleccionar un horario!");
            }
            return bandera;
        }
    }
}
