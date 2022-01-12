using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClsManejador
    {
        private MySqlConnection conexion;

        private MySqlConnection abrir_conexion()
        {

            try
            {
                string ConnectionString = "server=localhost; database=PruebaAc; Uid=root; pwd=kevin1234;";
                conexion = new MySqlConnection(ConnectionString);
                conexion.Open();
                Console.WriteLine("Se abrio la conexion desde la capa de acceso a datos");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return conexion;
        }

        private void cerrar_conexion(MySqlConnection conexion)
        {
            conexion.Close();
            Console.WriteLine("Se cerro la conexion desde la capa de acceso a datos");
        }

        public int actualizar_chofer_individual(string param_cedula, String param_nombre, String param_licencia, String param_sexo, Int16 param_telefono, String param_correo, String param_usuario, String param_contraseña)
        {
            MySqlConnection conexion = abrir_conexion();
            string actualizar = "update chofer set cedula=@param_cedula, nombre=@param_nombre, licencia=@param_licencia, sexo=@param_sexo, telefono=@param_telefono, correo=@param_correo, usuario=@param_usuario, contraseña=@param_contraseña WHERE cedula=@param_cedula";
            MySqlCommand comannd = new MySqlCommand(actualizar, conexion);
            comannd.Parameters.AddWithValue("@param_cedula", param_cedula); // a la variable de tip Mysql comand agregar un valor al parametro
            comannd.Parameters.AddWithValue("@param_nombre", param_nombre); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica
            comannd.Parameters.AddWithValue("@param_licencia", param_licencia);
            comannd.Parameters.AddWithValue("@param_sexo", param_sexo);
            comannd.Parameters.AddWithValue("@param_telefono", param_telefono);
            comannd.Parameters.AddWithValue("@param_correo", param_correo);
            comannd.Parameters.AddWithValue("@param_usuario", param_usuario);
            comannd.Parameters.AddWithValue("@param_contraseña", param_contraseña);
            int resultado_operacion = Convert.ToInt32(comannd.ExecuteScalar());
            cerrar_conexion(conexion);
            return resultado_operacion;

        }

        /*Lucio Johann*/
        public String insertar(List<ClsParametroChofer> lst)
        {
            String msj = "";
            try
            {
                MySqlConnection conexion = abrir_conexion();

                string cadena = "INSERT INTO Leccion (cedula,nombre,licencia,sexo,telefono,correo,usuario,contraseña)" +// AQUI VA LOS PARAMETROS DE LA BD
                    " VALUES (@cedula,@nombre,@licencia,@sexo,@telefono,@correo,@usuario,@contraseña)";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);

                comando.Parameters.AddWithValue("@cedula", lst[0].Cedula);
                comando.Parameters.AddWithValue("@nombre", lst[0].Nombre);
                comando.Parameters.AddWithValue("@licencia", lst[0].Licencia);
                comando.Parameters.AddWithValue("@sexo", lst[0].Sexo);
                comando.Parameters.AddWithValue("@telefono", lst[0].Telefono);
                comando.Parameters.AddWithValue("@correo", lst[0].Correo);
                comando.Parameters.AddWithValue("@usuario", lst[0].Usuario);
                comando.Parameters.AddWithValue("@contraseña", lst[0].Contraseña);

                int resultado = Convert.ToInt32(comando.ExecuteNonQuery());
                msj = "Registrado con éxito, " + resultado;
                cerrar_conexion(conexion);
            }
            catch (Exception ex)
            {
                msj = "Error al registrar los datos\nMotivo:\n" + ex;
            }
            return msj;
        }


    }
}
