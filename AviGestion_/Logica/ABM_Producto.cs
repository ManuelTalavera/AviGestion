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
            if (string.IsNullOrWhiteSpace(p.Categoria))
                throw new Exception("La categoría es obligatoria.");
            if (string.IsNullOrWhiteSpace(p.Estado))
                throw new Exception("El estado es obligatorio.");
            if (p.Precio <= 0)
                throw new Exception("El precio debe ser mayor a 0.");
            if (p.Stock < 0)
                throw new Exception("El stock no puede ser negativo.");
            if (p.StockMinimo < 0 || p.StockMaximo < 0)
                throw new Exception("El stock mínimo y máximo no pueden ser negativos.");
            if (p.StockMinimo >= p.StockMaximo)
                throw new Exception("El stock mínimo debe ser menor al stock máximo.");

            // NUEVO: evita registrar dos veces el mismo código de producto.
            if (datos.ExisteCodigo(p.Codigo, p.Id))
                throw new Exception($"Ya existe un producto registrado con el código '{p.Codigo}'.");

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