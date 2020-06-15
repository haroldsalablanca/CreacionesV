using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

//           Se definen los objetos de cada capa acceso datos para acceder al método propio de esas clases
//           Se agrega una clase por cada entidad lo cual tendrá acceso a datos de capa datos
//           Dentro de la clase logicanegocioclientes se define un objeto de la clase
//           accesodatosclientes para acceder a métodos propios de esta clase.

//           Luego se crearán un método por cada uno ubicado en accesodatosclientes.

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

    //      Cada método creado en este espacio  únicamente regresan lo que devuelve cada método de acceso datos clientes.
    //      El usuario no tendrá acceso directo a capa datos.
}
