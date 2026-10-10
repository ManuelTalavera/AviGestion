using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviGestion_.Datos;

namespace AviGestion_.Logica
{
    public class HistorialClienteLogica
    {
        private HistorialClienteDatos historialDatos = new HistorialClienteDatos();
        public List<HistorialPedido> ObtenerPedidosCliente(int idCliente) //nuevo
        {
            return historialDatos.ObtenerPedidosCliente(idCliente);
        }

        public ResumenFinanciero ObtenerResumenFinanciero(int idCliente)
        {
            // 1. Trae los totales duros calculados en la base de datos
            ResumenFinanciero resumen = historialDatos.CalcularResumenFinanciero(idCliente);
            List<HistorialPedido> pedidos = historialDatos.ObtenerPedidosCliente(idCliente);

            // 2. Procesa estadísticas analíticas complejas en memoria
            if (resumen.CantidadPedidos > 0 && pedidos.Count > 0)
            {
                decimal montoMaximo = 0;
                decimal montoMinimo = decimal.MaxValue;

                foreach (var p in pedidos)
                {
                    if (p.Monto > montoMaximo) montoMaximo = p.Monto;
                    if (p.Monto < montoMinimo) montoMinimo = p.Monto;
                }

                resumen.MontoMaximo = montoMaximo;
                resumen.MontoMinimo = montoMinimo == decimal.MaxValue ? 0 : montoMinimo;
                resumen.PromedioCompra = resumen.TotalComprado / resumen.CantidadPedidos;

                if (resumen.TotalComprado > 0)
                {
                    resumen.PorcentajePagado = (double)((resumen.TotalPagado * 100) / resumen.TotalComprado);
                }
                else
                {
                    resumen.PorcentajePagado = 0.0;
                }
            }
            return resumen;
        }
    }
}
