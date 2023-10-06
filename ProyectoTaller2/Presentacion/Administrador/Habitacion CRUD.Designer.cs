namespace ProyectoTaller2.Presentacion
{
    partial class CRUDHabitacion
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
            dataGridListaHabitacion = new DataGridView();
            IDHabitacion = new DataGridViewTextBoxColumn();
            Piso = new DataGridViewTextBoxColumn();
            NroHabitacion = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            CantidadDeCamas = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            lblIDHabitacion = new Label();
            lblPiso = new Label();
            lblNroHabitacion = new Label();
            lblCantidadCama = new Label();
            lblPrecio = new Label();
            lblCategoria = new Label();
            btnAgregarHabitacion = new Button();
            TIDHabitacion = new TextBox();
            TNroHabitacion = new TextBox();
            TPrecio = new TextBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            CBCategoriaH = new ComboBox();
            pictureBox1 = new PictureBox();
            numericCantCamas = new NumericUpDown();
            CBPiso = new ComboBox();
            btnGuardarCambios = new Button();
            label1 = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblEstadoHabitacion = new Label();
            CBEstado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridListaHabitacion).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantCamas).BeginInit();
            SuspendLayout();
            // 
            // dataGridListaHabitacion
            // 
            dataGridListaHabitacion.AllowUserToAddRows = false;
            dataGridListaHabitacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridListaHabitacion.Columns.AddRange(new DataGridViewColumn[] { IDHabitacion, Piso, NroHabitacion, Categoria, CantidadDeCamas, Precio, Estado });
            dataGridListaHabitacion.Dock = DockStyle.Fill;
            dataGridListaHabitacion.Location = new Point(0, 0);
            dataGridListaHabitacion.Name = "dataGridListaHabitacion";
            dataGridListaHabitacion.RowTemplate.Height = 25;
            dataGridListaHabitacion.Size = new Size(762, 165);
            dataGridListaHabitacion.TabIndex = 0;
            dataGridListaHabitacion.SelectionChanged += dataGridListaHabitacion_SelectionChanged;
            // 
            // IDHabitacion
            // 
            IDHabitacion.HeaderText = "ID Habitacion";
            IDHabitacion.Name = "IDHabitacion";
            IDHabitacion.Width = 104;
            // 
            // Piso
            // 
            Piso.HeaderText = "Piso";
            Piso.Name = "Piso";
            Piso.Width = 50;
            // 
            // NroHabitacion
            // 
            NroHabitacion.HeaderText = "Nro Habitacion";
            NroHabitacion.Name = "NroHabitacion";
            NroHabitacion.Width = 114;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // CantidadDeCamas
            // 
            CantidadDeCamas.HeaderText = "Cantidad de Camas";
            CantidadDeCamas.Name = "CantidadDeCamas";
            CantidadDeCamas.Width = 140;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridListaHabitacion);
            panel1.Location = new Point(32, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 165);
            panel1.TabIndex = 1;
            // 
            // lblIDHabitacion
            // 
            lblIDHabitacion.AutoSize = true;
            lblIDHabitacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIDHabitacion.Location = new Point(89, 146);
            lblIDHabitacion.Name = "lblIDHabitacion";
            lblIDHabitacion.Size = new Size(82, 15);
            lblIDHabitacion.TabIndex = 2;
            lblIDHabitacion.Text = "ID Habitacion";
            // 
            // lblPiso
            // 
            lblPiso.AutoSize = true;
            lblPiso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPiso.Location = new Point(89, 192);
            lblPiso.Name = "lblPiso";
            lblPiso.Size = new Size(29, 15);
            lblPiso.TabIndex = 3;
            lblPiso.Text = "Piso";
            // 
            // lblNroHabitacion
            // 
            lblNroHabitacion.AutoSize = true;
            lblNroHabitacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroHabitacion.Location = new Point(89, 227);
            lblNroHabitacion.Name = "lblNroHabitacion";
            lblNroHabitacion.Size = new Size(90, 15);
            lblNroHabitacion.TabIndex = 4;
            lblNroHabitacion.Text = "Nro Habitacion";
            // 
            // lblCantidadCama
            // 
            lblCantidadCama.AutoSize = true;
            lblCantidadCama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidadCama.Location = new Point(453, 254);
            lblCantidadCama.Name = "lblCantidadCama";
            lblCantidadCama.Size = new Size(110, 15);
            lblCantidadCama.TabIndex = 5;
            lblCantidadCama.Text = "Cantidad de Camas";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(453, 174);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(42, 15);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.Location = new Point(453, 215);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(60, 15);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria";
            // 
            // btnAgregarHabitacion
            // 
            btnAgregarHabitacion.BackColor = Color.Lime;
            btnAgregarHabitacion.FlatStyle = FlatStyle.Popup;
            btnAgregarHabitacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarHabitacion.Location = new Point(201, 70);
            btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            btnAgregarHabitacion.Size = new Size(117, 40);
            btnAgregarHabitacion.TabIndex = 8;
            btnAgregarHabitacion.Text = "Agregar Habitacion";
            btnAgregarHabitacion.UseVisualStyleBackColor = false;
            btnAgregarHabitacion.Click += btnAgregarHabitacion_Click;
            // 
            // TIDHabitacion
            // 
            TIDHabitacion.Location = new Point(220, 143);
            TIDHabitacion.Name = "TIDHabitacion";
            TIDHabitacion.Size = new Size(169, 23);
            TIDHabitacion.TabIndex = 1;
            TIDHabitacion.TextChanged += TIDHabitacion_TextChanged;
            TIDHabitacion.KeyPress += THabitacion_KeyPress;
            // 
            // TNroHabitacion
            // 
            TNroHabitacion.Location = new Point(220, 219);
            TNroHabitacion.Name = "TNroHabitacion";
            TNroHabitacion.Size = new Size(169, 23);
            TNroHabitacion.TabIndex = 3;
            TNroHabitacion.KeyPress += TNroHabitacion_KeyPress;
            // 
            // TPrecio
            // 
            TPrecio.Location = new Point(584, 166);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(169, 23);
            TPrecio.TabIndex = 5;
            TPrecio.TextChanged += TPrecio_TextChanged;
            TPrecio.KeyPress += TPrecio_KeyPress;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DodgerBlue;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(396, 70);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(117, 40);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(606, 70);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 40);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // CBCategoriaH
            // 
            CBCategoriaH.FormattingEnabled = true;
            CBCategoriaH.Items.AddRange(new object[] { "[Seleccione]", "Suite Simple", "Suite Doble", "Suite Matrimonial", "Suite Doble Matrimonial", "Suite Premium" });
            CBCategoriaH.Location = new Point(584, 207);
            CBCategoriaH.Name = "CBCategoriaH";
            CBCategoriaH.Size = new Size(169, 23);
            CBCategoriaH.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.room_1;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // numericCantCamas
            // 
            numericCantCamas.Location = new Point(584, 246);
            numericCantCamas.Name = "numericCantCamas";
            numericCantCamas.Size = new Size(169, 23);
            numericCantCamas.TabIndex = 7;
            // 
            // CBPiso
            // 
            CBPiso.FormattingEnabled = true;
            CBPiso.Items.AddRange(new object[] { "[Seleccione]", "Piso 1", "Piso 2", "Piso 3", "Piso 4", "Piso 5" });
            CBPiso.Location = new Point(220, 184);
            CBPiso.Name = "CBPiso";
            CBPiso.Size = new Size(169, 23);
            CBPiso.TabIndex = 2;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.Lime;
            btnGuardarCambios.FlatStyle = FlatStyle.Popup;
            btnGuardarCambios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCambios.Location = new Point(201, 70);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(117, 40);
            btnGuardarCambios.TabIndex = 20;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(141, 12);
            label1.Name = "label1";
            label1.Size = new Size(388, 37);
            label1.TabIndex = 21;
            label1.Text = "Gestión de Habitaciones";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(734, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 31);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(550, 26);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(173, 23);
            txtBuscar.TabIndex = 23;
            // 
            // lblEstadoHabitacion
            // 
            lblEstadoHabitacion.AutoSize = true;
            lblEstadoHabitacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoHabitacion.Location = new Point(89, 262);
            lblEstadoHabitacion.Name = "lblEstadoHabitacion";
            lblEstadoHabitacion.Size = new Size(43, 15);
            lblEstadoHabitacion.TabIndex = 24;
            lblEstadoHabitacion.Text = "Estado";
            // 
            // CBEstado
            // 
            CBEstado.FormattingEnabled = true;
            CBEstado.Items.AddRange(new object[] { "[Seleccione el Estado]", "Habilitado", "Mantenimiento" });
            CBEstado.Location = new Point(220, 259);
            CBEstado.Name = "CBEstado";
            CBEstado.Size = new Size(169, 23);
            CBEstado.TabIndex = 4;
            // 
            // CRUDHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 465);
            Controls.Add(CBEstado);
            Controls.Add(lblEstadoHabitacion);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(btnGuardarCambios);
            Controls.Add(CBPiso);
            Controls.Add(numericCantCamas);
            Controls.Add(pictureBox1);
            Controls.Add(CBCategoriaH);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(TPrecio);
            Controls.Add(TNroHabitacion);
            Controls.Add(TIDHabitacion);
            Controls.Add(btnAgregarHabitacion);
            Controls.Add(lblCategoria);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidadCama);
            Controls.Add(lblNroHabitacion);
            Controls.Add(lblPiso);
            Controls.Add(lblIDHabitacion);
            Controls.Add(panel1);
            Name = "CRUDHabitacion";
            Text = "Gestion Habitacion";
            ((System.ComponentModel.ISupportInitialize)dataGridListaHabitacion).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantCamas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewRow filaSeleccionada = null;

        private DataGridView dataGridListaHabitacion;
        private Panel panel1;
        private Label lblIDHabitacion;
        private Label lblPiso;
        private Label lblNroHabitacion;
        private Label lblCantidadCama;
        private Label lblPrecio;
        private Label lblCategoria;
        private Button btnAgregarHabitacion;
        private TextBox TIDHabitacion;
        private TextBox TNroHabitacion;
        private TextBox TPrecio;
        private Button btnEditar;
        private Button btnEliminar;
        private ComboBox CBCategoriaH;
        private PictureBox pictureBox1;
        private NumericUpDown numericCantCamas;
        private ComboBox CBPiso;
        private Button btnGuardarCambios;
        private Label label1;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblEstadoHabitacion;
        private ComboBox CBEstado;
        private DataGridViewTextBoxColumn IDHabitacion;
        private DataGridViewTextBoxColumn Piso;
        private DataGridViewTextBoxColumn NroHabitacion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn CantidadDeCamas;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Estado;
    }
}