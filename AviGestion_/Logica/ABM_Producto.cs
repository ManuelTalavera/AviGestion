using AviGestion_.Datos;
using AviGestion_.Datos;
using System;
using System.Collections.Generic;

namespace AviGestion_.Logica
{
    public class ABM_Producto
    {
        private DatosProducto datos = new DatosProducto();

        public List<Producto> ListarProductos()
        {
            return datos.Listar();
        }

        public List<Producto> BuscarProductos(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
                return datos.Listar();
            return datos.Buscar(filtro);
        }

        public void GuardarProducto(Producto p)
        {
            if (string.IsNullOrWhiteSpace(p.Codigo))
                throw new Exception("El código es obligatorio.");
            if (string.IsNullOrWhiteSpace(p.Descripcion))
                throw new Exception("La descripción es obligatoria.");
            if (p.Precio <= 0)
                throw new Exception("El precio debe ser mayor a 0.");

            if (p.Id == 0)
                datos.Registrar(p);
            else
                datos.Modificar(p);
        }

        public void EliminarProducto(int id)
        {
            datos.Eliminar(id);
        }
    }
}