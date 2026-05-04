using Sistema_de_Biblioteca_no6.Entidades;
using Sistema_de_Biblioteca_no6.Interfaces;
using Sistema_de_Biblioteca_no6.Repository;

namespace Sistema_de_Biblioteca_no6
{
    public partial class Form1 : Form
    {
        private readonly ILibroRepository _repo;
        public Form1()
        {
            InitializeComponent();
            _repo = new EntityLibroRepository();

            CargarGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoLibro = new Libro
                {
                    // Usamos 'text' y 'chk' según tu archivo Designer.cs
                    Titulo = textTitulo.Text,
                    Autor = textAutor.Text,
                    FechaPublicacion = textFecha.Text,
                    Disponible = chkActivo.Checked
                };

                _repo.Agregar(nuevoLibro);
                MessageBox.Show("Libro registrado en la biblioteca.");
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarGrid()
        {
            
            dataGridViewLibros.DataSource = null;
            dataGridViewLibros.DataSource = _repo.ObtenerTodos().ToList();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSoloDisponibles_Click(object sender, EventArgs e)
        {
            var todos = _repo.ObtenerTodos();
            var soloDisponibles = todos.Where(l => l.Disponible).ToList();

            dataGridViewLibros.DataSource = soloDisponibles;
        }

        
    }
}
