using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion.Recepcionista
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
            this.NCantidad = new System.Windows.Forms.NumericUpDown();
            this.DTRetiro = new System.Windows.Forms.DateTimePicker();
            this.DTIngreso = new System.Windows.Forms.DateTimePicker();
            this.LCantidad = new System.Windows.Forms.Label();
            this.LFechaRet = new System.Windows.Forms.Label();
            this.LFechaIng = new System.Windows.Forms.Label();
            this.BReservar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIDhab = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtCantCamas = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtNroHabitacion = new System.Windows.Forms.TextBox();
            this.lblDetalleHabitacion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNroHabitacion = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblIDHabitacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NCantidad
            // 
            this.NCantidad.Location = new System.Drawing.Point(171, 396);
            this.NCantidad.Name = "NCantidad";
            this.NCantidad.Size = new System.Drawing.Size(160, 23);
            this.NCantidad.TabIndex = 3;
            // 
            // DTRetiro
            // 
            this.DTRetiro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DTRetiro.Location = new System.Drawing.Point(171, 333);
            this.DTRetiro.Name = "DTRetiro";
            this.DTRetiro.Size = new System.Drawing.Size(160, 23);
            this.DTRetiro.TabIndex = 2;
            this.DTRetiro.ValueChanged += new System.EventHandler(this.DTRetiro_ValueChanged);
            // 
            // DTIngreso
            // 
            this.DTIngreso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DTIngreso.Location = new System.Drawing.Point(171, 274);
            this.DTIngreso.Name = "DTIngreso";
            this.DTIngreso.Size = new System.Drawing.Size(160, 23);
            this.DTIngreso.TabIndex = 1;
            this.DTIngreso.ValueChanged += new System.EventHandler(this.DTIngreso_ValueChanged);
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LCantidad.Location = new System.Drawing.Point(24, 398);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(130, 15);
            this.LCantidad.TabIndex = 33;
            this.LCantidad.Text = "Cantidad de Personas :";
            // 
            // LFechaRet
            // 
            this.LFechaRet.AutoSize = true;
            this.LFechaRet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LFechaRet.Location = new System.Drawing.Point(24, 333);
            this.LFechaRet.Name = "LFechaRet";
            this.LFechaRet.Size = new System.Drawing.Size(100, 15);
            this.LFechaRet.TabIndex = 25;
            this.LFechaRet.Text = "Fecha de Retiro :";
            // 
            // LFechaIng
            // 
            this.LFechaIng.AutoSize = true;
            this.LFechaIng.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LFechaIng.Location = new System.Drawing.Point(24, 274);
            this.LFechaIng.Name = "LFechaIng";
            this.LFechaIng.Size = new System.Drawing.Size(107, 15);
            this.LFechaIng.TabIndex = 24;
            this.LFechaIng.Text = "Fecha de Ingreso :";
            // 
            // BReservar
            // 
            this.BReservar.BackColor = System.Drawing.Color.Lime;
            this.BReservar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BReservar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.BReservar.Location = new System.Drawing.Point(24, 463);
            this.BReservar.Name = "BReservar";
            this.BReservar.Size = new System.Drawing.Size(113, 44);
            this.BReservar.TabIndex = 4;
            this.BReservar.Text = "Reservar";
            this.BReservar.UseVisualStyleBackColor = false;
            this.BReservar.Click += new System.EventHandler(this.BReservar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIDhab);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtPiso);
            this.panel1.Controls.Add(this.txtCantCamas);
            this.panel1.Controls.Add(this.txtCategoria);
            this.panel1.Controls.Add(this.txtNroHabitacion);
            this.panel1.Controls.Add(this.lblDetalleHabitacion);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.lblNroHabitacion);
            this.panel1.Controls.Add(this.lblPiso);
            this.panel1.Controls.Add(this.lblIDHabitacion);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 137);
            this.panel1.TabIndex = 40;
            // 
            // txtIDhab
            // 
            this.txtIDhab.Location = new System.Drawing.Point(652, 3);
            this.txtIDhab.Name = "txtIDhab";
            this.txtIDhab.ReadOnly = true;
            this.txtIDhab.Size = new System.Drawing.Size(35, 23);
            this.txtIDhab.TabIndex = 59;
            this.txtIDhab.Visible = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Location = new System.Drawing.Point(537, 80);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 16);
            this.txtPrecio.TabIndex = 58;
            // 
            // txtPiso
            // 
            this.txtPiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPiso.Location = new System.Drawing.Point(537, 44);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.ReadOnly = true;
            this.txtPiso.Size = new System.Drawing.Size(100, 16);
            this.txtPiso.TabIndex = 57;
            // 
            // txtCantCamas
            // 
            this.txtCantCamas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantCamas.Location = new System.Drawing.Point(537, 12);
            this.txtCantCamas.Name = "txtCantCamas";
            this.txtCantCamas.ReadOnly = true;
            this.txtCantCamas.Size = new System.Drawing.Size(100, 16);
            this.txtCantCamas.TabIndex = 56;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoria.Location = new System.Drawing.Point(162, 97);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(100, 16);
            this.txtCategoria.TabIndex = 55;
            // 
            // txtNroHabitacion
            // 
            this.txtNroHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNroHabitacion.Location = new System.Drawing.Point(162, 62);
            this.txtNroHabitacion.Name = "txtNroHabitacion";
            this.txtNroHabitacion.ReadOnly = true;
            this.txtNroHabitacion.Size = new System.Drawing.Size(100, 16);
            this.txtNroHabitacion.TabIndex = 54;
            // 
            // lblDetalleHabitacion
            // 
            this.lblDetalleHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDetalleHabitacion.ForeColor = System.Drawing.Color.White;
            this.lblDetalleHabitacion.Location = new System.Drawing.Point(21, 9);
            this.lblDetalleHabitacion.Name = "lblDetalleHabitacion";
            this.lblDetalleHabitacion.Size = new System.Drawing.Size(198, 38);
            this.lblDetalleHabitacion.TabIndex = 53;
            this.lblDetalleHabitacion.Text = "Habitacion :";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(24, 97);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 15);
            this.lblCategoria.TabIndex = 52;
            this.lblCategoria.Text = "Categoria :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(374, 78);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 15);
            this.lblPrecio.TabIndex = 51;
            this.lblPrecio.Text = "Precio :";
            // 
            // lblNroHabitacion
            // 
            this.lblNroHabitacion.AutoSize = true;
            this.lblNroHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNroHabitacion.Location = new System.Drawing.Point(24, 62);
            this.lblNroHabitacion.Name = "lblNroHabitacion";
            this.lblNroHabitacion.Size = new System.Drawing.Size(96, 15);
            this.lblNroHabitacion.TabIndex = 49;
            this.lblNroHabitacion.Text = "Nro Habitacion :";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPiso.Location = new System.Drawing.Point(374, 42);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(35, 15);
            this.lblPiso.TabIndex = 48;
            this.lblPiso.Text = "Piso :";
            // 
            // lblIDHabitacion
            // 
            this.lblIDHabitacion.AutoSize = true;
            this.lblIDHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIDHabitacion.Location = new System.Drawing.Point(374, 10);
            this.lblIDHabitacion.Name = "lblIDHabitacion";
            this.lblIDHabitacion.Size = new System.Drawing.Size(93, 15);
            this.lblIDHabitacion.TabIndex = 47;
            this.lblIDHabitacion.Text = "Cant de Camas :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(662, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "_________________________________________________________________________________" +
    "__________________________________________________";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(224, 463);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 44);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Asignar_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 531);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NCantidad);
            this.Controls.Add(this.DTRetiro);
            this.Controls.Add(this.DTIngreso);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.LFechaRet);
            this.Controls.Add(this.LFechaIng);
            this.Controls.Add(this.BReservar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Name = "Asignar_Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar_Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.NCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox txtIDhab;
    }
}