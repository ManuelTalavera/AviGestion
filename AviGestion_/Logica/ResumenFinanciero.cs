
namespace AviGestion_.Logica
{
    public class ResumenFinanciero //nuevo
    {
        // Resumen de Estado de Cuenta (Panel Superior)
        public decimal TotalComprado { get; set; }
        public decimal TotalPagado { get; set; }
        public decimal SaldoPendiente { get; set; }
        public int CantidadPedidos { get; set; }
        public int PedidosPagados { get; set; }
        public int PedidosParciales { get; set; }
        public int PedidosPendientes { get; set; }

        // Resumen Financiero (Panel Inferior)
        public decimal PromedioCompra { get; set; }
        public decimal MontoMinimo { get; set; }
        public decimal MontoMaximo { get; set; }
        public double PorcentajePagado { get; set; }
        public string Antiguedad { get; set; }
        public string UltimaCompra { get; set; }
    }
}
