namespace AviGestion_.UI
{
    partial class FrmCargaStock
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnActualizarInventario = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlIngreso = new System.Windows.Forms.Panel();
            this.lblTituloIngreso = new System.Windows.Forms.Label();
            this.lblProductoSel = new System.Windows.Forms.Label();
            this.txtProductoSeleccionado = new System.Windows.Forms.TextBox();
            this.lblStockActualTxt = new System.Windows.Forms.Label();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblNuevoStock = new System.Windows.Forms.Label();
            this.txtNuevoStock = new System.Windows.Forms.TextBox();
            this.lblValidacion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrarIngreso = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.pnlIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(855, 60);
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
            this.lblTitulo.Size = new System.Drawing.Size(855, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Carga de Stock";
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
            // btnActualizarInventario
            // 
            this.btnActualizarInventario.BackColor = System.Drawing.Color.ForestGreen;
            this.btnActualizarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarInventario.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnActualizarInventario.ForeColor = System.Drawing.Color.White;
            this.btnActualizarInventario.Location = new System.Drawing.Point(665, 78);
            this.btnActualizarInventario.Name = "btnActualizarInventario";
            this.btnActualizarInventario.Size = new System.Drawing.Size(170, 32);
            this.btnActualizarInventario.TabIndex = 2;
            this.btnActualizarInventario.Text = "↻ Actualizar Inventario";
            this.btnActualizarInventario.UseVisualStyleBackColor = false;
            this.btnActualizarInventario.Click += new System.EventHandler(this.btnActualizarInventario_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeight = 29;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSeleccionar});
            this.dgvStock.Location = new System.Drawing.Point(20, 120);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(815, 180);
            this.dgvStock.TabIndex = 3;
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            this.dgvStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStock_CellFormatting);
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.HeaderText = "Acción";
            this.colSeleccionar.MinimumWidth = 6;
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.ReadOnly = true;
            this.colSeleccionar.Text = "Seleccionar";
            this.colSeleccionar.UseColumnTextForButtonValue = true;
            // 
            // pnlIngreso
            // 
            this.pnlIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.pnlIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIngreso.Controls.Add(this.lblTituloIngreso);
            this.pnlIngreso.Controls.Add(this.lblProductoSel);
            this.pnlIngreso.Controls.Add(this.txtProductoSeleccionado);
            this.pnlIngreso.Controls.Add(this.lblStockActualTxt);
            this.pnlIngreso.Controls.Add(this.txtStockActual);
            this.pnlIngreso.Controls.Add(this.lblCantidad);
            this.pnlIngreso.Controls.Add(this.nudCantidad);
            this.pnlIngreso.Controls.Add(this.lblNuevoStock);
            this.pnlIngreso.Controls.Add(this.txtNuevoStock);
            this.pnlIngreso.Controls.Add(this.lblValidacion);
            this.pnlIngreso.Controls.Add(this.btnCancelar);
            this.pnlIngreso.Controls.Add(this.btnRegistrarIngreso);
            this.pnlIngreso.Controls.Add(this.btnVolver);
            this.pnlIngreso.Location = new System.Drawing.Point(20, 320);
            this.pnlIngreso.Name = "pnlIngreso";
            this.pnlIngreso.Size = new System.Drawing.Size(815, 250);
            this.pnlIngreso.TabIndex = 4;
            // 
            // lblTituloIngreso
            // 
            this.lblTituloIngreso.AutoSize = true;
            this.lblTituloIngreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloIngreso.Location = new System.Drawing.Point(15, 15);
            this.lblTituloIngreso.Name = "lblTituloIngreso";
            this.lblTituloIngreso.Size = new System.Drawing.Size(222, 23);
            this.lblTituloIngreso.TabIndex = 0;
            this.lblTituloIngreso.Text = "Registrar Ingreso de Stock";
            // 
            // lblProductoSel
            // 
            this.lblProductoSel.AutoSize = true;
            this.lblProductoSel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProductoSel.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblProductoSel.Location = new System.Drawing.Point(20, 55);
            this.lblProductoSel.Name = "lblProductoSel";
            this.lblProductoSel.Size = new System.Drawing.Size(204, 20);
            this.lblProductoSel.TabIndex = 1;
            this.lblProductoSel.Text = "PRODUCTO SELECCIONADO";
            // 
            // txtProductoSeleccionado
            // 
            this.txtProductoSeleccionado.Location = new System.Drawing.Point(20, 75);
            this.txtProductoSeleccionado.Name = "txtProductoSeleccionado";
            this.txtProductoSeleccionado.ReadOnly = true;
            this.txtProductoSeleccionado.Size = new System.Drawing.Size(340, 22);
            this.txtProductoSeleccionado.TabIndex = 0;
            // 
            // lblStockActualTxt
            // 
            this.lblStockActualTxt.AutoSize = true;
            this.lblStockActualTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStockActualTxt.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStockActualTxt.Location = new System.Drawing.Point(400, 55);
            this.lblStockActualTxt.Name = "lblStockActualTxt";
            this.lblStockActualTxt.Size = new System.Drawing.Size(118, 20);
            this.lblStockActualTxt.TabIndex = 2;
            this.lblStockActualTxt.Text = "STOCK ACTUAL";
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(400, 75);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.ReadOnly = true;
            this.txtStockActual.Size = new System.Drawing.Size(300, 22);
            this.txtStockActual.TabIndex = 1;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCantidad.Location = new System.Drawing.Point(20, 110);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(182, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "CANTIDAD A INGRESAR";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(20, 130);
            this.nudCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(340, 22);
            this.nudCantidad.TabIndex = 2;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // lblNuevoStock
            // 
            this.lblNuevoStock.AutoSize = true;
            this.lblNuevoStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNuevoStock.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNuevoStock.Location = new System.Drawing.Point(400, 110);
            this.lblNuevoStock.Name = "lblNuevoStock";
            this.lblNuevoStock.Size = new System.Drawing.Size(207, 20);
            this.lblNuevoStock.TabIndex = 4;
            this.lblNuevoStock.Text = "NUEVO STOCK RESULTANTE";
            // 
            // txtNuevoStock
            // 
            this.txtNuevoStock.Location = new System.Drawing.Point(400, 130);
            this.txtNuevoStock.Name = "txtNuevoStock";
            this.txtNuevoStock.ReadOnly = true;
            this.txtNuevoStock.Size = new System.Drawing.Size(300, 22);
            this.txtNuevoStock.TabIndex = 3;
            // 
            // lblValidacion
            // 
            this.lblValidacion.AutoSize = true;
            this.lblValidacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblValidacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblValidacion.Location = new System.Drawing.Point(20, 170);
            this.lblValidacion.Name = "lblValidacion";
            this.lblValidacion.Size = new System.Drawing.Size(0, 20);
            this.lblValidacion.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancelar.Location = new System.Drawing.Point(420, 200);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrarIngreso
            // 
            this.btnRegistrarIngreso.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegistrarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarIngreso.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarIngreso.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarIngreso.Location = new System.Drawing.Point(560, 200);
            this.btnRegistrarIngreso.Name = "btnRegistrarIngreso";
            this.btnRegistrarIngreso.Size = new System.Drawing.Size(160, 32);
            this.btnRegistrarIngreso.TabIndex = 6;
            this.btnRegistrarIngreso.Text = "Registrar Ingreso";
            this.btnRegistrarIngreso.UseVisualStyleBackColor = false;
            this.btnRegistrarIngreso.Click += new System.EventHandler(this.btnRegistrarIngreso_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnVolver.Location = new System.Drawing.Point(20, 200);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 32);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmCargaStock
            // 
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(855, 600);
            this.Controls.Add(this.pnlIngreso);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.btnActualizarInventario);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmCargaStock";
            this.Text = "Sistema AviGestión";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.pnlIngreso.ResumeLayout(false);
            this.pnlIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnActualizarInventario;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoStock;
        private System.Windows.Forms.DataGridViewButtonColumn colSeleccionar;
        private System.Windows.Forms.Panel pnlIngreso;
        private System.Windows.Forms.Label lblTituloIngreso;
        private System.Windows.Forms.Label lblProductoSel;
        private System.Windows.Forms.TextBox txtProductoSeleccionado;
        private System.Windows.Forms.Label lblStockActualTxt;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblNuevoStock;
        private System.Windows.Forms.TextBox txtNuevoStock;
        private System.Windows.Forms.Label lblValidacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrarIngreso;
        private System.Windows.Forms.Button btnVolver;
    }
}