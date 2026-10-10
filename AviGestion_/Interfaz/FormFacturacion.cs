using AviGestion_.Logica;
using AviGestion_.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace AviGestion_.Interfaz
{
    public partial class FormFacturacion : Form
    {
        private FacturacionLogica negocio = new FacturacionLogica();
        private int idPedidoSeleccionado = 0;
        private Usuario usuarioActual;

        public FormFacturacion(Usuario usuarioActual)//nuevo form
        {
            InitializeComponent();
            CenterToParent();
            this.usuarioActual = usuarioActual;
        }

        private void FormFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDetalle.ReadOnly = true;
                dgvDetalle.AllowUserToAddRows = false;
                dgvDetalle.RowHeadersVisible = false;
                dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvListadoCompra.ReadOnly = true;
                dgvListadoCompra.AllowUserToAddRows = false;
                dgvListadoCompra.RowHeadersVisible = false;
                dgvListadoCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvListadoCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Diagnóstico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrilla()
        {
            dgvListadoCompra.AutoGenerateColumns = true;
            dgvListadoCompra.DataSource = negocio.ListarPedidosPendientes();

            // Columnas que no aportan en este módulo (todos son 'Pendiente', sin pagos)
            if (dgvListadoCompra.Columns["Estado"] != null) dgvListadoCompra.Columns["Estado"].Visible = false;
            if (dgvListadoCompra.Columns["SaldoPendiente"] != null) dgvListadoCompra.Columns["SaldoPendiente"].Visible = false;

            if (dgvListadoCompra.Columns["NºPedido"] != null)
            {
                dgvListadoCompra.Columns["NºPedido"].HeaderText = "Nº";
                dgvListadoCompra.Columns["NºPedido"].FillWeight = 40;
            }
            if (dgvListadoCompra.Columns["Total"] != null)
            {
                dgvListadoCompra.Columns["Total"].DefaultCellStyle.Format = "C2";
                dgvListadoCompra.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvListadoCompra.Columns["BotonAccion"] != null)
            {
                dgvListadoCompra.Columns["BotonAccion"].DisplayIndex = dgvListadoCompra.Columns.Count - 1;
                dgvListadoCompra.Columns["BotonAccion"].HeaderText = "";
                foreach (DataGridViewRow fila in dgvListadoCompra.Rows)
                    fila.Cells["BotonAccion"].Value = "Facturar / Despachar";
            }
        }
        private void LimpiarCampos()
        {
            idPedidoSeleccionado = 0;
            lblPedidoCliente.Text = "";
            lblTotalPagar.Text = "$ 0,00";
            dgvDetalle.DataSource = null;
            grbDetalleCompra.Visible = false;
        }

        private void dgvListadoCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvListadoCompra.Columns[e.ColumnIndex].Name != "BotonAccion") return;

            try
            {
                DataGridViewRow fila = dgvListadoCompra.Rows[e.RowIndex];
                idPedidoSeleccionado = Convert.ToInt32(fila.Cells["NºPedido"].Value);
                string cliente = fila.Cells["Cliente"].Value.ToString();

                DataTable detalles = negocio.ListarDetallesDelPedido(idPedidoSeleccionado);
                detalles.Columns.Add("Subtotal", typeof(decimal));

                decimal importeTotal = 0;
                foreach (DataRow r in detalles.Rows)
                {
                    decimal sub = Convert.ToInt32(r["Cantidad"]) * Convert.ToDecimal(r["PrecioUnitario"]);
                    r["Subtotal"] = sub;
                    importeTotal += sub;
                }

                dgvDetalle.DataSource = detalles;
                dgvDetalle.Columns["PrecioUnitario"].HeaderText = "Precio unit.";
                dgvDetalle.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C2";
                dgvDetalle.Columns["Subtotal"].DefaultCellStyle.Format = "C2";

                lblPedidoCliente.Text = $"Pedido Nº {idPedidoSeleccionado} · {cliente}";
                lblTotalPagar.Text = "$ " + importeTotal.ToString("N2");
                grbDetalleCompra.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el detalle del pedido: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmarDespacho_Click(object sender, EventArgs e)
        {
            if (idPedidoSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un pedido de la lista antes de continuar.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirma = MessageBox.Show(
                $"¿Confirmar la facturación y el despacho del Pedido Nº {idPedidoSeleccionado} por {lblTotalPagar.Text}?",
                "Confirmación de Despacho", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirma != DialogResult.Yes) return;

            try
            {
                switch (negocio.ConfirmarDespacho(idPedidoSeleccionado))
                {
                    case ResultadoDespacho.Exito:
                        MessageBox.Show("La compra fue registrada correctamente. El pedido quedó listo para que Logística lo asigne a un camión.",
                                        "Despacho confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case ResultadoDespacho.CompraYaRegistrada:
                        MessageBox.Show("La compra ya fue registrada. La operación se cancela.",
                                        "Compra ya registrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case ResultadoDespacho.PedidoNoDisponible:
                        MessageBox.Show("El pedido ya fue procesado o cancelado por otro usuario. Se actualiza el listado.",
                                        "Pedido ya procesado o cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }

                LimpiarCampos();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error técnico: " + ex.Message, "Falla de Comunicación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarFactura_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu(usuarioActual);
            menu.Show();
            this.Close();
        }
    }
}
