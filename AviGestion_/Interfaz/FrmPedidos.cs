using AviGestion_.Datos;
using AviGestion_.Logica;
using AviGestion_.UI;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PdfDocument = iTextSharp.text.Document;
using PdfFont = iTextSharp.text.Font;

namespace AviGestion_.Interfaz
{
    public partial class FrmPedidos : Form
    {
        private PedidoLogica logica = new PedidoLogica();

        private Dictionary<string, string> _codigoPorNombre = new Dictionary<string, string>();

        #region Constructor e Inicialización
        public FrmPedidos()
        {
            InitializeComponent();
            CargarClientes();
            CargarProductos();
            CargarPedidos();

            dtpFecha.Value = DateTime.Today;
            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 999;
            nudCantidad.Value = 1;
            groupBoxAlta.Visible = false;
        }
        #endregion

        #region Carga de Datos
        private void CargarClientes()
        {
            try
            {
                cboCliente.Items.Clear();
                foreach (var c in logica.ObtenerClientes())
                    cboCliente.Items.Add(c);
                cboCliente.Items.Add("+ Agregar nuevo cliente");
                cboCliente.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                lstProductos.Items.Clear();
                foreach (var p in logica.ObtenerProductos())
                    lstProductos.Items.Add(p);
                lstProductos.DisplayMember = "Display";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPedidos()
        {
            try
            {
                dgvPedidos.Rows.Clear();
                foreach (var p in logica.ObtenerPedidos())
                {
                    dgvPedidos.Rows.Add(
                        p.Id.ToString(), p.Cliente, p.Productos, p.Fecha, p.Estado,
                        p.Estado == "Cancelado" || p.Estado == "Enviado" ||
                        p.Estado == "Entregado" ? "" : "Cancelar");

                    if (p.Estado == "Cancelado")
                    {
                        int ultima = dgvPedidos.Rows.Count - 1;
                        dgvPedidos.Rows[ultima].DefaultCellStyle.ForeColor = Color.DarkRed;
                        dgvPedidos.Rows[ultima].DefaultCellStyle.BackColor = Color.MistyRose;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Alta de Pedido
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            cboCliente.SelectedIndex = -1;
            dgvProductosPedido.Rows.Clear();
            nudCantidad.Value = 1;
            dtpFecha.Value = DateTime.Today;
            groupBoxAlta.Visible = true;
            cboCliente.Focus();
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem?.ToString() == "+ Agregar nuevo cliente")
            {
                FrmAgregarCliente frmAlta = new FrmAgregarCliente();
                if (frmAlta.ShowDialog() == DialogResult.OK)
                {
                    CargarClientes();
                    cboCliente.SelectedItem = frmAlta.NuevoClienteNombre;
                }
                else
                    cboCliente.SelectedIndex = -1;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un producto.", "Campo obligatorio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductoItem prod = (ProductoItem)lstProductos.SelectedItem;
            int cantidad = (int)nudCantidad.Value;

            if (cantidad > prod.Stock)
            {
                MessageBox.Show($"Stock insuficiente. Disponible: {prod.Stock} cajones.",
                    "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow fila in dgvProductosPedido.Rows)
            {
                if (fila.Cells[0].Value?.ToString() == prod.Nombre)
                {
                    MessageBox.Show("Ese producto ya fue agregado.",
                        "Producto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Guardar código en diccionario
            _codigoPorNombre[prod.Nombre] = prod.Codigo;

            dgvProductosPedido.Rows.Add(
                prod.Nombre,
                cantidad,
                (prod.Stock - cantidad) + " cajones",
                "✕ Quitar"
            );

            nudCantidad.Value = 1;
            lstProductos.ClearSelected();

            // Actualizar stock en tiempo real en el listbox
            ActualizarStockListbox();
        }

        private void ActualizarStockListbox()
        {
            // Cargar productos frescos de la BD
            var productosActuales = logica.ObtenerProductos();

            // Restar lo que ya está en el DGV
            foreach (DataGridViewRow fila in dgvProductosPedido.Rows)
            {
                string nombreProd = fila.Cells[0].Value?.ToString();
                int cantPedida = Convert.ToInt32(fila.Cells[1].Value);

                var prod = productosActuales.Find(p => p.Nombre == nombreProd);
                if (prod != null)
                    prod.Stock -= cantPedida;
            }

            // Actualizar el listbox
            lstProductos.Items.Clear();
            foreach (var p in productosActuales)
                lstProductos.Items.Add(p);
            lstProductos.DisplayMember = "Display";
        }

        private void dgvProductosPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                string nombre = dgvProductosPedido.Rows[e.RowIndex].Cells[0].Value?.ToString();
                _codigoPorNombre.Remove(nombre);
                dgvProductosPedido.Rows.RemoveAt(e.RowIndex);
                ActualizarStockListbox();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem == null ||
                cboCliente.SelectedItem.ToString() == "+ Agregar nuevo cliente")
            {
                MessageBox.Show("Por favor seleccioná un cliente.",
                    "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvProductosPedido.Rows.Count == 0)
            {
                MessageBox.Show("Agregá al menos un producto al pedido.",
                    "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ClienteItem cliente = (ClienteItem)cboCliente.SelectedItem;
                var productos = new List<(string Codigo, int Cantidad)>();
                string productosTexto = "";

                foreach (DataGridViewRow fila in dgvProductosPedido.Rows)
                {
                    string nombre = fila.Cells[0].Value?.ToString();
                    int cantidad = Convert.ToInt32(fila.Cells[1].Value);
                    string codigo = _codigoPorNombre[nombre]; // obtener código del diccionario
                    productos.Add((codigo, cantidad));
                    productosTexto += $"{nombre} x{cantidad}, ";
                }

                int idPedido = logica.RegistrarPedido(cliente.Id, dtpFecha.Value, productos);
                productosTexto = productosTexto.TrimEnd(',', ' ');

                dgvPedidos.Rows.Insert(0, idPedido.ToString(), cliente.Nombre,
                    productosTexto, dtpFecha.Value.ToShortDateString(), "Pendiente", "Cancelar");

                MessageBox.Show("Pedido registrado exitosamente con estado Pendiente.",
                    "Pedido registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cboCliente.SelectedIndex = -1;
                dgvProductosPedido.Rows.Clear();
                nudCantidad.Value = 1;
                groupBoxAlta.Visible = false;
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cboCliente.SelectedIndex = -1;
            dgvProductosPedido.Rows.Clear();
            nudCantidad.Value = 1;
            dtpFecha.Value = DateTime.Today;
            groupBoxAlta.Visible = false;
        }
        #endregion

        #region Cancelación de Pedido
        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                string estado = dgvPedidos.Rows[e.RowIndex].Cells[4].Value?.ToString();
                string cliente = dgvPedidos.Rows[e.RowIndex].Cells[1].Value?.ToString();
                string nroPedido = dgvPedidos.Rows[e.RowIndex].Cells[0].Value?.ToString();

                try
                {
                    // Validar en lógica antes de preguntar
                    if (estado == "Enviado" || estado == "Entregado" || estado == "Cancelado")
                    {
                        logica.CancelarPedido(int.Parse(nroPedido), estado);
                        return;
                    }

                    DialogResult confirmacion = MessageBox.Show(
                        $"¿Estás seguro que querés cancelar el pedido #{nroPedido} de {cliente}?",
                        "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmacion == DialogResult.Yes)
                    {
                        logica.CancelarPedido(int.Parse(nroPedido), estado);

                        dgvPedidos.Rows[e.RowIndex].Cells[4].Value = "Cancelado";
                        dgvPedidos.Rows[e.RowIndex].Cells[5].Value = "";
                        dgvPedidos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                        dgvPedidos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;

                        MessageBox.Show("Pedido cancelado. El stock fue restaurado.",
                            "Cancelación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarProductos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region Búsqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.ToLower();
            foreach (DataGridViewRow fila in dgvPedidos.Rows)
            {
                if (fila.IsNewRow) continue;
                string cli = fila.Cells[1].Value?.ToString().ToLower() ?? "";
                string est = fila.Cells[4].Value?.ToString().ToLower() ?? "";
                string nro = fila.Cells[0].Value?.ToString().ToLower() ?? "";
                fila.Visible = cli.Contains(busqueda) || est.Contains(busqueda) || nro.Contains(busqueda);
            }
        }
        #endregion

        #region Comprobante PDF
        private void btnComprobante_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un pedido de la lista para generar el comprobante.",
                    "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = dgvPedidos.SelectedRows[0];
            string nro = fila.Cells[0].Value?.ToString();
            string cliente = fila.Cells[1].Value?.ToString();
            string productos = fila.Cells[2].Value?.ToString();
            string fecha = fila.Cells[3].Value?.ToString();
            string estado = fila.Cells[4].Value?.ToString();

            string ruta = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                $"Comprobante_Pedido_{nro}.pdf");

            try
            {
                PdfDocument doc = new PdfDocument();
                PdfWriter.GetInstance(doc, new System.IO.FileStream(ruta, System.IO.FileMode.Create));
                doc.Open();

                PdfFont fuenteTitulo = new PdfFont(PdfFont.FontFamily.HELVETICA, 18f,
                    PdfFont.BOLD, new BaseColor(34, 139, 34));
                PdfFont fuenteNormal = new PdfFont(PdfFont.FontFamily.HELVETICA, 11f);
                PdfFont fuenteBold = new PdfFont(PdfFont.FontFamily.HELVETICA, 11f, PdfFont.BOLD);

                doc.Add(new Paragraph("AviGestión - Avícola Don José", fuenteTitulo));
                doc.Add(new Paragraph("Comprobante de Pedido", fuenteBold));
                doc.Add(new Paragraph("─────────────────────────────────"));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph($"N° Pedido:   #{nro}", fuenteNormal));
                doc.Add(new Paragraph($"Cliente:     {cliente}", fuenteNormal));
                doc.Add(new Paragraph($"Productos:   {productos}", fuenteNormal));
                doc.Add(new Paragraph($"Fecha:       {fecha}", fuenteNormal));
                doc.Add(new Paragraph($"Estado:      {estado}", fuenteNormal));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("─────────────────────────────────"));
                doc.Add(new Paragraph($"Generado el: {DateTime.Now:dd/MM/yyyy HH:mm}", fuenteNormal));
                doc.Close();

                MessageBox.Show("Comprobante generado en el escritorio.",
                    "PDF generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(
                    new System.Diagnostics.ProcessStartInfo(ruta) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Registrar Pago
        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de pagos próximamente.",
                "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Volver 
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            // El FormMenu ya estaba abierto y oculto, se vuelve a mostrar
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