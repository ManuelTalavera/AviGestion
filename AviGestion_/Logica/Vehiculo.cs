using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviGestion_.Datos;

namespace AviGestion_.Logica
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public int CapacidadMax { get; set; }
        public int CapacidadActual { get; set; }
        public string Estado { get; set; } // "Activo" / "Inactivo"
    }
}
