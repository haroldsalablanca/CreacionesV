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
            this.tabUsuario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.tabPage1);
            this.tabUsuario.Controls.Add(this.tabPage2);
            this.tabUsuario.Location = new System.Drawing.Point(2, 2);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.SelectedIndex = 0;
            this.tabUsuario.Size = new System.Drawing.Size(558, 282);
            this.tabUsuario.TabIndex = 2;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(550, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(365, 70);
            this.textBoxDireccion.Multiline = true;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(175, 55);
            this.textBoxDireccion.TabIndex = 42;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(310, 71);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 41;
            this.labelDireccion.Text = "Dirección:";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(83, 141);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(212, 20);
            this.textBoxApellidos.TabIndex = 40;
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(21, 144);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(52, 13);
            this.labelApellidos.TabIndex = 39;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(83, 106);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(212, 20);
            this.textBoxNombres.TabIndex = 38;
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(21, 109);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(52, 13);
            this.labelNombres.TabIndex = 37;
            this.labelNombres.Text = "Nombres:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(366, 141);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(175, 20);
            this.textBoxTelefono.TabIndex = 36;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(310, 144);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 35;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(227, 199);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(93, 34);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(83, 72);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(212, 20);
            this.textBoxCedula.TabIndex = 33;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(39, 25);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(44, 20);
            this.textBoxId.TabIndex = 31;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(232, 25);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(88, 13);
            this.labelUsuario.TabIndex = 28;
            this.labelUsuario.Text = "Registrar Usuario";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(17, 28);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 27;
            this.labelId.Text = "Id";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Location = new System.Drawing.Point(31, 74);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(43, 13);
            this.labelCedula.TabIndex = 25;
            this.labelCedula.Text = "Cédula:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewUsuario);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.AllowUserToOrderColumns = true;
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(20, 73);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.Size = new System.Drawing.Size(511, 155);
            this.dataGridViewUsuario.TabIndex = 18;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(383, 30);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(293, 30);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 16;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(208, 31);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 15;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(117, 31);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(85, 20);
            this.textBoxBuscar.TabIndex = 14;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(72, 34);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(43, 13);
            this.labelBuscar.TabIndex = 13;
            this.labelBuscar.Text = "Buscar:";
            // 
            // fUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 285);
            this.Controls.Add(this.tabUsuario);
            this.Name = "fUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.fUsuario_Load);
            this.tabUsuario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
    }
}