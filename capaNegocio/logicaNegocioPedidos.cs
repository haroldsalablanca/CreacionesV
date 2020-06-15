using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

//           Se definen los objetos de cada capa acceso datos para acceder al método propio de esas clases.

//           Se agrega una clase por cada entidad, lo cual tendrá acceso a datos de capa datos
//           Dentro de la clase logicanegocioclientes se define un objeto de la clase
//           accesodatosclientes para acceder a métodos propios de esta clase.

//           Luego se crearán un método por cada uno ubicado en accesodatosclientes.

namespace capaNegocio
{
    public class logicaNegocioPedidos
    {
        accesoDatosPedidos ap = new accesoDatosPedidos();
        public int insertarPedidos(Pedidos pd)
        {
            return ap.insertarPedidos(pd);
        }

        public List<Pedidos> listarPedidos()
        {
            return ap.listarPedidos();
        }

        public int eliminarPedidos(int idPed)
        {
            return ap.eliminarPedidos(idPed);
        }

        public int editarPedidos(Pedidos pd)
        {
            return ap.editarPedidos(pd);
        }

        public List<Pedidos> buscarPedidos(string dato)
        {
            return ap.buscarPedidos(dato);
        }
    }
}
