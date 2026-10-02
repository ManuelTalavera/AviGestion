namespace AviGestion_.Interfaz
{
    partial class FrmCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxAlta = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevaCategoria = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAlta
            // 
            this.groupBoxAlta.Controls.Add(this.btnCancelar);
            this.groupBoxAlta.Controls.Add(this.btnGuardar);
            this.groupBoxAlta.Controls.Add(this.txtDescripcion);
            this.groupBoxAlta.Controls.Add(this.label4);
            this.groupBoxAlta.Controls.Add(this.txtNombre);
            this.groupBoxAlta.Controls.Add(this.label2);
            this.groupBoxAlta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAlta.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBoxAlta.Location = new System.Drawing.Point(6, 357);
            this.groupBoxAlta.Name = "groupBoxAlta";
            this.groupBoxAlta.Size = new System.Drawing.Size(1033, 258);
            this.groupBoxAlta.TabIndex = 8;
            this.groupBoxAlta.TabStop = false;
            this.groupBoxAlta.Text = "Alta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.Location = new System.Drawing.Point(738, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(596, 169);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 37);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(186, 90);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(688, 26);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(62, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "DESCRIPCIÓN";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(186, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(688, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(62, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colDescripcion,
            this.colProductos,
            this.colCategoria,
            this.colModificar,
            this.colEliminar});
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.Location = new System.Drawing.Point(6, 126);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(1034, 215);
            this.dgvCategorias.TabIndex = 7;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 200;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.MinimumWidth = 6;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Width = 420;
            // 
            // colProductos
            // 
            this.colProductos.HeaderText = "Productos";
            this.colProductos.MinimumWidth = 6;
            this.colProductos.Name = "colProductos";
            this.colProductos.Width = 180;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Id_Categoria";
            this.colCategoria.MinimumWidth = 6;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Visible = false;
            this.colCategoria.Width = 125;
            // 
            // colModificar
            // 
            this.colModificar.HeaderText = "Modificar";
            this.colModificar.MinimumWidth = 6;
            this.colModificar.Name = "colModificar";
            this.colModificar.Text = "Modificar";
            this.colModificar.UseColumnTextForButtonValue = true;
            this.colModificar.Width = 85;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.MinimumWidth = 6;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Text = "Eliminar";
            this.colEliminar.UseColumnTextForButtonValue = true;
            this.colEliminar.Width = 85;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNuevaCategoria);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 54);
            this.panel3.TabIndex = 6;
            // 
            // btnNuevaCategoria
            // 
            this.btnNuevaCategoria.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCategoria.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCategoria.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCategoria.Location = new System.Drawing.Point(783, 11);
            this.btnNuevaCategoria.Name = "btnNuevaCategoria";
            this.btnNuevaCategoria.Size = new System.Drawing.Size(242, 29);
            this.btnNuevaCategoria.TabIndex = 2;
            this.btnNuevaCategoria.Text = "+ Nueva Categoría";
            this.btnNuevaCategoria.UseVisualStyleBackColor = false;
            this.btnNuevaCategoria.Click += new System.EventHandler(this.btnNuevaCategoria_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(34, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(743, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "🔍";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 60);
            this.panel1.TabIndex = 5;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(850, 13);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(190, 32);
            this.btnVolver.TabIndex = 23;
            this.btnVolver.Text = "←Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(9, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 70);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Categorías";
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 632);
            this.Controls.Add(this.groupBoxAlta);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema AviGestión";
            this.groupBoxAlta.ResumeLayout(false);
            this.groupBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNuevaCategoria;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn colModificar;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
    }
}