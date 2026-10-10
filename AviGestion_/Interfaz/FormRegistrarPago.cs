using AviGestion_.Logica;
using AviGestion_.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AviGestion_.Interfaz
{
    public partial class FormRegistrarPago : Form
    {
        private PagoPedidoLogica pagosLogica = new PagoPedidoLogica();
        private PagoPedido pedidoSeleccionado;
        private List<PagoPedido> listaOriginalPedidos = new List<PagoPedido>();
        private Usuario usuarioActual;

        public FormRegistrarPago(Usuario usuarioActual) //Nuevo form
        {
            InitializeComponent();
            LimpiarOcultarPanel();
            CenterToParent();
            this.usuarioActual = usuarioActual;
        }

        private void FormRegistrarPago_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasGrilla();
            CargarPedidos();

            txtBuscar.Text = "Filtrar por N°Pedido, Fecha, Estado o Productos";
            txtBuscar.ForeColor = Color.Gray;

            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            txtBuscar.TextChanged += txtBuscar_TextChanged;

        }

        private void dgvListadoPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvListadoPedidos.Columns[e.ColumnIndex].Name == "colPagar" || dgvListadoPedidos.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                pedidoSeleccionado = (PagoPedido)dgvListadoPedidos.Rows[e.RowIndex].DataBoundItem;
                MostrarPedidoSeleccionado();
            }
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim().ToLower();

            if (listaOriginalPedidos == null) return;

            if (string.IsNullOrEmpty(textoBusqueda) || txtBuscar.Text == "Filtrar por N°Pedido, Fecha, Estado o Productos")
            {
                dgvListadoPedidos.DataSource = null;
                dgvListadoPedidos.DataSource = listaOriginalPedidos;
                return;
            }

            List<PagoPedido> listaFiltrada = new List<PagoPedido>();

            foreach (PagoPedido ped in listaOriginalPedidos)
            {
                if (ped.NºPedido.ToString().Contains(textoBusqueda) ||
                    (ped.Cliente ?? "").ToLower().Contains(textoBusqueda) ||
                    (ped.Productos ?? "").ToLower().Contains(textoBusqueda) ||
                    (ped.Estado ?? "").ToLower().Contains(textoBusqueda))
                {
                    listaFiltrada.Add(ped);
                }
            }

            dgvListadoPedidos.DataSource = null;
            dgvListadoPedidos.DataSource = listaFiltrada;
        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            if (pedidoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un pedido de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal importeABonar = nudImporte.Value;

                if (importeABonar <= 0)
                {
                    MessageBox.Show("Ingresá un monto mayor a cero.", "Validación Comercial",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (importeABonar > pedidoSeleccionado.SaldoPendiente)
                {
                    MessageBox.Show($"El monto ({importeABonar:C2}) supera el saldo pendiente ({pedidoSeleccionado.SaldoPendiente:C2}). Corregí el importe.",
                                    "Validación Comercial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudImporte.Focus();
                    return;   // no se registra nada y el importe queda para se cambie
                }
                if (MessageBox.Show($"¿Registrar un pago de {importeABonar:C2} para el pedido Nº {pedidoSeleccionado.NºPedido}?",
                                    "Confirmar pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                pagosLogica.RegistrarPago(pedidoSeleccionado.NºPedido, importeABonar);
                MessageBox.Show("El pago fue registrado correctamente en la base de datos.", "Pago Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarPedidos();
                btnCancelarPago_Click(sender, e);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación Comercial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el abono: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelarPago_Click(object sender, EventArgs e)
        {
            LimpiarOcultarPanel();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu(usuarioActual);
            menu.Show();
            this.Close();
        }


        #region Métodos
        private void CargarPedidos()
        {
            try
            {
                listaOriginalPedidos = pagosLogica.ObtenerPedidosParaPagos();
                dgvListadoPedidos.DataSource = null;
                dgvListadoPedidos.DataSource = listaOriginalPedidos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar listado de deudas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarPedidoSeleccionado()
        {
            splitPagos.Panel2.Enabled = true;
            lblMensaje.Visible = false;

            panelPedido.Visible = true;
            panelImporte.Visible = true;
            panelPago.Visible = true;

            lblPedidoSeleccionado.Text = pedidoSeleccionado.NºPedido.ToString();
            lblClienteSeleccionado.Text = pedidoSeleccionado.Cliente;
            lblTotalPedido.Text = pedidoSeleccionado.Total.ToString("C2");
            lblSaldoPendiente.Text = pedidoSeleccionado.SaldoPendiente.ToString("C2");

            lblSaldoValor.Text = pedidoSeleccionado.SaldoPendiente.ToString("C2");
            lblMaximoValor.Text = pedidoSeleccionado.SaldoPendiente.ToString("C2");

            nudImporte.Minimum = 0;
            nudImporte.Maximum = 999999999;
            nudImporte.Value = 0;

            nudImporte.Focus();
            nudImporte.Select(0, nudImporte.Text.Length);
        }

        private void LimpiarOcultarPanel()
        {
            pedidoSeleccionado = null;
            lblMensaje.Visible = true;
            lblMensaje.Text = "Seleccione un pedido para registrar un pago.";
            lblPedidoSeleccionado.Text = "-";
            lblClienteSeleccionado.Text = "-";
            lblTotalPedido.Text = "$0,00";
            lblSaldoPendiente.Text = "$0,00";
            lblSaldoValor.Text = "$0,00";
            lblMaximoValor.Text = "$0,00";
            nudImporte.Value = 0;

            panelPedido.Visible = false;
            panelImporte.Visible = false;
            panelPago.Visible = false;

            lblMensaje.Text = "Seleccione un pedido de la lista superior para registrar un pago.";
            lblMensaje.ForeColor = Color.Gray;
            lblMensaje.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            lblMensaje.Visible = true;

            splitPagos.Panel2.Enabled = false;
        }

        private void ConfigurarColumnasGrilla()
        {
            dgvListadoPedidos.AutoGenerateColumns = false;
            if (dgvListadoPedidos.Columns.Contains("colIdPedido")) dgvListadoPedidos.Columns["colIdPedido"].DataPropertyName = "NºPedido";
            if (dgvListadoPedidos.Columns.Contains("colCliente")) dgvListadoPedidos.Columns["colCliente"].DataPropertyName = "Cliente";
            if (dgvListadoPedidos.Columns.Contains("colFecha")) dgvListadoPedidos.Columns["colFecha"].DataPropertyName = "Fecha";
            if (dgvListadoPedidos.Columns.Contains("colProductos")) dgvListadoPedidos.Columns["colProductos"].DataPropertyName = "Productos";
            if (dgvListadoPedidos.Columns.Contains("colTotal")) dgvListadoPedidos.Columns["colTotal"].DataPropertyName = "Total";
            if (dgvListadoPedidos.Columns.Contains("colSaldoPendiente")) dgvListadoPedidos.Columns["colSaldoPendiente"].DataPropertyName = "SaldoPendiente";
            if (dgvListadoPedidos.Columns.Contains("colEstado")) dgvListadoPedidos.Columns["colEstado"].DataPropertyName = "Estado";
        }

        #endregion
        #region Etiqueta de búsqueda
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Filtrar por N°Pedido, Fecha, Estado o Productos")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Filtrar por N°Pedido, Fecha, Estado o Productos";
                txtBuscar.ForeColor = Color.Gray;
            }
        }
        #endregion
    }
}
