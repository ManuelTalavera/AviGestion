using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviGestion_.Logica;

namespace AviGestion_.Interfaz
{
    public partial class FormHistorialCliente : Form
    {
        private HistorialClienteLogica historialLogica = new HistorialClienteLogica();
        public FormHistorialCliente(int idCliente, string nombreCompleto, string contacto, string direccion)
        {
            InitializeComponent();

            lblClienteValor.Text = nombreCompleto;
            lblContactoValor.Text = contacto;
            lblDireccionValor.Text = direccion;
            dgvHistorial.MultiSelect = false;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CenterToParent();
        }

        private void FormHistorialCliente_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasGrilla();

            txtBusqueda.Text = "Filtrar por N°Pedido, Fecha, Estado o Productos";
            txtBusqueda.ForeColor = Color.Gray;
            txtBusqueda.Text = "Filtrar por N°Pedido, Fecha, Estado o Productos";
            txtBusqueda.ForeColor = Color.Gray;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "Filtrar por N°Pedido, Fecha, Estado o Productos")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor = Color.Black;
            }
        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                txtBusqueda.Text = "Filtrar por N°Pedido, Fecha, Estado o Productos";
                txtBusqueda.ForeColor = Color.Gray;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "Filtrar por NºPedido, Fecha...";
            txtBusqueda.ForeColor = Color.Gray;
            dgvHistorial.DataSource = null;
            //dgvHistorial.DataSource = listaOriginalPedidos;
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.CurrentRow == null) return;
            //var pedido = (HistorialPedidoSimplificado/Pedido)dgvHistorial.CurrentRow.DataBoundItem;
            //int idPedidoReal = pedido.NumeroPedido;

            MessageBox.Show($"Abriendo el desglose de productos para el pedido N° {"idPedidoReal"}.", "Visor de Detalles");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurarColumnasGrilla()
        {
            dgvHistorial.AutoGenerateColumns = false;
            if (dgvHistorial.Columns.Contains("colN")) dgvHistorial.Columns["colN"].DataPropertyName = "NumeroFila";
            if (dgvHistorial.Columns.Contains("colNumPedidos")) dgvHistorial.Columns["colNumPedidos"].DataPropertyName = "NºPedido";
            if (dgvHistorial.Columns.Contains("colFecha")) dgvHistorial.Columns["colFecha"].DataPropertyName = "Fecha";
            if (dgvHistorial.Columns.Contains("colProducto")) dgvHistorial.Columns["colProducto"].DataPropertyName = "Productos";
            if (dgvHistorial.Columns.Contains("colMonto")) dgvHistorial.Columns["colMonto"].DataPropertyName = "Monto";
            if (dgvHistorial.Columns.Contains("colPagado")) dgvHistorial.Columns["colPagado"].DataPropertyName = "Pagado";
            if (dgvHistorial.Columns.Contains("colSaldo")) dgvHistorial.Columns["colSaldo"].DataPropertyName = "Saldo";
            if (dgvHistorial.Columns.Contains("colEstado")) dgvHistorial.Columns["colEstado"].DataPropertyName = "Estado";
        }
    }
}
