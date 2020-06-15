using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Atributos que son agregados con respecto a la tabla de origen de la base de datos, estos
//hacen función en las demás capas, a través de los métodos get y set, a si mismo funcionan en las demás entidades.
namespace capaEntidades
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public string Colores { get; set; }
        public string Descripcion { get; set; }
        public string Tamaño { get; set; }
        public string Precio { get; set; }
    }
}
