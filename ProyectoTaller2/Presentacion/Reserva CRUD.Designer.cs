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
            BRegistrar = new Button();
            BEditar = new Button();
            BEliminar = new Button();
            LFechaIng = new Label();
            LFechaRet = new Label();
            LHab = new Label();
            LNombre = new Label();
            LApellido = new Label();
            TApellido = new TextBox();
            TNombre = new TextBox();
            THabitacion = new TextBox();
            TDNI = new TextBox();
            LDNI = new Label();
            LTel = new Label();
            LCantidad = new Label();
            LServicio = new Label();
            TTelefono = new TextBox();
            DTIngreso = new DateTimePicker();
            DTRetiro = new DateTimePicker();
            CBServicio = new ComboBox();
            NCantidad = new NumericUpDown();
            BBuscar = new Button();
            TBuscar = new TextBox();
            panel1 = new Panel();
            dataGridReserva = new DataGridView();
            BGuardar = new Button();
            ingreso = new DataGridViewTextBoxColumn();
            retiro = new DataGridViewTextBoxColumn();
            habitacion = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            personas = new DataGridViewTextBoxColumn();
            servicio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)NCantidad).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReserva).BeginInit();
            SuspendLayout();
            // 
            // LReservas
            // 
            LReservas.AutoEllipsis = true;
            LReservas.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LReservas.ForeColor = Color.White;
            LReservas.Location = new Point(25, 3);
            LReservas.Name = "LReservas";
            LReservas.Size = new Size(275, 46);
            LReservas.TabIndex = 0;
            LReservas.Text = "Reserva CRUD";
            // 
            // BRegistrar
            // 
            BRegistrar.BackColor = Color.Lime;
            BRegistrar.FlatStyle = FlatStyle.Popup;
            BRegistrar.Location = new Point(703, 81);
            BRegistrar.Name = "BRegistrar";
            BRegistrar.Size = new Size(113, 44);
            BRegistrar.TabIndex = 2;
            BRegistrar.Text = "Registrar";
            BRegistrar.UseVisualStyleBackColor = false;
            BRegistrar.Click += BRegistrar_Click;
            // 
            // BEditar
            // 
            BEditar.BackColor = Color.DodgerBlue;
            BEditar.FlatStyle = FlatStyle.Popup;
            BEditar.Location = new Point(703, 144);
            BEditar.Name = "BEditar";
            BEditar.Size = new Size(113, 46);
            BEditar.TabIndex = 3;
            BEditar.Text = "Editar";
            BEditar.UseVisualStyleBackColor = false;
            BEditar.Click += BEditar_Click;
            // 
            // BEliminar
            // 
            BEliminar.BackColor = Color.Red;
            BEliminar.FlatStyle = FlatStyle.Popup;
            BEliminar.Location = new Point(703, 203);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(113, 46);
            BEliminar.TabIndex = 4;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = false;
            BEliminar.Click += BEliminar_Click;
            // 
            // LFechaIng
            // 
            LFechaIng.AutoSize = true;
            LFechaIng.Location = new Point(25, 68);
            LFechaIng.Name = "LFechaIng";
            LFechaIng.Size = new Size(102, 15);
            LFechaIng.TabIndex = 5;
            LFechaIng.Text = "Fecha de Ingreso :";
            // 
            // LFechaRet
            // 
            LFechaRet.AutoSize = true;
            LFechaRet.Location = new Point(25, 107);
            LFechaRet.Name = "LFechaRet";
            LFechaRet.Size = new Size(94, 15);
            LFechaRet.TabIndex = 6;
            LFechaRet.Text = "Fecha de Retiro :";
            // 
            // LHab
            // 
            LHab.AutoSize = true;
            LHab.Location = new Point(25, 147);
            LHab.Name = "LHab";
            LHab.Size = new Size(71, 15);
            LHab.TabIndex = 7;
            LHab.Text = "Habitación :";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(25, 193);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(116, 15);
            LNombre.TabIndex = 8;
            LNombre.Text = "Nombre del Cliente :";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(25, 234);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(116, 15);
            LApellido.TabIndex = 9;
            LApellido.Text = "Apellido del Cliente :";
            // 
            // TApellido
            // 
            TApellido.Location = new Point(157, 231);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(160, 23);
            TApellido.TabIndex = 10;
            TApellido.TextChanged += CamposTextChanged;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(157, 190);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(160, 23);
            TNombre.TabIndex = 11;
            TNombre.TextChanged += CamposTextChanged;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // THabitacion
            // 
            THabitacion.Location = new Point(157, 144);
            THabitacion.Name = "THabitacion";
            THabitacion.Size = new Size(160, 23);
            THabitacion.TabIndex = 12;
            THabitacion.TextChanged += CamposTextChanged;
            THabitacion.KeyPress += THabitacion_KeyPress;
            // 
            // TDNI
            // 
            TDNI.Location = new Point(505, 88);
            TDNI.Name = "TDNI";
            TDNI.Size = new Size(160, 23);
            TDNI.TabIndex = 13;
            TDNI.TextChanged += CamposTextChanged;
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Location = new Point(354, 91);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(92, 15);
            LDNI.TabIndex = 14;
            LDNI.Text = "DNI del Cliente :";
            // 
            // LTel
            // 
            LTel.AutoSize = true;
            LTel.Location = new Point(354, 131);
            LTel.Name = "LTel";
            LTel.Size = new Size(117, 15);
            LTel.TabIndex = 15;
            LTel.Text = "Telefono del Cliente :";
            // 
            // LCantidad
            // 
            LCantidad.AutoSize = true;
            LCantidad.Location = new Point(354, 175);
            LCantidad.Name = "LCantidad";
            LCantidad.Size = new Size(127, 15);
            LCantidad.TabIndex = 16;
            LCantidad.Text = "Cantidad de Personas :";
            // 
            // LServicio
            // 
            LServicio.AutoSize = true;
            LServicio.Location = new Point(354, 215);
            LServicio.Name = "LServicio";
            LServicio.Size = new Size(105, 15);
            LServicio.TabIndex = 17;
            LServicio.Text = "Servicio al Cuarto :";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(505, 128);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(160, 23);
            TTelefono.TabIndex = 18;
            TTelefono.TextChanged += CamposTextChanged;
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // DTIngreso
            // 
            DTIngreso.Location = new Point(157, 62);
            DTIngreso.Name = "DTIngreso";
            DTIngreso.Size = new Size(160, 23);
            DTIngreso.TabIndex = 19;
            DTIngreso.TextChanged += CamposTextChanged;
            // 
            // DTRetiro
            // 
            DTRetiro.Location = new Point(157, 102);
            DTRetiro.Name = "DTRetiro";
            DTRetiro.Size = new Size(160, 23);
            DTRetiro.TabIndex = 20;
            DTRetiro.TextChanged += CamposTextChanged;
            // 
            // CBServicio
            // 
            CBServicio.FormattingEnabled = true;
            CBServicio.Items.AddRange(new object[] { "Desayuno", "Televisión", "Despertador" });
            CBServicio.Location = new Point(505, 212);
            CBServicio.Name = "CBServicio";
            CBServicio.Size = new Size(160, 23);
            CBServicio.TabIndex = 21;
            CBServicio.TextChanged += CamposTextChanged;
            // 
            // NCantidad
            // 
            NCantidad.Location = new Point(505, 173);
            NCantidad.Name = "NCantidad";
            NCantidad.Size = new Size(160, 23);
            NCantidad.TabIndex = 22;
            NCantidad.TextChanged += CamposTextChanged;
            // 
            // BBuscar
            // 
            BBuscar.BackColor = Color.White;
            BBuscar.FlatStyle = FlatStyle.Popup;
            BBuscar.Location = new Point(596, 17);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(83, 38);
            BBuscar.TabIndex = 23;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = false;
            // 
            // TBuscar
            // 
            TBuscar.Location = new Point(390, 26);
            TBuscar.Name = "TBuscar";
            TBuscar.Size = new Size(156, 23);
            TBuscar.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridReserva);
            panel1.Location = new Point(0, 270);
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
            // BGuardar
            // 
            BGuardar.BackColor = Color.Lime;
            BGuardar.FlatStyle = FlatStyle.Popup;
            BGuardar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BGuardar.Location = new Point(703, 81);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(113, 44);
            BGuardar.TabIndex = 26;
            BGuardar.Text = "Guardar Cambios";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
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
            personas.Width = 60;
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
            ClientSize = new Size(833, 390);
            Controls.Add(BGuardar);
            Controls.Add(panel1);
            Controls.Add(TBuscar);
            Controls.Add(BBuscar);
            Controls.Add(NCantidad);
            Controls.Add(CBServicio);
            Controls.Add(DTRetiro);
            Controls.Add(DTIngreso);
            Controls.Add(TTelefono);
            Controls.Add(LServicio);
            Controls.Add(LCantidad);
            Controls.Add(LTel);
            Controls.Add(LDNI);
            Controls.Add(TDNI);
            Controls.Add(THabitacion);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(LHab);
            Controls.Add(LFechaRet);
            Controls.Add(LFechaIng);
            Controls.Add(BEliminar);
            Controls.Add(BEditar);
            Controls.Add(BRegistrar);
            Controls.Add(LReservas);
            Name = "Reservas";
            Text = "Reservas";
            Load += Reservas_Load;
            ((System.ComponentModel.ISupportInitialize)NCantidad).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridReserva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewRow filaSeleccionada = null;

        private Label LReservas;
        private Button BRegistrar;
        private Button BEditar;
        private Button BEliminar;
        private Label LFechaIng;
        private Label LFechaRet;
        private Label LHab;
        private Label LNombre;
        private Label LApellido;
        private TextBox TApellido;
        private TextBox TNombre;
        private TextBox THabitacion;
        private TextBox TDNI;
        private Label LDNI;
        private Label LTel;
        private Label LCantidad;
        private Label LServicio;
        private TextBox TTelefono;
        private DateTimePicker DTIngreso;
        private DateTimePicker DTRetiro;
        private ComboBox CBServicio;
        private NumericUpDown NCantidad;
        private Button BBuscar;
        private TextBox TBuscar;
        private Panel panel1;
        private DataGridView dataGridReserva;
        private Button BGuardar;
        private DataGridViewTextBoxColumn ingreso;
        private DataGridViewTextBoxColumn retiro;
        private DataGridViewTextBoxColumn habitacion;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn personas;
        private DataGridViewTextBoxColumn servicio;
    }
}