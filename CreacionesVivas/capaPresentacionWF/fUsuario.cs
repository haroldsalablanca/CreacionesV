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
    public partial class fUsuario : Form
    {
        logicaNegocioUsuario logicaNU = new logicaNegocioUsuario();
        public fUsuario()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Usuario objetoUsuario = new Usuario();
                    objetoUsuario.Cedula = textBoxCedula.Text;
                    objetoUsuario.Nombres = textBoxNombres.Text;
                    objetoUsuario.Apellidos = textBoxApellidos.Text;
                    objetoUsuario.Direccion = textBoxDireccion.Text;
                    objetoUsuario.Telefono = textBoxTelefono.Text;
                    

                    if (logicaNU.insertarUsuario(objetoUsuario) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewUsuario.DataSource = logicaNU.listarUsuarios();
                        textBoxNombres.Text = "";
                        textBoxApellidos.Text = "";
                        textBoxCedula.Text = "";
                        textBoxDireccion.Text = "";
                        textBoxTelefono.Text = "";
                        tabUsuario.SelectedTab = tabPage2; //Consultar
                    }
                    else { MessageBox.Show("Error al agregar Usuario"); }
                }
                if (buttonGuardar.Text == "Actualizar")
                {
                    Usuario objetoUsuario = new Usuario();
                    objetoUsuario.idUsuario = Convert.ToInt32(textBoxId.Text);
                    objetoUsuario.Cedula = textBoxCedula.Text;
                    objetoUsuario.Nombres = textBoxNombres.Text;
                    objetoUsuario.Apellidos = textBoxApellidos.Text;
                    objetoUsuario.Direccion = textBoxDireccion.Text;
                    objetoUsuario.Telefono = textBoxTelefono.Text;
                    

                    if (logicaNU.editarUsuarios(objetoUsuario) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewUsuario.DataSource = logicaNU.listarUsuarios();
                        textBoxCedula.Text = "";
                        textBoxNombres.Text = "";
                        textBoxApellidos.Text = "";
                        textBoxDireccion.Text = "";
                        textBoxTelefono.Text = "";
                        tabUsuario.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Usuario");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            }
            catch
            { MessageBox.Show("ERROR"); }
        }

        private void fUsuario_Load(object sender, EventArgs e)
        {
            textBoxId.Visible = false;
            labelId.Visible = false;
            dataGridViewUsuario.DataSource = logicaNU.listarUsuarios();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelId.Visible = true;

            textBoxId.Text = dataGridViewUsuario.CurrentRow.Cells["idUsuario"].Value.ToString();
            textBoxCedula.Text = dataGridViewUsuario.CurrentRow.Cells["Cedula"].Value.ToString();
            textBoxNombres.Text = dataGridViewUsuario.CurrentRow.Cells["Nombres"].Value.ToString();
            textBoxApellidos.Text = dataGridViewUsuario.CurrentRow.Cells["Apellidos"].Value.ToString();
            textBoxDireccion.Text = dataGridViewUsuario.CurrentRow.Cells["Direccion"].Value.ToString();
            textBoxTelefono.Text = dataGridViewUsuario.CurrentRow.Cells["Telefono"].Value.ToString();
            

            tabUsuario.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoU = Convert.ToInt32(dataGridViewUsuario.CurrentRow.Cells["idUsuario"].Value.ToString());
            try
            {
                if (logicaNU.eliminarUsuarios(codigoU) > 0)
                {
                    MessageBox.Show("Eliminado con éxito!");
                    dataGridViewUsuario.DataSource = logicaNU.listarUsuarios();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al eliminar Usuario");
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Usuario> listaUsuario = logicaNU.buscarUsuarios(textBoxBuscar.Text);
            dataGridViewUsuario.DataSource = listaUsuario;
        }
    }
}
