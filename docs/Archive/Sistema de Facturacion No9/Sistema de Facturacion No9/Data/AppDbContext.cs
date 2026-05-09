using Microsoft.EntityFrameworkCore;
using Sistema_de_Facturacion_No9.Entidades; 

namespace Sistema_de_Facturacion_No9.Data
{
    public class AppDbContext : DbContext
    {
        // Tablas de la base de datos
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Conexión para tu SQL Server en VMware
            // Cambia 'localhost' por el nombre de tu instancia si es necesario
            optionsBuilder.UseSqlServer("Server=localhost;Database=FacturacionDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de precisión para el precio (Decimal)
            modelBuilder.Entity<DetalleFactura>()
                .Property(d => d.Precio)
                .HasPrecision(18, 2);
        }
    }
}