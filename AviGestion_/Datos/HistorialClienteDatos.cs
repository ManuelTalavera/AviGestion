using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AviGestion_.Logica;

namespace AviGestion_.Datos
{
    public class HistorialClienteDatos
    {
        // Pedidos facturados del cliente (compra vigente, no cancelados).
        // El monto sale de Compra.Total y el estado de pago se calcula en la consulta.
        public List<HistorialPedido> ObtenerPedidosCliente(int idCliente)
        {
            List<HistorialPedido> lista = new List<HistorialPedido>();

            string query = @"
                SELECT
                    pc.Id_Pedido,
                    CONVERT(VARCHAR(10), f.FechaPedido, 103) AS Fecha,
                    ISNULL(d.Productos, '')                  AS Productos,
                    co.Total                                 AS Monto,
                    pg.Pagado,
                    co.Total - pg.Pagado                     AS Saldo,
                    CASE WHEN pg.Pagado = 0        THEN 'Sin pagos'
                         WHEN pg.Pagado < co.Total THEN 'Parcial'
                         ELSE 'Pagado' END                   AS EstadoPago
                FROM Compra co
                INNER JOIN PedidosCompra pc ON pc.Id_Pedido = co.Id_Pedido
                CROSS APPLY (SELECT COALESCE(TRY_CONVERT(date, pc.Fecha, 23),
                                             TRY_CONVERT(date, pc.Fecha, 103)) AS FechaPedido) f
                CROSS APPLY (SELECT ISNULL(SUM(p.Monto), 0) AS Pagado
                             FROM Pago p WHERE p.Id_Pedido = pc.Id_Pedido) pg
                CROSS APPLY (SELECT STRING_AGG(x.Producto, ', ') AS Productos
                             FROM DetallePedidoCompra x WHERE x.Id_Pedido = pc.Id_Pedido) d
                WHERE pc.Id_Cliente = @Id_Cliente
                  AND pc.Estado <> 'Cancelado'
                  AND co.Estado = 1
                ORDER BY pc.Id_Pedido DESC";

            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Id_Cliente", idCliente);

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int contadorFila = 1;
                        while (reader.Read())
                        {
                            lista.Add(new HistorialPedido
                            {
                                NumeroFila = contadorFila++,
                                NumeroPedido = Convert.ToInt32(reader["Id_Pedido"]),
                                Fecha = reader["Fecha"].ToString(),
                                Productos = reader["Productos"].ToString(),
                                Monto = Convert.ToDecimal(reader["Monto"]),
                                Pagado = Convert.ToDecimal(reader["Pagado"]),
                                Saldo = Convert.ToDecimal(reader["Saldo"]),
                                Estado = reader["EstadoPago"].ToString()   // Sin pagos / Parcial / Pagado
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error base de datos (Listar Historial): " + ex.Message);
                }
            }
            return lista;
        }

        // Totales del cliente: comprado vs pagado, promedios y contadores por estado de pago
        public ResumenFinanciero CalcularResumenFinanciero(int idCliente)
        {
            ResumenFinanciero resumen = new ResumenFinanciero();

            string query = @"
                WITH PedidosTotales AS (
                    SELECT
                        pc.Id_Pedido,
                        COALESCE(TRY_CONVERT(date, pc.Fecha, 23), TRY_CONVERT(date, pc.Fecha, 103)) AS FechaPedido,
                        co.Total AS TotalPedido,
                        (SELECT ISNULL(SUM(p.Monto), 0) FROM Pago p WHERE p.Id_Pedido = pc.Id_Pedido) AS TotalPagadoPedido
                    FROM Compra co
                    INNER JOIN PedidosCompra pc ON pc.Id_Pedido = co.Id_Pedido
                    WHERE pc.Id_Cliente = @Id_Cliente
                      AND pc.Estado <> 'Cancelado'
                      AND co.Estado = 1
                )
                SELECT
                    ISNULL(SUM(TotalPedido), 0)       AS GranTotal,
                    ISNULL(SUM(TotalPagadoPedido), 0) AS GranPagado,
                    ISNULL(AVG(TotalPedido), 0)       AS PromedioCompra,
                    ISNULL(MIN(TotalPedido), 0)       AS MontoMinimo,
                    ISNULL(MAX(TotalPedido), 0)       AS MontoMaximo,
                    COUNT(Id_Pedido)                  AS CantPedidos,
                    COUNT(CASE WHEN TotalPagadoPedido >= TotalPedido THEN 1 END)                          AS CantPagados,
                    COUNT(CASE WHEN TotalPagadoPedido > 0 AND TotalPagadoPedido < TotalPedido THEN 1 END) AS CantParciales,
                    COUNT(CASE WHEN TotalPagadoPedido = 0 THEN 1 END)                                     AS CantPendientes,
                    MIN(FechaPedido)                  AS PrimeraCompra,
                    MAX(FechaPedido)                  AS UltimaCompra
                FROM PedidosTotales";

            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Id_Cliente", idCliente);

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && Convert.ToInt32(reader["CantPedidos"]) > 0)
                        {
                            resumen.TotalComprado = Convert.ToDecimal(reader["GranTotal"]);
                            resumen.TotalPagado = Convert.ToDecimal(reader["GranPagado"]);
                            resumen.SaldoPendiente = resumen.TotalComprado - resumen.TotalPagado;
                            resumen.CantidadPedidos = Convert.ToInt32(reader["CantPedidos"]);

                            resumen.PedidosPagados = Convert.ToInt32(reader["CantPagados"]);
                            resumen.PedidosParciales = Convert.ToInt32(reader["CantParciales"]);
                            resumen.PedidosPendientes = Convert.ToInt32(reader["CantPendientes"]);

                            resumen.PromedioCompra = Convert.ToDecimal(reader["PromedioCompra"]);
                            resumen.MontoMinimo = Convert.ToDecimal(reader["MontoMinimo"]);
                            resumen.MontoMaximo = Convert.ToDecimal(reader["MontoMaximo"]);

                            resumen.UltimaCompra = reader["UltimaCompra"] != DBNull.Value
                                ? Convert.ToDateTime(reader["UltimaCompra"]).ToString("dd/MM/yyyy") : "-";

                            if (reader["PrimeraCompra"] != DBNull.Value)
                            {
                                DateTime inicio = Convert.ToDateTime(reader["PrimeraCompra"]);
                                int meses = ((DateTime.Today.Year - inicio.Year) * 12) + DateTime.Today.Month - inicio.Month;
                                resumen.Antiguedad = meses <= 0 ? "Menos de 1 mes" : $"{meses} meses";
                            }
                            else { resumen.Antiguedad = "-"; }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error base de datos (Calcular Resumen): " + ex.Message);
                }
            }
            return resumen;
        }
    }
}
