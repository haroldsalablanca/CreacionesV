using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosClientes
    {
        SqlConnection cnx;
        Clientes c = new Clientes();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Clientes> listaClientes = null;

        public int insertarClientes(Clientes c)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cliente", cnx); //'comentar' debe estar escrito tal cual esta en la table de Sql'
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idCliente", "");
                cm.Parameters.AddWithValue("@Nombres", c.Nombres);
                cm.Parameters.AddWithValue("@Apellidos", c.Apellidos);
                cm.Parameters.AddWithValue("@Cedula", c.Cedula);
                cm.Parameters.AddWithValue("@Direccion", c.Direccion);
                cm.Parameters.AddWithValue("@Telefono", c.Telefono);
                cm.Parameters.AddWithValue("@Email", c.Email);

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
        public List<Clientes> listarClientes()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Cliente", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idCliente", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Direccion", "");
                cm.Parameters.AddWithValue("@Telefono", "");
                cm.Parameters.AddWithValue("@Email", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaClientes = new List<Clientes>();
                while (dr.Read())
                {
                    Clientes l = new Clientes();
                    l.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                    l.Nombres = dr["Nombres"].ToString();
                    l.Apellidos = dr["Apellidos"].ToString();
                    l.Cedula = dr["Cedula"].ToString();
                    l.Direccion = dr["Direccion"].ToString();
                    l.Telefono = dr["Telefono"].ToString();
                    l.Email = dr["Email"].ToString();
                    listaClientes.Add(l);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaClientes = null;
            }
            finally
            { cm.Connection.Close(); }
            return listaClientes;

        }

        public int eliminarClientes(int idclient)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cliente", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idCliente", idclient);
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Direccion", "");
                cm.Parameters.AddWithValue("@Telefono", "");
                cm.Parameters.AddWithValue("@Email", "");

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

        public int editarClientes(Clientes cli)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Cliente", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idCliente", "");
                cm.Parameters.AddWithValue("@Nombres", c.Nombres);
                cm.Parameters.AddWithValue("@Apellidos", c.Apellidos);
                cm.Parameters.AddWithValue("@Cedula", c.Cedula);
                cm.Parameters.AddWithValue("@Direccion", c.Direccion);
                cm.Parameters.AddWithValue("@Telefono", c.Telefono);
                cm.Parameters.AddWithValue("@Email", c.Email);

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

        public List<Clientes> buscarClientes(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Cliente", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idCliente", "");
                cm.Parameters.AddWithValue("@Nombres", dato);
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Direccion", "");
                cm.Parameters.AddWithValue("@Telefono", "");
                cm.Parameters.AddWithValue("@Email", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaClientes = new List<Clientes>();
                while (dr.Read())
                {
                    Clientes l = new Clientes();
                    l.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                    l.Nombres = dr["Nombre"].ToString();
                    l.Apellidos = dr["Apellidos"].ToString();
                    l.Cedula = dr["Cedula"].ToString();
                    l.Direccion = dr["Direccion"].ToString();
                    l.Telefono = dr["Telefono"].ToString();
                    l.Email = dr["Email"].ToString();
                    listaClientes.Add(l);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }

            finally
            { cm.Connection.Close(); }
            return listaClientes;

        }
    }
}
