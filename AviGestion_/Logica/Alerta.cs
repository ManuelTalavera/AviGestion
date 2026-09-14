using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviGestion_.Logica
{
    public class Alerta
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string TipoAlerta { get; set; }
        public string Estado { get; set; }
        public DateTime FechaGeneracion { get; set; }
    }
}
