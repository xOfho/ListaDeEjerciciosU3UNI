namespace Sistema_de_Biblioteca_no6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textTitulo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridViewLibros = new DataGridView();
            textAutor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textFecha = new TextBox();
            chkActivo = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnSoloDisponibles = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibros).BeginInit();
            SuspendLayout();
            // 
            // textTitulo
            // 
            textTitulo.Location = new Point(49, 659);
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(564, 39);
            textTitulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 602);
            label1.Name = "label1";
            label1.Size = new Size(107, 38);
            label1.TabIndex = 1;
            label1.Text = "Titulo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Impact", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(599, 46);
            label2.Name = "label2";
            label2.Size = new Size(771, 85);
            label2.TabIndex = 2;
            label2.Text = "Sistema de Biblioteca v1.0";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // dataGridViewLibros
            // 
            dataGridViewLibros.BackgroundColor = SystemColors.Control;
            dataGridViewLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLibros.GridColor = SystemColors.HighlightText;
            dataGridViewLibros.Location = new Point(49, 160);
            dataGridViewLibros.Name = "dataGridViewLibros";
            dataGridViewLibros.RowHeadersWidth = 82;
            dataGridViewLibros.Size = new Size(1080, 426);
            dataGridViewLibros.TabIndex = 3;
            dataGridViewLibros.CellContentClick += dataGridViewLibros_CellContentClick;
            // 
            // textAutor
            // 
            textAutor.Location = new Point(49, 769);
            textAutor.Name = "textAutor";
            textAutor.Size = new Size(564, 39);
            textAutor.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(49, 718);
            label3.Name = "label3";
            label3.Size = new Size(105, 38);
            label3.TabIndex = 5;
            label3.Text = "Autor";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(49, 828);
            label4.Name = "label4";
            label4.Size = new Size(348, 38);
            label4.TabIndex = 7;
            label4.Text = "Fecha de Publicacion";
            label4.Click += label4_Click;
            // 
            // textFecha
            // 
            textFecha.Location = new Point(49, 885);
            textFecha.Name = "textFecha";
            textFecha.Size = new Size(564, 39);
            textFecha.TabIndex = 6;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkActivo.ForeColor = Color.White;
            chkActivo.Location = new Point(853, 653);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(132, 44);
            chkActivo.TabIndex = 8;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(863, 786);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(669, 654);
            label6.Name = "label6";
            label6.Size = new Size(125, 38);
            label6.TabIndex = 10;
            label6.Text = "Estado";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(669, 772);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(188, 62);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(887, 769);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(188, 62);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSoloDisponibles
            // 
            btnSoloDisponibles.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoloDisponibles.Location = new Point(669, 859);
            btnSoloDisponibles.Name = "btnSoloDisponibles";
            btnSoloDisponibles.Size = new Size(194, 65);
            btnSoloDisponibles.TabIndex = 14;
            btnSoloDisponibles.Text = "Disponibles";
            btnSoloDisponibles.UseVisualStyleBackColor = true;
            btnSoloDisponibles.Click += btnSoloDisponibles_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1894, 1009);
            Controls.Add(btnSoloDisponibles);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(chkActivo);
            Controls.Add(label4);
            Controls.Add(textFecha);
            Controls.Add(label3);
            Controls.Add(textAutor);
            Controls.Add(dataGridViewLibros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textTitulo);
            ForeColor = Color.CornflowerBlue;
            Name = "Form1";
            Text = "Sistema de Biblioteca";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTitulo;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewLibros;
        private TextBox textAutor;
        private Label label3;
        private Label label4;
        private TextBox textFecha;
        private CheckBox chkActivo;
        private Label label5;
        private Label label6;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnSoloDisponibles;
    }
}
