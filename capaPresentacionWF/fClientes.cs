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
    public partial class fClientes : Form
    {
        logicaNegocioClientes logicaNC = new logicaNegocioClientes();
        public fClientes()
        {
            InitializeComponent();
        }

//                   FORMULARIOS 
//                   Se crearán botones que servirán para guardar, editar, eliminar, insertar y actualizar datos 
//                   que serán guardados directamente en la base de datos.

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Clientes objetoCliente = new Clientes();
                    objetoCliente.Nombres = textBoxNombres.Text;
                    objetoCliente.Apellidos = textBoxApellidos.Text;
                    objetoCliente.Cedula = textBoxCedula.Text;
                    objetoCliente.Direccion = textBoxDireccion.Text;
                    objetoCliente.Telefono = textBoxTelefono.Text;
                    objetoCliente.Email = textBoxEmail.Text;

                    if (logicaNC.insertarClientes(objetoCliente) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewClientes.DataSource = logicaNC.listarClientes();
                        textBoxNombres.Text = "";
                        textBoxApellidos.Text = "";
                        textBoxCedula.Text = "";
                        textBoxDireccion.Text = "";
                        textBoxTelefono.Text = "";
                        textBoxEmail.Text = "";
                        tabClientes.SelectedTab=tabPage2; //Consultar
                    }
                    else { MessageBox.Show("Error al agregar Clientes"); }
                }
                if (buttonGuardar.Text == "Actualizar")
                {
                    Clientes objetoCliente = new Clientes();
                    objetoCliente.idCliente = Convert.ToInt32(textBoxId.Text);
                    objetoCliente.Nombres = textBoxNombres.Text;
                    objetoCliente.Apellidos = textBoxApellidos.Text;
                    objetoCliente.Cedula = textBoxCedula.Text;
                    objetoCliente.Direccion = textBoxDireccion.Text;
                    objetoCliente.Telefono = textBoxTelefono.Text;
                    objetoCliente.Email = textBoxEmail.Text;

                    if (logicaNC.editarClientes(objetoCliente) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewClientes.DataSource = logicaNC.listarClientes();
                        textBoxNombres.Text = "";
                        textBoxApellidos.Text = "";
                        textBoxCedula.Text = "";
                        textBoxDireccion.Text = "";
                        textBoxTelefono.Text = "";
                        textBoxEmail.Text = "";
                        tabClientes.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Clientes");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            }
            catch
            { MessageBox.Show("ERROR"); }
        }

        private void fClientes_Load(object sender, EventArgs e)
        {
            textBoxId.Visible = false;
            labelId.Visible = false;
            dataGridViewClientes.DataSource = logicaNC.listarClientes();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelId.Visible = true;

            textBoxId.Text = dataGridViewClientes.CurrentRow.Cells["idCliente"].Value.ToString();
            textBoxNombres.Text = dataGridViewClientes.CurrentRow.Cells["Nombres"].Value.ToString();
            textBoxApellidos.Text = dataGridViewClientes.CurrentRow.Cells["Apellidos"].Value.ToString();
            textBoxCedula.Text = dataGridViewClientes.CurrentRow.Cells["Cedula"].Value.ToString();
            textBoxDireccion.Text = dataGridViewClientes.CurrentRow.Cells["Direccion"].Value.ToString();
            textBoxTelefono.Text = dataGridViewClientes.CurrentRow.Cells["Telefono"].Value.ToString();
            textBoxEmail.Text = dataGridViewClientes.CurrentRow.Cells["Email"].Value.ToString();

            tabClientes.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoC = Convert.ToInt32(dataGridViewClientes.CurrentRow.Cells["idCliente"].Value.ToString());
            try
            {
                if (logicaNC.eliminarClientes(codigoC) > 0)
                {
                    MessageBox.Show("Eliminado con éxito!");
                    dataGridViewClientes.DataSource = logicaNC.listarClientes();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al eliminar Clientes");
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Clientes> listaCliente = logicaNC.buscarClientes(textBoxBuscar.Text);
            dataGridViewClientes.DataSource = listaCliente;
        }
    }
}