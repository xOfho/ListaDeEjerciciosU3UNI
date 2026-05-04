using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Facturacion_No9.Entidades
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int FacturaId { get; set; } 
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
