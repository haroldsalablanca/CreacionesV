using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

//           Se definen los objetos de cada capa acceso datos para acceder al método propio de esas clases.

//           Se agrega una clase por cada entidad, lo cual tendrá acceso a datos de capa datos
//           Dentro de la clase logicanegocioclientes se define un objeto de la clase
//           accesodatosclientes para acceder a métodos propios de esta clase.

//           Luego se crearán un método por cada uno ubicado en accesodatosclientes.

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
