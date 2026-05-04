using Sistema_de_Biblioteca_no6.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Biblioteca_no6.Interfaces
{

    public interface ILibroRepository
    {
        void Agregar(Libro libro);
        void ActualizarDisponibilidad(int id, bool estado);
        IEnumerable<Libro> ObtenerTodos();


    }
}
