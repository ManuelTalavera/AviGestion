
namespace AviGestion_.Logica
{
    public class HistorialPedido //nuevo
    {
        public int NumeroPedido { get; set; }
        public int NumeroFila { get; set; }
        public string Fecha { get; set; }
        public string Productos { get; set; }
        public decimal Monto { get; set; }
        public decimal Pagado { get; set; }
        public decimal Saldo { get; set; }
        public string Estado { get; set; }
    }
}
