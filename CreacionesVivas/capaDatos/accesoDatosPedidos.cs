using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using capaEntidad;

namespace capaDatos
{
    public class accesoDatosPedidos
    {
        SqlConnection cnx;
        Pedidos pd = new Pedidos();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;

        SqlDataReader dr = null;
        List<Pedidos> listaPedidos = null;

        //DEFINICIÓN DEL MÉTODO INSERTAR PEDIDOS
        public int insertarPedidos(Pedidos pd)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Pedido", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idPedidos", "");
                cm.Parameters.AddWithValue("@DireccionEnvio", pd.DireccionEnvio);
                cm.Parameters.AddWithValue("@CantidadSolicitada", pd.CantidadSolicitada);
                cm.Parameters.AddWithValue("@FechaSolicitud", pd.FechaSolicitud);
                cm.Parameters.AddWithValue("@FechaEntrega", pd.FechaEntrega);
                cm.Parameters.AddWithValue("@idUsuario", pd.idUsuario);
                cm.Parameters.AddWithValue("@idUsuario", pd.idCliente);

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

        //DEFINICIÓN DEL MÉTODO LISTAR PEDIDOS
        public List<Pedidos> listarPedidos()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Pedido", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idPedido", "");
                cm.Parameters.AddWithValue("@DireccionEnvio", "");
                cm.Parameters.AddWithValue("@CantidadSolicitada", "");
                cm.Parameters.AddWithValue("@FechaSolicitud", "");
                cm.Parameters.AddWithValue("@FechaEntrega", "");
                cm.Parameters.AddWithValue("@idUsuario", "");
                cm.Parameters.AddWithValue("@idCliente", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaPedidos = new List<Pedidos>();

                while (dr.Read())
                {
                    Pedidos p = new Pedidos();
                    p.idPedido = Convert.ToInt32(dr["idPedidos"].ToString());
                    p.DireccionEnvio = dr["DireccionEnvio"].ToString();
                    p.DireccionEnvio = dr["CantidadSolicitada"].ToString();
                    p.FechaSolicitud = Convert.ToDateTime(dr["FechaSolicitud"].ToString());
                    p.FechaEntrega = Convert.ToDateTime(dr["FechaEntrega"].ToString());
                    p.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                    p.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                    listaPedidos.Add(p);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaPedidos = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaPedidos;
        }

        //DEFINICIÓN DEL MÉTODO ELIMINAR PEDIDOS
        public int eliminarPedidos(int idPed)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Pedido", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idPedido", idPed);
                cm.Parameters.AddWithValue("@DireccionEnvio", "");
                cm.Parameters.AddWithValue("@CantidadSolicitada", "");
                cm.Parameters.AddWithValue("@FechaSolicitud", "");
                cm.Parameters.AddWithValue("@FechaEntrega", "");
                cm.Parameters.AddWithValue("@idUsuario", "");
                cm.Parameters.AddWithValue("@idCliente", "");

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

        //DEFINICIÓN DEL MÉTODO ACTUALIZAR PEDIDOS
        public int editarPedidos(Pedidos pd)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Pedido", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idPedido", "");
                cm.Parameters.AddWithValue("@DireccionEnvio", pd.DireccionEnvio);
                cm.Parameters.AddWithValue("@CantidadSolicitada", pd.CantidadSolicitada);
                cm.Parameters.AddWithValue("@FechaSolicitud", pd.FechaSolicitud);
                cm.Parameters.AddWithValue("@FechaEntrega", pd.FechaEntrega);
                cm.Parameters.AddWithValue("@idUsuario", "");
                cm.Parameters.AddWithValue("@idCliente", "");

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

        //DEFINICIÓN DEL MÉTODO BUSCAR PEDIDOS
        public List<Pedidos> buscarPedidos(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Pedido", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idPedido", dato);
                cm.Parameters.AddWithValue("@DireccionEnvio", "");
                cm.Parameters.AddWithValue("@CantidadSolicitada", "");
                cm.Parameters.AddWithValue("@FechaSolicitud", "");
                cm.Parameters.AddWithValue("@FechaEntrega", "");
                cm.Parameters.AddWithValue("@idUsuario", "");
                cm.Parameters.AddWithValue("@idCliente", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaPedidos = new List<Pedidos>();

                while (dr.Read())
                {
                    Pedidos p = new Pedidos();
                    p.idPedido = Convert.ToInt32(dr["idPedidos"].ToString());
                    p.DireccionEnvio = dr["DireccionEnvio"].ToString();
                    p.DireccionEnvio = dr["CantidadSolicitada"].ToString();
                    p.FechaSolicitud = Convert.ToDateTime(dr["FechaSolicitud"].ToString());
                    p.FechaEntrega = Convert.ToDateTime(dr["FechaEntrega"].ToString());
                    p.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                    p.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                    listaPedidos.Add(p);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaPedidos = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaPedidos;
        }
    }
}
