using Gestion_de_estudiantes_no3.Entities;
using Gestion_de_estudiantes_no3.Interfaces;
using Gestion_de_estudiantes_no3.Repositorio;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace Gestion_de_estudiantes_no3
{
    public partial class Form1 : Form
    {
      
        private readonly IEstudianteRepository _repo;
        private readonly string connectionString = "Server=localhost;Database=ColegioDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
            
            _repo = new SqlEstudianteRepository(connectionString);
        }


        private void CargarDatosGrid()
        {
            try
            {
                var lista = _repo.ObtenerTodos();
                
                dgvEstudiantes.DataSource = lista.OrderByDescending(x => x.Promedio).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            richTextBoxNombre.Clear();
            richTextBoxCarrera.Clear();
            richTextBoxPromedio.Clear();
            richTextBoxNombre.Focus();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatosGrid();
        }

       
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(richTextBoxNombre.Text) || string.IsNullOrWhiteSpace(richTextBoxCarrera.Text))
                {
                    MessageBox.Show("Por favor, llena Nombre y Carrera.");
                    return;
                }

                var estudiante = new Estudiante
                {
                    Nombre = richTextBoxNombre.Text,
                    Carrera = richTextBoxCarrera.Text,
                    Promedio = double.Parse(richTextBoxPromedio.Text)
                };

                _repo.Agregar(estudiante);
                MessageBox.Show("Estudiante guardado con éxito.");

                LimpiarCampos();
                CargarDatosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

       
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string criterio = richTextBox4.Text.Trim();

                
                var todos = _repo.ObtenerTodos();

                
                var filtrados = todos.Where(x => x.Carrera.Contains(criterio, StringComparison.OrdinalIgnoreCase)).ToList();

               
                dgvEstudiantes.DataSource = null; 
                dgvEstudiantes.DataSource = filtrados; 

                if (filtrados.Count == 0)
                {
                    MessageBox.Show("No se encontraron estudiantes en esa carrera.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var est = (Estudiante)dgvEstudiantes.Rows[e.RowIndex].DataBoundItem;
                
                richTextBox4.Text = $"Seleccionado: {est.Nombre} - {est.Promedio}";
            }
        }

        
        private void label5_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de borrado en desarrollo.");
        }
    }
}