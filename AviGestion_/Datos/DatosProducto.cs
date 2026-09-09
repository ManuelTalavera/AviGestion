using System.Collections.Generic;
using System.Data.SqlClient;
using AviGestion_.Logica;

namespace AviGestion_.Datos
{
    public class DatosProducto
    {
        public List<Producto> Listar()
        {
            var lista = new List<Producto>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = "SELECT Id, Codigo, Descripcion, Categoria, Precio, Stock, Estado FROM Productos";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto
                            {
                                Id = reader.GetInt32(0),
                                Codigo = reader.GetString(1),
                                Descripcion = reader.GetString(2),
                                Categoria = reader.GetString(3),
                                Precio = reader.GetDecimal(4),
                                Stock = reader.GetInt32(5),
                                Estado = reader.GetString(6)
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public List<Producto> Buscar(string filtro)
        {
            var lista = new List<Producto>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"SELECT Id, Codigo, Descripcion, Categoria, Precio, Stock, Estado 
                               FROM Productos 
                               WHERE Codigo LIKE @filtro OR Descripcion LIKE @filtro";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto
                            {
                                Id = reader.GetInt32(0),
                                Codigo = reader.GetString(1),
                                Descripcion = reader.GetString(2),
                                Categoria = reader.GetString(3),
                                Precio = reader.GetDecimal(4),
                                Stock = reader.GetInt32(5),
                                Estado = reader.GetString(6)
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public void Registrar(Producto p)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"INSERT INTO Productos (Codigo, Descripcion, Categoria, Precio, Stock, Estado) 
                               VALUES (@codigo, @descripcion, @categoria, @precio, @stock, @estado)";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@codigo", p.Codigo);
                    cmd.Parameters.AddWithValue("@descripcion", p.Descripcion);
                    cmd.Parameters.AddWithValue("@categoria", p.Categoria);
                    cmd.Parameters.AddWithValue("@precio", p.Precio);
                    cmd.Parameters.AddWithValue("@stock", p.Stock);
                    cmd.Parameters.AddWithValue("@estado", p.Estado);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Modificar(Producto p)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = @"UPDATE Productos SET Codigo=@codigo, Descripcion=@descripcion, 
                               Categoria=@categoria, Precio=@precio, Stock=@stock, Estado=@estado 
                               WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@codigo", p.Codigo);
                    cmd.Parameters.AddWithValue("@descripcion", p.Descripcion);
                    cmd.Parameters.AddWithValue("@categoria", p.Categoria);
                    cmd.Parameters.AddWithValue("@precio", p.Precio);
                    cmd.Parameters.AddWithValue("@stock", p.Stock);
                    cmd.Parameters.AddWithValue("@estado", p.Estado);
                    cmd.Parameters.AddWithValue("@id", p.Id);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = "DELETE FROM Productos WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}