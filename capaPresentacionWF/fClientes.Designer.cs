namespace capaPresentacionWF
{
    partial class fClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fClientes));
            this.tabClientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombres = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelRegistroClientes = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.tabClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabPage1);
            this.tabClientes.Controls.Add(this.tabPage2);
            this.tabClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabClientes.Location = new System.Drawing.Point(4, 4);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.SelectedIndex = 0;
            this.tabClientes.Size = new System.Drawing.Size(704, 490);
            this.tabClientes.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::capaPresentacionWF.Properties.Resources.cepillo_pintura_paleta;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Controls.Add(this.textBoxTelefono);
            this.tabPage1.Controls.Add(this.textBoxDireccion);
            this.tabPage1.Controls.Add(this.textBoxCedula);
            this.tabPage1.Controls.Add(this.textBoxApellidos);
            this.tabPage1.Controls.Add(this.textBoxNombres);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.labelEmail);
            this.tabPage1.Controls.Add(this.labelTelefono);
            this.tabPage1.Controls.Add(this.labelDireccion);
            this.tabPage1.Controls.Add(this.labelCedula);
            this.tabPage1.Controls.Add(this.labelApellidos);
            this.tabPage1.Controls.Add(this.labelNombres);
            this.tabPage1.Controls.Add(this.labelId);
            this.tabPage1.Controls.Add(this.labelRegistroClientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaPresentacionWF.Properties.Resources.ImagenCreacionesPNG;
            this.pictureBox1.Location = new System.Drawing.Point(152, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonGuardar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonGuardar.Location = new System.Drawing.Point(416, 399);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(118, 39);
            this.buttonGuardar.TabIndex = 15;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(371, 363);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(212, 20);
            this.textBoxEmail.TabIndex = 14;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(371, 302);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(153, 20);
            this.textBoxTelefono.TabIndex = 13;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(120, 363);
            this.textBoxDireccion.Multiline = true;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(195, 62);
            this.textBoxDireccion.TabIndex = 12;
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(120, 302);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(198, 20);
            this.textBoxCedula.TabIndex = 11;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(371, 241);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(195, 20);
            this.textBoxApellidos.TabIndex = 10;
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(120, 241);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(198, 20);
            this.textBoxNombres.TabIndex = 9;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(507, 194);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(45, 20);
            this.textBoxId.TabIndex = 8;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelEmail.Location = new System.Drawing.Point(367, 336);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(65, 24);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTelefono.Location = new System.Drawing.Point(367, 275);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(89, 24);
            this.labelTelefono.TabIndex = 6;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelDireccion.Location = new System.Drawing.Point(116, 336);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(99, 24);
            this.labelDireccion.TabIndex = 5;
            this.labelDireccion.Text = "Dirección:";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelCedula.Location = new System.Drawing.Point(116, 275);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(78, 24);
            this.labelCedula.TabIndex = 4;
            this.labelCedula.Text = "Cédula:";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelApellidos.Location = new System.Drawing.Point(367, 214);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(98, 24);
            this.labelApellidos.TabIndex = 3;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelNombres.Location = new System.Drawing.Point(116, 214);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(90, 24);
            this.labelNombres.TabIndex = 2;
            this.labelNombres.Text = "Nombres:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelId.Location = new System.Drawing.Point(474, 194);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(27, 24);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Id";
            // 
            // labelRegistroClientes
            // 
            this.labelRegistroClientes.AutoSize = true;
            this.labelRegistroClientes.Font = new System.Drawing.Font("Cooper Black", 22.25F);
            this.labelRegistroClientes.Location = new System.Drawing.Point(177, 152);
            this.labelRegistroClientes.Name = "labelRegistroClientes";
            this.labelRegistroClientes.Size = new System.Drawing.Size(320, 35);
            this.labelRegistroClientes.TabIndex = 0;
            this.labelRegistroClientes.Text = "Registro de Clientes";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::capaPresentacionWF.Properties.Resources.cepillo_pintura_paleta;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.dataGridViewClientes);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxBuscar.Location = new System.Drawing.Point(233, 130);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(180, 20);
            this.textBoxBuscar.TabIndex = 8;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToOrderColumns = true;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(139, 163);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(402, 242);
            this.dataGridViewClientes.TabIndex = 7;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEliminar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonEliminar.Location = new System.Drawing.Point(380, 411);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(106, 34);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEditar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonEditar.Location = new System.Drawing.Point(207, 411);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(84, 34);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonBuscar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonBuscar.Location = new System.Drawing.Point(419, 123);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(84, 34);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelBuscar.Location = new System.Drawing.Point(153, 126);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(74, 24);
            this.labelBuscar.TabIndex = 2;
            this.labelBuscar.Text = "Buscar:";
            // 
            // fClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 498);
            this.Controls.Add(this.tabClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.fClientes_Load);
            this.tabClientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelRegistroClientes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

