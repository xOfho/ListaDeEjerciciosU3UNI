using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Biblioteca_no6.Entidades
{
  
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string FechaPublicacion { get; set; } = string.Empty; // En tu diseño usaste "Fecha"
        public bool Disponible { get; set; } // Esto se conectará con tu CheckBox "Activo" 
    }
}
