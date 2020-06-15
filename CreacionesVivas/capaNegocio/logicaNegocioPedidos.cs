using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

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
