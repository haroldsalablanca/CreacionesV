using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosProducto
    {
        SqlConnection cnx;
        Producto P = new Producto();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;

        SqlDataReader dr = null;
        List<Producto> listaProducto = null;

        //DEFINICIÓN DEL MÉTODO INSERTAR PRODUCTO
        public int insertarProducto(Producto P)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Productos", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idProducto", "");
                cm.Parameters.AddWithValue("@Nombre", P.Nombre);
                cm.Parameters.AddWithValue("@Colores", P.Colores);
                cm.Parameters.AddWithValue("@Descripcion", P.Descripcion);
                cm.Parameters.AddWithValue("@Tamaño", P.Tamaño);
                cm.Parameters.AddWithValue("@Precio", P.Precio);

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
        public List<Producto> listarProducto()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Productos", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idProducto", "");
                cm.Parameters.AddWithValue("@Nombre", "");
                cm.Parameters.AddWithValue("@Colores", "");
                cm.Parameters.AddWithValue("@Descripcion", "");
                cm.Parameters.AddWithValue("@Tamaño", "");
                cm.Parameters.AddWithValue("@Precio", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProducto = new List<Producto>();

                while (dr.Read())
                {
                    Producto Pr = new Producto();
                    Pr.idProducto = Convert.ToInt32(dr["idProducto"].ToString());
                    Pr.Nombre = dr["Nombre"].ToString();
                    Pr.Colores = dr["Colores"].ToString();
                    Pr.Descripcion = dr["Descripcion"].ToString();
                    Pr.Tamaño = dr["Tamaño"].ToString();
                    Pr.Precio = dr["Precio"].ToString();
                    listaProducto.Add(Pr);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaProducto = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaProducto;
        }

        //DEFINICIÓN DEL MÉTODO ELIMINAR PRODUCTO
        public int eliminarProducto(int idProd)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Productos", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idProducto", idProd);
                cm.Parameters.AddWithValue("@Nombre", "");
                cm.Parameters.AddWithValue("@Colores", "");
                cm.Parameters.AddWithValue("@Descripcion", "");
                cm.Parameters.AddWithValue("@Tamaño", "");
                cm.Parameters.AddWithValue("@Precio", "");

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
        public int editarProducto(Producto Pr)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Productos", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idProducto", "");
                cm.Parameters.AddWithValue("@Nombre", P.Nombre);
                cm.Parameters.AddWithValue("@Colores", P.Colores);
                cm.Parameters.AddWithValue("@Descripcion", P.Descripcion);
                cm.Parameters.AddWithValue("@Tamaño", P.Tamaño);
                cm.Parameters.AddWithValue("@Precio", P.Precio);

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
        public List<Producto> buscarProducto(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Productos", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idProducto", "");
                cm.Parameters.AddWithValue("@Nombre", dato);
                cm.Parameters.AddWithValue("@Colores", "");
                cm.Parameters.AddWithValue("@Descripcion", "");
                cm.Parameters.AddWithValue("@Tamaño", "");
                cm.Parameters.AddWithValue("@Precio", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProducto = new List<Producto>();

                while (dr.Read())
                {
                    Producto Pr = new Producto();
                    Pr.idProducto = Convert.ToInt32(dr["idProducto"].ToString());
                    Pr.Nombre = dr["Nombre"].ToString();
                    Pr.Colores = dr["Colores"].ToString();
                    Pr.Descripcion = dr["Descripcion"].ToString();
                    Pr.Tamaño = dr["Tamaño"].ToString();
                    Pr.Precio = dr["Precio"].ToString();
                    listaProducto.Add(Pr);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaProducto = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaProducto;
        }
    }
}

