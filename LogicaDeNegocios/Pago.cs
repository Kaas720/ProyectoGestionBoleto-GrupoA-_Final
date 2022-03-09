using Datos;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
    public class Pago
    {
        //public List<Object> boletos = new List<Object>();
        //public Pago(Object c)
        //{

        //}
        public  static int MNumeroboleto;
        public Pago() { }
        private static List<string> boleto = new List<string>();

        private string cooperativa, destino, fechaSalida, horaSalida, LugarSalida, numeroDisco;
        private double precios;

        public string Destino { get => destino; set => destino = value; }
        public string FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public string HoraSalida { get => horaSalida; set => horaSalida = value; }
        public string LugarSalida1 { get => LugarSalida; set => LugarSalida = value; }
        public string NumeroDisco { get => numeroDisco; set => numeroDisco = value; }
        public double Precios { get => precios; set => precios = value; }


        public string getCooperativa()
        {
            return cooperativa;
        }

        public void setCooperativa(string cooperativa)
        {
            this.cooperativa = cooperativa;
        }




        /*public Pago(string cooperativa, string destino, string fechaSalida, string horaSalida, string lugarSalida, string numeroDisco, double precios)
        {
            this.cooperativa = cooperativa;
            this.destino = destino;
            this.fechaSalida = fechaSalida;
            this.horaSalida = horaSalida;
            this.LugarSalida = lugarSalida;
            this.numeroDisco = numeroDisco;
            this.precios = precios;

        }
        */
        public static List<string> getBoleto()
        {
            return boleto;
        }
        public static bool pagarBoleto(int Id_bus, string Cedula_cliente)
        {
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            bool validacion = false;
            try
            {
                MessageBoxButtons ob = MessageBoxButtons.YesNoCancel;
                DialogResult obj = MessageBox.Show("Desea confirmar el pago","Titulo",ob, MessageBoxIcon.Question);
                if (obj == DialogResult.Yes)
                {
                    MessageBox.Show(""+ MNumeroboleto);
                    while (MNumeroboleto>0)
                    {
                        MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_pago", con.conectar());
                        mySqlCommand.Parameters.AddWithValue("@id_bus", Id_bus);
                        mySqlCommand.Parameters.AddWithValue("@cedula_cliente", Cedula_cliente);
                        mySqlCommand.Parameters.AddWithValue("@FechaActual", DateTime.Now);
                        mySqlCommand.ExecuteNonQuery();
                        MNumeroboleto--;
                    }
                        boleto.Clear();
                    MessageBox.Show("Se realizó el pago con éxito ");
                    validacion = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return validacion;
        } 
    }
}
