namespace capaPresentacionWF
{
    partial class fPedidos
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
            this.tabControlPedidos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaSolicitada = new System.Windows.Forms.DateTimePicker();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelPedidos = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelFechaSolicitada = new System.Windows.Forms.Label();
            this.labelDireccionEnvio = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIdUsuario = new System.Windows.Forms.Label();
            this.labelCantidadSolicitada = new System.Windows.Forms.Label();
            this.dateTimePickerFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.labelFechaEntrega = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControlPedidos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPedidos
            // 
            this.tabControlPedidos.Controls.Add(this.tabPage1);
            this.tabControlPedidos.Controls.Add(this.tabPage2);
            this.tabControlPedidos.Location = new System.Drawing.Point(5, 3);
            this.tabControlPedidos.Name = "tabControlPedidos";
            this.tabControlPedidos.SelectedIndex = 0;
            this.tabControlPedidos.Size = new System.Drawing.Size(564, 407);
            this.tabControlPedidos.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBoxIdUsuario);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dateTimePickerFechaEntrega);
            this.tabPage1.Controls.Add(this.labelFechaEntrega);
            this.tabPage1.Controls.Add(this.labelCantidadSolicitada);
            this.tabPage1.Controls.Add(this.labelIdUsuario);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxIdCliente);
            this.tabPage1.Controls.Add(this.dateTimePickerFechaSolicitada);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.labelPedidos);
            this.tabPage1.Controls.Add(this.labelId);
            this.tabPage1.Controls.Add(this.labelFechaSolicitada);
            this.tabPage1.Controls.Add(this.labelDireccionEnvio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(345, 236);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(102, 36);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(44, 112);
            this.textBoxIdCliente.Multiline = true;
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(200, 60);
            this.textBoxIdCliente.TabIndex = 33;
            // 
            // dateTimePickerFechaSolicitada
            // 
            this.dateTimePickerFechaSolicitada.Location = new System.Drawing.Point(44, 211);
            this.dateTimePickerFechaSolicitada.Name = "dateTimePickerFechaSolicitada";
            this.dateTimePickerFechaSolicitada.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaSolicitada.TabIndex = 32;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(67, 32);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(44, 20);
            this.textBoxId.TabIndex = 31;
            // 
            // labelPedidos
            // 
            this.labelPedidos.AutoSize = true;
            this.labelPedidos.Location = new System.Drawing.Point(241, 35);
            this.labelPedidos.Name = "labelPedidos";
            this.labelPedidos.Size = new System.Drawing.Size(90, 13);
            this.labelPedidos.TabIndex = 28;
            this.labelPedidos.Text = "Registrar Pedidos";
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
            // labelFechaSolicitada
            // 
            this.labelFechaSolicitada.AutoSize = true;
            this.labelFechaSolicitada.Location = new System.Drawing.Point(43, 193);
            this.labelFechaSolicitada.Name = "labelFechaSolicitada";
            this.labelFechaSolicitada.Size = new System.Drawing.Size(89, 13);
            this.labelFechaSolicitada.TabIndex = 26;
            this.labelFechaSolicitada.Text = "Fecha Solicitada:";
            // 
            // labelDireccionEnvio
            // 
            this.labelDireccionEnvio.AutoSize = true;
            this.labelDireccionEnvio.Location = new System.Drawing.Point(43, 96);
            this.labelDireccionEnvio.Name = "labelDireccionEnvio";
            this.labelDireccionEnvio.Size = new System.Drawing.Size(101, 13);
            this.labelDireccionEnvio.TabIndex = 25;
            this.labelDireccionEnvio.Text = "Dirección de envío:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewPedidos);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(556, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToOrderColumns = true;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(20, 91);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.Size = new System.Drawing.Size(514, 267);
            this.dataGridViewPedidos.TabIndex = 18;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(399, 34);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(316, 34);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 16;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(233, 34);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 15;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Id Cliente:";
            // 
            // labelIdUsuario
            // 
            this.labelIdUsuario.AutoSize = true;
            this.labelIdUsuario.Location = new System.Drawing.Point(318, 139);
            this.labelIdUsuario.Name = "labelIdUsuario";
            this.labelIdUsuario.Size = new System.Drawing.Size(58, 13);
            this.labelIdUsuario.TabIndex = 37;
            this.labelIdUsuario.Text = "Id Usuario:";
            // 
            // labelCantidadSolicitada
            // 
            this.labelCantidadSolicitada.AutoSize = true;
            this.labelCantidadSolicitada.Location = new System.Drawing.Point(280, 99);
            this.labelCantidadSolicitada.Name = "labelCantidadSolicitada";
            this.labelCantidadSolicitada.Size = new System.Drawing.Size(101, 13);
            this.labelCantidadSolicitada.TabIndex = 38;
            this.labelCantidadSolicitada.Text = "Cantidad Solicitada:";
            // 
            // dateTimePickerFechaEntrega
            // 
            this.dateTimePickerFechaEntrega.Location = new System.Drawing.Point(44, 266);
            this.dateTimePickerFechaEntrega.Name = "dateTimePickerFechaEntrega";
            this.dateTimePickerFechaEntrega.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaEntrega.TabIndex = 40;
            // 
            // labelFechaEntrega
            // 
            this.labelFechaEntrega.AutoSize = true;
            this.labelFechaEntrega.Location = new System.Drawing.Point(43, 250);
            this.labelFechaEntrega.Name = "labelFechaEntrega";
            this.labelFechaEntrega.Size = new System.Drawing.Size(80, 13);
            this.labelFechaEntrega.TabIndex = 39;
            this.labelFechaEntrega.Text = "Fecha Entrega:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 41;
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Location = new System.Drawing.Point(386, 136);
            this.textBoxIdUsuario.Name = "textBoxIdUsuario";
            this.textBoxIdUsuario.Size = new System.Drawing.Size(99, 20);
            this.textBoxIdUsuario.TabIndex = 42;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(386, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 43;
            // 
            // fPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 411);
            this.Controls.Add(this.tabControlPedidos);
            this.Name = "fPedidos";
            this.Text = "fPedidos";
            this.tabControlPedidos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPedidos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxIdUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEntrega;
        private System.Windows.Forms.Label labelFechaEntrega;
        private System.Windows.Forms.Label labelCantidadSolicitada;
        private System.Windows.Forms.Label labelIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaSolicitada;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelPedidos;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelFechaSolicitada;
        private System.Windows.Forms.Label labelDireccionEnvio;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
    }
}