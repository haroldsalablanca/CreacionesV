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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
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
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlFactura
            // 
            this.tabControlFactura.Controls.Add(this.tabPage1);
            this.tabControlFactura.Controls.Add(this.tabPage2);
            this.tabControlFactura.Location = new System.Drawing.Point(2, 2);
            this.tabControlFactura.Name = "tabControlFactura";
            this.tabControlFactura.SelectedIndex = 0;
            this.tabControlFactura.Size = new System.Drawing.Size(441, 299);
            this.tabControlFactura.TabIndex = 0;
            this.tabControlFactura.Click += new System.EventHandler(this.tabControlFactura_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxIdCliente);
            this.tabPage1.Controls.Add(this.dateTimePickerFecha);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.labelFactura);
            this.tabPage1.Controls.Add(this.labelId);
            this.tabPage1.Controls.Add(this.labelFecha);
            this.tabPage1.Controls.Add(this.labelIdCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(433, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(216, 146);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(93, 38);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(91, 149);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(82, 20);
            this.textBoxIdCliente.TabIndex = 33;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(91, 88);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFecha.TabIndex = 32;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(58, 28);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(44, 20);
            this.textBoxId.TabIndex = 31;
            // 
            // labelFactura
            // 
            this.labelFactura.AutoSize = true;
            this.labelFactura.Location = new System.Drawing.Point(192, 28);
            this.labelFactura.Name = "labelFactura";
            this.labelFactura.Size = new System.Drawing.Size(43, 13);
            this.labelFactura.TabIndex = 28;
            this.labelFactura.Text = "Factura";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(36, 31);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 27;
            this.labelId.Text = "Id";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(45, 94);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(40, 13);
            this.labelFecha.TabIndex = 26;
            this.labelFecha.Text = "Fecha:";
            // 
            // labelIdCliente
            // 
            this.labelIdCliente.AutoSize = true;
            this.labelIdCliente.Location = new System.Drawing.Point(31, 152);
            this.labelIdCliente.Name = "labelIdCliente";
            this.labelIdCliente.Size = new System.Drawing.Size(54, 13);
            this.labelIdCliente.TabIndex = 25;
            this.labelIdCliente.Text = "Id Cliente:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewFactura);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(433, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFactura
            // 
            this.dataGridViewFactura.AllowUserToOrderColumns = true;
            this.dataGridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactura.Location = new System.Drawing.Point(20, 73);
            this.dataGridViewFactura.Name = "dataGridViewFactura";
            this.dataGridViewFactura.Size = new System.Drawing.Size(395, 182);
            this.dataGridViewFactura.TabIndex = 18;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(340, 29);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(257, 29);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 16;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click_1);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(174, 29);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 15;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click_1);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(65, 30);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(98, 20);
            this.textBoxBuscar.TabIndex = 14;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(17, 33);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(43, 13);
            this.labelBuscar.TabIndex = 13;
            this.labelBuscar.Text = "Buscar:";
            // 
            // fFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 301);
            this.Controls.Add(this.tabControlFactura);
            this.Name = "fFactura";
            this.Text = "fFactura";
            this.tabControlFactura.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.DataGridView dataGridViewFactura;
    }
}