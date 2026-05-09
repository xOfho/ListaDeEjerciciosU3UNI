using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_estudiantes_no3.Entities
{
    public class Estudiante
    {
        public int Id { get; set; }
     
        public string Nombre { get; set; } = string.Empty;
        public string Carrera { get; set; } = string.Empty;
        public double Promedio { get; set; }
    }
}
