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
using capaEntidades;

namespace capaPresentacionWF
{
    public partial class fProductos : Form
    {
        logicaNegocioProducto logicaNP = new logicaNegocioProducto();
        public fProductos()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Producto objetoProducto = new Producto();
                    //objetoRecurso.idrecursos = Convert.ToInt32(textBoxId.Text);
                    objetoProducto.Nombre = textBoxNombre.Text;
                    objetoProducto.Colores = textBoxColores.Text;
                    objetoProducto.Descripcion = textBoxDescripcion.Text;
                    objetoProducto.Tamaño = textBoxTamaño.Text;
                    objetoProducto.Precio = textBoxPrecio.Text;
                    
                    if (logicaNP.insertarProducto(objetoProducto) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewProductos.DataSource = logicaNP.listarProducto();
                        //textBoxId.Text = "";
                        textBoxNombre.Text = "";
                        textBoxColores.Text = "";
                        textBoxDescripcion.Text = "";
                        textBoxTamaño.Text = "";
                        textBoxPrecio.Text = "";
                        tabControlProductos.SelectedTab = tabPage2; //Consultar
                    }
                    else { MessageBox.Show("Error al agregar Producto"); }
                }
                if (buttonGuardar.Text == "Actualizar")
                {
                    Producto objetoProducto = new Producto();
                    objetoProducto.idProducto = Convert.ToInt32(textBoxId.Text);
                    objetoProducto.Nombre = textBoxNombre.Text;
                    objetoProducto.Colores = textBoxColores.Text;
                    objetoProducto.Descripcion = textBoxDescripcion.Text;
                    objetoProducto.Tamaño = textBoxTamaño.Text;
                    objetoProducto.Precio = textBoxPrecio.Text;

                    if (logicaNP.editarProducto(objetoProducto) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewProductos.DataSource = logicaNP.listarProducto();
                        textBoxNombre.Text = "";
                        textBoxColores.Text = "";
                        textBoxDescripcion.Text = "";
                        textBoxTamaño.Text = "";
                        textBoxPrecio.Text = "";
                        tabControlProductos.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Producto");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        //Ocultar Id cuando se agrega un nuevo Producto "Se agrega por defecto"
        private void tabControl1_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = false;
            labelId.Visible = false;
            dataGridViewProductos.DataSource = logicaNP.listarProducto();
        }

        //Boton Buscar en Detalle de Recursos
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Producto> listaProducto = logicaNP.buscarProducto(textBoxBuscar.Text);
            dataGridViewProductos.DataSource = listaProducto;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelId.Visible = true;

            textBoxId.Text = dataGridViewProductos.CurrentRow.Cells["idProducto"].Value.ToString();
            textBoxNombre.Text = dataGridViewProductos.CurrentRow.Cells["Nombre"].Value.ToString();
            textBoxColores.Text = dataGridViewProductos.CurrentRow.Cells["Colores"].Value.ToString();
            textBoxDescripcion.Text = dataGridViewProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
            textBoxTamaño.Text = dataGridViewProductos.CurrentRow.Cells["Tamaño"].Value.ToString();
            textBoxPrecio.Text = dataGridViewProductos.CurrentRow.Cells["Precio"].Value.ToString();

            tabControlProductos.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoP = Convert.ToInt32(dataGridViewProductos.CurrentRow.Cells["idProducto"].Value.ToString());
            try
            {
                if (logicaNP.eliminarProducto(codigoP) > 0)
                {
                    MessageBox.Show("Eliminado con éxito!");
                    dataGridViewProductos.DataSource = logicaNP.listarProducto();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al elminar Producto");
            }
        }
    }
}
