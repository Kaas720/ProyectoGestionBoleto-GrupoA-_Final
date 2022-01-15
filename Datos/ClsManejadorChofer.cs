
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class  ClsManejadorChofer
    {

        ClsManejador ManejadorChofer = new ClsManejador();

        public int actualizar_chofer_individual(String param_cedula, String param_nombre, String param_licencia, String param_sexo, String param_telefono, String param_correo, String param_ciudad, String param_usuario, String param_contraseña, Int16 param_idCooperativa, String param_estado)
        {
            MySqlConnection conexion = ManejadorChofer.abrir_conexion();

            MySqlCommand comannd = new MySqlCommand();
            comannd.Connection = conexion;
            comannd.CommandText = "ModificarChofer";
            comannd.CommandType = System.Data.CommandType.StoredProcedure;



            comannd.Parameters.AddWithValue("param_cedula", param_cedula); // a la variable de tip Mysql comand agregar un valor al parametro
            comannd.Parameters.AddWithValue("param_nombre", param_nombre); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica
            comannd.Parameters.AddWithValue("param_licencia", param_licencia);
            comannd.Parameters.AddWithValue("param_sexo", param_sexo);
            comannd.Parameters.AddWithValue("param_telefono", param_telefono);
            comannd.Parameters.AddWithValue("param_correo", param_correo);
            comannd.Parameters.AddWithValue("param_ciudad", param_ciudad);
            comannd.Parameters.AddWithValue("param_usuario", param_usuario);
            comannd.Parameters.AddWithValue("param_contraseña", param_contraseña);
            comannd.Parameters.AddWithValue("param_idCooperativa", param_idCooperativa);
            comannd.Parameters.AddWithValue("param_estado", param_estado);
            int resultado_operacion = Convert.ToInt32(comannd.ExecuteScalar());
            ManejadorChofer.cerrar_conexion(conexion);
            return resultado_operacion;

        }

        /*Lucio Johann*/
        public String insertar_chofer(List<ClsParametroChofer> lst)
        {
            String msj = "";
            try
            {
                MySqlConnection conexion = ManejadorChofer.abrir_conexion();

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
                ManejadorChofer.cerrar_conexion(conexion);
            }
            catch (Exception ex)
            {
                msj = "Error al registrar los datos\nMotivo:\n" + ex;
            }
            return msj;
        }

    }
}
