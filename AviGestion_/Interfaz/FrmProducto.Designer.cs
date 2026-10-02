namespace AviGestion_.UI
{
    partial class FrmProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlAltaModificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(760, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.ForestGreen;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(760, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Productos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(20, 80);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(500, 30);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.ForestGreen;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.ColumnHeadersHeight = 29;
            this.dgvProductos.Location = new System.Drawing.Point(20, 120);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(720, 180);
            this.dgvProductos.TabIndex = 3;
            // 
            // pnlAltaModificacion
            // 
            this.pnlAltaModificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
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
            this.lblAltaModificacion.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblAltaModificacion.Location = new System.Drawing.Point(10, 5);
            this.lblAltaModificacion.Name = "lblAltaModificacion";
            this.lblAltaModificacion.Size = new System.Drawing.Size(143, 20);
            this.lblAltaModificacion.TabIndex = 0;
            this.lblAltaModificacion.Text = "Alta / Modificación";
            // 
            // lblRegistrarProducto
            // 
            this.lblRegistrarProducto.AutoSize = true;
            this.lblRegistrarProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRegistrarProducto.Location = new System.Drawing.Point(10, 30);
            this.lblRegistrarProducto.Name = "lblRegistrarProducto";
            this.lblRegistrarProducto.Size = new System.Drawing.Size(161, 23);
            this.lblRegistrarProducto.TabIndex = 1;
            this.lblRegistrarProducto.Text = "Registrar Producto";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Location = new System.Drawing.Point(20, 70);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 20);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(20, 90);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(280, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(20, 125);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(106, 20);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "DESCRIPCIÓN";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(20, 145);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(280, 22);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(20, 180);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(93, 20);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "CATEGORÍA";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Huevo",
            "Pollo"});
            this.cmbCategoria.Location = new System.Drawing.Point(20, 200);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(280, 24);
            this.cmbCategoria.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(400, 70);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 20);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "PRECIO";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(400, 90);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(280, 22);
            this.nudPrecio.TabIndex = 3;
            this.nudPrecio.ThousandsSeparator = true;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(400, 125);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(55, 20);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "STOCK";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(400, 145);
            this.nudStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(280, 22);
            this.nudStock.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(400, 180);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 20);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "ESTADO";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(400, 200);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(280, 24);
            this.cmbEstado.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancelar.Location = new System.Drawing.Point(400, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarProducto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProducto.Location = new System.Drawing.Point(560, 220);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(140, 32);
            this.btnRegistrarProducto.TabIndex = 7;
            this.btnRegistrarProducto.Text = "Registrar Producto";
            this.btnRegistrarProducto.UseVisualStyleBackColor = false;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // FrmProducto
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(760, 600);
            this.Controls.Add(this.pnlAltaModificacion);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmProducto";
            this.Text = "Sistema AviGestión";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlAltaModificacion.ResumeLayout(false);
            this.pnlAltaModificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
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