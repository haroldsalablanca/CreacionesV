namespace capaPresentacionWF
{
    partial class fFactura
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
            this.tabControlFactura = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelFactura = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelIdCliente = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewFactura = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.tabControlFactura.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlFactura
            // 
            this.tabControlFactura.Controls.Add(this.tabPage1);
            this.tabControlFactura.Controls.Add(this.tabPage2);
            this.tabControlFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControlFactura.Location = new System.Drawing.Point(2, 2);
            this.tabControlFactura.Name = "tabControlFactura";
            this.tabControlFactura.SelectedIndex = 0;
            this.tabControlFactura.Size = new System.Drawing.Size(560, 447);
            this.tabControlFactura.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::capaPresentacionWF.Properties.Resources.cepillo_pintura_paleta;
            this.tabPage1.Controls.Add(this.textBoxFecha);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxIdCliente);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.labelFactura);
            this.tabPage1.Controls.Add(this.labelId);
            this.tabPage1.Controls.Add(this.labelFecha);
            this.tabPage1.Controls.Add(this.labelIdCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(162, 236);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(132, 20);
            this.textBoxFecha.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaPresentacionWF.Properties.Resources.ImagenCreacionesPNG;
            this.pictureBox1.Location = new System.Drawing.Point(136, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonGuardar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonGuardar.Location = new System.Drawing.Point(235, 299);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(93, 38);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(416, 238);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(55, 20);
            this.textBoxIdCliente.TabIndex = 33;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(168, 188);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(44, 20);
            this.textBoxId.TabIndex = 31;
            // 
            // labelFactura
            // 
            this.labelFactura.AutoSize = true;
            this.labelFactura.Font = new System.Drawing.Font("Cooper Black", 22.25F);
            this.labelFactura.Location = new System.Drawing.Point(229, 141);
            this.labelFactura.Name = "labelFactura";
            this.labelFactura.Size = new System.Drawing.Size(135, 35);
            this.labelFactura.TabIndex = 28;
            this.labelFactura.Text = "Factura";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelId.Location = new System.Drawing.Point(132, 184);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(27, 24);
            this.labelId.TabIndex = 27;
            this.labelId.Text = "Id";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelFecha.Location = new System.Drawing.Point(91, 233);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(65, 24);
            this.labelFecha.TabIndex = 26;
            this.labelFecha.Text = "Fecha:";
            // 
            // labelIdCliente
            // 
            this.labelIdCliente.AutoSize = true;
            this.labelIdCliente.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelIdCliente.Location = new System.Drawing.Point(310, 236);
            this.labelIdCliente.Name = "labelIdCliente";
            this.labelIdCliente.Size = new System.Drawing.Size(100, 24);
            this.labelIdCliente.TabIndex = 25;
            this.labelIdCliente.Text = "Id Cliente:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::capaPresentacionWF.Properties.Resources.cepillo_pintura_paleta;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.dataGridViewFactura);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFactura
            // 
            this.dataGridViewFactura.AllowUserToOrderColumns = true;
            this.dataGridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactura.Location = new System.Drawing.Point(96, 139);
            this.dataGridViewFactura.Name = "dataGridViewFactura";
            this.dataGridViewFactura.Size = new System.Drawing.Size(340, 232);
            this.dataGridViewFactura.TabIndex = 18;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEliminar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonEliminar.Location = new System.Drawing.Point(289, 377);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(99, 38);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEditar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonEditar.Location = new System.Drawing.Point(158, 377);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(81, 38);
            this.buttonEditar.TabIndex = 16;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonBuscar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonBuscar.Location = new System.Drawing.Point(307, 102);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(85, 31);
            this.buttonBuscar.TabIndex = 15;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(193, 111);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(108, 20);
            this.textBoxBuscar.TabIndex = 14;
            this.textBoxBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelBuscar.Location = new System.Drawing.Point(113, 109);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(74, 24);
            this.labelBuscar.TabIndex = 13;
            this.labelBuscar.Text = "Buscar:";
            // 
            // fFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 453);
            this.Controls.Add(this.tabControlFactura);
            this.Name = "fFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.fFactura_load);
            this.tabControlFactura.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFactura;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelFactura;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelIdCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.DataGridView dataGridViewFactura;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}