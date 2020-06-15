using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Atributos que son agregados con respecto a la tabla de origen de la base de datos, estos
//hacen función en las demás capas, a través de los métodos get y set, a si mismo funcionan en las demás entidades.

namespace capaEntidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
