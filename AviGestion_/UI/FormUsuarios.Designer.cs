namespace AviGestion_.UI
{
    partial class FormUsuarios
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.lblModificarDatos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlHeader.Controls.Add(this.btnVolver);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(740, 15);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 30);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Usuarios";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(20, 75);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(740, 74);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 26);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "+ Agregar Usuario";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colApellido,
            this.colRol,
            this.colAccion,
            this.colEliminar});
            this.dgvUsuarios.Location = new System.Drawing.Point(20, 110);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(860, 180);
            this.dgvUsuarios.TabIndex = 3;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 200;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            this.colApellido.Width = 200;
            // 
            // colRol
            // 
            this.colRol.HeaderText = "Rol";
            this.colRol.Name = "colRol";
            this.colRol.ReadOnly = true;
            this.colRol.Width = 200;
            // 
            // colAccion
            // 
            this.colAccion.HeaderText = "Acción";
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            this.colAccion.Text = "Modificar";
            this.colAccion.UseColumnTextForButtonValue = true;
            this.colAccion.Width = 120;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            this.colEliminar.Text = "Eliminar";
            this.colEliminar.UseColumnTextForButtonValue = true;
            this.colEliminar.Width = 120;
            // 
            // pnlModificar
            // 
            this.pnlModificar.BackColor = System.Drawing.Color.White;
            this.pnlModificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlModificar.Controls.Add(this.lblModificarDatos);
            this.pnlModificar.Controls.Add(this.lblNombre);
            this.pnlModificar.Controls.Add(this.txtNombre);
            this.pnlModificar.Controls.Add(this.lblApellido);
            this.pnlModificar.Controls.Add(this.txtApellido);
            this.pnlModificar.Controls.Add(this.lblContrasena);
            this.pnlModificar.Controls.Add(this.txtContrasena);
            this.pnlModificar.Controls.Add(this.lblRol);
            this.pnlModificar.Controls.Add(this.cmbRol);
            this.pnlModificar.Controls.Add(this.btnCancelar);
            this.pnlModificar.Controls.Add(this.btnGuardar);
            this.pnlModificar.Location = new System.Drawing.Point(20, 305);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(860, 190);
            this.pnlModificar.TabIndex = 4;
            // 
            // lblModificarDatos
            // 
            this.lblModificarDatos.AutoSize = true;
            this.lblModificarDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblModificarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblModificarDatos.Location = new System.Drawing.Point(15, 12);
            this.lblModificarDatos.Name = "lblModificarDatos";
            this.lblModificarDatos.Size = new System.Drawing.Size(50, 20);
            this.lblModificarDatos.TabIndex = 0;
            this.lblModificarDatos.Text = "Datos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblNombre.Location = new System.Drawing.Point(15, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblApellido.Location = new System.Drawing.Point(260, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "APELLIDO";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(260, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(220, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblContrasena.Location = new System.Drawing.Point(505, 50);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(81, 13);
            this.lblContrasena.TabIndex = 5;
            this.lblContrasena.Text = "CONTRASEÑA";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(505, 68);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(160, 20);
            this.txtContrasena.TabIndex = 6;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblRol.Location = new System.Drawing.Point(15, 105);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(29, 13);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "ROL";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.cmbRol.Location = new System.Drawing.Point(15, 123);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(220, 21);
            this.cmbRol.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(620, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(730, 145);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 30);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.pnlModificar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormUsuarios";
            this.Text = "Gestión de Usuarios";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlModificar.ResumeLayout(false);
            this.pnlModificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private System.Windows.Forms.DataGridViewButtonColumn colAccion;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.Panel pnlModificar;
        private System.Windows.Forms.Label lblModificarDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}