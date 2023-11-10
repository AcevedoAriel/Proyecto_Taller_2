using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion.Recepcionista
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
            this.LReservas = new System.Windows.Forms.Label();
            this.BEditar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.LFechaIng = new System.Windows.Forms.Label();
            this.LFechaRet = new System.Windows.Forms.Label();
            this.LCantidad = new System.Windows.Forms.Label();
            this.DTIngreso = new System.Windows.Forms.DateTimePicker();
            this.DTRetiro = new System.Windows.Forms.DateTimePicker();
            this.NCantidad = new System.Windows.Forms.NumericUpDown();
            this.TBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridReserva = new System.Windows.Forms.DataGridView();
            this.BGuardar = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblNroHabitacion = new System.Windows.Forms.Label();
            this.txtNroHabitacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LReservas
            // 
            this.LReservas.AutoEllipsis = true;
            this.LReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LReservas.ForeColor = System.Drawing.Color.White;
            this.LReservas.Location = new System.Drawing.Point(117, 8);
            this.LReservas.Name = "LReservas";
            this.LReservas.Size = new System.Drawing.Size(441, 46);
            this.LReservas.TabIndex = 0;
            this.LReservas.Text = "Gestión Reservas";
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BEditar.Location = new System.Drawing.Point(702, 153);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(113, 45);
            this.BEditar.TabIndex = 3;
            this.BEditar.Text = "Editar";
            this.BEditar.UseVisualStyleBackColor = false;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.Color.Red;
            this.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BEliminar.Location = new System.Drawing.Point(702, 214);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(113, 45);
            this.BEliminar.TabIndex = 4;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = false;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // LFechaIng
            // 
            this.LFechaIng.AutoSize = true;
            this.LFechaIng.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LFechaIng.Location = new System.Drawing.Point(20, 96);
            this.LFechaIng.Name = "LFechaIng";
            this.LFechaIng.Size = new System.Drawing.Size(107, 15);
            this.LFechaIng.TabIndex = 5;
            this.LFechaIng.Text = "Fecha de Ingreso :";
            // 
            // LFechaRet
            // 
            this.LFechaRet.AutoSize = true;
            this.LFechaRet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LFechaRet.Location = new System.Drawing.Point(20, 152);
            this.LFechaRet.Name = "LFechaRet";
            this.LFechaRet.Size = new System.Drawing.Size(100, 15);
            this.LFechaRet.TabIndex = 6;
            this.LFechaRet.Text = "Fecha de Retiro :";
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LCantidad.Location = new System.Drawing.Point(367, 154);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(130, 15);
            this.LCantidad.TabIndex = 16;
            this.LCantidad.Text = "Cantidad de Personas :";
            // 
            // DTIngreso
            // 
            this.DTIngreso.Location = new System.Drawing.Point(167, 94);
            this.DTIngreso.Name = "DTIngreso";
            this.DTIngreso.Size = new System.Drawing.Size(160, 23);
            this.DTIngreso.TabIndex = 19;
            // 
            // DTRetiro
            // 
            this.DTRetiro.Location = new System.Drawing.Point(167, 147);
            this.DTRetiro.Name = "DTRetiro";
            this.DTRetiro.Size = new System.Drawing.Size(160, 23);
            this.DTRetiro.TabIndex = 20;
            // 
            // NCantidad
            // 
            this.NCantidad.Location = new System.Drawing.Point(586, 150);
            this.NCantidad.Name = "NCantidad";
            this.NCantidad.Size = new System.Drawing.Size(87, 23);
            this.NCantidad.TabIndex = 22;
            // 
            // TBuscar
            // 
            this.TBuscar.Location = new System.Drawing.Point(356, 232);
            this.TBuscar.Name = "TBuscar";
            this.TBuscar.Size = new System.Drawing.Size(192, 23);
            this.TBuscar.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridReserva);
            this.panel1.Location = new System.Drawing.Point(1, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 149);
            this.panel1.TabIndex = 25;
            // 
            // dataGridReserva
            // 
            this.dataGridReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridReserva.Location = new System.Drawing.Point(0, 0);
            this.dataGridReserva.Name = "dataGridReserva";
            this.dataGridReserva.RowHeadersWidth = 51;
            this.dataGridReserva.RowTemplate.Height = 25;
            this.dataGridReserva.Size = new System.Drawing.Size(833, 149);
            this.dataGridReserva.TabIndex = 2;
            this.dataGridReserva.SelectionChanged += new System.EventHandler(this.dataGridReserva_SelectionChanged);
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.Lime;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BGuardar.Location = new System.Drawing.Point(702, 94);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(113, 45);
            this.BGuardar.TabIndex = 26;
            this.BGuardar.Text = "Guardar Cambios";
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 85;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(85, 85);
            this.iconPictureBox1.TabIndex = 27;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblNroHabitacion
            // 
            this.lblNroHabitacion.AutoSize = true;
            this.lblNroHabitacion.Location = new System.Drawing.Point(367, 99);
            this.lblNroHabitacion.Name = "lblNroHabitacion";
            this.lblNroHabitacion.Size = new System.Drawing.Size(96, 15);
            this.lblNroHabitacion.TabIndex = 28;
            this.lblNroHabitacion.Text = "Nro Habitacion :";
            // 
            // txtNroHabitacion
            // 
            this.txtNroHabitacion.Location = new System.Drawing.Point(513, 96);
            this.txtNroHabitacion.Name = "txtNroHabitacion";
            this.txtNroHabitacion.Size = new System.Drawing.Size(160, 23);
            this.txtNroHabitacion.TabIndex = 29;
            this.txtNroHabitacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroHabitacion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Filtrar por número de Habitacion :";
            // 
            // ListadoDeReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNroHabitacion);
            this.Controls.Add(this.lblNroHabitacion);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TBuscar);
            this.Controls.Add(this.NCantidad);
            this.Controls.Add(this.DTRetiro);
            this.Controls.Add(this.DTIngreso);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.LFechaRet);
            this.Controls.Add(this.LFechaIng);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.LReservas);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Name = "ListadoDeReservas";
            this.Text = "Gestionar Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.NCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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