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
        public Pago() { }
        private static List<Pago> boleto = new List<Pago>();

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




        public Pago(string cooperativa, string destino, string fechaSalida, string horaSalida, string lugarSalida, string numeroDisco, double precios)
        {
            this.cooperativa = cooperativa;
            this.destino = destino;
            this.fechaSalida = fechaSalida;
            this.horaSalida = horaSalida;
            this.LugarSalida = lugarSalida;
            this.numeroDisco = numeroDisco;
            this.precios = precios;

        }

        public static List<Pago> getBoleto()
        {
            return boleto;
        }

        public static void setBoleto(Pago boletos)
        {
            boleto.Add(boletos);
        }

        public static bool pagarBoleto()
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

                    foreach (var b in Pago.getBoleto())
                    {
                        MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_pago", con.conectar());
                        mySqlCommand.Parameters.AddWithValue("@Cooperativax", b.getCooperativa());
                        mySqlCommand.Parameters.AddWithValue("@Destino", b.Destino);
                        mySqlCommand.Parameters.AddWithValue("@FechaSalida", b.FechaSalida);
                        mySqlCommand.Parameters.AddWithValue("@HoraSalida", b.HoraSalida);
                        mySqlCommand.Parameters.AddWithValue("@LugarSalida", b.LugarSalida);
                        mySqlCommand.Parameters.AddWithValue("@NumeroDisco", b.NumeroDisco);
                        mySqlCommand.ExecuteNonQuery();
                    }
                    boleto.Clear();
                    con.cerrar();
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
