using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacionWF
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDICreacionesVivas());
            //Application.Run(new fUsuario());
            //Application.Run(new fClientes());
            //Application.Run(new fFactura());
            //Application.Run(new fDetalleFactura());
            //Application.Run(new fProductos());
            //Application.Run(new fRedSocial());
            //Application.Run(new fPedidos());
         
        }
    }
}
