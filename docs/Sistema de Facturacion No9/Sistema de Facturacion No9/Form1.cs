namespace Sistema_de_Facturacion_No9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                Environment.Exit(0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            // Usamos el namespace correcto donde están tus formularios
           AbrirFormHijo(new Sistema_de_Facturacion_No9.Forms.FacturarForm());
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Sistema_de_Facturacion_No9.Forms.TransaccionesForm());
        }

        private void AbrirFormHijo(object formHijo)
        {
            // Esto limpia el panel gris para poner el nuevo formulario
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
    }
}
