namespace ProyectoTaller2.Presentacion.Recepcionista
{
    partial class Asignar_Reserva
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
            NCantidad = new NumericUpDown();
            CBServicio = new ComboBox();
            DTRetiro = new DateTimePicker();
            DTIngreso = new DateTimePicker();
            TTelefono = new TextBox();
            LServicio = new Label();
            LCantidad = new Label();
            LTel = new Label();
            LDNI = new Label();
            TDNI = new TextBox();
            TNombre = new TextBox();
            TApellido = new TextBox();
            LApellido = new Label();
            LNombre = new Label();
            LFechaRet = new Label();
            LFechaIng = new Label();
            BReservar = new Button();
            panel1 = new Panel();
            lblDetalleHabitacion = new Label();
            lblCategoria = new Label();
            lblPrecio = new Label();
            lblNroHabitacion = new Label();
            lblPiso = new Label();
            lblIDHabitacion = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)NCantidad).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NCantidad
            // 
            NCantidad.Location = new Point(519, 392);
            NCantidad.Name = "NCantidad";
            NCantidad.Size = new Size(160, 23);
            NCantidad.TabIndex = 39;
            // 
            // CBServicio
            // 
            CBServicio.FormattingEnabled = true;
            CBServicio.Items.AddRange(new object[] { "[Seleccione]", "Desayuno", "Televisión", "Despertador" });
            CBServicio.Location = new Point(519, 337);
            CBServicio.Name = "CBServicio";
            CBServicio.Size = new Size(160, 23);
            CBServicio.TabIndex = 38;
            // 
            // DTRetiro
            // 
            DTRetiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DTRetiro.Location = new Point(159, 279);
            DTRetiro.Name = "DTRetiro";
            DTRetiro.Size = new Size(160, 23);
            DTRetiro.TabIndex = 37;
            DTRetiro.ValueChanged += DTRetiro_ValueChanged;
            // 
            // DTIngreso
            // 
            DTIngreso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DTIngreso.Location = new Point(159, 235);
            DTIngreso.Name = "DTIngreso";
            DTIngreso.Size = new Size(160, 23);
            DTIngreso.TabIndex = 36;
            DTIngreso.ValueChanged += DTIngreso_ValueChanged;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(519, 285);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(160, 23);
            TTelefono.TabIndex = 35;
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // LServicio
            // 
            LServicio.AutoSize = true;
            LServicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LServicio.Location = new Point(357, 339);
            LServicio.Name = "LServicio";
            LServicio.Size = new Size(110, 15);
            LServicio.TabIndex = 34;
            LServicio.Text = "Servicio al Cuarto :";
            // 
            // LCantidad
            // 
            LCantidad.AutoSize = true;
            LCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LCantidad.Location = new Point(357, 400);
            LCantidad.Name = "LCantidad";
            LCantidad.Size = new Size(130, 15);
            LCantidad.TabIndex = 33;
            LCantidad.Text = "Cantidad de Personas :";
            // 
            // LTel
            // 
            LTel.AutoSize = true;
            LTel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LTel.Location = new Point(357, 287);
            LTel.Name = "LTel";
            LTel.Size = new Size(124, 15);
            LTel.TabIndex = 32;
            LTel.Text = "Telefono del Cliente :";
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LDNI.Location = new Point(357, 237);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(97, 15);
            LDNI.TabIndex = 31;
            LDNI.Text = "DNI del Cliente :";
            // 
            // TDNI
            // 
            TDNI.Location = new Point(519, 235);
            TDNI.Name = "TDNI";
            TDNI.Size = new Size(160, 23);
            TDNI.TabIndex = 30;
            TDNI.KeyPress += TDNI_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TNombre.Location = new Point(159, 334);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(160, 23);
            TNombre.TabIndex = 29;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TApellido.Location = new Point(159, 397);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(160, 23);
            TApellido.TabIndex = 28;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LApellido.Location = new Point(12, 400);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(120, 15);
            LApellido.TabIndex = 27;
            LApellido.Text = "Apellido del Cliente :";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LNombre.Location = new Point(12, 336);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(121, 15);
            LNombre.TabIndex = 26;
            LNombre.Text = "Nombre del Cliente :";
            // 
            // LFechaRet
            // 
            LFechaRet.AutoSize = true;
            LFechaRet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LFechaRet.Location = new Point(12, 284);
            LFechaRet.Name = "LFechaRet";
            LFechaRet.Size = new Size(100, 15);
            LFechaRet.TabIndex = 25;
            LFechaRet.Text = "Fecha de Retiro :";
            // 
            // LFechaIng
            // 
            LFechaIng.AutoSize = true;
            LFechaIng.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LFechaIng.Location = new Point(12, 241);
            LFechaIng.Name = "LFechaIng";
            LFechaIng.Size = new Size(107, 15);
            LFechaIng.TabIndex = 24;
            LFechaIng.Text = "Fecha de Ingreso :";
            // 
            // BReservar
            // 
            BReservar.BackColor = Color.Lime;
            BReservar.FlatStyle = FlatStyle.Popup;
            BReservar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BReservar.Location = new Point(206, 463);
            BReservar.Name = "BReservar";
            BReservar.Size = new Size(113, 44);
            BReservar.TabIndex = 23;
            BReservar.Text = "Reservar";
            BReservar.UseVisualStyleBackColor = false;
            BReservar.Click += BReservar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDetalleHabitacion);
            panel1.Controls.Add(lblCategoria);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblNroHabitacion);
            panel1.Controls.Add(lblPiso);
            panel1.Controls.Add(lblIDHabitacion);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 189);
            panel1.TabIndex = 40;
            // 
            // lblDetalleHabitacion
            // 
            lblDetalleHabitacion.AutoSize = true;
            lblDetalleHabitacion.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblDetalleHabitacion.ForeColor = Color.White;
            lblDetalleHabitacion.Location = new Point(12, 20);
            lblDetalleHabitacion.Name = "lblDetalleHabitacion";
            lblDetalleHabitacion.Size = new Size(270, 31);
            lblDetalleHabitacion.TabIndex = 53;
            lblDetalleHabitacion.Text = "Detalle Habitacion :";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.Location = new Point(301, 90);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(66, 15);
            lblCategoria.TabIndex = 52;
            lblCategoria.Text = "Categoria :";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(301, 156);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(48, 15);
            lblPrecio.TabIndex = 51;
            lblPrecio.Text = "Precio :";
            // 
            // lblNroHabitacion
            // 
            lblNroHabitacion.AutoSize = true;
            lblNroHabitacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroHabitacion.Location = new Point(301, 60);
            lblNroHabitacion.Name = "lblNroHabitacion";
            lblNroHabitacion.Size = new Size(96, 15);
            lblNroHabitacion.TabIndex = 49;
            lblNroHabitacion.Text = "Nro Habitacion :";
            // 
            // lblPiso
            // 
            lblPiso.AutoSize = true;
            lblPiso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPiso.Location = new Point(301, 120);
            lblPiso.Name = "lblPiso";
            lblPiso.Size = new Size(35, 15);
            lblPiso.TabIndex = 48;
            lblPiso.Text = "Piso :";
            // 
            // lblIDHabitacion
            // 
            lblIDHabitacion.AutoSize = true;
            lblIDHabitacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIDHabitacion.Location = new Point(301, 26);
            lblIDHabitacion.Name = "lblIDHabitacion";
            lblIDHabitacion.Size = new Size(88, 15);
            lblIDHabitacion.TabIndex = 47;
            lblIDHabitacion.Text = "ID Habitacion :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 192);
            label2.Name = "label2";
            label2.Size = new Size(612, 15);
            label2.TabIndex = 41;
            label2.Text = "_________________________________________________________________________________________________________________________";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(374, 463);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 44);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Asignar_Reserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(699, 531);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(panel1);
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
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(LFechaRet);
            Controls.Add(LFechaIng);
            Controls.Add(BReservar);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Asignar_Reserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignar_Reserva";
            ((System.ComponentModel.ISupportInitialize)NCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NCantidad;
        private ComboBox CBServicio;
        private DateTimePicker DTRetiro;
        private DateTimePicker DTIngreso;
        private TextBox TTelefono;
        private Label LServicio;
        private Label LCantidad;
        private Label LTel;
        private Label LDNI;
        private TextBox TDNI;
        private TextBox TNombre;
        private TextBox TApellido;
        private Label LApellido;
        private Label LNombre;
        private Label LFechaRet;
        private Label LFechaIng;
        private Button BReservar;
        private Panel panel1;
        private Label lblDetalleHabitacion;
        private Label lblCategoria;
        private Label lblPrecio;
        private Label lblNroHabitacion;
        private Label lblPiso;
        private Label lblIDHabitacion;
        private Label label2;
        private Button btnCancelar;
    }
}