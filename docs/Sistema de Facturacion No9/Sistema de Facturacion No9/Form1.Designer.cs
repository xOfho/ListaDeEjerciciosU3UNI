namespace Sistema_de_Facturacion_No9
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
            panelMenu = new Panel();
            btnCerrar = new Button();
            btnTransacciones = new Button();
            btnFacturar = new Button();
            panelLogo = new Panel();
            panel2 = new Panel();
            panelContenedor = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(15, 69, 113);
            panelMenu.Controls.Add(btnCerrar);
            panelMenu.Controls.Add(btnTransacciones);
            panelMenu.Controls.Add(btnFacturar);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(374, 1009);
            panelMenu.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ControlLightLight;
            btnCerrar.Location = new Point(0, 919);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(374, 90);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += button4_Click;
            // 
            // btnTransacciones
            // 
            btnTransacciones.BackColor = Color.FromArgb(15, 69, 113);
            btnTransacciones.FlatAppearance.BorderSize = 0;
            btnTransacciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 157, 221);
            btnTransacciones.FlatStyle = FlatStyle.Flat;
            btnTransacciones.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransacciones.ForeColor = SystemColors.ControlLightLight;
            btnTransacciones.Location = new Point(0, 360);
            btnTransacciones.Name = "btnTransacciones";
            btnTransacciones.Size = new Size(374, 90);
            btnTransacciones.TabIndex = 2;
            btnTransacciones.Text = "Transacciones";
            btnTransacciones.UseVisualStyleBackColor = false;
            btnTransacciones.Click += btnTransacciones_Click;
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.FromArgb(15, 69, 113);
            btnFacturar.FlatAppearance.BorderSize = 0;
            btnFacturar.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 157, 221);
            btnFacturar.FlatStyle = FlatStyle.Flat;
            btnFacturar.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFacturar.ForeColor = SystemColors.ControlLightLight;
            btnFacturar.Location = new Point(0, 268);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(374, 90);
            btnFacturar.TabIndex = 1;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = false;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(255, 192, 192);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(374, 106);
            panelLogo.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 69, 113);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(374, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1524, 70);
            panel2.TabIndex = 1;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ActiveCaption;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(374, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1520, 1009);
            panelContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnFacturar;
        private Button btnTransacciones;
        private Button btnCerrar;
        private Panel panel2;
        private Panel panelContenedor;
    }
}
