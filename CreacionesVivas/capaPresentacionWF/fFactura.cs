using System;
using System.Collections.Generic;
using System.Windows.Forms;
using capaNegocio;
using capaEntidades;

namespace capaPresentacionWF
{
    public partial class fFactura : Form
    {
        logicaNegocioFactura logicaNR = new logicaNegocioFactura();
        public fFactura()
        { InitializeComponent(); }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Factura objetoFactura = new Factura();
                    objetoFactura.Fecha = Convert.ToDateTime(dateTimePickerFecha.Text);
                    objetoFactura.idCliente = Convert.ToInt32(textBoxIdCliente.Text);

                    if (logicaNR.insertarFactura(objetoFactura) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewFactura.DataSource = logicaNR.listarFactura();
                        dateTimePickerFecha.Text = "";
                        textBoxIdCliente.Text = "";
                        tabControlFactura.SelectedTab = tabPage2; //Consultar
                    }
                    else { MessageBox.Show("Error al agregar Factura"); }
                }
                if (buttonGuardar.Text == "Actualizar")
                {
                    Factura objetoFactura = new Factura();
                    objetoFactura.Fecha = Convert.ToDateTime(dateTimePickerFecha.Text);
                    objetoFactura.idCliente = Convert.ToInt32(textBoxIdCliente.Text);

                    if (logicaNR.editarFactura(objetoFactura) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewFactura.DataSource = logicaNR.listarFactura();
                        dateTimePickerFecha.Text = "";
                        textBoxIdCliente.Text = "";
                        tabControlFactura.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Factura");
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
        private void tabControlFactura_Click_1(object sender, EventArgs e)
        {
            textBoxId.Visible = false;
            labelId.Visible = false;
            dataGridViewFactura.DataSource = logicaNR.listarFactura();
        }

        //Boton Buscar en Detalle de Recursos
        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            List<Factura> listarFactura = logicaNR.buscarFactura(textBoxBuscar.Text);
            dataGridViewFactura.DataSource = listarFactura;
        }

        private void buttonEditar_Click_1(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelId.Visible = true;

            textBoxId.Text = dataGridViewFactura.CurrentRow.Cells["idFactura"].Value.ToString();
            dateTimePickerFecha.Text = dataGridViewFactura.CurrentRow.Cells["Fecha"].Value.ToString();
            textBoxIdCliente.Text = dataGridViewFactura.CurrentRow.Cells["idCliente"].Value.ToString();
            

            tabControlFactura.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoR = Convert.ToInt32(dataGridViewFactura.CurrentRow.Cells["idFactura"].Value.ToString());
            try
            {
                if (logicaNR.eliminarFactura(codigoR) > 0)
                {
                    MessageBox.Show("Eliminado con éxito!");
                    dataGridViewFactura.DataSource = logicaNR.listarFactura();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al elminar Factura");
            }
        }
    }
}
