using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient; 
using System.Data;            
using Gestion_de_estudiantes_no3.Entities;
using Gestion_de_estudiantes_no3.Interfaces;

namespace Gestion_de_estudiantes_no3.Repositorio
{
    public class SqlEstudianteRepository : IEstudianteRepository
    {
        private readonly string _connectionString;

        public SqlEstudianteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Agregar(Estudiante estudiante)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
               
                string query = "INSERT INTO Estudiantes (Nombre, Carrera, Promedio) VALUES (@Nombre, @Carrera, @Promedio)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                command.Parameters.AddWithValue("@Carrera", estudiante.Carrera);
                command.Parameters.AddWithValue("@Promedio", estudiante.Promedio);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Estudiante> ObtenerTodos()
        {
            var lista = new List<Estudiante>();
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Nombre, Carrera, Promedio FROM Estudiantes";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Estudiante
                        {
                            Id = (int)reader["Id"],
                            Nombre = reader["Nombre"].ToString(),
                            Carrera = reader["Carrera"].ToString(),
                            Promedio = Convert.ToDouble(reader["Promedio"])
                        });
                    }
                }
            }
            return lista;
        }
    }
}

