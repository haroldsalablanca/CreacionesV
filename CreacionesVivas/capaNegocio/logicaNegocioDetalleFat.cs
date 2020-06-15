using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

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
