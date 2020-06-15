using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

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
