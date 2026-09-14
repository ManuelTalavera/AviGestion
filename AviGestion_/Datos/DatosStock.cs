using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AviGestion_.Logica;

namespace AviGestion_.Datos
{
    public class DatosStock
    {
        public List<Producto> ListarProductosConStock()
        {
            var lista = new List<Producto>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"SELECT Id, Codigo, Descripcion, Categoria, Precio, Stock, StockMinimo, StockMaximo, Estado 
                               FROM Productos";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            lista.Add(LeerProducto(reader));
                    }
                }
            }
            return lista;
        }

        public List<Producto> BuscarProductosConStock(string filtro)
        {
            var lista = new List<Producto>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"SELECT Id, Codigo, Descripcion, Categoria, Precio, Stock, StockMinimo, StockMaximo, Estado 
                               FROM Productos
                               WHERE Codigo LIKE @filtro OR Descripcion LIKE @filtro";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            lista.Add(LeerProducto(reader));
                    }
                }
            }
            return lista;
        }

        private Producto LeerProducto(SqlDataReader reader)
        {
            return new Producto
            {
                Id = (int)reader["Id"],
                Codigo = reader["Codigo"].ToString(),
                Descripcion = reader["Descripcion"].ToString(),
                Categoria = reader["Categoria"].ToString(),
                Precio = (decimal)reader["Precio"],
                Stock = (int)reader["Stock"],
                StockMinimo = (int)reader["StockMinimo"],
                StockMaximo = (int)reader["StockMaximo"],
                Estado = reader["Estado"].ToString()
            };
        }

        public void ActualizarStockProducto(int idProducto, int nuevoStock)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = "UPDATE Productos SET Stock = @stock WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@stock", nuevoStock);
                    cmd.Parameters.AddWithValue("@id", idProducto);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Alerta ObtenerAlertaActiva(int idProducto, string tipoAlerta)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"SELECT TOP 1 Id, ProductoId, TipoAlerta, Estado, FechaGeneracion 
                               FROM Alertas 
                               WHERE ProductoId = @id AND TipoAlerta = @tipo AND Estado = 'Activa'";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", idProducto);
                    cmd.Parameters.AddWithValue("@tipo", tipoAlerta);
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Alerta
                            {
                                Id = (int)reader["Id"],
                                ProductoId = (int)reader["ProductoId"],
                                TipoAlerta = reader["TipoAlerta"].ToString(),
                                Estado = reader["Estado"].ToString(),
                                FechaGeneracion = (DateTime)reader["FechaGeneracion"]
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void InsertarAlerta(Alerta alerta)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"INSERT INTO Alertas (ProductoId, TipoAlerta, Estado, FechaGeneracion) 
                               VALUES (@productoId, @tipo, @estado, GETDATE())";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@productoId", alerta.ProductoId);
                    cmd.Parameters.AddWithValue("@tipo", alerta.TipoAlerta);
                    cmd.Parameters.AddWithValue("@estado", alerta.Estado);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ResolverAlertasActivas(int idProducto, string tipoAlerta)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"UPDATE Alertas SET Estado = 'Resuelta', FechaResolucion = GETDATE() 
                               WHERE ProductoId = @id AND TipoAlerta = @tipo AND Estado = 'Activa'";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", idProducto);
                    cmd.Parameters.AddWithValue("@tipo", tipoAlerta);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}