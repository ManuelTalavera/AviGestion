using System;
using System.Collections.Generic;
using AviGestion_.Datos;

namespace AviGestion_.Logica
{
    public class CategoriaLogica
    {
        private CategoriaDatos datos = new CategoriaDatos();

        #region Obtener
        public List<Categoria> ObtenerCategorias()
        {
            return datos.ObtenerCategorias();
        }

        public List<Categoria> BuscarCategorias(string busqueda)
        {
            return datos.BuscarCategorias(busqueda);
        }
        #endregion

        #region Alta
        public void AltaCategoria(string nombre, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new Exception("La descripción es obligatoria.");

            datos.InsertarCategoria(nombre.Trim(), descripcion.Trim());
        }
        #endregion

        #region Modificacion
        public void ModificarCategoria(int idCategoria, string nombre, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new Exception("La descripción es obligatoria.");

            datos.ModificarCategoria(idCategoria, nombre.Trim(), descripcion.Trim());
        }
        #endregion

        #region Baja
        public void EliminarCategoria(int idCategoria)
        {
            datos.EliminarCategoria(idCategoria);
        }
        #endregion
    }
}