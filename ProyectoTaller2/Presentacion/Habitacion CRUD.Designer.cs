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
            dataGridDetalleHabitacion = new DataGridView();
            panel1 = new Panel();
            lblIDHabitacion = new Label();
            lblPiso = new Label();
            lblNroHabitacion = new Label();
            lblCantidadCama = new Label();
            lblTarifa = new Label();
            lblCategoria = new Label();
            btnAgregarHabitacion = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            IDHabitacion = new DataGridViewTextBoxColumn();
            Piso = new DataGridViewTextBoxColumn();
            NroHabitacion = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            CantidadDeCamas = new DataGridViewTextBoxColumn();
            Tarifa = new DataGridViewTextBoxColumn();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridDetalleHabitacion).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridDetalleHabitacion
            // 
            dataGridDetalleHabitacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDetalleHabitacion.Columns.AddRange(new DataGridViewColumn[] { IDHabitacion, Piso, NroHabitacion, Categoria, CantidadDeCamas, Tarifa });
            dataGridDetalleHabitacion.Dock = DockStyle.Fill;
            dataGridDetalleHabitacion.Location = new Point(0, 0);
            dataGridDetalleHabitacion.Name = "dataGridDetalleHabitacion";
            dataGridDetalleHabitacion.RowTemplate.Height = 25;
            dataGridDetalleHabitacion.Size = new Size(825, 254);
            dataGridDetalleHabitacion.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridDetalleHabitacion);
            panel1.Location = new Point(1, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 254);
            panel1.TabIndex = 1;
            // 
            // lblIDHabitacion
            // 
            lblIDHabitacion.AutoSize = true;
            lblIDHabitacion.Location = new Point(73, 30);
            lblIDHabitacion.Name = "lblIDHabitacion";
            lblIDHabitacion.Size = new Size(79, 15);
            lblIDHabitacion.TabIndex = 2;
            lblIDHabitacion.Text = "ID Habitacion";
            // 
            // lblPiso
            // 
            lblPiso.AutoSize = true;
            lblPiso.Location = new Point(73, 62);
            lblPiso.Name = "lblPiso";
            lblPiso.Size = new Size(29, 15);
            lblPiso.TabIndex = 3;
            lblPiso.Text = "Piso";
            // 
            // lblNroHabitacion
            // 
            lblNroHabitacion.AutoSize = true;
            lblNroHabitacion.Location = new Point(62, 97);
            lblNroHabitacion.Name = "lblNroHabitacion";
            lblNroHabitacion.Size = new Size(88, 15);
            lblNroHabitacion.TabIndex = 4;
            lblNroHabitacion.Text = "Nro Habitacion";
            // 
            // lblCantidadCama
            // 
            lblCantidadCama.AutoSize = true;
            lblCantidadCama.Location = new Point(62, 133);
            lblCantidadCama.Name = "lblCantidadCama";
            lblCantidadCama.Size = new Size(110, 15);
            lblCantidadCama.TabIndex = 5;
            lblCantidadCama.Text = "Cantidad de Camas";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(329, 75);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(35, 15);
            lblTarifa.TabIndex = 6;
            lblTarifa.Text = "Tarifa";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(329, 33);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria";
            // 
            // btnAgregarHabitacion
            // 
            btnAgregarHabitacion.BackColor = Color.Lime;
            btnAgregarHabitacion.FlatStyle = FlatStyle.Popup;
            btnAgregarHabitacion.Location = new Point(641, 30);
            btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            btnAgregarHabitacion.Size = new Size(134, 40);
            btnAgregarHabitacion.TabIndex = 8;
            btnAgregarHabitacion.Text = "Agregar Habitacion";
            btnAgregarHabitacion.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(180, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(370, 72);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 12;
            // 
            // IDHabitacion
            // 
            IDHabitacion.HeaderText = "ID Habitacion";
            IDHabitacion.Name = "IDHabitacion";
            // 
            // Piso
            // 
            Piso.HeaderText = "Piso";
            Piso.Name = "Piso";
            // 
            // NroHabitacion
            // 
            NroHabitacion.HeaderText = "Nro Habitacion";
            NroHabitacion.Name = "NroHabitacion";
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
            // 
            // Tarifa
            // 
            Tarifa.HeaderText = "Tarifa";
            Tarifa.Name = "Tarifa";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DodgerBlue;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Location = new Point(641, 84);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(134, 40);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Location = new Point(641, 142);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 40);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // DetalleHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 465);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnAgregarHabitacion);
            Controls.Add(lblCategoria);
            Controls.Add(lblTarifa);
            Controls.Add(lblCantidadCama);
            Controls.Add(lblNroHabitacion);
            Controls.Add(lblPiso);
            Controls.Add(lblIDHabitacion);
            Controls.Add(panel1);
            Name = "DetalleHabitacion";
            Text = "DetalleHabitacion";
            ((System.ComponentModel.ISupportInitialize)dataGridDetalleHabitacion).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridDetalleHabitacion;
        private Panel panel1;
        private Label lblIDHabitacion;
        private Label lblPiso;
        private Label lblNroHabitacion;
        private Label lblCantidadCama;
        private Label lblTarifa;
        private Label lblCategoria;
        private Button btnAgregarHabitacion;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridViewTextBoxColumn IDHabitacion;
        private DataGridViewTextBoxColumn Piso;
        private DataGridViewTextBoxColumn NroHabitacion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn CantidadDeCamas;
        private DataGridViewTextBoxColumn Tarifa;
        private Button btnEditar;
        private Button btnEliminar;
    }
}