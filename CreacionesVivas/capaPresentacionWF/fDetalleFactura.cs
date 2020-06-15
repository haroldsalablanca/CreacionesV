using System;
using System.Collections.Generic;

using System.Windows.Forms;
using capaNegocio;
using capaEntidades;

namespace capaPresentacionWF
{
    public partial class fDetalleFactura : Form
    {
        logicaNegocioDetalleFat logicaNR = new logicaNegocioDetalleFat();
        public fDetalleFactura()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
                try
                {
                    if (buttonGuardar.Text == "Guardar")
                    {
                        DetalleFact objetoDetalleF = new DetalleFact();
                        //objetoRecurso.idrecursos = Convert.ToInt32(textBoxId.Text);
                        objetoDetalleF.Descripcion = textBoxDescripcion.Text;
                        objetoDetalleF.CantidadV = textBoxCantidadV.Text;
                        objetoDetalleF.Precio = textBoxPrecio.Text;
                        objetoDetalleF.idFactura = Convert.ToInt32(textBoxIdFactura.Text);
                        objetoDetalleF.idProducto = Convert.ToInt32(textBoxIdProducto.Text);

                        if (logicaNR.insertarDetalleFact(objetoDetalleF) > 0)
                        {
                            MessageBox.Show("Agregado con éxito");
                            dataGridViewDetalleFact.DataSource = logicaNR.listarDetalleFact();
                            //textBoxId.Text = "";
                            textBoxDescripcion.Text = "";
                            textBoxCantidadV.Text = "";
                            textBoxPrecio.Text = "";
                            textBoxIdFactura.Text = "";
                            textBoxIdProducto.Text = "";
                            tabControlDetalleFact.SelectedTab = tabPage2; //Consultar
                        }
                        else { MessageBox.Show("Error al agregar Clientes"); }
                    }
                    if (buttonGuardar.Text == "Actualizar")
                    {
                        DetalleFact objetoDetalleFact = new DetalleFact();
                        //objetoRecurso.idrecursos = Convert.ToInt32(textBoxId.Text);
                        objetoDetalleFact.Descripcion = textBoxDescripcion.Text;
                        objetoDetalleFact.CantidadV = textBoxCantidadV.Text;
                        objetoDetalleFact.Precio = textBoxPrecio.Text;
                        objetoDetalleFact.idFactura = Convert.ToInt32(textBoxIdFactura.Text);
                        objetoDetalleFact.idProducto = Convert.ToInt32(textBoxIdProducto.Text);

                    if (logicaNR.editarDetalleFact(objetoDetalleFact) > 0)
                        {
                            MessageBox.Show("Agregado con éxito");
                            dataGridViewDetalleFact.DataSource = logicaNR.listarDetalleFact();
                            //textBoxId.Text = "";
                            textBoxDescripcion.Text = "";
                            textBoxCantidadV.Text = "";
                            textBoxPrecio.Text = "";
                            textBoxIdFactura.Text = "";
                            textBoxIdProducto.Text = "";
                            tabControlDetalleFact.SelectedTab = tabPage2;
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar Detalle Factura");
                        }
                        buttonGuardar.Text = "Guardar";
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
            }

            //// Esta Tabla no tiene el ID entonces por eso en comentario
            //private void tabControlClientes_Click_1(object sender, EventArgs e)
            //{
            //    textBoxId.Visible = false;
            //    labelId.Visible = false;
            //    dataGridViewDetalleFact.DataSource = logicaNR.listarClientes();
            //}

            //Boton Buscar en Detalle de Recursos
            private void buttonBuscar_Click(object sender, EventArgs e)
            {
                List<DetalleFact> listarDetalleFact = logicaNR.buscarDetalleFact(textBoxBuscar.Text);
                dataGridViewDetalleFact.DataSource = listarDetalleFact;
            }

            private void buttonEditar_Click(object sender, EventArgs e)
            {
                //textBoxDescripcion.Visible = true;
                //textBoxDescripcion.Enabled = false;
                //labelDescripcion.Visible = true;

                textBoxDescripcion.Text = dataGridViewDetalleFact.CurrentRow.Cells["Descripcion"].Value.ToString();
                textBoxCantidadV.Text = dataGridViewDetalleFact.CurrentRow.Cells["CantidadV"].Value.ToString();
                textBoxPrecio.Text = dataGridViewDetalleFact.CurrentRow.Cells["Precio"].Value.ToString();
                textBoxIdFactura.Text = dataGridViewDetalleFact.CurrentRow.Cells["idFactura"].Value.ToString();
                textBoxIdProducto.Text = dataGridViewDetalleFact.CurrentRow.Cells["idProducto"].Value.ToString();
                
                tabControlDetalleFact.SelectedTab = tabPage1;
                buttonGuardar.Text = "Actualizar";
            }

            private void buttonEliminar_Click_1(object sender, EventArgs e)
            {
                string codigoR = dataGridViewDetalleFact.CurrentRow.Cells["Descripcion"].Value.ToString();
                try
                {
                    if (logicaNR.eliminarDetalleFact(codigoR) > 0)
                    {
                        MessageBox.Show("Eliminado con éxito!");
                        dataGridViewDetalleFact.DataSource = logicaNR.listarDetalleFact();
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR al elminar Detalle Factura");
                }
            }
    }
}
