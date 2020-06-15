using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosDetalleFact
    {
        SqlConnection cnx;
        DetalleFact D = new DetalleFact();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;

        SqlDataReader dr = null;
        List<DetalleFact> listaDetalleFact = null;

        //DEFINICIÓN DEL MÉTODO INSERTAR DETALLEFACT
        public int insertarDetalleFact(DetalleFact D)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("DetalleFactura", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@Descripcion", D.Descripcion);
                cm.Parameters.AddWithValue("@CantidadV", D.CantidadV);
                cm.Parameters.AddWithValue("@Precio", D.Precio);
                cm.Parameters.AddWithValue("@idFactura", D.idFactura);
                cm.Parameters.AddWithValue("@idProducto", D.idProducto);


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

        //DEFINICIÓN DEL MÉTODO LISTAR DETALLEFACT
        public List<DetalleFact> listarDetalleFact()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("DetalleFactura", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@Descripcion", "");
                cm.Parameters.AddWithValue("@CantidadV", "");
                cm.Parameters.AddWithValue("@Precio", "");
                cm.Parameters.AddWithValue("@idFactura", "");
                cm.Parameters.AddWithValue("@idProducto", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaDetalleFact = new List<DetalleFact>();

                while (dr.Read())
                {
                    DetalleFact df = new DetalleFact();
                    df.Descripcion = dr["Descripcion"].ToString();
                    df.CantidadV = dr["CantidadV"].ToString();
                    df.Precio = dr["Precio"].ToString();
                    df.idFactura = Convert.ToInt32(dr["idFactura"].ToString());
                    df.idProducto = Convert.ToInt32(dr["idProducto"].ToString());
                    listaDetalleFact.Add(df);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaDetalleFact = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaDetalleFact;
        }

        //DEFINICIÓN DEL MÉTODO ELIMINAR DETALLEFACT
        public int eliminarDetalleFact(string Descp)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("DetalleFactura", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@Descripcion", Descp);
                cm.Parameters.AddWithValue("@CantidadV", "");
                cm.Parameters.AddWithValue("@Precio", "");
                cm.Parameters.AddWithValue("@idFactura", "");
                cm.Parameters.AddWithValue("@idProducto", "");

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
        public int editarDetalleFact(DetalleFact df)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("DetalleFactura", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@Descripcion", D.Descripcion);
                cm.Parameters.AddWithValue("@CantidadV", D.CantidadV);
                cm.Parameters.AddWithValue("@Precio", D.Precio);
                cm.Parameters.AddWithValue("@idFactura", "");
                cm.Parameters.AddWithValue("@idProducto", "");

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


        //DEFINICIÓN DEL MÉTODO BUSCAR DETALLEFACT
        public List<DetalleFact> buscarDetalleFact(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("DetalleFact", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@Descripcion", dato);
                cm.Parameters.AddWithValue("@CantidadV", "");
                cm.Parameters.AddWithValue("@Precio", "");
                cm.Parameters.AddWithValue("@idFactura", "");
                cm.Parameters.AddWithValue("@idProducto", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaDetalleFact = new List<DetalleFact>();

                while (dr.Read())
                {
                    DetalleFact df = new DetalleFact();
                    df.Descripcion = dr["Descripcion"].ToString();
                    df.CantidadV = dr["CantidadV"].ToString();
                    df.Precio = dr["Precio"].ToString();
                    df.idFactura = Convert.ToInt32(dr["idFactura"].ToString());
                    df.idProducto = Convert.ToInt32(dr["idProducto"].ToString());
                    listaDetalleFact.Add(df);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaDetalleFact = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaDetalleFact;
        }
    }
}


