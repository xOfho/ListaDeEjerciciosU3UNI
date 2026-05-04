namespace Sistema_de_Facturacion_No9.Forms
{
    partial class FacturarForm
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
            label1 = new Label();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            txtCliente = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAgregar = new Button();
            dgvDetalle = new DataGridView();
            txtProducto = new TextBox();
            nmCantidad = new NumericUpDown();
            txtPrecio = new TextBox();
            btnProcesarFactura = new Button();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Size = new Size(398, 59);
            label1.TabIndex = 0;
            label1.Text = "Nueva Facturacion";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCliente);
            panel1.Location = new Point(-1, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(1680, 182);
            panel1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(538, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(538, 47);
            label3.Name = "label3";
            label3.Size = new Size(81, 33);
            label3.TabIndex = 5;
            label3.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 39);
            label2.Name = "label2";
            label2.Size = new Size(92, 33);
            label2.TabIndex = 3;
            label2.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(18, 97);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(308, 39);
            txtCliente.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 338);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 2;
            label4.Text = "Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(572, 338);
            label5.Name = "label5";
            label5.Size = new Size(109, 32);
            label5.TabIndex = 3;
            label5.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(829, 338);
            label6.Name = "label6";
            label6.Size = new Size(79, 32);
            label6.TabIndex = 4;
            label6.Text = "Precio";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Highlight;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(1431, 350);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(222, 88);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "+ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colProducto, colCantidad, colPrecio, colSubtotal });
            dgvDetalle.Location = new Point(12, 464);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 82;
            dgvDetalle.Size = new Size(1641, 390);
            dgvDetalle.TabIndex = 6;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(17, 388);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(532, 39);
            txtProducto.TabIndex = 7;
            // 
            // nmCantidad
            // 
            nmCantidad.Location = new Point(578, 388);
            nmCantidad.Name = "nmCantidad";
            nmCantidad.Size = new Size(206, 39);
            nmCantidad.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(829, 387);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(200, 39);
            txtPrecio.TabIndex = 9;
            // 
            // btnProcesarFactura
            // 
            btnProcesarFactura.BackColor = Color.FromArgb(0, 192, 0);
            btnProcesarFactura.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcesarFactura.ForeColor = SystemColors.ButtonHighlight;
            btnProcesarFactura.Location = new Point(1379, 930);
            btnProcesarFactura.Name = "btnProcesarFactura";
            btnProcesarFactura.Size = new Size(274, 106);
            btnProcesarFactura.TabIndex = 10;
            btnProcesarFactura.Text = "Procesar Factura";
            btnProcesarFactura.UseVisualStyleBackColor = false;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 10;
            colProducto.Name = "colProducto";
            colProducto.Width = 200;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 10;
            colCantidad.Name = "colCantidad";
            colCantidad.Width = 200;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 10;
            colPrecio.Name = "colPrecio";
            colPrecio.Width = 200;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 10;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.Width = 200;
            // 
            // FacturarForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1678, 1104);
            Controls.Add(btnProcesarFactura);
            Controls.Add(txtPrecio);
            Controls.Add(nmCantidad);
            Controls.Add(txtProducto);
            Controls.Add(dgvDetalle);
            Controls.Add(btnAgregar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FacturarForm";
            Text = "FacturarForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtCliente;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAgregar;
        private DataGridView dgvDetalle;
        private TextBox txtProducto;
        private NumericUpDown nmCantidad;
        private TextBox txtPrecio;
        private Button btnProcesarFactura;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colSubtotal;
    }
}