using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

//           Se definen los objetos de cada capa acceso datos para acceder al método propio de esas clases
//           Se agrega una clase por cada entidad lo cual tendrá acceso a datos de capa datos
//           Dentro de la clase logicanegocioclientes se define un objeto de la clase
//           accesodatosclientes para acceder a métodos propios de esta clase.

//           Luego se crearán un método por cada uno ubicado en accesodatosclientes.

namespace capaNegocio
{
   public class logicaNegocioUsuario
    {
        accesoDatosUsuario au = new accesoDatosUsuario();
        public int insertarUsuario(Usuario U)
        {
            return au.insertarUsuario(U);
        }

        public List<Usuario> listarUsuarios()
        {
            return au.listarUsuarios();
        }

        public int eliminarUsuarios(int iduser)
        {
            return au.eliminarUsuarios(iduser);
        }

        public int editarUsuarios(Usuario U)
        {
            return au.editarUsuarios(U);
        }

        public List<Usuario> buscarUsuarios(string dato)
        {
            return au.buscarUsuarios(dato);
        }
    }
}
