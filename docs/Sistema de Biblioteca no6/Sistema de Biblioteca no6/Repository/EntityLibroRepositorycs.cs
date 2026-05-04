using Sistema_de_Biblioteca_no6.Data; // Asegúrate de tener tu AppDbContext aquí
using Sistema_de_Biblioteca_no6.Entidades;
using Sistema_de_Biblioteca_no6.Interfaces;

namespace Sistema_de_Biblioteca_no6.Repository
{
    // 1. Agregamos ": ILibroRepository" para que cumpla con el contrato
    public class EntityLibroRepository : ILibroRepository
    {
        // 2. Instanciamos el contexto de Entity Framework
        private readonly AppDbContext _context = new AppDbContext();

        public void Agregar(Libro libro)
        {
            _context.Libros.Add(libro); // EF prepara el comando INSERT
            _context.SaveChanges();     // Se ejecuta en SQL Server
        }

        public IEnumerable<Libro> ObtenerTodos()
        {
            // Retorna la lista completa de libros
            return _context.Libros.ToList();
        }

        public void ActualizarDisponibilidad(int id, bool estado)
        {
            var libro = _context.Libros.Find(id);
            if (libro != null)
            {
                libro.Disponible = estado;
                _context.SaveChanges();
            }
        }
    }
}