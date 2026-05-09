using Microsoft.EntityFrameworkCore; // Esto ya no debería salir en rojo
using Sistema_de_Biblioteca_no6.Entidades;

namespace Sistema_de_Biblioteca_no6.Data
{
    // Debe decir ": DbContext" para que funcione SaveChanges()
    public class AppDbContext : DbContext
    {
        public DbSet<Libro> Libros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Nota: Verifica que el nombre de tu servidor sea localhost o el que uses en VMware
            optionsBuilder.UseSqlServer("Server=localhost;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}