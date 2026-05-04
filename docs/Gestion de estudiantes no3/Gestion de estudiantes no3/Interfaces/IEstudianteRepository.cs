using Gestion_de_estudiantes_no3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_estudiantes_no3.Interfaces
{
    public interface IEstudianteRepository
    {
        void Agregar(Estudiante estudiante);
        IEnumerable<Estudiante> ObtenerTodos();
    }
}
