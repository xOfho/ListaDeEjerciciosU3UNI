using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Facturacion_No9.Entidades
{
    public class Factura
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
      
        public List<DetalleFactura> Detalles { get; set; } = new List<DetalleFactura>();
    }
}
