using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

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
