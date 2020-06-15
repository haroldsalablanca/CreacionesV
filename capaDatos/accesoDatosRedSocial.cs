using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosRedSocial
    {
        SqlConnection cnx;
        RedSocial RS = new RedSocial();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;

        SqlDataReader dr = null;
        List<RedSocial> listaRedSocial = null;

        //DEFINICIÓN DEL MÉTODO INSERTAR REDSOCIAL
        public int insertarRedSocial(RedSocial RS)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RedesSociales", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idRedSocial", "");
                cm.Parameters.AddWithValue("@NombreR", RS.NombreR);
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

        //DEFINICIÓN DEL MÉTODO LISTAR REDSOCIAL
        public List<RedSocial> listarRedSocial()
        {
            try
            {
                SqlConnection cnx = cn.conectar();


                cm = new SqlCommand("RedesSociales", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idRedSocial", "");
                cm.Parameters.AddWithValue("@NombreR", "");
                cm.Parameters.AddWithValue("@idCliente", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaRedSocial = new List<RedSocial>();

                while (dr.Read())
                {
                    RedSocial r = new RedSocial();
                    r.idRedSocial = Convert.ToInt32(dr["idRedSocial"].ToString());
                    r.NombreR = dr["NombreR"].ToString();
                    r.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                    listaRedSocial.Add(r);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaRedSocial = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaRedSocial;
        }

        //DEFINICIÓN DEL MÉTODO ELIMINAR REDSOCIAL
        public int eliminarRedSocial(int idRedS)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RedesSociales", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idRedSocial", idRedS);
                cm.Parameters.AddWithValue("@NombreR", "");
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

        //DEFINICIÓN DEL MÉTODO ACTUALIZAR REDSOCIAL
        public int editarRedSocial(RedSocial RS)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RedesSociales", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idRedSocial", "");
                cm.Parameters.AddWithValue("@NombreR", RS.NombreR);
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

        //DEFINICIÓN DEL MÉTODO BUSCAR REDSOCIAL
        public List<RedSocial> buscarRedSocial(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RedesSociales", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idRedSocial", "");
                cm.Parameters.AddWithValue("@NombreR", dato);
                cm.Parameters.AddWithValue("@idCliente", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaRedSocial = new List<RedSocial>();

                while (dr.Read())
                {
                    RedSocial r = new RedSocial();
                    r.idRedSocial = Convert.ToInt32(dr["idRedSocial"].ToString());
                    r.NombreR = dr["NombreR"].ToString();
                    r.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                    listaRedSocial.Add(r);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaRedSocial = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaRedSocial;
        }
    }
}
