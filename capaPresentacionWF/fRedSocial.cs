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
    public partial class fRedSocial : Form
    {
        logicaNegocioRedSocial logicaNRS = new logicaNegocioRedSocial();
    public fRedSocial()
    {
        InitializeComponent();
    }

    private void buttonGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            if (buttonGuardar.Text == "Guardar")
            {
                RedSocial objetoRedSocial = new RedSocial();
                objetoRedSocial.NombreR = textBoxNombreR.Text;
                objetoRedSocial.idCliente = Convert.ToInt32(textBoxIdCliente.Text);

                if (logicaNRS.insertarRedSocial(objetoRedSocial) > 0)
                {
                    MessageBox.Show("Agregado con éxito");
                    dataGridViewRedSocial.DataSource = logicaNRS.listarRedSocial();
                    textBoxNombreR.Text = "";
                    textBoxIdCliente.Text = "";
                    tabRedSocial.SelectedTab = tabPage2; //Consultar
                }
                else { MessageBox.Show("Error al agregar Red Social"); }
            }
            if (buttonGuardar.Text == "Actualizar")
            {
                RedSocial objetoRedSocial = new RedSocial();
                objetoRedSocial.idRedSocial = Convert.ToInt32(textBoxId.Text);
                objetoRedSocial.NombreR = textBoxNombreR.Text;
                objetoRedSocial.idCliente = Convert.ToInt32(textBoxIdCliente.Text);

                if (logicaNRS.editarRedSocial(objetoRedSocial) > 0)
                {
                    MessageBox.Show("Actualizado con éxito");
                    dataGridViewRedSocial.DataSource = logicaNRS.listarRedSocial();
                    textBoxNombreR.Text = "";
                    textBoxIdCliente.Text = "";
                    tabRedSocial.SelectedTab = tabPage2;
                }
                else
                {
                    MessageBox.Show("Error al actualizar Red Social");
                }
                buttonGuardar.Text = "Guardar";
                }
            }
            catch
            { MessageBox.Show("ERROR"); }
        }

        private void fRedSocial_Load(object sender, EventArgs e)
        {
            textBoxId.Visible = false;
            labelId.Visible = false;
            dataGridViewRedSocial.DataSource = logicaNRS.listarRedSocial();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<RedSocial> listaRedSocial = logicaNRS.buscarRedSocial(textBoxBuscar.Text);
            dataGridViewRedSocial.DataSource = listaRedSocial;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelId.Visible = true;

            textBoxId.Text = dataGridViewRedSocial.CurrentRow.Cells["idUsuario"].Value.ToString();
            textBoxNombreR.Text = dataGridViewRedSocial.CurrentRow.Cells["NombreR"].Value.ToString();
            textBoxIdCliente.Text = dataGridViewRedSocial.CurrentRow.Cells["idCliente"].Value.ToString();

            tabRedSocial.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoRS = Convert.ToInt32(dataGridViewRedSocial.CurrentRow.Cells["idRedSocial"].Value.ToString());
            try
            {
                if (logicaNRS.eliminarRedSocial(codigoRS) > 0)
                {
                    MessageBox.Show("Eliminado con éxito!");
                    dataGridViewRedSocial.DataSource = logicaNRS.listarRedSocial();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al eliminar Red Social");
            }
        }
    }
}
