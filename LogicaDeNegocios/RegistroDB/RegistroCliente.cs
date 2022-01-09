using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using LogicaDeNegocios.Modulo_de_cliente;
using Datos;
//using MySql.Data.MySqlClient;

namespace LogicaDeNegocios.RegistroDB
{/*
    public class RegistroCliente
    {
        Conexion conexion;
         public  RegistroCliente(){
         conexion = new Conexion(); }
        public void InsertarCliente(Cliente cliente)
        {
           
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "spl_insertar_cliente";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            //Lista de parámetros para el procedimeinto almacenado
            MySqlParameter parameterCedula = new MySqlParameter("@Cedula", MySqlDbType.VarChar);
            parameterCedula.Direction = System.Data.ParameterDirection.Input;
            parameterCedula.Value = cliente.Cedula;
            comando.Parameters.Add(parameterCedula);
            MySqlParameter parameterNombre = new MySqlParameter("@Nombre", MySqlDbType.VarChar);
            parameterNombre.Direction = System.Data.ParameterDirection.Input;
            parameterNombre.Value = cliente.Nombre;
            comando.Parameters.Add(parameterNombre);
            MySqlParameter parameterSexo = new MySqlParameter("@Sexo", MySqlDbType.VarChar);
            parameterSexo.Direction = System.Data.ParameterDirection.Input;
            parameterSexo.Value = cliente.Sexo;
            comando.Parameters.Add(parameterSexo);
            MySqlParameter parameterTelefono = new MySqlParameter("@Telefono", MySqlDbType.VarChar);
            parameterTelefono.Direction = System.Data.ParameterDirection.Input;
            parameterTelefono.Value = cliente.Telefono;
            comando.Parameters.Add(parameterTelefono);
            MySqlParameter parameterCorreo = new MySqlParameter("@Correo", MySqlDbType.VarChar);
            parameterCorreo.Direction = System.Data.ParameterDirection.Input;
            parameterCorreo.Value = cliente.Correo;
            comando.Parameters.Add(parameterCorreo);
            MySqlParameter parameterCiudad = new MySqlParameter("@Ciudad", MySqlDbType.VarChar);
            parameterCiudad.Direction = System.Data.ParameterDirection.Input;
            parameterCiudad.Value = cliente.Ciudad;
            comando.Parameters.Add(parameterCiudad);
            MySqlParameter parameterUsuario = new MySqlParameter("@Usuario", MySqlDbType.VarChar);
            parameterUsuario.Direction = System.Data.ParameterDirection.Input;
            parameterUsuario.Value = cliente.Usuario;
            comando.Parameters.Add(parameterUsuario);
            MySqlParameter parameterContraseña = new MySqlParameter("@Contraseña", MySqlDbType.VarChar);
            parameterContraseña.Direction = System.Data.ParameterDirection.Input;
            parameterContraseña.Value = cliente.Contraseña;
            comando.Parameters.Add(parameterContraseña);
           /* MySqlCommand mySqlCommand;
            Conexion conexion = new Conexion();
                   
                mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = "spl_insertar_cliente";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("@Cedula1", cliente.Cedula);
                mySqlCommand.Parameters.AddWithValue("@Nombre2", cliente.Nombre);
                mySqlCommand.Parameters.AddWithValue("@Sexo3", cliente.Sexo);
                mySqlCommand.Parameters.AddWithValue("@Telefono4", cliente.Telefono);
                mySqlCommand.Parameters.AddWithValue("@Correo5", cliente.Correo);
                mySqlCommand.Parameters.AddWithValue("@Ciudad6", cliente.Ciudad);
                mySqlCommand.Parameters.AddWithValue("@Usuario7", cliente.Usuario);
                mySqlCommand.Parameters.AddWithValue("@Contrasena8", cliente.Contraseña);*
            try
            {

                conexion.Conectar();
                  comando.Connection = conexion.Conection;
                  comando.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("No se encontro la base de datos" + ex.ToString());
                }
                conexion.Cerrar();          
            }
        }*/
}
