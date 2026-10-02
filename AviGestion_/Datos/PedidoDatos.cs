using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AviGestion_.Datos
{
    public class PedidoDatos
    {
        #region Obtener Clientes
        public List<ClienteItem> ObtenerClientes()
        {
            List<ClienteItem> lista = new List<ClienteItem>();
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_ObtenerClientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new ClienteItem
                    {
                        Id = (int)dr["Id_Cliente"],
                        Nombre = dr["NombreCompleto"].ToString()
                    });
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clientes: " + ex.Message);
            }
            return lista;
        }
        #endregion

        #region Obtener Productos
        public List<ProductoItem> ObtenerProductos()
        {
            List<ProductoItem> lista = new List<ProductoItem>();
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_ObtenerProductos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new ProductoItem
                    {
                        Id = (int)dr["Id"],
                        Codigo = dr["Codigo"].ToString(),
                        Nombre = dr["Descripcion"].ToString(),
                        Stock = (int)dr["Stock"],
                        Precio = (decimal)dr["Precio"]
                    });
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos: " + ex.Message);
            }
            return lista;
        }
        #endregion

        #region Obtener Pedidos
        public List<PedidoItem> ObtenerPedidos()
        {
            List<PedidoItem> lista = new List<PedidoItem>();
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_ObtenerPedidos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new PedidoItem
                    {
                        Id = (int)dr["Id_Pedido"],
                        Cliente = dr["Cliente"].ToString(),
                        Productos = dr["Productos"].ToString(),
                        Fecha = dr["Fecha"].ToString(),
                        Estado = dr["Estado"].ToString()
                    });
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener pedidos: " + ex.Message);
            }
            return lista;
        }
        #endregion

        #region Insertar Pedido
        public int InsertarPedido(int idCliente, DateTime fecha, string productosParam)
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertarPedido", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Cliente", idCliente);
                cmd.Parameters.AddWithValue("@Fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@Productos", productosParam);

                SqlParameter outParam = new SqlParameter("@Id_Pedido_Out", SqlDbType.Int)
                { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(outParam);
                cmd.ExecuteNonQuery();
                con.Close();

                return (int)outParam.Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar pedido: " + ex.Message);
            }
        }
        #endregion

        #region Cancelar Pedido
        public void CancelarPedido(int idPedido)
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_CancelarPedido", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Pedido", idPedido);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cancelar pedido: " + ex.Message);
            }
        }
        #endregion
    }
}