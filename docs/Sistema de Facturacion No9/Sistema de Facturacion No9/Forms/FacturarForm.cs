using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Facturacion_No9.Forms
{
    public partial class FacturarForm : Form
    {
        public FacturarForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones simples
            if (string.IsNullOrEmpty(txtProducto.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, llena los campos del producto y precio.");
                return;
            }

            try
            {
                // 2. Obtener valores de los controles
                string producto = txtProducto.Text;
                int cantidad = (int)nmCantidad.Value;
                decimal precio = decimal.Parse(txtPrecio.Text);
                decimal subtotal = cantidad * precio;

                // 3. Agregar al DataGridView (Asegúrate que los nombres de columnas coincidan)
                dgvDetalle.Rows.Add(producto, cantidad, precio, subtotal);

                // 4. Limpiar para el siguiente ingreso
                txtProducto.Clear();
                txtPrecio.Clear();
                nmCantidad.Value = 1;
                txtProducto.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }
    }
}
