

namespace AviGestion_.UI
{
    partial class FormMenu
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Panel();
            this.lblClientesDescripcion = new System.Windows.Forms.Label();
            this.lblClientesTitulo = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPedidos = new System.Windows.Forms.Panel();
            this.lblPedidosDescripcion = new System.Windows.Forms.Label();
            this.lblPedidosTitulo = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Panel();
            this.lblProductosDescripcion = new System.Windows.Forms.Label();
            this.lblProductosTitulo = new System.Windows.Forms.Label();
            this.btnAsignarPedidos = new System.Windows.Forms.Panel();
            this.lblAsignarPedidosDescripcion = new System.Windows.Forms.Label();
            this.lblAsignarPedidosTitulo = new System.Windows.Forms.Label();
            this.btnStock = new System.Windows.Forms.Panel();
            this.lblStockDescripcion = new System.Windows.Forms.Label();
            this.lblStockTitulo = new System.Windows.Forms.Label();
            this.btnCategorias = new System.Windows.Forms.Panel();
            this.lblCategoriasDescripcion = new System.Windows.Forms.Label();
            this.lblCategoriasTitulo = new System.Windows.Forms.Label();
            this.btnVehiculos = new System.Windows.Forms.Panel();
            this.lblVehiculosDescripcion = new System.Windows.Forms.Label();
            this.lblVehiculosTitulo = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Panel();
            this.lblAyudaDescripcion = new System.Windows.Forms.Label();
            this.lblAyudaTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.btnClientes.SuspendLayout();
            this.btnUsuarios.SuspendLayout();
            this.btnPedidos.SuspendLayout();
            this.btnProductos.SuspendLayout();
            this.btnAsignarPedidos.SuspendLayout();
            this.btnStock.SuspendLayout();
            this.btnCategorias.SuspendLayout();
            this.btnVehiculos.SuspendLayout();
            this.btnAyuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menú Principal - Sistema AviGestión";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 35);
            this.panel1.TabIndex = 5;
            // 
            // btnClientes
            // 
            this.btnClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnClientes.Controls.Add(this.lblClientesDescripcion);
            this.btnClientes.Controls.Add(this.lblClientesTitulo);
            this.btnClientes.Location = new System.Drawing.Point(20, 50);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(260, 150);
            this.btnClientes.TabIndex = 6;
            this.btnClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.btnClientes_Paint);
            // 
            // lblClientesDescripcion
            // 
            this.lblClientesDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesDescripcion.Location = new System.Drawing.Point(10, 85);
            this.lblClientesDescripcion.Name = "lblClientesDescripcion";
            this.lblClientesDescripcion.Size = new System.Drawing.Size(240, 51);
            this.lblClientesDescripcion.TabIndex = 1;
            this.lblClientesDescripcion.Text = "Gestión de perfiles, historial y datos de clientes.";
            this.lblClientesDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientesTitulo
            // 
            this.lblClientesTitulo.AutoSize = true;
            this.lblClientesTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesTitulo.Location = new System.Drawing.Point(85, 55);
            this.lblClientesTitulo.Name = "lblClientesTitulo";
            this.lblClientesTitulo.Size = new System.Drawing.Size(71, 19);
            this.lblClientesTitulo.TabIndex = 0;
            this.lblClientesTitulo.Text = "Clientes";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnUsuarios.Controls.Add(this.label2);
            this.btnUsuarios.Controls.Add(this.label1);
            this.btnUsuarios.Location = new System.Drawing.Point(300, 50);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(260, 150);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.btnUsuarios_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Administración de accesos, roles y permisos de usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuarios";
            // 
            // btnPedidos
            // 
            this.btnPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPedidos.Controls.Add(this.lblPedidosDescripcion);
            this.btnPedidos.Controls.Add(this.lblPedidosTitulo);
            this.btnPedidos.Location = new System.Drawing.Point(580, 50);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(260, 150);
            this.btnPedidos.TabIndex = 8;
            // 
            // lblPedidosDescripcion
            // 
            this.lblPedidosDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidosDescripcion.Location = new System.Drawing.Point(10, 85);
            this.lblPedidosDescripcion.Name = "lblPedidosDescripcion";
            this.lblPedidosDescripcion.Size = new System.Drawing.Size(240, 51);
            this.lblPedidosDescripcion.TabIndex = 1;
            this.lblPedidosDescripcion.Text = "Visualización, creación y seguimiento de todos los pedidos.";
            this.lblPedidosDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPedidosTitulo
            // 
            this.lblPedidosTitulo.AutoSize = true;
            this.lblPedidosTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidosTitulo.Location = new System.Drawing.Point(88, 55);
            this.lblPedidosTitulo.Name = "lblPedidosTitulo";
            this.lblPedidosTitulo.Size = new System.Drawing.Size(72, 19);
            this.lblPedidosTitulo.TabIndex = 0;
            this.lblPedidosTitulo.Text = "Pedidos";
            // 
            // btnProductos
            // 
            this.btnProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnProductos.Controls.Add(this.lblProductosDescripcion);
            this.btnProductos.Controls.Add(this.lblProductosTitulo);
            this.btnProductos.Location = new System.Drawing.Point(20, 220);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(260, 150);
            this.btnProductos.TabIndex = 9;
            this.btnProductos.Paint += new System.Windows.Forms.PaintEventHandler(this.btnProductos_Paint);
            // 
            // lblProductosDescripcion
            // 
            this.lblProductosDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosDescripcion.Location = new System.Drawing.Point(10, 85);
            this.lblProductosDescripcion.Name = "lblProductosDescripcion";
            this.lblProductosDescripcion.Size = new System.Drawing.Size(240, 51);
            this.lblProductosDescripcion.TabIndex = 1;
            this.lblProductosDescripcion.Text = "Control y mantenimiento detallado del catálogo de productos.";
            this.lblProductosDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductosTitulo
            // 
            this.lblProductosTitulo.AutoSize = true;
            this.lblProductosTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosTitulo.Location = new System.Drawing.Point(78, 55);
            this.lblProductosTitulo.Name = "lblProductosTitulo";
            this.lblProductosTitulo.Size = new System.Drawing.Size(89, 19);
            this.lblProductosTitulo.TabIndex = 0;
            this.lblProductosTitulo.Text = "Productos";
            this.lblProductosTitulo.Click += new System.EventHandler(this.lblProductosTitulo_Click);
            // 
            // btnAsignarPedidos
            // 
            this.btnAsignarPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAsignarPedidos.Controls.Add(this.lblAsignarPedidosDescripcion);
            this.btnAsignarPedidos.Controls.Add(this.lblAsignarPedidosTitulo);
            this.btnAsignarPedidos.Location = new System.Drawing.Point(300, 220);
            this.btnAsignarPedidos.Name = "btnAsignarPedidos";
            this.btnAsignarPedidos.Size = new System.Drawing.Size(260, 150);
            this.btnAsignarPedidos.TabIndex = 10;
            // 
            // lblAsignarPedidosDescripcion
            // 
            this.lblAsignarPedidosDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarPedidosDescripcion.Location = new System.Drawing.Point(10, 85);
            this.lblAsignarPedidosDescripcion.Name = "lblAsignarPedidosDescripcion";
            this.lblAsignarPedidosDescripcion.Size = new System.Drawing.Size(240, 51);
            this.lblAsignarPedidosDescripcion.TabIndex = 1;
            this.lblAsignarPedidosDescripcion.Text = "Asignación de pedidos a vehículos y responsables de reparto.";
            this.lblAsignarPedidosDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAsignarPedidosTitulo
            // 
            this.lblAsignarPedidosTitulo.AutoSize = true;
            this.lblAsignarPedidosTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarPedidosTitulo.Location = new System.Drawing.Point(55, 55);
            this.lblAsignarPedidosTitulo.Name = "lblAsignarPedidosTitulo";
            this.lblAsignarPedidosTitulo.Size = new System.Drawing.Size(135, 19);
            this.lblAsignarPedidosTitulo.TabIndex = 0;
            this.lblAsignarPedidosTitulo.Text = "Asignar Pedidos";
            // 
            // btnStock
            // 
            this.btnStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnStock.Controls.Add(this.lblStockDescripcion);
            this.btnStock.Controls.Add(this.lblStockTitulo);
            this.btnStock.Location = new System.Drawing.Point(580, 220);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(260, 150);
            this.btnStock.TabIndex = 11;
            // 
            // lblStockDescripcion
            // 
            this.lblStockDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockDescripcion.Location = new System.Drawing.Point(10, 85);
            this.lblStockDescripcion.Name = "lblStockDescripcion";
            this.lblStockDescripcion.Size = new System.Drawing.Size(240, 51);
            this.lblStockDescripcion.TabIndex = 1;
            this.lblStockDescripcion.Text = "Gestión de inventario en tiempo real y alertas de nivel bajo.";
            this.lblStockDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockTitulo
            // 
            this.lblStockTitulo.AutoSize = true;
            this.lblStockTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockTitulo.Location = new System.Drawing.Point(103, 55);
            this.lblStockTitulo.Name = "lblStockTitulo";
            this.lblStockTitulo.Size = new System.Drawing.Size(53, 19);
            this.lblStockTitulo.TabIndex = 0;
            this.lblStockTitulo.Text = "Stock";
            // 
            // btnCategorias
            // 
            this.btnCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCategorias.Controls.Add(this.lblCategoriasDescripcion);
            this.btnCategorias.Controls.Add(this.lblCategoriasTitulo);
            this.btnCategorias.Location = new System.Drawing.Point(20, 390);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(260, 150);
            this.btnCategorias.TabIndex = 12;
            // 
            // lblCategoriasDescripcion
            // 
            this.lblCategoriasDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriasDescripcion.Location = new System.Drawing.Point(10, 85);
            this.lblCategoriasDescripcion.Name = "lblCategoriasDescripcion";
            this.lblCategoriasDescripcion.Size = new System.Drawing.Size(240, 51);
            this.lblCategoriasDescripcion.TabIndex = 1;
            this.lblCategoriasDescripcion.Text = "Organización y clasificación de productos por categoría.";
            this.lblCategoriasDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoriasTitulo
            // 
            this.lblCategoriasTitulo.AutoSize = true;
            this.lblCategoriasTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriasTitulo.Location = new System.Drawing.Point(78, 55);
            this.lblCategoriasTitulo.Name = "lblCategoriasTitulo";
            this.lblCategoriasTitulo.Size = new System.Drawing.Size(92, 19);
            this.lblCategoriasTitulo.TabIndex = 0;
            this.lblCategoriasTitulo.Text = "Categorías";
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnVehiculos.Controls.Add(this.lblVehiculosDescripcion);
            this.btnVehiculos.Controls.Add(this.lblVehiculosTitulo);
            this.btnVehiculos.Location = new System.Drawing.Point(300, 390);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(260, 150);
            this.btnVehiculos.TabIndex = 13;
            // 
            // lblVehiculosDescripcion
            // 
            this.lblVehiculosDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosDescripcion.Location = new System.Drawing.Point(10, 85);
            this.lblVehiculosDescripcion.Name = "lblVehiculosDescripcion";
            this.lblVehiculosDescripcion.Size = new System.Drawing.Size(240, 51);
            this.lblVehiculosDescripcion.TabIndex = 1;
            this.lblVehiculosDescripcion.Text = "Gestión de flota, mantenimiento y asignación de vehículos.";
            this.lblVehiculosDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVehiculosTitulo
            // 
            this.lblVehiculosTitulo.AutoSize = true;
            this.lblVehiculosTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosTitulo.Location = new System.Drawing.Point(80, 55);
            this.lblVehiculosTitulo.Name = "lblVehiculosTitulo";
            this.lblVehiculosTitulo.Size = new System.Drawing.Size(84, 19);
            this.lblVehiculosTitulo.TabIndex = 0;
            this.lblVehiculosTitulo.Text = "Vehículos";
            // 
            // btnAyuda
            // 
            this.btnAyuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAyuda.Controls.Add(this.lblAyudaDescripcion);
            this.btnAyuda.Controls.Add(this.lblAyudaTitulo);
            this.btnAyuda.Location = new System.Drawing.Point(580, 390);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(260, 150);
            this.btnAyuda.TabIndex = 14;
            // 
            // lblAyudaDescripcion
            // 
            this.lblAyudaDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyudaDescripcion.Location = new System.Drawing.Point(10, 85);
            this.lblAyudaDescripcion.Name = "lblAyudaDescripcion";
            this.lblAyudaDescripcion.Size = new System.Drawing.Size(240, 51);
            this.lblAyudaDescripcion.TabIndex = 1;
            this.lblAyudaDescripcion.Text = "Acceso a manuales, guías y soporte técnico.";
            this.lblAyudaDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAyudaTitulo
            // 
            this.lblAyudaTitulo.AutoSize = true;
            this.lblAyudaTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyudaTitulo.Location = new System.Drawing.Point(105, 55);
            this.lblAyudaTitulo.Name = "lblAyudaTitulo";
            this.lblAyudaTitulo.Size = new System.Drawing.Size(57, 19);
            this.lblAyudaTitulo.TabIndex = 0;
            this.lblAyudaTitulo.Text = "Ayuda";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(860, 570);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnVehiculos);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnAsignarPedidos);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btnClientes.ResumeLayout(false);
            this.btnClientes.PerformLayout();
            this.btnUsuarios.ResumeLayout(false);
            this.btnUsuarios.PerformLayout();
            this.btnPedidos.ResumeLayout(false);
            this.btnPedidos.PerformLayout();
            this.btnProductos.ResumeLayout(false);
            this.btnProductos.PerformLayout();
            this.btnAsignarPedidos.ResumeLayout(false);
            this.btnAsignarPedidos.PerformLayout();
            this.btnStock.ResumeLayout(false);
            this.btnStock.PerformLayout();
            this.btnCategorias.ResumeLayout(false);
            this.btnCategorias.PerformLayout();
            this.btnVehiculos.ResumeLayout(false);
            this.btnVehiculos.PerformLayout();
            this.btnAyuda.ResumeLayout(false);
            this.btnAyuda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Panel btnClientes;
        private System.Windows.Forms.Label lblClientesTitulo;
        private System.Windows.Forms.Label lblClientesDescripcion;

        private System.Windows.Forms.Panel btnUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel btnPedidos;
        private System.Windows.Forms.Label lblPedidosTitulo;
        private System.Windows.Forms.Label lblPedidosDescripcion;

        private System.Windows.Forms.Panel btnProductos;
        private System.Windows.Forms.Label lblProductosTitulo;
        private System.Windows.Forms.Label lblProductosDescripcion;

        private System.Windows.Forms.Panel btnAsignarPedidos;
        private System.Windows.Forms.Label lblAsignarPedidosTitulo;
        private System.Windows.Forms.Label lblAsignarPedidosDescripcion;

        private System.Windows.Forms.Panel btnStock;
        private System.Windows.Forms.Label lblStockTitulo;
        private System.Windows.Forms.Label lblStockDescripcion;

        private System.Windows.Forms.Panel btnCategorias;
        private System.Windows.Forms.Label lblCategoriasTitulo;
        private System.Windows.Forms.Label lblCategoriasDescripcion;

        private System.Windows.Forms.Panel btnVehiculos;
        private System.Windows.Forms.Label lblVehiculosTitulo;
        private System.Windows.Forms.Label lblVehiculosDescripcion;

        private System.Windows.Forms.Panel btnAyuda;
        private System.Windows.Forms.Label lblAyudaTitulo;
        private System.Windows.Forms.Label lblAyudaDescripcion;
    }
}

