namespace ProyectoTaller2.Presentacion
{
    partial class ServiciosCrud
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
            btnGuardarCambios = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregarServicio = new Button();
            lblPrecio = new Label();
            lblNombre = new Label();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            panel1 = new Panel();
            dataGridServicios = new DataGridView();
            Cod_Servio = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            CodigoServicio = new Label();
            txtCodServicio = new TextBox();
            lblTituloServicio = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridServicios).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.Lime;
            btnGuardarCambios.FlatStyle = FlatStyle.Popup;
            btnGuardarCambios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCambios.Location = new Point(611, 55);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(134, 40);
            btnGuardarCambios.TabIndex = 24;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(611, 195);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 40);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DodgerBlue;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(611, 125);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(134, 40);
            btnEditar.TabIndex = 22;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.BackColor = Color.Lime;
            btnAgregarServicio.FlatStyle = FlatStyle.Popup;
            btnAgregarServicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarServicio.Location = new Point(611, 55);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(134, 40);
            btnAgregarServicio.TabIndex = 21;
            btnAgregarServicio.Text = "Agregar Servicio";
            btnAgregarServicio.UseVisualStyleBackColor = false;
            btnAgregarServicio.Click += btnAgregarServicio_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(316, 183);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(42, 15);
            lblPrecio.TabIndex = 25;
            lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(316, 138);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 26;
            lblNombre.Text = "Nombre";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(396, 175);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(164, 23);
            txtPrecio.TabIndex = 27;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(396, 130);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 23);
            txtNombre.TabIndex = 28;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridServicios);
            panel1.Location = new Point(246, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 199);
            panel1.TabIndex = 29;
            // 
            // dataGridServicios
            // 
            dataGridServicios.AllowUserToAddRows = false;
            dataGridServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridServicios.Columns.AddRange(new DataGridViewColumn[] { Cod_Servio, Nombre, Precio });
            dataGridServicios.Dock = DockStyle.Fill;
            dataGridServicios.Location = new Point(0, 0);
            dataGridServicios.Name = "dataGridServicios";
            dataGridServicios.RowTemplate.Height = 25;
            dataGridServicios.Size = new Size(346, 199);
            dataGridServicios.TabIndex = 0;
            dataGridServicios.SelectionChanged += dataGridServicios_SelectionChanged;
            // 
            // Cod_Servio
            // 
            Cod_Servio.HeaderText = "Codigo Servicio";
            Cod_Servio.Name = "Cod_Servio";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // CodigoServicio
            // 
            CodigoServicio.AutoSize = true;
            CodigoServicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CodigoServicio.Location = new Point(276, 88);
            CodigoServicio.Name = "CodigoServicio";
            CodigoServicio.Size = new Size(93, 15);
            CodigoServicio.TabIndex = 30;
            CodigoServicio.Text = "Codigo Servicio";
            // 
            // txtCodServicio
            // 
            txtCodServicio.Location = new Point(396, 80);
            txtCodServicio.Name = "txtCodServicio";
            txtCodServicio.Size = new Size(164, 23);
            txtCodServicio.TabIndex = 31;
            txtCodServicio.KeyPress += txtCodServicio_KeyPress;
            // 
            // lblTituloServicio
            // 
            lblTituloServicio.AutoSize = true;
            lblTituloServicio.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloServicio.ForeColor = Color.Honeydew;
            lblTituloServicio.Location = new Point(12, 9);
            lblTituloServicio.Name = "lblTituloServicio";
            lblTituloServicio.Size = new Size(334, 45);
            lblTituloServicio.TabIndex = 32;
            lblTituloServicio.Text = "Servicios Adicionales";
            // 
            // ServiciosCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 465);
            Controls.Add(lblTituloServicio);
            Controls.Add(txtCodServicio);
            Controls.Add(CodigoServicio);
            Controls.Add(panel1);
            Controls.Add(txtNombre);
            Controls.Add(txtPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblPrecio);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregarServicio);
            Name = "ServiciosCrud";
            Text = "Servicios";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewRow filaSeleccionada = null;

        private Button btnGuardarCambios;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregarServicio;
        private Label lblPrecio;
        private Label lblNombre;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Panel panel1;
        private DataGridView dataGridServicios;
        private DataGridViewTextBoxColumn Cod_Servio;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private Label CodigoServicio;
        private TextBox txtCodServicio;
        private Label lblTituloServicio;
    }
}