namespace ProyectoTaller2.CapaPresentacion.Recepcionista
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
            DTRetiro = new DateTimePicker();
            DTIngreso = new DateTimePicker();
            LCantidad = new Label();
            LFechaRet = new Label();
            LFechaIng = new Label();
            BReservar = new Button();
            panel1 = new Panel();
            txtIDhab = new TextBox();
            txtPrecio = new TextBox();
            txtPiso = new TextBox();
            txtCantCamas = new TextBox();
            txtCategoria = new TextBox();
            txtNroHabitacion = new TextBox();
            lblDetalleHabitacion = new Label();
            lblCategoria = new Label();
            lblPrecio = new Label();
            lblNroHabitacion = new Label();
            lblPiso = new Label();
            lblIDHabitacion = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            cboboxCliente = new ComboBox();
            listServicios = new ListBox();
            CBServicios = new ComboBox();
            label1 = new Label();
            btnServicio = new Button();
            ((System.ComponentModel.ISupportInitialize)NCantidad).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NCantidad
            // 
            NCantidad.Location = new Point(197, 398);
            NCantidad.Name = "NCantidad";
            NCantidad.Size = new Size(134, 27);
            NCantidad.TabIndex = 39;
            // 
            // DTRetiro
            // 
            DTRetiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DTRetiro.Location = new Point(171, 333);
            DTRetiro.Name = "DTRetiro";
            DTRetiro.Size = new Size(160, 27);
            DTRetiro.TabIndex = 37;
            DTRetiro.ValueChanged += DTRetiro_ValueChanged;
            // 
            // DTIngreso
            // 
            DTIngreso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DTIngreso.Location = new Point(171, 274);
            DTIngreso.Name = "DTIngreso";
            DTIngreso.Size = new Size(160, 27);
            DTIngreso.TabIndex = 36;
            DTIngreso.ValueChanged += DTIngreso_ValueChanged;
            // 
            // LCantidad
            // 
            LCantidad.AutoSize = true;
            LCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LCantidad.Location = new Point(24, 398);
            LCantidad.Name = "LCantidad";
            LCantidad.Size = new Size(167, 20);
            LCantidad.TabIndex = 33;
            LCantidad.Text = "Cantidad de Personas :";
            // 
            // LFechaRet
            // 
            LFechaRet.AutoSize = true;
            LFechaRet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LFechaRet.Location = new Point(24, 333);
            LFechaRet.Name = "LFechaRet";
            LFechaRet.Size = new Size(125, 20);
            LFechaRet.TabIndex = 25;
            LFechaRet.Text = "Fecha de Retiro :";
            // 
            // LFechaIng
            // 
            LFechaIng.AutoSize = true;
            LFechaIng.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LFechaIng.Location = new Point(24, 274);
            LFechaIng.Name = "LFechaIng";
            LFechaIng.Size = new Size(135, 20);
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
            panel1.Controls.Add(txtIDhab);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtPiso);
            panel1.Controls.Add(txtCantCamas);
            panel1.Controls.Add(txtCategoria);
            panel1.Controls.Add(txtNroHabitacion);
            panel1.Controls.Add(lblDetalleHabitacion);
            panel1.Controls.Add(lblCategoria);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblNroHabitacion);
            panel1.Controls.Add(lblPiso);
            panel1.Controls.Add(lblIDHabitacion);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 137);
            panel1.TabIndex = 40;
            // 
            // txtIDhab
            // 
            txtIDhab.Location = new Point(652, 3);
            txtIDhab.Name = "txtIDhab";
            txtIDhab.ReadOnly = true;
            txtIDhab.Size = new Size(35, 27);
            txtIDhab.TabIndex = 59;
            txtIDhab.Visible = false;
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Location = new Point(537, 80);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(100, 20);
            txtPrecio.TabIndex = 58;
            // 
            // txtPiso
            // 
            txtPiso.BorderStyle = BorderStyle.None;
            txtPiso.Location = new Point(537, 44);
            txtPiso.Name = "txtPiso";
            txtPiso.ReadOnly = true;
            txtPiso.Size = new Size(100, 20);
            txtPiso.TabIndex = 57;
            // 
            // txtCantCamas
            // 
            txtCantCamas.BorderStyle = BorderStyle.None;
            txtCantCamas.Location = new Point(537, 12);
            txtCantCamas.Name = "txtCantCamas";
            txtCantCamas.ReadOnly = true;
            txtCantCamas.Size = new Size(100, 20);
            txtCantCamas.TabIndex = 56;
            // 
            // txtCategoria
            // 
            txtCategoria.BorderStyle = BorderStyle.None;
            txtCategoria.Location = new Point(162, 97);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(100, 20);
            txtCategoria.TabIndex = 55;
            // 
            // txtNroHabitacion
            // 
            txtNroHabitacion.BorderStyle = BorderStyle.None;
            txtNroHabitacion.Location = new Point(162, 62);
            txtNroHabitacion.Name = "txtNroHabitacion";
            txtNroHabitacion.ReadOnly = true;
            txtNroHabitacion.Size = new Size(100, 20);
            txtNroHabitacion.TabIndex = 54;
            // 
            // lblDetalleHabitacion
            // 
            lblDetalleHabitacion.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblDetalleHabitacion.ForeColor = Color.White;
            lblDetalleHabitacion.Location = new Point(21, 9);
            lblDetalleHabitacion.Name = "lblDetalleHabitacion";
            lblDetalleHabitacion.Size = new Size(198, 50);
            lblDetalleHabitacion.TabIndex = 53;
            lblDetalleHabitacion.Text = "Habitacion :";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.Location = new Point(24, 97);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(84, 20);
            lblCategoria.TabIndex = 52;
            lblCategoria.Text = "Categoria :";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(374, 78);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 20);
            lblPrecio.TabIndex = 51;
            lblPrecio.Text = "Precio :";
            // 
            // lblNroHabitacion
            // 
            lblNroHabitacion.AutoSize = true;
            lblNroHabitacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroHabitacion.Location = new Point(24, 62);
            lblNroHabitacion.Name = "lblNroHabitacion";
            lblNroHabitacion.Size = new Size(123, 20);
            lblNroHabitacion.TabIndex = 49;
            lblNroHabitacion.Text = "Nro Habitacion :";
            // 
            // lblPiso
            // 
            lblPiso.AutoSize = true;
            lblPiso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPiso.Location = new Point(374, 42);
            lblPiso.Name = "lblPiso";
            lblPiso.Size = new Size(46, 20);
            lblPiso.TabIndex = 48;
            lblPiso.Text = "Piso :";
            // 
            // lblIDHabitacion
            // 
            lblIDHabitacion.AutoSize = true;
            lblIDHabitacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIDHabitacion.Location = new Point(374, 10);
            lblIDHabitacion.Name = "lblIDHabitacion";
            lblIDHabitacion.Size = new Size(120, 20);
            lblIDHabitacion.TabIndex = 47;
            lblIDHabitacion.Text = "Cant de Camas :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-11, 156);
            label2.Name = "label2";
            label2.Size = new Size(735, 20);
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
            // cboboxCliente
            // 
            cboboxCliente.FormattingEnabled = true;
            cboboxCliente.Location = new Point(54, 219);
            cboboxCliente.Name = "cboboxCliente";
            cboboxCliente.Size = new Size(233, 28);
            cboboxCliente.TabIndex = 43;
            // 
            // listServicios
            // 
            listServicios.FormattingEnabled = true;
            listServicios.ItemHeight = 20;
            listServicios.Location = new Point(393, 288);
            listServicios.Name = "listServicios";
            listServicios.Size = new Size(244, 104);
            listServicios.TabIndex = 44;
            // 
            // CBServicios
            // 
            CBServicios.FormattingEnabled = true;
            CBServicios.Location = new Point(393, 244);
            CBServicios.Name = "CBServicios";
            CBServicios.Size = new Size(244, 28);
            CBServicios.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 196);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 46;
            label1.Text = "Seleccione Cliente :";
            // 
            // btnServicio
            // 
            btnServicio.Location = new Point(393, 398);
            btnServicio.Name = "btnServicio";
            btnServicio.Size = new Size(90, 45);
            btnServicio.TabIndex = 47;
            btnServicio.Text = "Agregar";
            btnServicio.UseVisualStyleBackColor = true;
            btnServicio.Click += btnServicio_Click;
            // 
            // Asignar_Reserva
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(699, 531);
            Controls.Add(btnServicio);
            Controls.Add(label1);
            Controls.Add(CBServicios);
            Controls.Add(listServicios);
            Controls.Add(cboboxCliente);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(NCantidad);
            Controls.Add(DTRetiro);
            Controls.Add(DTIngreso);
            Controls.Add(LCantidad);
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
        private DateTimePicker DTRetiro;
        private DateTimePicker DTIngreso;
        private Label LCantidad;
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
        private TextBox txtPrecio;
        private TextBox txtPiso;
        private TextBox txtCantCamas;
        private TextBox txtCategoria;
        private TextBox txtNroHabitacion;
        private ComboBox cboboxCliente;
        private TextBox txtIDhab;
        private ListBox listServicios;
        private ComboBox CBServicios;
        private Label label1;
        private Button btnServicio;
    }
}