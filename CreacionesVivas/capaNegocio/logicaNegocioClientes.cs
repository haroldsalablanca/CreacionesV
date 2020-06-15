using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaNegocioClientes
    {
        accesoDatosClientes ac = new accesoDatosClientes();
        public int insertarClientes(Clientes c)
        {
            return ac.insertarClientes(c);
        }

        public List<Clientes> listarClientes()
        {
            return ac.listarClientes();
        }

        public int eliminarClientes(int idclient)
        {
            return ac.eliminarClientes(idclient);
        }

        public int editarClientes(Clientes c)
        {
            return ac.editarClientes(c);
        }

        public List<Clientes> buscarClientes(string dato)
        {
            return ac.buscarClientes(dato);
        }
    }
}
