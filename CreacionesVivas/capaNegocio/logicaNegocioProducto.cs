using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioProducto
    {
        accesoDatosProducto apr = new accesoDatosProducto();
        public int insertarProducto(Producto P)
        {
            return apr.insertarProducto(P);
        }

        public List<Producto> listarProducto()
        {
            return apr.listarProducto();
        }

        public int eliminarProducto(int idProd)
        {
            return apr.eliminarProducto(idProd);
        }

        public int editarProducto(Producto p)
        {
            return apr.editarProducto(p);
        }

        public List<Producto> buscarProducto(string dato)
        {
            return apr.buscarProducto(dato);
        }
    }
}
