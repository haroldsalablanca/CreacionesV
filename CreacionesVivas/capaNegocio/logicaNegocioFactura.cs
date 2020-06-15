using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaNegocioFactura
    {
        accesoDatosFactura af = new accesoDatosFactura();
        public int insertarFactura(Factura F)
        {
            return af.insertarFactura(F);
        }

        public List<Factura> listarFactura()
        {
            return af.listarFactura();
        }

        public int eliminarFactura(int idFact)
        {
            return af.eliminarFactura(idFact);
        }

        public int editarFactura(Factura F)
        {
            return af.editarFactura(F);
        }

        public List<Factura> buscarFactura(string dato)
        {
            return af.buscarFactura(dato);
        }
    }
}
