namespace capaPresentacionWF
{
    partial class fUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUsuario));
            this.tabUsuario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.labelNombres = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.tabUsuario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.tabPage1);
            this.tabUsuario.Controls.Add(this.tabPage2);
            this.tabUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabUsuario.Location = new System.Drawing.Point(2, 2);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.SelectedIndex = 0;
            this.tabUsuario.Size = new System.Drawing.Size(677, 480);
            this.tabUsuario.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::capaPresentacionWF.Properties.Resources.cepillo_pintura_paleta;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textBoxDireccion);
            this.tabPage1.Controls.Add(this.labelDireccion);
            this.tabPage1.Controls.Add(this.textBoxApellidos);
            this.tabPage1.Controls.Add(this.labelApellidos);
            this.tabPage1.Controls.Add(this.textBoxNombres);
            this.tabPage1.Controls.Add(this.labelNombres);
            this.tabPage1.Controls.Add(this.textBoxTelefono);
            this.tabPage1.Controls.Add(this.labelTelefono);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxCedula);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.labelUsuario);
            this.tabPage1.Controls.Add(this.labelId);
            this.tabPage1.Controls.Add(this.labelCedula);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(669, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaPresentacionWF.Properties.Resources.ImagenCreacionesPNG;
            this.pictureBox1.Location = new System.Drawing.Point(197, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxDireccion.Location = new System.Drawing.Point(142, 372);
            this.textBoxDireccion.Multiline = true;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(176, 60);
            this.textBoxDireccion.TabIndex = 42;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelDireccion.Location = new System.Drawing.Point(138, 344);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(99, 24);
            this.labelDireccion.TabIndex = 41;
            this.labelDireccion.Text = "Dirección:";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxApellidos.Location = new System.Drawing.Point(359, 313);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(171, 20);
            this.textBoxApellidos.TabIndex = 40;
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelApellidos.Location = new System.Drawing.Point(356, 286);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(98, 24);
            this.labelApellidos.TabIndex = 39;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxNombres.Location = new System.Drawing.Point(142, 313);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(176, 20);
            this.textBoxNombres.TabIndex = 38;
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelNombres.Location = new System.Drawing.Point(138, 286);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(90, 24);
            this.labelNombres.TabIndex = 37;
            this.labelNombres.Text = "Nombres:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxTelefono.Location = new System.Drawing.Point(359, 253);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(171, 20);
            this.textBoxTelefono.TabIndex = 36;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTelefono.Location = new System.Drawing.Point(355, 226);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(89, 24);
            this.labelTelefono.TabIndex = 35;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonGuardar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonGuardar.Location = new System.Drawing.Point(380, 373);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(120, 43);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxCedula.Location = new System.Drawing.Point(142, 253);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(176, 20);
            this.textBoxCedula.TabIndex = 33;
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxId.Location = new System.Drawing.Point(171, 180);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(44, 20);
            this.textBoxId.TabIndex = 31;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Cooper Black", 22.25F);
            this.labelUsuario.Location = new System.Drawing.Point(197, 139);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(288, 35);
            this.labelUsuario.TabIndex = 28;
            this.labelUsuario.Text = "Registrar Usuario";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelId.Location = new System.Drawing.Point(138, 175);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(27, 24);
            this.labelId.TabIndex = 27;
            this.labelId.Text = "Id";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelCedula.Location = new System.Drawing.Point(138, 226);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(78, 24);
            this.labelCedula.TabIndex = 25;
            this.labelCedula.Text = "Cédula:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::capaPresentacionWF.Properties.Resources.cepillo_pintura_paleta;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage2.Controls.Add(this.dataGridViewUsuario);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(669, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.AllowUserToOrderColumns = true;
            this.dataGridViewUsuario.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(137, 174);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.Size = new System.Drawing.Size(379, 218);
            this.dataGridViewUsuario.TabIndex = 18;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEliminar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonEliminar.Location = new System.Drawing.Point(375, 398);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(97, 34);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEditar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonEditar.Location = new System.Drawing.Point(198, 398);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(84, 34);
            this.buttonEditar.TabIndex = 16;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonBuscar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonBuscar.Location = new System.Drawing.Point(407, 134);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(84, 34);
            this.buttonBuscar.TabIndex = 15;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxBuscar.Location = new System.Drawing.Point(229, 142);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(172, 20);
            this.textBoxBuscar.TabIndex = 14;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelBuscar.Location = new System.Drawing.Point(151, 138);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(74, 24);
            this.labelBuscar.TabIndex = 13;
            this.labelBuscar.Text = "Buscar:";
            // 
            // fUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 494);
            this.Controls.Add(this.tabUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.fUsuario_Load);
            this.tabUsuario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUsuario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}