namespace AviGestion_.Interfaz
{
    partial class FormRegistrarPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pnlBuscarPagos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblListadoPedidosPendientes = new System.Windows.Forms.Label();
            this.splitPagos = new System.Windows.Forms.SplitContainer();
            this.dgvListadoPedidos = new System.Windows.Forms.DataGridView();
            this.colIdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPagar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelImporte = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoPendiente = new System.Windows.Forms.Label();
            this.panelPedido = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblClienteSeleccionado = new System.Windows.Forms.Label();
            this.lblPedidoSeleccionado = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblTituloPago = new System.Windows.Forms.Label();
            this.panelPago = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelarPago = new System.Windows.Forms.Button();
            this.btnConfirmarPago = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblMaximoValor = new System.Windows.Forms.Label();
            this.lblInfoPago = new System.Windows.Forms.Label();
            this.lblSaldoValor = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblSaldoInfo = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.nudImporte = new System.Windows.Forms.NumericUpDown();
            this.lblImporte = new System.Windows.Forms.Label();
            this.pnlBuscarPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPagos)).BeginInit();
            this.splitPagos.Panel1.SuspendLayout();
            this.splitPagos.Panel2.SuspendLayout();
            this.splitPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPedidos)).BeginInit();
            this.panelImporte.SuspendLayout();
            this.panelPedido.SuspendLayout();
            this.panelPago.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnAtras.FlatAppearance.BorderSize = 2;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAtras.Location = new System.Drawing.Point(776, 80);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(126, 32);
            this.btnAtras.TabIndex = 16;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pnlBuscarPagos
            // 
            this.pnlBuscarPagos.BackColor = System.Drawing.Color.White;
            this.pnlBuscarPagos.Controls.Add(this.label1);
            this.pnlBuscarPagos.Controls.Add(this.txtBuscar);
            this.pnlBuscarPagos.Location = new System.Drawing.Point(4, 80);
            this.pnlBuscarPagos.Name = "pnlBuscarPagos";
            this.pnlBuscarPagos.Size = new System.Drawing.Size(746, 44);
            this.pnlBuscarPagos.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "🔍 ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(44, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(668, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblListadoPedidosPendientes
            // 
            this.lblListadoPedidosPendientes.BackColor = System.Drawing.Color.ForestGreen;
            this.lblListadoPedidosPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblListadoPedidosPendientes.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoPedidosPendientes.ForeColor = System.Drawing.Color.White;
            this.lblListadoPedidosPendientes.Location = new System.Drawing.Point(-1, 2);
            this.lblListadoPedidosPendientes.Name = "lblListadoPedidosPendientes";
            this.lblListadoPedidosPendientes.Size = new System.Drawing.Size(927, 75);
            this.lblListadoPedidosPendientes.TabIndex = 14;
            this.lblListadoPedidosPendientes.Text = "Listado - Pedidos Pendientes";
            this.lblListadoPedidosPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitPagos
            // 
            this.splitPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitPagos.Location = new System.Drawing.Point(4, 130);
            this.splitPagos.Name = "splitPagos";
            this.splitPagos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPagos.Panel1
            // 
            this.splitPagos.Panel1.Controls.Add(this.dgvListadoPedidos);
            // 
            // splitPagos.Panel2
            // 
            this.splitPagos.Panel2.BackColor = System.Drawing.Color.Beige;
            this.splitPagos.Panel2.Controls.Add(this.panelImporte);
            this.splitPagos.Panel2.Controls.Add(this.panelPedido);
            this.splitPagos.Panel2.Controls.Add(this.lblMensaje);
            this.splitPagos.Panel2.Controls.Add(this.lblTituloPago);
            this.splitPagos.Panel2.Controls.Add(this.panelPago);
            this.splitPagos.Size = new System.Drawing.Size(905, 465);
            this.splitPagos.SplitterDistance = 215;
            this.splitPagos.TabIndex = 13;
            // 
            // dgvListadoPedidos
            // 
            this.dgvListadoPedidos.AllowUserToAddRows = false;
            this.dgvListadoPedidos.AllowUserToDeleteRows = false;
            this.dgvListadoPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoPedidos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListadoPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPedido,
            this.colCliente,
            this.colFecha,
            this.colProductos,
            this.colTotal,
            this.colSaldo,
            this.colEstado,
            this.colPagar});
            this.dgvListadoPedidos.Location = new System.Drawing.Point(2, -1);
            this.dgvListadoPedidos.MultiSelect = false;
            this.dgvListadoPedidos.Name = "dgvListadoPedidos";
            this.dgvListadoPedidos.ReadOnly = true;
            this.dgvListadoPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoPedidos.Size = new System.Drawing.Size(902, 257);
            this.dgvListadoPedidos.TabIndex = 7;
            this.dgvListadoPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoPedidos_CellContentClick);
            // 
            // colIdPedido
            // 
            this.colIdPedido.DataPropertyName = "IdPedido";
            this.colIdPedido.HeaderText = "N°Pedido";
            this.colIdPedido.Name = "colIdPedido";
            this.colIdPedido.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.DataPropertyName = "Cliente";
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle19.Format = "d";
            dataGridViewCellStyle19.NullValue = null;
            this.colFecha.DefaultCellStyle = dataGridViewCellStyle19;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colProductos
            // 
            this.colProductos.HeaderText = "Productos";
            this.colProductos.Name = "colProductos";
            this.colProductos.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "Total";
            dataGridViewCellStyle20.Format = "C2";
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle20;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colSaldo
            // 
            this.colSaldo.DataPropertyName = "SaldoPendiente";
            dataGridViewCellStyle21.Format = "C2";
            this.colSaldo.DefaultCellStyle = dataGridViewCellStyle21;
            this.colSaldo.HeaderText = "Saldo Pendiente";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Estado";
            this.colEstado.HeaderText = "Estado de Pago";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colPagar
            // 
            this.colPagar.HeaderText = "Acción";
            this.colPagar.Name = "colPagar";
            this.colPagar.ReadOnly = true;
            this.colPagar.Text = "Pagar";
            this.colPagar.UseColumnTextForButtonValue = true;
            // 
            // panelImporte
            // 
            this.panelImporte.BackColor = System.Drawing.Color.White;
            this.panelImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImporte.Controls.Add(this.label2);
            this.panelImporte.Controls.Add(this.lblTotalPedido);
            this.panelImporte.Controls.Add(this.lblTotal);
            this.panelImporte.Controls.Add(this.lblSaldo);
            this.panelImporte.Controls.Add(this.lblSaldoPendiente);
            this.panelImporte.Location = new System.Drawing.Point(252, 58);
            this.panelImporte.Name = "panelImporte";
            this.panelImporte.Size = new System.Drawing.Size(223, 175);
            this.panelImporte.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "IMPORTES";
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.BackColor = System.Drawing.Color.White;
            this.lblTotalPedido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedido.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPedido.Location = new System.Drawing.Point(46, 65);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(58, 18);
            this.lblTotalPedido.TabIndex = 6;
            this.lblTotalPedido.Text = "$0,00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotal.Location = new System.Drawing.Point(77, 41);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 18);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "TOTAL";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.White;
            this.lblSaldo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSaldo.Location = new System.Drawing.Point(26, 111);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(162, 18);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "SALDO PENDIENTE";
            // 
            // lblSaldoPendiente
            // 
            this.lblSaldoPendiente.AutoSize = true;
            this.lblSaldoPendiente.BackColor = System.Drawing.Color.White;
            this.lblSaldoPendiente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoPendiente.ForeColor = System.Drawing.Color.Black;
            this.lblSaldoPendiente.Location = new System.Drawing.Point(46, 135);
            this.lblSaldoPendiente.Name = "lblSaldoPendiente";
            this.lblSaldoPendiente.Size = new System.Drawing.Size(58, 18);
            this.lblSaldoPendiente.TabIndex = 8;
            this.lblSaldoPendiente.Text = "$0,00";
            // 
            // panelPedido
            // 
            this.panelPedido.BackColor = System.Drawing.Color.White;
            this.panelPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPedido.Controls.Add(this.lblCliente);
            this.panelPedido.Controls.Add(this.lblClienteSeleccionado);
            this.panelPedido.Controls.Add(this.lblPedidoSeleccionado);
            this.panelPedido.Controls.Add(this.lblPedido);
            this.panelPedido.Location = new System.Drawing.Point(23, 58);
            this.panelPedido.Name = "panelPedido";
            this.panelPedido.Size = new System.Drawing.Size(223, 175);
            this.panelPedido.TabIndex = 24;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCliente.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCliente.Location = new System.Drawing.Point(52, 106);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(85, 18);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "CLIENTE";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClienteSeleccionado
            // 
            this.lblClienteSeleccionado.AutoSize = true;
            this.lblClienteSeleccionado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblClienteSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClienteSeleccionado.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteSeleccionado.Location = new System.Drawing.Point(55, 133);
            this.lblClienteSeleccionado.Name = "lblClienteSeleccionado";
            this.lblClienteSeleccionado.Size = new System.Drawing.Size(17, 20);
            this.lblClienteSeleccionado.TabIndex = 3;
            this.lblClienteSeleccionado.Text = "-";
            // 
            // lblPedidoSeleccionado
            // 
            this.lblPedidoSeleccionado.AutoSize = true;
            this.lblPedidoSeleccionado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPedidoSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPedidoSeleccionado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoSeleccionado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPedidoSeleccionado.Location = new System.Drawing.Point(89, 65);
            this.lblPedidoSeleccionado.Name = "lblPedidoSeleccionado";
            this.lblPedidoSeleccionado.Size = new System.Drawing.Size(16, 18);
            this.lblPedidoSeleccionado.TabIndex = 2;
            this.lblPedidoSeleccionado.Text = "-";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.BackColor = System.Drawing.Color.White;
            this.lblPedido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPedido.Location = new System.Drawing.Point(52, 34);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(106, 18);
            this.lblPedido.TabIndex = 1;
            this.lblPedido.Text = "PEDIDO N°";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.White;
            this.lblMensaje.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMensaje.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMensaje.Location = new System.Drawing.Point(299, 30);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 18);
            this.lblMensaje.TabIndex = 16;
            // 
            // lblTituloPago
            // 
            this.lblTituloPago.BackColor = System.Drawing.Color.Beige;
            this.lblTituloPago.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTituloPago.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPago.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTituloPago.Location = new System.Drawing.Point(0, 8);
            this.lblTituloPago.Name = "lblTituloPago";
            this.lblTituloPago.Size = new System.Drawing.Size(902, 30);
            this.lblTituloPago.TabIndex = 0;
            this.lblTituloPago.Text = "Registrar Pago";
            this.lblTituloPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelPago
            // 
            this.panelPago.BackColor = System.Drawing.Color.White;
            this.panelPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPago.Controls.Add(this.label3);
            this.panelPago.Controls.Add(this.btnCancelarPago);
            this.panelPago.Controls.Add(this.btnConfirmarPago);
            this.panelPago.Controls.Add(this.pnlInfo);
            this.panelPago.Controls.Add(this.nudImporte);
            this.panelPago.Controls.Add(this.lblImporte);
            this.panelPago.Location = new System.Drawing.Point(481, 58);
            this.panelPago.Name = "panelPago";
            this.panelPago.Size = new System.Drawing.Size(403, 175);
            this.panelPago.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "INFORMACIÓN / PAGO";
            // 
            // btnCancelarPago
            // 
            this.btnCancelarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarPago.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPago.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelarPago.Location = new System.Drawing.Point(243, 102);
            this.btnCancelarPago.Name = "btnCancelarPago";
            this.btnCancelarPago.Size = new System.Drawing.Size(146, 31);
            this.btnCancelarPago.TabIndex = 15;
            this.btnCancelarPago.Text = "Cancelar";
            this.btnCancelarPago.UseVisualStyleBackColor = true;
            this.btnCancelarPago.Click += new System.EventHandler(this.btnCancelarPago_Click);
            // 
            // btnConfirmarPago
            // 
            this.btnConfirmarPago.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarPago.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarPago.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarPago.Location = new System.Drawing.Point(243, 135);
            this.btnConfirmarPago.Name = "btnConfirmarPago";
            this.btnConfirmarPago.Size = new System.Drawing.Size(146, 33);
            this.btnConfirmarPago.TabIndex = 11;
            this.btnConfirmarPago.Text = "Confirmar Pago";
            this.btnConfirmarPago.UseVisualStyleBackColor = false;
            this.btnConfirmarPago.Click += new System.EventHandler(this.btnConfirmarPago_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.lblMaximoValor);
            this.pnlInfo.Controls.Add(this.lblInfoPago);
            this.pnlInfo.Controls.Add(this.lblSaldoValor);
            this.pnlInfo.Controls.Add(this.lblMaximo);
            this.pnlInfo.Controls.Add(this.lblSaldoInfo);
            this.pnlInfo.Controls.Add(this.lblInformacion);
            this.pnlInfo.Location = new System.Drawing.Point(10, 45);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(227, 88);
            this.pnlInfo.TabIndex = 23;
            // 
            // lblMaximoValor
            // 
            this.lblMaximoValor.AutoSize = true;
            this.lblMaximoValor.BackColor = System.Drawing.Color.White;
            this.lblMaximoValor.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMaximoValor.Location = new System.Drawing.Point(142, 66);
            this.lblMaximoValor.Name = "lblMaximoValor";
            this.lblMaximoValor.Size = new System.Drawing.Size(37, 13);
            this.lblMaximoValor.TabIndex = 21;
            this.lblMaximoValor.Text = "$ 0,00";
            // 
            // lblInfoPago
            // 
            this.lblInfoPago.AutoSize = true;
            this.lblInfoPago.BackColor = System.Drawing.Color.White;
            this.lblInfoPago.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPago.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblInfoPago.Location = new System.Drawing.Point(12, 5);
            this.lblInfoPago.Name = "lblInfoPago";
            this.lblInfoPago.Size = new System.Drawing.Size(195, 16);
            this.lblInfoPago.TabIndex = 17;
            this.lblInfoPago.Text = "Se aceptan pagos parciales!";
            // 
            // lblSaldoValor
            // 
            this.lblSaldoValor.AutoSize = true;
            this.lblSaldoValor.BackColor = System.Drawing.Color.White;
            this.lblSaldoValor.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSaldoValor.Location = new System.Drawing.Point(142, 50);
            this.lblSaldoValor.Name = "lblSaldoValor";
            this.lblSaldoValor.Size = new System.Drawing.Size(37, 13);
            this.lblSaldoValor.TabIndex = 19;
            this.lblSaldoValor.Text = "$ 0,00";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.BackColor = System.Drawing.Color.White;
            this.lblMaximo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMaximo.Location = new System.Drawing.Point(12, 63);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(124, 16);
            this.lblMaximo.TabIndex = 20;
            this.lblMaximo.Text = "Máximo a abonar:";
            // 
            // lblSaldoInfo
            // 
            this.lblSaldoInfo.AutoSize = true;
            this.lblSaldoInfo.BackColor = System.Drawing.Color.White;
            this.lblSaldoInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSaldoInfo.Location = new System.Drawing.Point(12, 47);
            this.lblSaldoInfo.Name = "lblSaldoInfo";
            this.lblSaldoInfo.Size = new System.Drawing.Size(119, 16);
            this.lblSaldoInfo.TabIndex = 18;
            this.lblSaldoInfo.Text = "Saldo Pendiente:";
            // 
            // lblInformacion
            // 
            this.lblInformacion.BackColor = System.Drawing.Color.White;
            this.lblInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformacion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInformacion.Location = new System.Drawing.Point(0, 4);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(227, 84);
            this.lblInformacion.TabIndex = 22;
            // 
            // nudImporte
            // 
            this.nudImporte.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nudImporte.DecimalPlaces = 2;
            this.nudImporte.ForeColor = System.Drawing.Color.Black;
            this.nudImporte.Location = new System.Drawing.Point(243, 65);
            this.nudImporte.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudImporte.Name = "nudImporte";
            this.nudImporte.Size = new System.Drawing.Size(146, 20);
            this.nudImporte.TabIndex = 10;
            this.nudImporte.ThousandsSeparator = true;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.BackColor = System.Drawing.Color.White;
            this.lblImporte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblImporte.Location = new System.Drawing.Point(240, 43);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(149, 16);
            this.lblImporte.TabIndex = 9;
            this.lblImporte.Text = "IMPORTE A ABONAR";
            // 
            // FormRegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(921, 595);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pnlBuscarPagos);
            this.Controls.Add(this.lblListadoPedidosPendientes);
            this.Controls.Add(this.splitPagos);
            this.Name = "FormRegistrarPago";
            this.Text = "FormRegistrarPago";
            this.Load += new System.EventHandler(this.FormRegistrarPago_Load);
            this.pnlBuscarPagos.ResumeLayout(false);
            this.pnlBuscarPagos.PerformLayout();
            this.splitPagos.Panel1.ResumeLayout(false);
            this.splitPagos.Panel2.ResumeLayout(false);
            this.splitPagos.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPagos)).EndInit();
            this.splitPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPedidos)).EndInit();
            this.panelImporte.ResumeLayout(false);
            this.panelImporte.PerformLayout();
            this.panelPedido.ResumeLayout(false);
            this.panelPedido.PerformLayout();
            this.panelPago.ResumeLayout(false);
            this.panelPago.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel pnlBuscarPagos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblListadoPedidosPendientes;
        private System.Windows.Forms.SplitContainer splitPagos;
        private System.Windows.Forms.DataGridView dgvListadoPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewButtonColumn colPagar;
        private System.Windows.Forms.Panel panelImporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSaldoPendiente;
        private System.Windows.Forms.Panel panelPedido;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblClienteSeleccionado;
        private System.Windows.Forms.Label lblPedidoSeleccionado;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblTituloPago;
        private System.Windows.Forms.Panel panelPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelarPago;
        private System.Windows.Forms.Button btnConfirmarPago;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblMaximoValor;
        private System.Windows.Forms.Label lblInfoPago;
        private System.Windows.Forms.Label lblSaldoValor;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblSaldoInfo;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.NumericUpDown nudImporte;
        private System.Windows.Forms.Label lblImporte;
    }
}