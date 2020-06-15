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
using capaEntidad;

namespace capaPresentacionWF
{
    public partial class fPedidos : Form
    {
        logicaNegocioPedidos logicaNP = new logicaNegocioPedidos();
        public fPedidos()
        {
            InitializeComponent();
        }
//             FORMULARIOS 
//             Se crearán botones que servirán para guardar, editar, eliminar, insertar y actualizar datos 
//             que serán guardados directamente en la base de datos.

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Pedidos objetoPedido = new Pedidos();
                    objetoPedido.DireccionEnvio = textBoxDireccionEnvio.Text;
                    objetoPedido.CantidadSolicitada = textBoxCantidadSolicitada.Text;
                    objetoPedido.FechaSolicitud = textBoxFachaSolicitud.Text;
                    objetoPedido.FechaEntrega = textBoxFechaEntrega.Text;
                    objetoPedido.idUsuario = Convert.ToInt32(textBoxIdUsuario.Text);
                    objetoPedido.idCliente = Convert.ToInt32(textBoxIdCliente.Text);


                    if (logicaNP.insertarPedidos(objetoPedido) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewPedidos.DataSource = logicaNP.listarPedidos();
                        textBoxDireccionEnvio.Text = "";
                        textBoxCantidadSolicitada.Text = "";
                        textBoxFachaSolicitud.Text = "";
                        textBoxFechaEntrega.Text = "";
                        textBoxIdUsuario.Text = "";
                        textBoxIdCliente.Text = "";
                        tabControlPedidos.SelectedTab = tabPage2; //Consultar
                    }
                    else { MessageBox.Show("Error al agregar Pedidos"); }
                }
                if (buttonGuardar.Text == "Actualizar")
                {
                    Pedidos objetoPedidos = new Pedidos();
                    objetoPedidos.idPedido = Convert.ToInt32(textBoxId.Text);
                    objetoPedidos.DireccionEnvio = textBoxDireccionEnvio.Text;
                    objetoPedidos.CantidadSolicitada = textBoxCantidadSolicitada.Text;
                    objetoPedidos.FechaSolicitud = textBoxFachaSolicitud.Text;
                    objetoPedidos.FechaEntrega = textBoxFechaEntrega.Text;
                    objetoPedidos.idUsuario = Convert.ToInt32(textBoxIdUsuario.Text);
                    objetoPedidos.idCliente = Convert.ToInt32(textBoxIdCliente.Text);


                    if (logicaNP.editarPedidos(objetoPedidos) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewPedidos.DataSource = logicaNP.listarPedidos();
                        textBoxDireccionEnvio.Text = "";
                        textBoxCantidadSolicitada.Text = "";
                        textBoxFachaSolicitud.Text = "";
                        textBoxFechaEntrega.Text = "";
                        textBoxIdUsuario.Text = "";
                        textBoxIdCliente.Text = "";
                        tabControlPedidos.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Pedidos");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            }
            catch
            { MessageBox.Show("ERROR"); }
        }

       
        private void fPedidos_load(object sender, EventArgs e)
        {
            textBoxId.Visible = false; //Ocultamos Id de Pedidos
            labelId.Visible = false;
            dataGridViewPedidos.DataSource = logicaNP.listarPedidos(); //Se carga los datos
        }

        //Boton Buscar "Detalle del Producto" 
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Pedidos> listarPedidos = logicaNP.buscarPedidos(textBoxBuscar.Text);
            dataGridViewPedidos.DataSource = listarPedidos;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelId.Visible = true;

            textBoxId.Text = dataGridViewPedidos.CurrentRow.Cells["idPedidos"].Value.ToString();
            textBoxDireccionEnvio.Text = dataGridViewPedidos.CurrentRow.Cells["DireccionEnvio"].Value.ToString();
            textBoxCantidadSolicitada.Text = dataGridViewPedidos.CurrentRow.Cells["CantidadSolicitada"].Value.ToString();
            textBoxFachaSolicitud.Text = dataGridViewPedidos.CurrentRow.Cells["FechaSolicitud"].Value.ToString();
            textBoxFechaEntrega.Text = dataGridViewPedidos.CurrentRow.Cells["FechaEntrega"].Value.ToString();
            textBoxIdUsuario.Text = dataGridViewPedidos.CurrentRow.Cells["idUsuario"].Value.ToString();
            textBoxIdCliente.Text = dataGridViewPedidos.CurrentRow.Cells["idCliente"].Value.ToString();


            tabControlPedidos.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoR = Convert.ToInt32(dataGridViewPedidos.CurrentRow.Cells["idFactura"].Value.ToString());
            try
            {
                if (logicaNP.eliminarPedidos(codigoR) > 0)
                {
                    MessageBox.Show("Eliminado con éxito!");
                    dataGridViewPedidos.DataSource = logicaNP.listarPedidos();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al elminar Pedidos");
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Pedidos> listarPedidos = logicaNP.buscarPedidos(textBoxBuscar.Text);
            dataGridViewPedidos.DataSource = listarPedidos;
        }

      
    }
}
