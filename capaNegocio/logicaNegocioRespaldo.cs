using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

// Logica negocio para el respaldo de la base de dato.

namespace capaNegocio
{
    public class logicaNegocioRespaldo
    {
        accesoDatosRespaldoBD rbd = new accesoDatosRespaldoBD();  
        public int respaldarBD()    
        {
            return rbd.respaldarBD();
        }
    }
}
