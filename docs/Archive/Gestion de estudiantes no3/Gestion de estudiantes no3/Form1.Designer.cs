namespace Gestion_de_estudiantes_no3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvEstudiantes = new DataGridView();
            richTextBoxNombre = new RichTextBox();
            richTextBoxCarrera = new RichTextBox();
            richTextBoxPromedio = new RichTextBox();
            btnRegistrar = new Button();
            btnBorrar = new Button();
            btnBuscar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            richTextBox4 = new RichTextBox();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(587, 66);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 0;
            label1.Text = "Bienvenidos";
            label1.TextAlign = ContentAlignment.TopCenter;
            //label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 178);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 268);
            label3.Name = "label3";
            label3.Size = new Size(90, 32);
            label3.TabIndex = 2;
            label3.Text = "Carrera";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 358);
            label4.Name = "label4";
            label4.Size = new Size(117, 32);
            label4.TabIndex = 3;
            label4.Text = "Promedio";
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(811, 110);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.RowHeadersWidth = 82;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.Size = new Size(612, 370);
            dgvEstudiantes.TabIndex = 4;
            dgvEstudiantes.CellContentClick += dgvEstudiantes_CellContentClick;
            // 
            // richTextBoxNombre
            // 
            richTextBoxNombre.Location = new Point(181, 175);
            richTextBoxNombre.Name = "richTextBoxNombre";
            richTextBoxNombre.Size = new Size(460, 50);
            richTextBoxNombre.TabIndex = 5;
            richTextBoxNombre.Text = "";
            richTextBoxNombre.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBoxCarrera
            // 
            richTextBoxCarrera.Location = new Point(181, 265);
            richTextBoxCarrera.Name = "richTextBoxCarrera";
            richTextBoxCarrera.Size = new Size(460, 50);
            richTextBoxCarrera.TabIndex = 6;
            richTextBoxCarrera.Text = "";
            // 
            // richTextBoxPromedio
            // 
            richTextBoxPromedio.Location = new Point(182, 346);
            richTextBoxPromedio.Name = "richTextBoxPromedio";
            richTextBoxPromedio.Size = new Size(459, 54);
            richTextBoxPromedio.TabIndex = 7;
            richTextBoxPromedio.Text = "";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(59, 544);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(192, 52);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += buttonRegistrar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(297, 544);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(196, 52);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += buttonBorrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(811, 654);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(184, 52);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += buttonBuscar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 484);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 11;
            label5.Text = "Registrar";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(297, 484);
            label6.Name = "label6";
            label6.Size = new Size(78, 32);
            label6.TabIndex = 12;
            label6.Text = "Borrar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(811, 606);
            label7.Name = "label7";
            label7.Size = new Size(83, 32);
            label7.TabIndex = 13;
            label7.Text = "Buscar";
            label7.Click += label7_Click;
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(811, 504);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(612, 58);
            richTextBox4.TabIndex = 14;
            richTextBox4.Text = "";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(523, 544);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(180, 52);
            btnMostrar.TabIndex = 15;
            btnMostrar.Text = "Ordenar";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1476, 851);
            Controls.Add(btnMostrar);
            Controls.Add(richTextBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnBuscar);
            Controls.Add(btnBorrar);
            Controls.Add(btnRegistrar);
            Controls.Add(richTextBoxPromedio);
            Controls.Add(richTextBoxCarrera);
            Controls.Add(richTextBoxNombre);
            Controls.Add(dgvEstudiantes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvEstudiantes;
        private RichTextBox richTextBoxNombre;
        private RichTextBox richTextBoxCarrera;
        private RichTextBox richTextBoxPromedio;
        private Button btnRegistrar;
        private Button btnBorrar;
        private Button btnBuscar;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox richTextBox4;
        private Button btnMostrar;
    }
}
