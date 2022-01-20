using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Modulo_de_chofer
{
    public class ClsChofer: Persona
    {
        
        private String licencia;
        private Int16 idCooperativa;
        private String estado;


        ClsManejador ManejadorChofer = new ClsManejador();

       

        /* Lucio Johann*/

        public  ClsChofer() {
        
        
        }

        public String Licencia
        {
            get { return licencia; }
            set { licencia = value; }
        }

        public Int16 IdCooperativa
        {
            get { return idCooperativa; }
            set { idCooperativa = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }



        public int actualizar_x_cedula()
        {
            MySqlConnection conexion = ManejadorChofer.abrir_conexion();

            MySqlCommand comannd = new MySqlCommand();
            comannd.Connection = conexion;
            comannd.CommandText = "ModificarChofer";
            comannd.CommandType = System.Data.CommandType.StoredProcedure;



            comannd.Parameters.AddWithValue("param_cedula", Cedula); // a la variable de tip Mysql comand agregar un valor al parametro
            comannd.Parameters.AddWithValue("param_nombre", Nombre); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica
            comannd.Parameters.AddWithValue("param_licencia", licencia);
            comannd.Parameters.AddWithValue("param_sexo", Sexo);
            comannd.Parameters.AddWithValue("param_telefono", Telefono);
            comannd.Parameters.AddWithValue("param_correo", Correo);
            comannd.Parameters.AddWithValue("param_ciudad", Ciudad);
            comannd.Parameters.AddWithValue("param_usuario", Usuario);
            comannd.Parameters.AddWithValue("param_contraseña", Contraseña);
            comannd.Parameters.AddWithValue("param_idCooperativa", IdCooperativa);
            comannd.Parameters.AddWithValue("param_estado", Estado);
            int resultado_operacion = Convert.ToInt32(comannd.ExecuteScalar());
            ManejadorChofer.cerrar_conexion(conexion);
            return resultado_operacion;

        }

        /* Lucio Johann*/
        public override String registrar()
        {
            String msj = "";
            try
            {
                MySqlConnection conexion = ManejadorChofer.abrir_conexion();

                MySqlCommand comannd = new MySqlCommand();
                comannd.Connection = conexion;
                comannd.CommandText = "Registrar_Chofer";
                comannd.CommandType = System.Data.CommandType.StoredProcedure;

                comannd.Parameters.AddWithValue("param_cedula", Cedula);
                comannd.Parameters.AddWithValue("param_nombre", Nombre);
                comannd.Parameters.AddWithValue("param_licencia", Licencia);
                comannd.Parameters.AddWithValue("param_sexo", Sexo);
                comannd.Parameters.AddWithValue("param_telefono", Telefono);
                comannd.Parameters.AddWithValue("param_correo", Correo);
                comannd.Parameters.AddWithValue("param_ciudad", Ciudad);
                comannd.Parameters.AddWithValue("param_usuario", Usuario);
                comannd.Parameters.AddWithValue("param_contraseña", Contraseña);
                comannd.Parameters.AddWithValue("param_idCooperativa", IdCooperativa);
                comannd.Parameters.AddWithValue("param_estado", Estado);

                int resultado = Convert.ToInt32(comannd.ExecuteNonQuery());
                msj = "Registrado con éxito, " ;
                ManejadorChofer.cerrar_conexion(conexion);
            }
            catch (Exception ex)
            {
                msj = "Error al registrar los datos\nMotivo:\n" ;
            }
            return msj;
        }


    }
}
