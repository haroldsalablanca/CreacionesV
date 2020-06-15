namespace capaPresentacionWF
{
    partial class fDetalleFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDetalleFactura));
            this.tabControlDetalleFact = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxIdProducto = new System.Windows.Forms.TextBox();
            this.textBoxIdFactura = new System.Windows.Forms.TextBox();
            this.textBoxCantidadV = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelDetalleFactura = new System.Windows.Forms.Label();
            this.labelIdProductos = new System.Windows.Forms.Label();
            this.labelIdFactura = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCantidadVentas = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewDetalleFact = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlDetalleFact.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDetalleFact
            // 
            this.tabControlDetalleFact.Controls.Add(this.tabPage1);
            this.tabControlDetalleFact.Controls.Add(this.tabPage2);
            this.tabControlDetalleFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControlDetalleFact.Location = new System.Drawing.Point(3, 3);
            this.tabControlDetalleFact.Name = "tabControlDetalleFact";
            this.tabControlDetalleFact.SelectedIndex = 0;
            this.tabControlDetalleFact.Size = new System.Drawing.Size(703, 494);
            this.tabControlDetalleFact.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::capaPresentacionWF.Properties.Resources.cepillo_pintura_paleta;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textBoxIdProducto);
            this.tabPage1.Controls.Add(this.textBoxIdFactura);
            this.tabPage1.Controls.Add(this.textBoxCantidadV);
            this.tabPage1.Controls.Add(this.textBoxPrecio);
            this.tabPage1.Controls.Add(this.textBoxDescripcion);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.labelDetalleFactura);
            this.tabPage1.Controls.Add(this.labelIdProductos);
            this.tabPage1.Controls.Add(this.labelIdFactura);
            this.tabPage1.Controls.Add(this.labelPrecio);
            this.tabPage1.Controls.Add(this.labelCantidadVentas);
            this.tabPage1.Controls.Add(this.labelDescripcion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(695, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxIdProducto
            // 
            this.textBoxIdProducto.Location = new System.Drawing.Point(366, 372);
            this.textBoxIdProducto.Name = "textBoxIdProducto";
            this.textBoxIdProducto.Size = new System.Drawing.Size(53, 20);
            this.textBoxIdProducto.TabIndex = 35;
            // 
            // textBoxIdFactura
            // 
            this.textBoxIdFactura.Location = new System.Drawing.Point(366, 319);
            this.textBoxIdFactura.Name = "textBoxIdFactura";
            this.textBoxIdFactura.Size = new System.Drawing.Size(53, 20);
            this.textBoxIdFactura.TabIndex = 34;
            // 
            // textBoxCantidadV
            // 
            this.textBoxCantidadV.Location = new System.Drawing.Point(137, 319);
            this.textBoxCantidadV.Name = "textBoxCantidadV";
            this.textBoxCantidadV.Size = new System.Drawing.Size(161, 20);
            this.textBoxCantidadV.TabIndex = 33;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(137, 372);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(157, 20);
            this.textBoxPrecio.TabIndex = 32;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(133, 231);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(401, 45);
            this.textBoxDescripcion.TabIndex = 29;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonGuardar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonGuardar.Location = new System.Drawing.Point(276, 409);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(120, 43);
            this.buttonGuardar.TabIndex = 28;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelDetalleFactura
            // 
            this.labelDetalleFactura.AutoSize = true;
            this.labelDetalleFactura.Font = new System.Drawing.Font("Cooper Black", 22.25F);
            this.labelDetalleFactura.Location = new System.Drawing.Point(229, 143);
            this.labelDetalleFactura.Name = "labelDetalleFactura";
            this.labelDetalleFactura.Size = new System.Drawing.Size(252, 35);
            this.labelDetalleFactura.TabIndex = 27;
            this.labelDetalleFactura.Text = "Detalle Factura";
            // 
            // labelIdProductos
            // 
            this.labelIdProductos.AutoSize = true;
            this.labelIdProductos.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelIdProductos.Location = new System.Drawing.Point(362, 346);
            this.labelIdProductos.Name = "labelIdProductos";
            this.labelIdProductos.Size = new System.Drawing.Size(119, 24);
            this.labelIdProductos.TabIndex = 26;
            this.labelIdProductos.Text = "Id Productos:";
            // 
            // labelIdFactura
            // 
            this.labelIdFactura.AutoSize = true;
            this.labelIdFactura.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelIdFactura.Location = new System.Drawing.Point(362, 292);
            this.labelIdFactura.Name = "labelIdFactura";
            this.labelIdFactura.Size = new System.Drawing.Size(102, 24);
            this.labelIdFactura.TabIndex = 25;
            this.labelIdFactura.Text = "Id Factura:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelPrecio.Location = new System.Drawing.Point(129, 346);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(68, 24);
            this.labelPrecio.TabIndex = 24;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelCantidadVentas
            // 
            this.labelCantidadVentas.AutoSize = true;
            this.labelCantidadVentas.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelCantidadVentas.Location = new System.Drawing.Point(129, 292);
            this.labelCantidadVentas.Name = "labelCantidadVentas";
            this.labelCantidadVentas.Size = new System.Drawing.Size(161, 24);
            this.labelCantidadVentas.TabIndex = 23;
            this.labelCantidadVentas.Text = "Cantidad Ventas:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelDescripcion.Location = new System.Drawing.Point(129, 204);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(117, 24);
            this.labelDescripcion.TabIndex = 22;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::capaPresentacionWF.Properties.Resources.cepillo_pintura_paleta;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.dataGridViewDetalleFact);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(695, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDetalleFact
            // 
            this.dataGridViewDetalleFact.AllowUserToOrderColumns = true;
            this.dataGridViewDetalleFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleFact.Location = new System.Drawing.Point(143, 156);
            this.dataGridViewDetalleFact.Name = "dataGridViewDetalleFact";
            this.dataGridViewDetalleFact.Size = new System.Drawing.Size(404, 244);
            this.dataGridViewDetalleFact.TabIndex = 13;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEliminar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonEliminar.Location = new System.Drawing.Point(394, 406);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(103, 34);
            this.buttonEliminar.TabIndex = 12;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click_1);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEditar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonEditar.Location = new System.Drawing.Point(198, 406);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(84, 34);
            this.buttonEditar.TabIndex = 11;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonBuscar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonBuscar.Location = new System.Drawing.Point(420, 112);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(88, 36);
            this.buttonBuscar.TabIndex = 10;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(226, 124);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(188, 20);
            this.textBoxBuscar.TabIndex = 9;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelBuscar.Location = new System.Drawing.Point(146, 124);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(74, 24);
            this.labelBuscar.TabIndex = 8;
            this.labelBuscar.Text = "Buscar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaPresentacionWF.Properties.Resources.ImagenCreacionesPNG;
            this.pictureBox1.Location = new System.Drawing.Point(205, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // fDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 509);
            this.Controls.Add(this.tabControlDetalleFact);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDetalleFactura";
            this.Text = "Detalle Factura";
            this.tabControlDetalleFact.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDetalleFact;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxCantidadV;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelDetalleFactura;
        private System.Windows.Forms.Label labelIdProductos;
        private System.Windows.Forms.Label labelIdFactura;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCantidadVentas;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.DataGridView dataGridViewDetalleFact;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxIdProducto;
        private System.Windows.Forms.TextBox textBoxIdFactura;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}