using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace capaPresentacionWF
{
    public partial class MDICreacionesVivas : Form
    {

        logicaNegocioRespaldo lN = new logicaNegocioRespaldo();

        private void respaldobdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lN.respaldarBD() > 0)
                {
                    MessageBox.Show("Respaldo realizado con éxito");
                }
            }
            catch { MessageBox.Show("Error al realizar el respaldo"); }
        }

        private int childFormNumber = 0;

        public MDICreacionesVivas()
        {
            InitializeComponent();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }


        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fUsuario"] != null)
            {
                Application.OpenForms["fUsuario"].Activate();
            }
            else
            {
                fUsuario fr = new fUsuario();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fClientes"] != null)
            {
                Application.OpenForms["fClientes"].Activate();
            }
            else
            {
                fClientes fr = new fClientes();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fProductos"] != null)
            {
                Application.OpenForms["fProductos"].Activate();
            }
            else
            {
                fProductos fr = new fProductos();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void pedidosAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fPedidos"] != null)
            {
                Application.OpenForms["fPedidos"].Activate();
            }
            else
            {
                fPedidos fr = new fPedidos();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void redsocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fRedSocial"] != null)
            {
                Application.OpenForms["fRedSocial"].Activate();
            }
            else
            {
                fRedSocial fr = new fRedSocial();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void facturatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fFactura"] != null)
            {
                Application.OpenForms["fFactura"].Activate();
            }
            else
            {
                fFactura fr = new fFactura();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void detallefacturatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fDetalleFactura"] != null)
            {
                Application.OpenForms["fDetalleFactura"].Activate();
            }
            else
            {
                fDetalleFactura fr = new fDetalleFactura();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
        }
        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("¿Está seguro de que quiere cerrar la aplicación?",
                                                                     "Cerrar la aplicación", MessageBoxButtons.YesNo,
                                                                     MessageBoxIcon.Question);
            return res;
        }
    }
}
