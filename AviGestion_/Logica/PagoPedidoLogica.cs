using AviGestion_.Datos;
using System;
using System.Collections.Generic;

namespace AviGestion_.Logica
{
    public class PagoPedidoLogica
    {
        private PagosPedidoDatos _pagosDatos = new PagosPedidoDatos();

        public List<PagoPedido> ObtenerPedidosParaPagos()
        {
            return _pagosDatos.ObtenerPedidosParaPagos();
        }

        public void RegistrarPago(int idPedido, decimal importeAbonar)
        {
            if (importeAbonar <= 0)
                throw new ArgumentException("El monto a abonar debe ser mayor a cero.");

            int resultado = _pagosDatos.RegistrarPagoTransaccional(idPedido, importeAbonar);

            if (resultado == 1)
                throw new ArgumentException("El pedido ya no está disponible para cobro (cancelado o sin compra registrada).");
            if (resultado == 2)
                throw new ArgumentException("El monto supera el saldo pendiente actual. Se actualizó el listado.");
        }
    }
}
