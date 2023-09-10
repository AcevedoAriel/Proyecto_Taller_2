namespace ProyectoTaller2.Presentacion.Administrador
{
    partial class Reservas
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
            LReservas = new Label();
            dataGridView1 = new DataGridView();
            ingreso = new DataGridViewTextBoxColumn();
            retiro = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            personas = new DataGridViewTextBoxColumn();
            habitacion = new DataGridViewTextBoxColumn();
            servicio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LReservas
            // 
            LReservas.AutoEllipsis = true;
            LReservas.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LReservas.Location = new Point(257, 9);
            LReservas.Name = "LReservas";
            LReservas.Size = new Size(272, 46);
            LReservas.TabIndex = 0;
            LReservas.Text = "Registro de Reservas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ingreso, retiro, nombre, apellido, personas, habitacion, servicio });
            dataGridView1.Location = new Point(3, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(766, 150);
            dataGridView1.TabIndex = 1;
            // 
            // ingreso
            // 
            ingreso.HeaderText = "Fecha de Ingreso";
            ingreso.Name = "ingreso";
            ingreso.Width = 80;
            // 
            // retiro
            // 
            retiro.HeaderText = "Fecha de Retiro";
            retiro.Name = "retiro";
            retiro.Width = 80;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre del Cliente";
            nombre.Name = "nombre";
            nombre.Width = 250;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido del Cliente";
            apellido.Name = "apellido";
            apellido.Width = 120;
            // 
            // personas
            // 
            personas.HeaderText = "Cantidad de Personas";
            personas.Name = "personas";
            personas.Width = 60;
            // 
            // habitacion
            // 
            habitacion.HeaderText = "Habitación";
            habitacion.Name = "habitacion";
            habitacion.Width = 70;
            // 
            // servicio
            // 
            servicio.HeaderText = "Servicio al Cuarto";
            servicio.Name = "servicio";
            servicio.Width = 60;
            // 
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 450);
            Controls.Add(dataGridView1);
            Controls.Add(LReservas);
            Name = "Reservas";
            Text = "Reservas";
            Load += Reservas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LReservas;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ingreso;
        private DataGridViewTextBoxColumn retiro;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn personas;
        private DataGridViewTextBoxColumn habitacion;
        private DataGridViewTextBoxColumn servicio;
    }
}