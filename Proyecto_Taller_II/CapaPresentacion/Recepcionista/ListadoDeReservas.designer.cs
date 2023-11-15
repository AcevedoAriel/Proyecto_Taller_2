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
            this.BEliminar = new System.Windows.Forms.Button();
            this.TBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridReserva = new System.Windows.Forms.DataGridView();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.LReservas.Text = "Registro de Reservas";
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.Color.Red;
            this.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BEliminar.Location = new System.Drawing.Point(657, 108);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(113, 45);
            this.BEliminar.TabIndex = 8;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = false;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // TBuscar
            // 
            this.TBuscar.Location = new System.Drawing.Point(335, 120);
            this.TBuscar.Name = "TBuscar";
            this.TBuscar.Size = new System.Drawing.Size(192, 23);
            this.TBuscar.TabIndex = 5;
            this.TBuscar.TextChanged += new System.EventHandler(this.TBuscar_TextChanged);
            this.TBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBuscar_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridReserva);
            this.panel1.Location = new System.Drawing.Point(1, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 274);
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
            this.dataGridReserva.Size = new System.Drawing.Size(833, 274);
            this.dataGridReserva.TabIndex = 9;
            this.dataGridReserva.SelectionChanged += new System.EventHandler(this.dataGridReserva_SelectionChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 123);
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
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TBuscar);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.LReservas);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Name = "ListadoDeReservas";
            this.Text = "Gestionar Reservas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridViewRow filaSeleccionada = null;

        private Label LReservas;
        private Button BEliminar;
        private TextBox TBuscar;
        private Panel panel1;
        private DataGridView dataGridReserva;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
    }
}