using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviGestion_.Logica;

namespace AviGestion_.Logica
{
    public class Cliente
    {
        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string DniCuil { get; set; }
        public string Direccion { get; set; }
    }
}
