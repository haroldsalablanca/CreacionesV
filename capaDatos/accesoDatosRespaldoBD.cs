using System;
using System.Data.SqlClient;
using System.Data;
namespace capaDatos
{
    public class accesoDatosRespaldoBD
    {
        SqlConnection cnx;              //Conexion a la BD
        Conexion cn = new Conexion();   
        SqlCommand cm = null;           //Conectando a SQL Server
        int indicador = 0;

        public int respaldarBD()
        {
            try
            {
                SqlConnection cnx = cn.conectar();   //Conexion

                cm = new SqlCommand("RespaldoBD_CreacionesV", cnx); // Se manda a llamar al procedimiento
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            { cm.Connection.Close(); }
            return indicador;
        }
    }
}
