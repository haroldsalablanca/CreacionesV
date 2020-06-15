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
    public class logicaNegocioDetalleFat
    {
        accesoDatosDetalleFact ad = new accesoDatosDetalleFact();
        public int insertarDetalleFact(DetalleFact D)
        {
            return ad.insertarDetalleFact(D);
        }

        public List<DetalleFact> listarDetalleFact()
        {
            return ad.listarDetalleFact();
        }
        public int eliminarDetalleFact(string Descp)
        {
            return ad.eliminarDetalleFact(Descp);
        }

        public int editarDetalleFact(DetalleFact D)
        {
            return ad.editarDetalleFact(D);
        }

        public List<DetalleFact> buscarDetalleFact(string dato)
        {
            return ad.buscarDetalleFact(dato);
        }
    }
}
