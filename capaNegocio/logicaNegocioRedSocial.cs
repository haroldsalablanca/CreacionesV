using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

//           Se definen los objetos de cada capa acceso datos para acceder al método propio de esas clases.

//           Se agrega una clase por cada entidad, lo cual tendrá acceso a datos de capa datos
//           Dentro de la clase logicanegocioclientes se define un objeto de la clase
//           accesodatosclientes para acceder a métodos propios de esta clase.

//           Luego se crearán un método por cada uno ubicado en accesodatosclientes.

namespace capaNegocio
{
    public class logicaNegocioRedSocial
    {
        accesoDatosRedSocial ars = new accesoDatosRedSocial();
        public int insertarRedSocial(RedSocial RS)
        {
            return ars.insertarRedSocial(RS);
        }

        public List<RedSocial> listarRedSocial()
        {
            return ars.listarRedSocial();
        }

        public int eliminarRedSocial(int idRedS)
        {
            return ars.eliminarRedSocial(idRedS);
        }

        public int editarRedSocial(RedSocial RS)
        {
            return ars.editarRedSocial(RS);
        }

        public List<RedSocial> buscarRedSocial(string dato)
        {
            return ars.buscarRedSocial(dato);
        }
    }
}
