using System;
using System.Windows.Forms;
using AviGestion_.Logica;

namespace AviGestion_.UI
{
    public partial class FormProducto : Form
    {
        private ABM_Producto logica = new ABM_Producto();
        private int idSeleccionado = 0;

        public FormProducto()
        {
            InitializeComponent();
            ConfigurarPlaceholderBuscar();
            this.Load += FormProducto_Load;
            this.dgvProductos.CellClick += dgvProductos_CellClick;
        }

        private void ConfigurarPlaceholderBuscar()
        {
            txtBuscar.Text = "Buscar producto...";
            txtBuscar.ForeColor = System.Drawing.Color.Gray;

            txtBuscar.Enter += (s, e) =>
            {
                if (txtBuscar.Text == "Buscar producto...")
                {
                    txtBuscar.Text = "";
                    txtBuscar.ForeColor = System.Drawing.Color.Black;
                }
            };

            txtBuscar.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    txtBuscar.Text = "Buscar producto...";
                    txtBuscar.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla(string filtro = "")
        {
            var lista = logica.BuscarProductos(filtro);
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = lista;

            if (dgvProductos.Columns.Count > 0)
            {
                dgvProductos.Columns["Id"].Visible = false;
                dgvProductos.Columns["Codigo"].HeaderText = "Código";
                dgvProductos.Columns["Descripcion"].HeaderText = "Producto";
                dgvProductos.Columns["Categoria"].HeaderText = "Categoría";
                dgvProductos.Columns["Precio"].HeaderText = "Precio";
                dgvProductos.Columns["Stock"].HeaderText = "Stock";
                dgvProductos.Columns["Estado"].HeaderText = "Estado";
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar producto...") return;
            CargarGrilla(txtBuscar.Text);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var fila = dgvProductos.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
            txtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            cmbCategoria.Text = fila.Cells["Categoria"].Value.ToString();
            nudPrecio.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
            nudStock.Value = Convert.ToDecimal(fila.Cells["Stock"].Value);
            cmbEstado.Text = fila.Cells["Estado"].Value.ToString();
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = new Producto
                {
                    Id = idSeleccionado,
                    Codigo = txtCodigo.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Categoria = cmbCategoria.Text,
                    Precio = nudPrecio.Value,
                    Stock = (int)nudStock.Value,
                    Estado = string.IsNullOrEmpty(cmbEstado.Text) ? "Activo" : cmbEstado.Text
                };

                logica.GuardarProducto(producto);
                MessageBox.Show("Producto guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            idSeleccionado = 0;
            txtCodigo.Clear();
            txtDescripcion.Clear();
            cmbCategoria.SelectedIndex = -1;
            nudPrecio.Value = 0;
            nudStock.Value = 0;
            cmbEstado.SelectedIndex = -1;
        }
    }
}