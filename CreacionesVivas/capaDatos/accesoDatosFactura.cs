using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosFactura
    {
        SqlConnection cnx;
        Factura F = new Factura();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;

        SqlDataReader dr = null;
        List<Factura> listaFactura = null;

        //DEFINICIÓN DEL MÉTODO INSERTAR FACTURA
        public int insertarFactura(Factura F)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Facturas", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idFactura", "");
                cm.Parameters.AddWithValue("@Fecha", F.Fecha);
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

        //DEFINICIÓN DEL MÉTODO LISTAR FACTURA
        public List<Factura> listarFactura()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Facturas", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idFactura", "");
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("@idCliente", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaFactura = new List<Factura>();

                while (dr.Read())
                {
                    Factura f = new Factura();
                    f.idFactura = Convert.ToInt32(dr["idFactura"].ToString());
                    f.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                    f.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                    listaFactura.Add(F);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaFactura = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaFactura;
        }

        //DEFINICIÓN DEL MÉTODO ELIMINAR FACTURA
        public int eliminarFactura(int idFact)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Productos", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idFactura", idFact);
                cm.Parameters.AddWithValue("@Fecha", "");
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

        //DEFINICIÓN DEL MÉTODO ACTUALIZAR FACTURA
        public int editarFactura(Factura F)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Facturas", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idFacturas", F.idFactura);
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("@idCliente", F.idCliente);

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

        //DEFINICIÓN DEL MÉTODO BUSCAR FACTURA
        public List<Factura> buscarFactura(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Facturas", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idFactura", "");
                cm.Parameters.AddWithValue("@Fecha", dato);
                cm.Parameters.AddWithValue("@idCliente", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaFactura = new List<Factura>();

                while (dr.Read())
                {
                    Factura f = new Factura();
                    f.idFactura = Convert.ToInt32(dr["idFactura"].ToString());
                    f.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                    f.idCliente = Convert.ToInt32(dr["idCliente"].ToString());

                    listaFactura.Add(f);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaFactura = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaFactura;
        }
    }

}
