using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class Factura
    {
        public int idFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int idCliente { get; set; }

    }
}
