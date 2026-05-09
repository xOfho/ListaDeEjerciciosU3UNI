using Sistema_de_Facturacion_No9.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Facturacion_No9.Forms
{
    public partial class TransaccionesForm : Form
    {
        public TransaccionesForm()
        {
            InitializeComponent();
        }

        private void TransaccionesForm_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                // Esto toma todas las facturas guardadas en SQL Server
                // y las muestra en el DataGridView de este formulario.
                dgvHistorial.DataSource = db.Facturas.ToList();
            }
        }
       
        private void CargarHistorial()
        {
            try
            {
                using (var db = new Sistema_de_Facturacion_No9.Data.AppDbContext())
                {
                    // Consultamos la base de datos y mandamos los resultados al Grid
                    dgvHistorial.DataSource = db.Facturas.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con SQL Server: " + ex.Message);
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarHistorial();
        }
    }
}
