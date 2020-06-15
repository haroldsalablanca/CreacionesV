namespace capaPresentacionWF
{
    partial class fProductos
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
            this.tabControlProductos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxColores = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxTamaño = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelColores = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelTamaño = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelProductos = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.tabControlProductos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlProductos
            // 
            this.tabControlProductos.Controls.Add(this.tabPage1);
            this.tabControlProductos.Controls.Add(this.tabPage2);
            this.tabControlProductos.Location = new System.Drawing.Point(3, 2);
            this.tabControlProductos.Name = "tabControlProductos";
            this.tabControlProductos.SelectedIndex = 0;
            this.tabControlProductos.Size = new System.Drawing.Size(564, 322);
            this.tabControlProductos.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxColores);
            this.tabPage1.Controls.Add(this.textBoxPrecio);
            this.tabPage1.Controls.Add(this.textBoxTamaño);
            this.tabPage1.Controls.Add(this.textBoxDescripcion);
            this.tabPage1.Controls.Add(this.textBoxNombre);
            this.tabPage1.Controls.Add(this.labelDescripcion);
            this.tabPage1.Controls.Add(this.labelColores);
            this.tabPage1.Controls.Add(this.labelPrecio);
            this.tabPage1.Controls.Add(this.labelTamaño);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.labelProductos);
            this.tabPage1.Controls.Add(this.labelId);
            this.tabPage1.Controls.Add(this.labelNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxColores
            // 
            this.textBoxColores.Location = new System.Drawing.Point(96, 140);
            this.textBoxColores.Name = "textBoxColores";
            this.textBoxColores.Size = new System.Drawing.Size(178, 20);
            this.textBoxColores.TabIndex = 46;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(350, 93);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(178, 20);
            this.textBoxPrecio.TabIndex = 45;
            // 
            // textBoxTamaño
            // 
            this.textBoxTamaño.Location = new System.Drawing.Point(350, 138);
            this.textBoxTamaño.Name = "textBoxTamaño";
            this.textBoxTamaño.Size = new System.Drawing.Size(178, 20);
            this.textBoxTamaño.TabIndex = 44;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(96, 188);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(178, 55);
            this.textBoxDescripcion.TabIndex = 43;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(96, 92);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(178, 20);
            this.textBoxNombre.TabIndex = 41;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(24, 191);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 39;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // labelColores
            // 
            this.labelColores.AutoSize = true;
            this.labelColores.Location = new System.Drawing.Point(41, 143);
            this.labelColores.Name = "labelColores";
            this.labelColores.Size = new System.Drawing.Size(45, 13);
            this.labelColores.TabIndex = 38;
            this.labelColores.Text = "Colores:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(304, 93);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(40, 13);
            this.labelPrecio.TabIndex = 37;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelTamaño
            // 
            this.labelTamaño.AutoSize = true;
            this.labelTamaño.Location = new System.Drawing.Point(295, 139);
            this.labelTamaño.Name = "labelTamaño";
            this.labelTamaño.Size = new System.Drawing.Size(49, 13);
            this.labelTamaño.TabIndex = 35;
            this.labelTamaño.Text = "Tamaño:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(385, 213);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(86, 30);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(67, 32);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(44, 20);
            this.textBoxId.TabIndex = 31;
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Location = new System.Drawing.Point(241, 35);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(100, 13);
            this.labelProductos.TabIndex = 28;
            this.labelProductos.Text = "Registrar Productos";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(45, 35);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 27;
            this.labelId.Text = "Id";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(43, 96);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 25;
            this.labelNombre.Text = "Nombre:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewProductos);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(556, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToOrderColumns = true;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(20, 84);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(514, 187);
            this.dataGridViewProductos.TabIndex = 18;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(399, 34);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(316, 34);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 16;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(233, 34);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 15;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(124, 35);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(98, 20);
            this.textBoxBuscar.TabIndex = 14;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(76, 38);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(43, 13);
            this.labelBuscar.TabIndex = 13;
            this.labelBuscar.Text = "Buscar:";
            // 
            // fProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 326);
            this.Controls.Add(this.tabControlProductos);
            this.Name = "fProductos";
            this.Text = "fProductos";
            this.tabControlProductos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProductos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxTamaño;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelColores;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelTamaño;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxColores;
    }
}