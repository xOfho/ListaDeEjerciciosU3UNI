namespace Sistema_de_Facturacion_No9.Forms
{
    partial class TransaccionesForm
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
            dgvHistorial = new DataGridView();
            btnCargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(41, 58);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 82;
            dgvHistorial.Size = new Size(1390, 690);
            dgvHistorial.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.FromArgb(0, 192, 0);
            btnCargar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.ForeColor = SystemColors.ButtonHighlight;
            btnCargar.Location = new Point(1157, 879);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(274, 106);
            btnCargar.TabIndex = 11;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // TransaccionesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 1060);
            Controls.Add(btnCargar);
            Controls.Add(dgvHistorial);
            Name = "TransaccionesForm";
            Text = "TransaccionesForm";
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistorial;
        private Button btnCargar;
    }
}