using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Pedidos
    {
        public int idPedido { get; set; }
        public string DireccionEnvio { get; set; }
        public string CantidadSolicitada { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int idUsuario { get; set; }
        public int idCliente { get; set; }
    }
}
