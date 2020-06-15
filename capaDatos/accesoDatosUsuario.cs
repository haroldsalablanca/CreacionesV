using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosUsuario
    {
        SqlConnection cnx;
        Usuario U = new Usuario();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;

        SqlDataReader dr = null;
        List<Usuario> listarUsuario = null;

        //DEFINICIÓN DEL MÉTODO INSERTAR USUARIO
        public int insertarUsuario(Usuario U)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuarios", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idUsuario", "");
                cm.Parameters.AddWithValue("@Cedula", U.Cedula);
                cm.Parameters.AddWithValue("@Nombres", U.Nombres);
                cm.Parameters.AddWithValue("@Apellidos", U.Apellidos);
                cm.Parameters.AddWithValue("@Direccion", U.Direccion);
                cm.Parameters.AddWithValue("@Telefono", U.Telefono);

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
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        //DEFINICIÓN DEL MÉTODO LISTAR PRODUCTO
        public List<Usuario> listarUsuarios()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuarios", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idUsuario", "");
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Direccion", "");
                cm.Parameters.AddWithValue("@Telefono", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listarUsuario = new List<Usuario>();

                while (dr.Read())
                {
                    Usuario u = new Usuario();
                    u.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                    u.Cedula = dr["Cedula"].ToString();
                    u.Nombres = dr["Nombres"].ToString();
                    u.Apellidos = dr["Apellidos"].ToString();
                    u.Direccion = dr["Direccion"].ToString();
                    u.Telefono = dr["Telefono"].ToString();
                    listarUsuario.Add(u);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listarUsuario = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listarUsuario;
        }

        //DEFINICIÓN DEL MÉTODO ELIMINAR PRODUCTO
        public int eliminarUsuarios(int iduser)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuarios", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idUsuario", iduser);
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Direccion", "");
                cm.Parameters.AddWithValue("@Telefono", "");

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
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        //DEFINICIÓN DEL MÉTODO ACTUALIZAR PRODUCTO
        public int editarUsuarios(Usuario U)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Productos", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idUsuario", "");
                cm.Parameters.AddWithValue("@Cedula", U.Cedula);
                cm.Parameters.AddWithValue("@Nombres", U.Nombres);
                cm.Parameters.AddWithValue("@Apellidos", U.Apellidos);
                cm.Parameters.AddWithValue("@Direccion", U.Direccion);
                cm.Parameters.AddWithValue("@Telefono", U.Telefono);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        //DEFINICIÓN DEL MÉTODO BUSCAR PRODUCTO
        public List<Usuario> buscarUsuarios(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuarios", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idUsuario", "");
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Nombres", dato);
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Direccion", "");
                cm.Parameters.AddWithValue("@Telefono", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listarUsuario = new List<Usuario>();

                while (dr.Read())
                {
                    Usuario u = new Usuario();
                    u.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                    u.Cedula = dr["Cedula"].ToString();
                    u.Nombres = dr["Nombres"].ToString();
                    u.Apellidos = dr["Apellidos"].ToString();
                    u.Direccion = dr["Direccion"].ToString();
                    u.Telefono = dr["Telefono"].ToString();
                    listarUsuario.Add(u);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listarUsuario = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listarUsuario;
        }
    }
}
