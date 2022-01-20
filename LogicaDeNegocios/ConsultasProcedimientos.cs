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
        public bool Login(string usuario, string password, int rol)
        {
            bool bandera = false;
            if (procedimientos.IniciasSeccion(usuario, password, rol))
            {
                bandera = true;
            }
            else
            {
                // Si los campos no coinsiden con los datos almacenados en la base de datos se realiza el manejo de excepciones para
                // mostar el mensaje en una pantalla emergente indicando la causa del error.
                throw new ControlExcepcion("Usuario y/o contrasena incorrecta");
            }
            return bandera;
        }

        // Se crea el metodo LlenarCombos que recibe como parametro la ciudad de origen y destino, se crea una lista almacenada string 
        // llamada ciudad la cual se llena al llamar al metodo CagarCiudad 
        public void LlenarCombos(ComboBox cbOrigen, ComboBox cbDestino)
        {
            List<string> ciudad = new List<string>();
            ciudad = procedimientos.CargarCiudad();
            if (ciudad.Count!=0)
            {
            // Se utiliza el bucle foreach para realizar la agregacion de las ciudades que se tiene almacenadas dentro de la base de datos
                foreach (string ciudadfx in ciudad)
                {
                    cbOrigen.Items.Add(ciudadfx);
                    cbDestino.Items.Add(ciudadfx);
                }
            }

        }

        // Se crea el metodo LlenarComboCooperativa que recibe como parametro cooperativa, origen y destino, se crea una lista almacenada string 
        // llamada cooperativa la cual se llena al llamar al metodo CagarCooperativa 
        public void LlenarComboCooperativa(ComboBox cbCooperativa, string origen, string destino)
        {
            List<string> coopeativa = new List<string>();
            coopeativa = procedimientos.CargarCooperativa(origen,destino);
            // Si la cooperativa obtine la lista de elementos esta sera diferente de cero 
            if (coopeativa.Count != 0)
            {
           // Se utiliza el bucle foreach para realizar la agregacion de las cooperativas que se tiene almacenadas dentro de la base de datos
                foreach (string coopeativafx in coopeativa)
                {
                    cbCooperativa.Items.Add(coopeativafx);
                }
            }
        }

        // Se crea el metodo LLenarGrit que recibe como parametro origen, destino, cooperativa y dataGridInf,
        // para lo cual se llama al metodo LllenarDataGrid que permite obtener los datos almacenados en la base de datos.
        public void LLenarGrit(string origen, string destino, string cooperativa, DataGridView dataGridInf)
        {
            procedimientos.LllenarDataGrid(origen, destino, cooperativa, dataGridInf);
        }


        /*Se realiza la validacion para el dataGrid*/
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
