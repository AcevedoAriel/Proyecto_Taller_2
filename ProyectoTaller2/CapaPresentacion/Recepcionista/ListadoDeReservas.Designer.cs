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
            LNombre = new Label();
            LApellido = new Label();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TDNI = new TextBox();
            LDNI = new Label();
            LTel = new Label();
            LCantidad = new Label();
            TTelefono = new TextBox();
            DTIngreso = new DateTimePicker();
            DTRetiro = new DateTimePicker();
            NCantidad = new NumericUpDown();
            btnBuscar = new Button();
            TBuscar = new TextBox();
            panel1 = new Panel();
            dataGridReserva = new DataGridView();
            ingreso = new DataGridViewTextBoxColumn();
            retiro = new DataGridViewTextBoxColumn();
            habitacion = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            personas = new DataGridViewTextBoxColumn();
            servicio = new DataGridViewComboBoxColumn();
            BGuardar = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblNroHabitacion = new Label();
            txtNroHabitacion = new TextBox();
            BServicios = new Button();
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
            LReservas.Size = new Size(340, 46);
            LReservas.TabIndex = 0;
            LReservas.Text = "Gestión Reservadas";
            // 
            // BEditar
            // 
            BEditar.BackColor = Color.DodgerBlue;
            BEditar.FlatStyle = FlatStyle.Popup;
            BEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BEditar.Location = new Point(702, 181);
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
            BEliminar.Location = new Point(702, 242);
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
            LFechaIng.Size = new Size(107, 15);
            LFechaIng.TabIndex = 5;
            LFechaIng.Text = "Fecha de Ingreso :";
            // 
            // LFechaRet
            // 
            LFechaRet.AutoSize = true;
            LFechaRet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LFechaRet.Location = new Point(20, 152);
            LFechaRet.Name = "LFechaRet";
            LFechaRet.Size = new Size(100, 15);
            LFechaRet.TabIndex = 6;
            LFechaRet.Text = "Fecha de Retiro :";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LNombre.Location = new Point(360, 96);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(121, 15);
            LNombre.TabIndex = 8;
            LNombre.Text = "Nombre del Cliente :";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LApellido.Location = new Point(20, 256);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(120, 15);
            LApellido.TabIndex = 9;
            LApellido.Text = "Apellido del Cliente :";
            // 
            // TApellido
            // 
            TApellido.Location = new Point(166, 254);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(160, 23);
            TApellido.TabIndex = 10;
            TApellido.TextChanged += CamposTextChanged;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(516, 94);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(160, 23);
            TNombre.TabIndex = 11;
            TNombre.TextChanged += CamposTextChanged;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TDNI
            // 
            TDNI.Location = new Point(516, 147);
            TDNI.MaxLength = 10;
            TDNI.Name = "TDNI";
            TDNI.Size = new Size(160, 23);
            TDNI.TabIndex = 13;
            TDNI.TextChanged += CamposTextChanged;
            TDNI.KeyPress += TDNI_KeyPress;
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LDNI.Location = new Point(360, 152);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(97, 15);
            LDNI.TabIndex = 14;
            LDNI.Text = "DNI del Cliente :";
            // 
            // LTel
            // 
            LTel.AutoSize = true;
            LTel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LTel.Location = new Point(354, 206);
            LTel.Name = "LTel";
            LTel.Size = new Size(124, 15);
            LTel.TabIndex = 15;
            LTel.Text = "Telefono del Cliente :";
            // 
            // LCantidad
            // 
            LCantidad.AutoSize = true;
            LCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LCantidad.Location = new Point(354, 256);
            LCantidad.Name = "LCantidad";
            LCantidad.Size = new Size(130, 15);
            LCantidad.TabIndex = 16;
            LCantidad.Text = "Cantidad de Personas :";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(516, 203);
            TTelefono.MaxLength = 10;
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(160, 23);
            TTelefono.TabIndex = 18;
            TTelefono.TextChanged += CamposTextChanged;
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // DTIngreso
            // 
            DTIngreso.Location = new Point(167, 94);
            DTIngreso.Name = "DTIngreso";
            DTIngreso.Size = new Size(160, 23);
            DTIngreso.TabIndex = 19;
            DTIngreso.TextChanged += CamposTextChanged;
            // 
            // DTRetiro
            // 
            DTRetiro.Location = new Point(167, 147);
            DTRetiro.Name = "DTRetiro";
            DTRetiro.Size = new Size(160, 23);
            DTRetiro.TabIndex = 20;
            DTRetiro.TextChanged += CamposTextChanged;
            // 
            // NCantidad
            // 
            NCantidad.Location = new Point(516, 254);
            NCantidad.Name = "NCantidad";
            NCantidad.Size = new Size(160, 23);
            NCantidad.TabIndex = 22;
            NCantidad.TextChanged += CamposTextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(680, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(83, 38);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // TBuscar
            // 
            TBuscar.Location = new Point(470, 17);
            TBuscar.Name = "TBuscar";
            TBuscar.Size = new Size(192, 23);
            TBuscar.TabIndex = 24;
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
            dataGridReserva.Columns.AddRange(new DataGridViewColumn[] { ingreso, retiro, habitacion, nombre, apellido, dni, telefono, personas, servicio });
            dataGridReserva.Dock = DockStyle.Fill;
            dataGridReserva.Location = new Point(0, 0);
            dataGridReserva.Name = "dataGridReserva";
            dataGridReserva.RowTemplate.Height = 25;
            dataGridReserva.Size = new Size(833, 149);
            dataGridReserva.TabIndex = 2;
            dataGridReserva.SelectionChanged += dataGridReserva_SelectionChanged;
            // 
            // ingreso
            // 
            ingreso.HeaderText = "Fecha de Ingreso";
            ingreso.Name = "ingreso";
            // 
            // retiro
            // 
            retiro.HeaderText = "Fecha de Retiro";
            retiro.Name = "retiro";
            // 
            // habitacion
            // 
            habitacion.HeaderText = "Habitación";
            habitacion.Name = "habitacion";
            habitacion.Width = 70;
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
            // dni
            // 
            dni.HeaderText = "DNI del Cliente";
            dni.Name = "dni";
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono del Cliente";
            telefono.Name = "telefono";
            // 
            // personas
            // 
            personas.HeaderText = "Cantidad de Personas";
            personas.Name = "personas";
            // 
            // servicio
            // 
            servicio.HeaderText = "Servicios Incluidos";
            servicio.Name = "servicio";
            servicio.Resizable = DataGridViewTriState.True;
            servicio.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.Lime;
            BGuardar.FlatStyle = FlatStyle.Popup;
            BGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BGuardar.Location = new Point(702, 122);
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
            lblNroHabitacion.Location = new Point(20, 206);
            lblNroHabitacion.Name = "lblNroHabitacion";
            lblNroHabitacion.Size = new Size(96, 15);
            lblNroHabitacion.TabIndex = 28;
            lblNroHabitacion.Text = "Nro Habitacion :";
            // 
            // txtNroHabitacion
            // 
            txtNroHabitacion.Location = new Point(166, 203);
            txtNroHabitacion.Name = "txtNroHabitacion";
            txtNroHabitacion.Size = new Size(160, 23);
            txtNroHabitacion.TabIndex = 29;
            txtNroHabitacion.KeyPress += txtNroHabitacion_KeyPress;
            // 
            // BServicios
            // 
            BServicios.BackColor = Color.Gold;
            BServicios.FlatStyle = FlatStyle.Popup;
            BServicios.Location = new Point(702, 66);
            BServicios.Name = "BServicios";
            BServicios.Size = new Size(113, 45);
            BServicios.TabIndex = 30;
            BServicios.Text = "Agregar Servicios";
            BServicios.UseVisualStyleBackColor = false;
            BServicios.Click += BServicios_Click;
            // 
            // ListadoDeReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 465);
            Controls.Add(BServicios);
            Controls.Add(txtNroHabitacion);
            Controls.Add(lblNroHabitacion);
            Controls.Add(iconPictureBox1);
            Controls.Add(BGuardar);
            Controls.Add(panel1);
            Controls.Add(TBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(NCantidad);
            Controls.Add(DTRetiro);
            Controls.Add(DTIngreso);
            Controls.Add(TTelefono);
            Controls.Add(LCantidad);
            Controls.Add(LTel);
            Controls.Add(LDNI);
            Controls.Add(TDNI);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
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
        private Label LNombre;
        private Label LApellido;
        private TextBox TApellido;
        private TextBox TNombre;
        private TextBox TDNI;
        private Label LDNI;
        private Label LTel;
        private Label LCantidad;
        private TextBox TTelefono;
        private DateTimePicker DTIngreso;
        private DateTimePicker DTRetiro;
        private NumericUpDown NCantidad;
        private Button btnBuscar;
        private TextBox TBuscar;
        private Panel panel1;
        private Button BGuardar;
        private DataGridView dataGridReserva;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblNroHabitacion;
        private TextBox txtNroHabitacion;
        private Button BServicios;
        private DataGridViewTextBoxColumn ingreso;
        private DataGridViewTextBoxColumn retiro;
        private DataGridViewTextBoxColumn habitacion;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn personas;
        private DataGridViewComboBoxColumn servicio;
    }
}