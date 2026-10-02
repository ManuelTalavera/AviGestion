using AviGestion_.Datos;
using AviGestion_.Logica;
using AviGestion_.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AviGestion_.Interfaz
{
    public partial class FrmCategorias : Form
    {
        private CategoriaLogica logica = new CategoriaLogica();
        private int idCategoriaModificando = -1;

        #region Constructor
        public FrmCategorias()
        {
            InitializeComponent();
            CargarCategorias();
            groupBoxAlta.Visible = false;
        }
        #endregion

        #region Carga de Datos
        private void CargarCategorias()
        {
            try
            {
                dgvCategorias.Rows.Clear();
                foreach (var c in logica.ObtenerCategorias())
                    dgvCategorias.Rows.Add(c.Nombre, c.Descripcion,
                        c.CantProductos + " productos", c.Id_Categoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Nueva Categoria
        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            idCategoriaModificando = -1;
            btnGuardar.Text = "Guardar";
            groupBoxAlta.Visible = true;
            txtNombre.Focus();
        }
        #endregion

        #region Guardar (Alta o Modificacion)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idCategoriaModificando == -1)
                {
                    logica.AltaCategoria(txtNombre.Text, txtDescripcion.Text);
                    MessageBox.Show("Categoría registrada exitosamente.", "Alta exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    logica.ModificarCategoria(idCategoriaModificando,
                        txtNombre.Text, txtDescripcion.Text);
                    MessageBox.Show("Categoría modificada exitosamente.", "Modificación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    idCategoriaModificando = -1;
                }

                txtNombre.Clear();
                txtDescripcion.Clear();
                btnGuardar.Text = "Guardar";
                groupBoxAlta.Visible = false;
                CargarCategorias();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            idCategoriaModificando = -1;
            btnGuardar.Text = "Guardar";
            groupBoxAlta.Text = "Alta";
            groupBoxAlta.Visible = false;
        }
        #endregion

        #region Acciones DGV
        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idCategoria = Convert.ToInt32(dgvCategorias.Rows[e.RowIndex].Cells[3].Value);
            string nombre = dgvCategorias.Rows[e.RowIndex].Cells[0].Value?.ToString();

            // Columna Modificar (índice 4)
            if (e.ColumnIndex == 4)
            {
                idCategoriaModificando = idCategoria;
                txtNombre.Text = nombre;
                txtDescripcion.Text = dgvCategorias.Rows[e.RowIndex].Cells[1].Value?.ToString();
                btnGuardar.Text = "Guardar Cambios";
                groupBoxAlta.Text = "Modificación";  // ← agregar
                groupBoxAlta.Visible = true;
                txtNombre.Focus();
            }

            // Columna Eliminar (índice 5)
            if (e.ColumnIndex == 5)
            {
                DialogResult confirmar = MessageBox.Show(
                    $"¿Estás seguro que querés eliminar la categoría \"{nombre}\"?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    try
                    {
                        logica.EliminarCategoria(idCategoria);
                        MessageBox.Show("Categoría eliminada correctamente.", "Baja exitosa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCategorias();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "No se puede eliminar",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        #endregion

        #region Busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvCategorias.Rows.Clear();
                foreach (var c in logica.BuscarCategorias(txtBuscar.Text))
                    dgvCategorias.Rows.Add(c.Nombre, c.Descripcion,
                        c.CantProductos + " productos", c.Id_Categoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Volver al Menu
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormMenu)
                {
                    f.Show();
                    break;
                }
            }
        }
        #endregion

       
    }
}