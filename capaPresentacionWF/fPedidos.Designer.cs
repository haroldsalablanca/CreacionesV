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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxFechaEntrega = new System.Windows.Forms.TextBox();
            this.textBoxFachaSolicitud = new System.Windows.Forms.TextBox();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.textBoxCantidadSolicitada = new System.Windows.Forms.TextBox();
            this.labelFechaEntrega = new System.Windows.Forms.Label();
            this.labelCantidadSolicitada = new System.Windows.Forms.Label();
            this.labelIdUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxDireccionEnvio = new System.Windows.Forms.TextBox();
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
            this.tabControlPedidos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPedidos
            // 
            this.tabControlPedidos.Controls.Add(this.tabPage1);
            this.tabControlPedidos.Controls.Add(this.tabPage2);
            this.tabControlPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControlPedidos.Location = new System.Drawing.Point(5, 3);
            this.tabControlPedidos.Name = "tabControlPedidos";
            this.tabControlPedidos.SelectedIndex = 0;
            this.tabControlPedidos.Size = new System.Drawing.Size(690, 537);
            this.tabControlPedidos.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::capaPresentacionWF.Properties.Resources.cepillo_pintura_paleta;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textBoxFechaEntrega);
            this.tabPage1.Controls.Add(this.textBoxFachaSolicitud);
            this.tabPage1.Controls.Add(this.textBoxIdCliente);
            this.tabPage1.Controls.Add(this.textBoxIdUsuario);
            this.tabPage1.Controls.Add(this.textBoxCantidadSolicitada);
            this.tabPage1.Controls.Add(this.labelFechaEntrega);
            this.tabPage1.Controls.Add(this.labelCantidadSolicitada);
            this.tabPage1.Controls.Add(this.labelIdUsuario);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxDireccionEnvio);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.labelPedidos);
            this.tabPage1.Controls.Add(this.labelId);
            this.tabPage1.Controls.Add(this.labelFechaSolicitada);
            this.tabPage1.Controls.Add(this.labelDireccionEnvio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaPresentacionWF.Properties.Resources.ImagenCreacionesPNG;
            this.pictureBox1.Location = new System.Drawing.Point(183, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxFechaEntrega
            // 
            this.textBoxFechaEntrega.Location = new System.Drawing.Point(102, 427);
            this.textBoxFechaEntrega.Name = "textBoxFechaEntrega";
            this.textBoxFechaEntrega.Size = new System.Drawing.Size(200, 20);
            this.textBoxFechaEntrega.TabIndex = 45;
            // 
            // textBoxFachaSolicitud
            // 
            this.textBoxFachaSolicitud.Location = new System.Drawing.Point(98, 364);
            this.textBoxFachaSolicitud.Name = "textBoxFachaSolicitud";
            this.textBoxFachaSolicitud.Size = new System.Drawing.Size(200, 20);
            this.textBoxFachaSolicitud.TabIndex = 44;
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(363, 391);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(99, 20);
            this.textBoxIdCliente.TabIndex = 43;
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Location = new System.Drawing.Point(353, 260);
            this.textBoxIdUsuario.Name = "textBoxIdUsuario";
            this.textBoxIdUsuario.Size = new System.Drawing.Size(112, 20);
            this.textBoxIdUsuario.TabIndex = 42;
            // 
            // textBoxCantidadSolicitada
            // 
            this.textBoxCantidadSolicitada.Location = new System.Drawing.Point(360, 327);
            this.textBoxCantidadSolicitada.Name = "textBoxCantidadSolicitada";
            this.textBoxCantidadSolicitada.Size = new System.Drawing.Size(99, 20);
            this.textBoxCantidadSolicitada.TabIndex = 41;
            // 
            // labelFechaEntrega
            // 
            this.labelFechaEntrega.AutoSize = true;
            this.labelFechaEntrega.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelFechaEntrega.Location = new System.Drawing.Point(98, 400);
            this.labelFechaEntrega.Name = "labelFechaEntrega";
            this.labelFechaEntrega.Size = new System.Drawing.Size(139, 24);
            this.labelFechaEntrega.TabIndex = 39;
            this.labelFechaEntrega.Text = "Fecha Entrega:";
            // 
            // labelCantidadSolicitada
            // 
            this.labelCantidadSolicitada.AutoSize = true;
            this.labelCantidadSolicitada.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelCantidadSolicitada.Location = new System.Drawing.Point(349, 233);
            this.labelCantidadSolicitada.Name = "labelCantidadSolicitada";
            this.labelCantidadSolicitada.Size = new System.Drawing.Size(190, 24);
            this.labelCantidadSolicitada.TabIndex = 38;
            this.labelCantidadSolicitada.Text = "Cantidad Solicitada:";
            // 
            // labelIdUsuario
            // 
            this.labelIdUsuario.AutoSize = true;
            this.labelIdUsuario.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelIdUsuario.Location = new System.Drawing.Point(360, 300);
            this.labelIdUsuario.Name = "labelIdUsuario";
            this.labelIdUsuario.Size = new System.Drawing.Size(102, 24);
            this.labelIdUsuario.TabIndex = 37;
            this.labelIdUsuario.Text = "Id Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(360, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Id Cliente:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonGuardar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonGuardar.Location = new System.Drawing.Point(363, 418);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(102, 36);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxDireccionEnvio
            // 
            this.textBoxDireccionEnvio.Location = new System.Drawing.Point(98, 265);
            this.textBoxDireccionEnvio.Multiline = true;
            this.textBoxDireccionEnvio.Name = "textBoxDireccionEnvio";
            this.textBoxDireccionEnvio.Size = new System.Drawing.Size(200, 60);
            this.textBoxDireccionEnvio.TabIndex = 33;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(148, 201);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(44, 20);
            this.textBoxId.TabIndex = 31;
            // 
            // labelPedidos
            // 
            this.labelPedidos.AutoSize = true;
            this.labelPedidos.Font = new System.Drawing.Font("Cooper Black", 22.25F);
            this.labelPedidos.Location = new System.Drawing.Point(198, 160);
            this.labelPedidos.Name = "labelPedidos";
            this.labelPedidos.Size = new System.Drawing.Size(287, 35);
            this.labelPedidos.TabIndex = 28;
            this.labelPedidos.Text = "Registrar Pedidos";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelId.Location = new System.Drawing.Point(115, 200);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(27, 24);
            this.labelId.TabIndex = 27;
            this.labelId.Text = "Id";
            // 
            // labelFechaSolicitada
            // 
            this.labelFechaSolicitada.AutoSize = true;
            this.labelFechaSolicitada.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelFechaSolicitada.Location = new System.Drawing.Point(97, 339);
            this.labelFechaSolicitada.Name = "labelFechaSolicitada";
            this.labelFechaSolicitada.Size = new System.Drawing.Size(159, 24);
            this.labelFechaSolicitada.TabIndex = 26;
            this.labelFechaSolicitada.Text = "Fecha Solicitada:";
            // 
            // labelDireccionEnvio
            // 
            this.labelDireccionEnvio.AutoSize = true;
            this.labelDireccionEnvio.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelDireccionEnvio.Location = new System.Drawing.Point(96, 233);
            this.labelDireccionEnvio.Name = "labelDireccionEnvio";
            this.labelDireccionEnvio.Size = new System.Drawing.Size(175, 24);
            this.labelDireccionEnvio.TabIndex = 25;
            this.labelDireccionEnvio.Text = "Dirección de envío:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::capaPresentacionWF.Properties.Resources.cepillo_pintura_paleta;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.dataGridViewPedidos);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToOrderColumns = true;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(150, 177);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.Size = new System.Drawing.Size(378, 267);
            this.dataGridViewPedidos.TabIndex = 18;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEliminar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonEliminar.Location = new System.Drawing.Point(417, 450);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 35);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEditar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonEditar.Location = new System.Drawing.Point(172, 450);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(77, 32);
            this.buttonEditar.TabIndex = 16;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonBuscar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonBuscar.Location = new System.Drawing.Point(430, 137);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(86, 31);
            this.buttonBuscar.TabIndex = 15;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(239, 143);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(185, 20);
            this.textBoxBuscar.TabIndex = 14;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelBuscar.Location = new System.Drawing.Point(159, 139);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(74, 24);
            this.labelBuscar.TabIndex = 13;
            this.labelBuscar.Text = "Buscar:";
            // 
            // fPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 539);
            this.Controls.Add(this.tabControlPedidos);
            this.Name = "fPedidos";
            this.Text = "fPedidos";
            this.Load += new System.EventHandler(this.fPedidos_load);
            this.tabControlPedidos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPedidos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.TextBox textBoxIdUsuario;
        private System.Windows.Forms.TextBox textBoxCantidadSolicitada;
        private System.Windows.Forms.Label labelFechaEntrega;
        private System.Windows.Forms.Label labelCantidadSolicitada;
        private System.Windows.Forms.Label labelIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxDireccionEnvio;
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
        private System.Windows.Forms.TextBox textBoxFachaSolicitud;
        private System.Windows.Forms.TextBox textBoxFechaEntrega;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}