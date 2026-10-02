namespace AviGestion_.Datos
{
    public class ClienteItem
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public override string ToString() => Nombre;
    }

    public class ProductoItem
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
        public string Display => $"{Nombre} (Stock: {Stock})";
        public override string ToString() => Display;
    }

    public class PedidoItem
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Productos { get; set; }
        public string Fecha { get; set; }
        public string Estado { get; set; }
    }
}