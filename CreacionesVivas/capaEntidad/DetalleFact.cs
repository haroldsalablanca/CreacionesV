using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class DetalleFact
    {
        public string Descripcion { get; set; }
        public string CantidadV { get; set; }
        public string Precio { get; set; }
        public int idFactura { get; set; }
        public int idProducto { get; set; }

    }
}
