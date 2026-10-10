using AviGestion_.Interfaz;
using AviGestion_.Logica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AviGestion_.Datos
{
    public class VehiculoDAL
    {
        // ---------------------------------------------------------
        // Obtener todos los vehículos
        // ---------------------------------------------------------
        public List<Vehiculo> ObtenerTodos()
        {
            var lista = new List<Vehiculo>();

            const string query = @"SELECT Id, Marca, Modelo, Patente,
                                          CapacidadMax, CapacidadActual, Estado
                                   FROM Vehiculos
                                   ORDER BY Id";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                conexion.Open();
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Vehiculo
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Marca = reader["Marca"].ToString(),
                            Modelo = reader["Modelo"].ToString(),
                            Patente = reader["Patente"].ToString(),
                            CapacidadMax = Convert.ToInt32(reader["CapacidadMax"]),
                            CapacidadActual = Convert.ToInt32(reader["CapacidadActual"]),
                            Estado = reader["Estado"].ToString()
                        });
                    }
                }
            }

            return lista;
        }

        // ---------------------------------------------------------
        // Agregar un nuevo vehículo (devuelve el Id generado)
        // ---------------------------------------------------------
        public int Agregar(Vehiculo vehiculo)
        {
            const string query = @"INSERT INTO Vehiculos
                                       (Marca, Modelo, Patente, CapacidadMax, CapacidadActual, Estado)
                                   OUTPUT INSERTED.Id
                                   VALUES
                                       (@Marca, @Modelo, @Patente, @CapacidadMax, @CapacidadActual, @Estado)";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                comando.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                comando.Parameters.AddWithValue("@Patente", vehiculo.Patente);
                comando.Parameters.AddWithValue("@CapacidadMax", vehiculo.CapacidadMax);
                comando.Parameters.AddWithValue("@CapacidadActual", vehiculo.CapacidadActual);
                comando.Parameters.AddWithValue("@Estado", vehiculo.Estado);

                conexion.Open();
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        // ---------------------------------------------------------
        // Actualizar los datos de un vehículo existente
        // (no toca CapacidadActual, que se maneja por otro lado)
        // ---------------------------------------------------------
        public bool Actualizar(Vehiculo vehiculo)
        {
            const string query = @"UPDATE Vehiculos
                                   SET Marca = @Marca,
                                       Modelo = @Modelo,
                                       Patente = @Patente,
                                       CapacidadMax = @CapacidadMax,
                                       Estado = @Estado
                                   WHERE Id = @Id";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                comando.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                comando.Parameters.AddWithValue("@Patente", vehiculo.Patente);
                comando.Parameters.AddWithValue("@CapacidadMax", vehiculo.CapacidadMax);
                comando.Parameters.AddWithValue("@Estado", vehiculo.Estado);
                comando.Parameters.AddWithValue("@Id", vehiculo.Id);

                conexion.Open();
                return comando.ExecuteNonQuery() > 0;
            }
        }

        // ---------------------------------------------------------
        // Cambiar el estado ("Activo" / "Inactivo")
        // ---------------------------------------------------------
        public bool CambiarEstado(int id, string nuevoEstado)
        {
            const string query = @"UPDATE Vehiculos
                                   SET Estado = @Estado
                                   WHERE Id = @Id";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@Estado", nuevoEstado);
                comando.Parameters.AddWithValue("@Id", id);

                conexion.Open();
                return comando.ExecuteNonQuery() > 0;
            }
        }

        // ---------------------------------------------------------
        // Verificar si una patente ya existe (idExcluir sirve al editar)
        // ---------------------------------------------------------
        public bool ExistePatente(string patente, int idExcluir = 0)
        {
            const string query = @"SELECT COUNT(1)
                                   FROM Vehiculos
                                   WHERE Patente = @Patente AND Id <> @IdExcluir";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@Patente", patente);
                comando.Parameters.AddWithValue("@IdExcluir", idExcluir);

                conexion.Open();
                return Convert.ToInt32(comando.ExecuteScalar()) > 0;
            }
        }
    }
}