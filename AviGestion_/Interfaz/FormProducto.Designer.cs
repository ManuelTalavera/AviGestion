namespace AviGestion_.UI
{
    partial class FormProducto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pnlAltaModificacion = new System.Windows.Forms.Panel();
            this.lblAltaModificacion = new System.Windows.Forms.Label();
            this.lblRegistrarProducto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.pnlAltaModificacion.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(760, 60);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Text = "Gestión de Productos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // txtBuscar
            //
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(20, 80);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(500, 27);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            //
            // btnAgregarProducto
            //
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(600, 78);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(140, 32);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.Text = "+ Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            //
            // dgvProductos
            //
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dgvProductos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvProductos.Location = new System.Drawing.Point(20, 120);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(720, 180);
            this.dgvProductos.TabIndex = 3;
            //
            // pnlAltaModificacion
            //
            this.pnlAltaModificacion.BackColor = System.Drawing.Color.FromArgb(245, 240, 220);
            this.pnlAltaModificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAltaModificacion.Controls.Add(this.lblAltaModificacion);
            this.pnlAltaModificacion.Controls.Add(this.lblRegistrarProducto);
            this.pnlAltaModificacion.Controls.Add(this.lblCodigo);
            this.pnlAltaModificacion.Controls.Add(this.txtCodigo);
            this.pnlAltaModificacion.Controls.Add(this.lblDescripcion);
            this.pnlAltaModificacion.Controls.Add(this.txtDescripcion);
            this.pnlAltaModificacion.Controls.Add(this.lblCategoria);
            this.pnlAltaModificacion.Controls.Add(this.cmbCategoria);
            this.pnlAltaModificacion.Controls.Add(this.lblPrecio);
            this.pnlAltaModificacion.Controls.Add(this.nudPrecio);
            this.pnlAltaModificacion.Controls.Add(this.lblStock);
            this.pnlAltaModificacion.Controls.Add(this.nudStock);
            this.pnlAltaModificacion.Controls.Add(this.lblEstado);
            this.pnlAltaModificacion.Controls.Add(this.cmbEstado);
            this.pnlAltaModificacion.Controls.Add(this.btnCancelar);
            this.pnlAltaModificacion.Controls.Add(this.btnRegistrarProducto);
            this.pnlAltaModificacion.Location = new System.Drawing.Point(20, 320);
            this.pnlAltaModificacion.Name = "pnlAltaModificacion";
            this.pnlAltaModificacion.Size = new System.Drawing.Size(720, 260);
            this.pnlAltaModificacion.TabIndex = 4;
            //
            // lblAltaModificacion
            //
            this.lblAltaModificacion.AutoSize = true;
            this.lblAltaModificacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            this.lblAltaModificacion.Location = new System.Drawing.Point(10, 5);
            this.lblAltaModificacion.Name = "lblAltaModificacion";
            this.lblAltaModificacion.Text = "Alta / Modificación";
            //
            // lblRegistrarProducto
            //
            this.lblRegistrarProducto.AutoSize = true;
            this.lblRegistrarProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRegistrarProducto.Location = new System.Drawing.Point(10, 30);
            this.lblRegistrarProducto.Name = "lblRegistrarProducto";
            this.lblRegistrarProducto.Text = "Registrar Producto";
            //
            // lblCodigo
            //
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Location = new System.Drawing.Point(20, 70);
            this.lblCodigo.Text = "CÓDIGO";
            //
            // txtCodigo
            //
            this.txtCodigo.Location = new System.Drawing.Point(20, 90);
            this.txtCodigo.Size = new System.Drawing.Size(280, 25);
            this.txtCodigo.TabIndex = 0;
            //
            // lblDescripcion
            //
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(20, 125);
            this.lblDescripcion.Text = "DESCRIPCIÓN";
            //
            // txtDescripcion
            //
            this.txtDescripcion.Location = new System.Drawing.Point(20, 145);
            this.txtDescripcion.Size = new System.Drawing.Size(280, 25);
            this.txtDescripcion.TabIndex = 1;
            //
            // lblCategoria
            //
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(20, 180);
            this.lblCategoria.Text = "CATEGORÍA";
            //
            // cmbCategoria
            //
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Location = new System.Drawing.Point(20, 200);
            this.cmbCategoria.Size = new System.Drawing.Size(280, 25);
            this.cmbCategoria.TabIndex = 2;
            this.cmbCategoria.Items.AddRange(new object[] { "Huevo", "Pollo" });
            //
            // lblPrecio
            //
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(400, 70);
            this.lblPrecio.Text = "PRECIO";
            //
            // nudPrecio
            //
            this.nudPrecio.Location = new System.Drawing.Point(400, 90);
            this.nudPrecio.Size = new System.Drawing.Size(280, 25);
            this.nudPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.ThousandsSeparator = true;
            this.nudPrecio.TabIndex = 3;
            //
            // lblStock
            //
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(400, 125);
            this.lblStock.Text = "STOCK";
            //
            // nudStock
            //
            this.nudStock.Location = new System.Drawing.Point(400, 145);
            this.nudStock.Size = new System.Drawing.Size(280, 25);
            this.nudStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudStock.TabIndex = 4;
            //
            // lblEstado
            //
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(400, 180);
            this.lblEstado.Text = "ESTADO";
            //
            // cmbEstado
            //
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Location = new System.Drawing.Point(400, 200);
            this.cmbEstado.Size = new System.Drawing.Size(280, 25);
            this.cmbEstado.TabIndex = 5;
            this.cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            //
            // btnCancelar
            //
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(150, 30, 30);
            this.btnCancelar.Location = new System.Drawing.Point(400, 220);
            this.btnCancelar.Size = new System.Drawing.Size(120, 32);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // btnRegistrarProducto
            //
            this.btnRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(46, 92, 45);
            this.btnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarProducto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProducto.Location = new System.Drawing.Point(560, 220);
            this.btnRegistrarProducto.Size = new System.Drawing.Size(140, 32);
            this.btnRegistrarProducto.Text = "Registrar Producto";
            this.btnRegistrarProducto.TabIndex = 7;
            this.btnRegistrarProducto.UseVisualStyleBackColor = false;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            //
            // FormProducto
            //
            this.ClientSize = new System.Drawing.Size(760, 600);
            this.Controls.Add(this.pnlAltaModificacion);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormProducto";
            this.Text = "Sistema AviGestión";
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 240);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.pnlAltaModificacion.ResumeLayout(false);
            this.pnlAltaModificacion.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel pnlAltaModificacion;
        private System.Windows.Forms.Label lblAltaModificacion;
        private System.Windows.Forms.Label lblRegistrarProducto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrarProducto;
    }
}