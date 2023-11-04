namespace ProyectoTaller2.CapaPresentacion.Recepcionista
{
    partial class ListadoDeReservas
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
            BEditar = new Button();
            BEliminar = new Button();
            LFechaIng = new Label();
            LFechaRet = new Label();
            LCantidad = new Label();
            DTIngreso = new DateTimePicker();
            DTRetiro = new DateTimePicker();
            NCantidad = new NumericUpDown();
            TBuscar = new TextBox();
            panel1 = new Panel();
            dataGridReserva = new DataGridView();
            BGuardar = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblNroHabitacion = new Label();
            txtNroHabitacion = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)NCantidad).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReserva).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LReservas
            // 
            LReservas.AutoEllipsis = true;
            LReservas.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LReservas.ForeColor = Color.White;
            LReservas.Location = new Point(117, 8);
            LReservas.Name = "LReservas";
            LReservas.Size = new Size(441, 46);
            LReservas.TabIndex = 0;
            LReservas.Text = "Gestión Reservas";
            // 
            // BEditar
            // 
            BEditar.BackColor = Color.DodgerBlue;
            BEditar.FlatStyle = FlatStyle.Popup;
            BEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BEditar.Location = new Point(702, 153);
            BEditar.Name = "BEditar";
            BEditar.Size = new Size(113, 45);
            BEditar.TabIndex = 3;
            BEditar.Text = "Editar";
            BEditar.UseVisualStyleBackColor = false;
            BEditar.Click += BEditar_Click;
            // 
            // BEliminar
            // 
            BEliminar.BackColor = Color.Red;
            BEliminar.FlatStyle = FlatStyle.Popup;
            BEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BEliminar.Location = new Point(702, 214);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(113, 45);
            BEliminar.TabIndex = 4;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = false;
            BEliminar.Click += BEliminar_Click;
            // 
            // LFechaIng
            // 
            LFechaIng.AutoSize = true;
            LFechaIng.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LFechaIng.Location = new Point(20, 96);
            LFechaIng.Name = "LFechaIng";
            LFechaIng.Size = new Size(135, 20);
            LFechaIng.TabIndex = 5;
            LFechaIng.Text = "Fecha de Ingreso :";
            // 
            // LFechaRet
            // 
            LFechaRet.AutoSize = true;
            LFechaRet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LFechaRet.Location = new Point(20, 152);
            LFechaRet.Name = "LFechaRet";
            LFechaRet.Size = new Size(125, 20);
            LFechaRet.TabIndex = 6;
            LFechaRet.Text = "Fecha de Retiro :";
            // 
            // LCantidad
            // 
            LCantidad.AutoSize = true;
            LCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LCantidad.Location = new Point(367, 154);
            LCantidad.Name = "LCantidad";
            LCantidad.Size = new Size(167, 20);
            LCantidad.TabIndex = 16;
            LCantidad.Text = "Cantidad de Personas :";
            // 
            // DTIngreso
            // 
            DTIngreso.Location = new Point(167, 94);
            DTIngreso.Name = "DTIngreso";
            DTIngreso.Size = new Size(160, 27);
            DTIngreso.TabIndex = 19;
            DTIngreso.TextChanged += CamposTextChanged;
            // 
            // DTRetiro
            // 
            DTRetiro.Location = new Point(167, 147);
            DTRetiro.Name = "DTRetiro";
            DTRetiro.Size = new Size(160, 27);
            DTRetiro.TabIndex = 20;
            DTRetiro.TextChanged += CamposTextChanged;
            // 
            // NCantidad
            // 
            NCantidad.Location = new Point(586, 150);
            NCantidad.Name = "NCantidad";
            NCantidad.Size = new Size(87, 27);
            NCantidad.TabIndex = 22;
            NCantidad.TextChanged += CamposTextChanged;
            // 
            // TBuscar
            // 
            TBuscar.Location = new Point(356, 232);
            TBuscar.Name = "TBuscar";
            TBuscar.Size = new Size(192, 27);
            TBuscar.TabIndex = 24;
            TBuscar.TextChanged += TBuscar_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridReserva);
            panel1.Location = new Point(1, 313);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 149);
            panel1.TabIndex = 25;
            // 
            // dataGridReserva
            // 
            dataGridReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReserva.Dock = DockStyle.Fill;
            dataGridReserva.Location = new Point(0, 0);
            dataGridReserva.Name = "dataGridReserva";
            dataGridReserva.RowHeadersWidth = 51;
            dataGridReserva.RowTemplate.Height = 25;
            dataGridReserva.Size = new Size(833, 149);
            dataGridReserva.TabIndex = 2;
            dataGridReserva.SelectionChanged += dataGridReserva_SelectionChanged;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.Lime;
            BGuardar.FlatStyle = FlatStyle.Popup;
            BGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BGuardar.Location = new Point(702, 94);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(113, 45);
            BGuardar.TabIndex = 26;
            BGuardar.Text = "Guardar Cambios";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 85;
            iconPictureBox1.Location = new Point(12, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(85, 85);
            iconPictureBox1.TabIndex = 27;
            iconPictureBox1.TabStop = false;
            // 
            // lblNroHabitacion
            // 
            lblNroHabitacion.AutoSize = true;
            lblNroHabitacion.Location = new Point(367, 99);
            lblNroHabitacion.Name = "lblNroHabitacion";
            lblNroHabitacion.Size = new Size(123, 20);
            lblNroHabitacion.TabIndex = 28;
            lblNroHabitacion.Text = "Nro Habitacion :";
            // 
            // txtNroHabitacion
            // 
            txtNroHabitacion.Location = new Point(513, 96);
            txtNroHabitacion.Name = "txtNroHabitacion";
            txtNroHabitacion.Size = new Size(160, 27);
            txtNroHabitacion.TabIndex = 29;
            txtNroHabitacion.KeyPress += txtNroHabitacion_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 235);
            label1.Name = "label1";
            label1.Size = new Size(246, 20);
            label1.TabIndex = 30;
            label1.Text = "Filtrar por número de Habitacion :";
            // 
            // ListadoDeReservas
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 465);
            Controls.Add(label1);
            Controls.Add(txtNroHabitacion);
            Controls.Add(lblNroHabitacion);
            Controls.Add(iconPictureBox1);
            Controls.Add(BGuardar);
            Controls.Add(panel1);
            Controls.Add(TBuscar);
            Controls.Add(NCantidad);
            Controls.Add(DTRetiro);
            Controls.Add(DTIngreso);
            Controls.Add(LCantidad);
            Controls.Add(LFechaRet);
            Controls.Add(LFechaIng);
            Controls.Add(BEliminar);
            Controls.Add(BEditar);
            Controls.Add(LReservas);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "ListadoDeReservas";
            Text = "Gestionar Reservas";
            ((System.ComponentModel.ISupportInitialize)NCantidad).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridReserva).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewRow filaSeleccionada = null;

        private Label LReservas;
        private Button BEditar;
        private Button BEliminar;
        private Label LFechaIng;
        private Label LFechaRet;
        private Label LCantidad;
        private DateTimePicker DTIngreso;
        private DateTimePicker DTRetiro;
        private NumericUpDown NCantidad;
        private TextBox TBuscar;
        private Panel panel1;
        private Button BGuardar;
        private DataGridView dataGridReserva;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblNroHabitacion;
        private TextBox txtNroHabitacion;
        private Label label1;
    }
}