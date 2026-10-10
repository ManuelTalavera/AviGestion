namespace AviGestion
{
    partial class FormVehiculo
    {
        /// <summary>
        /// Variable de diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No modifique
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.pnlAlta = new System.Windows.Forms.Panel();
            this.lblAltaVehiculo = new System.Windows.Forms.Label();
            this.lblRegistrarNuevo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblCapacidadMax = new System.Windows.Forms.Label();
            this.numCapacidadMax = new System.Windows.Forms.NumericUpDown();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacidadActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.pnlAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidadMax)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1114, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(23, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(351, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Vehículos";
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.White;
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Controls.Add(this.btnAgregarVehiculo);
            this.pnlBuscar.Location = new System.Drawing.Point(21, 87);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(1073, 43);
            this.pnlBuscar.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(0, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(822, 30);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnAgregarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnAgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregarVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(841, 0);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(232, 39);
            this.btnAgregarVehiculo.TabIndex = 1;
            this.btnAgregarVehiculo.Text = "+  Agregar Vehículo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = false;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToOrderColumns = true;
            this.dgvVehiculos.AllowUserToResizeRows = false;
            this.dgvVehiculos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehiculos.ColumnHeadersHeight = 38;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMarca,
            this.colModelo,
            this.colPatente,
            this.colCapacidad,
            this.CapacidadActual,
            this.colEstado,
            this.colBaja});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehiculos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehiculos.EnableHeadersVisualStyles = false;
            this.dgvVehiculos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvVehiculos.Location = new System.Drawing.Point(21, 141);
            this.dgvVehiculos.MultiSelect = false;
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.RowHeadersVisible = false;
            this.dgvVehiculos.RowHeadersWidth = 51;
            this.dgvVehiculos.RowTemplate.Height = 34;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(964, 235);
            this.dgvVehiculos.TabIndex = 2;
            this.dgvVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellContentClick);
            this.dgvVehiculos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVehiculos_CellFormatting);
            // 
            // pnlAlta
            // 
            this.pnlAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(217)))));
            this.pnlAlta.Controls.Add(this.lblAltaVehiculo);
            this.pnlAlta.Controls.Add(this.lblRegistrarNuevo);
            this.pnlAlta.Controls.Add(this.lblMarca);
            this.pnlAlta.Controls.Add(this.cmbMarca);
            this.pnlAlta.Controls.Add(this.lblModelo);
            this.pnlAlta.Controls.Add(this.txtModelo);
            this.pnlAlta.Controls.Add(this.lblPatente);
            this.pnlAlta.Controls.Add(this.txtPatente);
            this.pnlAlta.Controls.Add(this.lblCapacidadMax);
            this.pnlAlta.Controls.Add(this.numCapacidadMax);
            this.pnlAlta.Controls.Add(this.lblEstado);
            this.pnlAlta.Controls.Add(this.cmbEstado);
            this.pnlAlta.Controls.Add(this.btnCancelar);
            this.pnlAlta.Controls.Add(this.btnRegistrar);
            this.pnlAlta.Location = new System.Drawing.Point(21, 393);
            this.pnlAlta.Name = "pnlAlta";
            this.pnlAlta.Size = new System.Drawing.Size(1073, 320);
            this.pnlAlta.TabIndex = 3;
            // 
            // lblAltaVehiculo
            // 
            this.lblAltaVehiculo.AutoSize = true;
            this.lblAltaVehiculo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAltaVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblAltaVehiculo.Location = new System.Drawing.Point(15, 16);
            this.lblAltaVehiculo.Name = "lblAltaVehiculo";
            this.lblAltaVehiculo.Size = new System.Drawing.Size(122, 20);
            this.lblAltaVehiculo.TabIndex = 0;
            this.lblAltaVehiculo.Text = "Alta de Vehículo";
            // 
            // lblRegistrarNuevo
            // 
            this.lblRegistrarNuevo.AutoSize = true;
            this.lblRegistrarNuevo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRegistrarNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblRegistrarNuevo.Location = new System.Drawing.Point(12, 36);
            this.lblRegistrarNuevo.Name = "lblRegistrarNuevo";
            this.lblRegistrarNuevo.Size = new System.Drawing.Size(341, 37);
            this.lblRegistrarNuevo.TabIndex = 1;
            this.lblRegistrarNuevo.Text = "Registrar Nuevo Vehículo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblMarca.Location = new System.Drawing.Point(23, 101);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(64, 20);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "MARCA";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Mercedes-Benz",
            "Toyota",
            "Ford",
            "Iveco",
            "Volkswagen"});
            this.cmbMarca.Location = new System.Drawing.Point(23, 121);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(319, 31);
            this.cmbMarca.TabIndex = 3;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblModelo.Location = new System.Drawing.Point(377, 101);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(72, 20);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "MODELO";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtModelo.Location = new System.Drawing.Point(377, 121);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(319, 30);
            this.txtModelo.TabIndex = 5;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPatente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblPatente.Location = new System.Drawing.Point(731, 101);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(73, 20);
            this.lblPatente.TabIndex = 6;
            this.lblPatente.Text = "PATENTE";
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatente.Location = new System.Drawing.Point(731, 121);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(319, 30);
            this.txtPatente.TabIndex = 7;
            // 
            // lblCapacidadMax
            // 
            this.lblCapacidadMax.AutoSize = true;
            this.lblCapacidadMax.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCapacidadMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblCapacidadMax.Location = new System.Drawing.Point(23, 176);
            this.lblCapacidadMax.Name = "lblCapacidadMax";
            this.lblCapacidadMax.Size = new System.Drawing.Size(169, 20);
            this.lblCapacidadMax.TabIndex = 8;
            this.lblCapacidadMax.Text = "CAPACIDAD MAX (Kg)";
            // 
            // numCapacidadMax
            // 
            this.numCapacidadMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numCapacidadMax.Location = new System.Drawing.Point(23, 195);
            this.numCapacidadMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCapacidadMax.Name = "numCapacidadMax";
            this.numCapacidadMax.Size = new System.Drawing.Size(320, 30);
            this.numCapacidadMax.TabIndex = 9;
            this.numCapacidadMax.ThousandsSeparator = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblEstado.Location = new System.Drawing.Point(377, 176);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 20);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "ESTADO";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(377, 195);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(319, 31);
            this.cmbEstado.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelar.Location = new System.Drawing.Point(674, 261);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 41);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(857, 261);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(217, 41);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar Vehículo";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.MinimumWidth = 6;
            this.colMarca.Name = "colMarca";
            this.colMarca.Width = 130;
            // 
            // colModelo
            // 
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.MinimumWidth = 6;
            this.colModelo.Name = "colModelo";
            this.colModelo.Width = 130;
            // 
            // colPatente
            // 
            this.colPatente.HeaderText = "Patente";
            this.colPatente.MinimumWidth = 6;
            this.colPatente.Name = "colPatente";
            this.colPatente.Width = 130;
            // 
            // colCapacidad
            // 
            this.colCapacidad.HeaderText = "CapacidadMax";
            this.colCapacidad.MinimumWidth = 6;
            this.colCapacidad.Name = "colCapacidad";
            this.colCapacidad.Width = 150;
            // 
            // CapacidadActual
            // 
            this.CapacidadActual.HeaderText = "CapacidadActual";
            this.CapacidadActual.MinimumWidth = 6;
            this.CapacidadActual.Name = "CapacidadActual";
            this.CapacidadActual.Width = 150;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 110;
            // 
            // colBaja
            // 
            this.colBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colBaja.HeaderText = "Acción";
            this.colBaja.MinimumWidth = 6;
            this.colBaja.Name = "colBaja";
            this.colBaja.Text = "Dar de baja";
            this.colBaja.Width = 109;
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1114, 734);
            this.Controls.Add(this.pnlAlta);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(912, 637);
            this.Name = "FormVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema AviGestión";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.pnlAlta.ResumeLayout(false);
            this.pnlAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidadMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Panel pnlAlta;
        private System.Windows.Forms.Label lblAltaVehiculo;
        private System.Windows.Forms.Label lblRegistrarNuevo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblCapacidadMax;
        private System.Windows.Forms.NumericUpDown numCapacidadMax;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacidadActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewButtonColumn colBaja;
    }
}
