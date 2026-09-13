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
    public partial class FormClientes : Form
    {
        private ClienteLogica clienteLogica = new ClienteLogica();
        private int idClienteSeleccionado = -1;
        private List<Cliente> listaOriginalClientes = new List<Cliente>();
        public FormClientes()
        {
            InitializeComponent();
            splitContainer1.Panel2Collapsed = false;
            grbRegistrarModificar.Visible = false;
            dgvTablaClientes.MultiSelect = false;
            dgvTablaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CenterToScreen();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            dgvTablaClientes.AutoGenerateColumns = false;

            // Enlaces entre las columnas de la Grilla y las propiedades de la Clase
            if (dgvTablaClientes.Columns.Contains("colId"))
                dgvTablaClientes.Columns["colId"].DataPropertyName = "Id_Cliente";

            if (dgvTablaClientes.Columns.Contains("colEmpresa"))
                dgvTablaClientes.Columns["colEmpresa"].DataPropertyName = "Empresa";

            if (dgvTablaClientes.Columns.Contains("colNombre"))
                dgvTablaClientes.Columns["colNombre"].DataPropertyName = "Nombre";

            if (dgvTablaClientes.Columns.Contains("colApellido"))
                dgvTablaClientes.Columns["colApellido"].DataPropertyName = "Apellido";

            if (dgvTablaClientes.Columns.Contains("colTelefono"))
                dgvTablaClientes.Columns["colTelefono"].DataPropertyName = "Telefono";

            if (dgvTablaClientes.Columns.Contains("colDireccion"))
                dgvTablaClientes.Columns["colDireccion"].DataPropertyName = "Direccion";

            if (dgvTablaClientes.Columns.Contains("colCorreo"))
                dgvTablaClientes.Columns["colCorreo"].DataPropertyName = "CorreoElectronico";

            if (dgvTablaClientes.Columns.Contains("colDniCuil"))
                dgvTablaClientes.Columns["colDniCuil"].DataPropertyName = "DniCuil";

            txtBusquedaFiltrado.TextChanged += txtBusquedaFiltrado_TextChanged;
            CargarDatosClientes();
        }

        private void dgvTablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que sea la columna Acción (Modificar) y una fila válida
            if (e.ColumnIndex == dgvTablaClientes.Columns["colAccion"].Index && e.RowIndex >= 0)
            {
                MapearFilaAFormulario(e.RowIndex);
            }
            if (dgvTablaClientes.Columns[e.ColumnIndex].Name == "btnHistorial")
            {
                var fila = dgvTablaClientes.Rows[e.RowIndex];
                int idCliente = Convert.ToInt32(fila.Cells["colId"].Value);

                string nombreCompleto = $"{fila.Cells["colNombre"].Value} {fila.Cells["colApellido"].Value}".Trim();
                string contacto = $"{fila.Cells["colCorreo"].Value} | {fila.Cells["colTelefono"].Value}";
                string direccion = fila.Cells["colDireccion"].Value?.ToString() ?? "Sin dirección registrada";

                FormHistorialCliente frmHistorial = new FormHistorialCliente(idCliente, nombreCompleto, contacto, direccion);
                frmHistorial.ShowDialog(); 
            }
        }

        private void dgvTablaClientes_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dgvTablaClientes.Columns["colAccion"].Index && e.RowIndex >= 0)
            {
                MapearFilaAFormulario(e.RowIndex);
            }
        }

        private void txtBusquedaFiltrado_TextChanged(object sender, EventArgs e)
        {
            string textoABuscar = txtBusquedaFiltrado.Text.Trim().ToLower();

            List<Cliente> listaFiltrada = new List<Cliente>();

            if (string.IsNullOrEmpty(textoABuscar))
            {
                dgvTablaClientes.DataSource = null;
                dgvTablaClientes.DataSource = listaOriginalClientes;
                return;
            }

            foreach (Cliente cliente in listaOriginalClientes)
            {
                string empresa = (cliente.Empresa ?? "").ToLower();
                string nombre = (cliente.Nombre ?? "").ToLower();
                string apellido = (cliente.Apellido ?? "").ToLower();
                string dniCuil = (cliente.DniCuil ?? "").ToLower();

                if (empresa.Contains(textoABuscar) ||
                    nombre.Contains(textoABuscar) ||
                    apellido.Contains(textoABuscar) ||
                    dniCuil.Contains(textoABuscar))
                {
                    listaFiltrada.Add(cliente);
                }
            }

            dgvTablaClientes.DataSource = null;
            dgvTablaClientes.DataSource = listaFiltrada;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            idClienteSeleccionado = -1; // Nos aseguramos que está en modo Alta

            LimpiarCampos();
            grbRegistrarModificar.Text = "Alta";
            lblRegistrarModificar.Text = "Registrar Nuevo Cliente";
            grbRegistrarModificar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> todosLosErrores = new List<string>();

                if (string.IsNullOrWhiteSpace(txtNombreNegocio.Text)) todosLosErrores.Add("- El nombre del negocio es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtResponsable.Text)) todosLosErrores.Add("- El responsable es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtTelefono.Text)) todosLosErrores.Add("- El teléfono es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtEmail.Text)) todosLosErrores.Add("- El correo es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtDniCuil.Text)) todosLosErrores.Add("- El DNI/CUIL es obligatorio.");

                if (todosLosErrores.Count == 0)
                {
                    List<string> erroresLogica = clienteLogica.ValidarFormatosLogicos(txtTelefono.Text, txtDniCuil.Text, txtEmail.Text, txtResponsable.Text.Trim());

                    todosLosErrores.AddRange(erroresLogica);
                }

                if (todosLosErrores.Count > 0)
                {
                    string mensajeFinal = string.Join("\n", todosLosErrores);
                    MessageBox.Show("Por favor, corrija los siguientes errores:\n\n" + mensajeFinal,
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string responsableCompleto = txtResponsable.Text.Trim();
                string nombreGuardar = responsableCompleto;
                string apellidoGuardar = "";
                int primerEspacio = responsableCompleto.IndexOf(' ');

                if (primerEspacio > 0)
                {
                    nombreGuardar = responsableCompleto.Substring(0, primerEspacio).Trim();
                    apellidoGuardar = responsableCompleto.Substring(primerEspacio).Trim();
                }

                Cliente cliente = new Cliente
                {
                    Id_Cliente = idClienteSeleccionado,
                    Empresa = txtNombreNegocio.Text.Trim(),
                    Nombre = nombreGuardar,
                    Apellido = apellidoGuardar,
                    Telefono = txtTelefono.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    CorreoElectronico = txtEmail.Text.Trim(),
                    DniCuil = txtDniCuil.Text.Trim()
                };

                clienteLogica.GuardarCliente(cliente);

                MessageBox.Show("Los datos se guardaron correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grbRegistrarModificar.Visible = false;
                CargarDatosClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SoloNumerosYGuiones_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Bloquea cualquier cosa que no sea número, tecla de borrar o guion
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grbRegistrarModificar.Visible = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatosClientes()
        {
            try
            {
                // Guarda la lectura de la base de datos enla lista fija de memoria
                listaOriginalClientes = clienteLogica.ObtenerClientes();

                dgvTablaClientes.DataSource = null;
                dgvTablaClientes.DataSource = listaOriginalClientes; // Enlace directo inicial

                if (dgvTablaClientes.Rows.Count > 0)
                {
                    dgvTablaClientes.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MapearFilaAFormulario(int rowIndex)
        {
            var fila = dgvTablaClientes.Rows[rowIndex];
            idClienteSeleccionado = Convert.ToInt32(fila.Cells["colId"].Value);

            txtNombreNegocio.Text = fila.Cells["colEmpresa"].Value?.ToString();
            string nombre = fila.Cells["colNombre"].Value?.ToString() ?? "";
            string apellido = fila.Cells["colApellido"].Value?.ToString() ?? "";
            txtResponsable.Text = $"{nombre.Trim()} {apellido.Trim()}".Trim();
            txtTelefono.Text = fila.Cells["colTelefono"].Value?.ToString();
            txtEmail.Text = fila.Cells["colCorreo"].Value?.ToString();
            txtDniCuil.Text = fila.Cells["colDniCuil"].Value?.ToString();
            txtDireccion.Text = fila.Cells["colDireccion"].Value?.ToString();

            grbRegistrarModificar.Text = "Modificar";
            lblRegistrarModificar.Text = "Modificar Datos";
            grbRegistrarModificar.Visible = true;
        }

        private void LimpiarCampos()
        {
            txtNombreNegocio.Text = "";
            txtResponsable.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtDniCuil.Text = "";
        }
    }
}
