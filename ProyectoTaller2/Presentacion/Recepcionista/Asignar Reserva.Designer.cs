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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)NCantidad).BeginInit();
            SuspendLayout();
            // 
            // NCantidad
            // 
            NCantidad.Location = new Point(490, 258);
            NCantidad.Name = "NCantidad";
            NCantidad.Size = new Size(118, 23);
            NCantidad.TabIndex = 39;
            // 
            // CBServicio
            // 
            CBServicio.FormattingEnabled = true;
            CBServicio.Items.AddRange(new object[] { "[Seleccione]", "Desayuno", "Televisión", "Despertador" });
            CBServicio.Location = new Point(472, 178);
            CBServicio.Name = "CBServicio";
            CBServicio.Size = new Size(160, 23);
            CBServicio.TabIndex = 38;
            // 
            // DTRetiro
            // 
            DTRetiro.Location = new Point(152, 123);
            DTRetiro.Name = "DTRetiro";
            DTRetiro.Size = new Size(160, 23);
            DTRetiro.TabIndex = 37;
            // 
            // DTIngreso
            // 
            DTIngreso.Location = new Point(152, 74);
            DTIngreso.Name = "DTIngreso";
            DTIngreso.Size = new Size(160, 23);
            DTIngreso.TabIndex = 36;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(490, 115);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(160, 23);
            TTelefono.TabIndex = 35;
            // 
            // LServicio
            // 
            LServicio.AutoSize = true;
            LServicio.Location = new Point(348, 186);
            LServicio.Name = "LServicio";
            LServicio.Size = new Size(105, 15);
            LServicio.TabIndex = 34;
            LServicio.Text = "Servicio al Cuarto :";
            // 
            // LCantidad
            // 
            LCantidad.AutoSize = true;
            LCantidad.Location = new Point(357, 230);
            LCantidad.Name = "LCantidad";
            LCantidad.Size = new Size(127, 15);
            LCantidad.TabIndex = 33;
            LCantidad.Text = "Cantidad de Personas :";
            // 
            // LTel
            // 
            LTel.AutoSize = true;
            LTel.Location = new Point(357, 123);
            LTel.Name = "LTel";
            LTel.Size = new Size(117, 15);
            LTel.TabIndex = 32;
            LTel.Text = "Telefono del Cliente :";
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Location = new Point(361, 74);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(92, 15);
            LDNI.TabIndex = 31;
            LDNI.Text = "DNI del Cliente :";
            // 
            // TDNI
            // 
            TDNI.Location = new Point(472, 71);
            TDNI.Name = "TDNI";
            TDNI.Size = new Size(160, 23);
            TDNI.TabIndex = 30;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(152, 170);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(160, 23);
            TNombre.TabIndex = 29;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(152, 222);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(160, 23);
            TApellido.TabIndex = 28;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(10, 225);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(116, 15);
            LApellido.TabIndex = 27;
            LApellido.Text = "Apellido del Cliente :";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(10, 173);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(116, 15);
            LNombre.TabIndex = 26;
            LNombre.Text = "Nombre del Cliente :";
            // 
            // LFechaRet
            // 
            LFechaRet.AutoSize = true;
            LFechaRet.Location = new Point(10, 129);
            LFechaRet.Name = "LFechaRet";
            LFechaRet.Size = new Size(94, 15);
            LFechaRet.TabIndex = 25;
            LFechaRet.Text = "Fecha de Retiro :";
            // 
            // LFechaIng
            // 
            LFechaIng.AutoSize = true;
            LFechaIng.Location = new Point(10, 80);
            LFechaIng.Name = "LFechaIng";
            LFechaIng.Size = new Size(102, 15);
            LFechaIng.TabIndex = 24;
            LFechaIng.Text = "Fecha de Ingreso :";
            // 
            // BReservar
            // 
            BReservar.BackColor = Color.Lime;
            BReservar.FlatStyle = FlatStyle.Popup;
            BReservar.Location = new Point(126, 313);
            BReservar.Name = "BReservar";
            BReservar.Size = new Size(113, 44);
            BReservar.TabIndex = 23;
            BReservar.Text = "Reservar";
            BReservar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 28);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 40;
            label1.Text = "falta detalle habitacion";
            // 
            // Asignar_Reserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 441);
            Controls.Add(label1);
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
            Name = "Asignar_Reserva";
            Text = "Asignar_Reserva";
            ((System.ComponentModel.ISupportInitialize)NCantidad).EndInit();
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
        private Label label1;
    }
}