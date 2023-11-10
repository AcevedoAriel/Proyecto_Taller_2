using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion.Recepcionista
{
    partial class Cobrar_Habitacion
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
            this.lblPagoTotal = new System.Windows.Forms.Label();
            this.btnCobrarHabitacion = new System.Windows.Forms.Button();
            this.CBMetodoPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrSer = new System.Windows.Forms.TextBox();
            this.txtPrHab = new System.Windows.Forms.TextBox();
            this.txtServicios = new System.Windows.Forms.TextBox();
            this.cboboxCliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDReserva = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPagoTotal
            // 
            this.lblPagoTotal.AutoSize = true;
            this.lblPagoTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPagoTotal.Location = new System.Drawing.Point(67, 216);
            this.lblPagoTotal.Name = "lblPagoTotal";
            this.lblPagoTotal.Size = new System.Drawing.Size(108, 20);
            this.lblPagoTotal.TabIndex = 2;
            this.lblPagoTotal.Text = "Total a Pagar :";
            // 
            // btnCobrarHabitacion
            // 
            this.btnCobrarHabitacion.BackColor = System.Drawing.Color.Lime;
            this.btnCobrarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCobrarHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCobrarHabitacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCobrarHabitacion.Location = new System.Drawing.Point(363, 339);
            this.btnCobrarHabitacion.Name = "btnCobrarHabitacion";
            this.btnCobrarHabitacion.Size = new System.Drawing.Size(119, 58);
            this.btnCobrarHabitacion.TabIndex = 4;
            this.btnCobrarHabitacion.Text = "Cobrar Habitacion";
            this.btnCobrarHabitacion.UseVisualStyleBackColor = false;
            this.btnCobrarHabitacion.Click += new System.EventHandler(this.btnCobrarHabitacion_Click);
            // 
            // CBMetodoPago
            // 
            this.CBMetodoPago.FormattingEnabled = true;
            this.CBMetodoPago.Items.AddRange(new object[] {
            "[Eliga la Opcion de Pago]",
            "Efectivo",
            "Credito",
            "Debito",
            "MercadoPago"});
            this.CBMetodoPago.Location = new System.Drawing.Point(57, 326);
            this.CBMetodoPago.Name = "CBMetodoPago";
            this.CBMetodoPago.Size = new System.Drawing.Size(217, 25);
            this.CBMetodoPago.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(57, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Metodo de Pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(67, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Habitación :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(67, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Servicios Incluidos :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(67, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Costo por Habitación :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(67, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Costo por Servicios :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "_________________________________________________________________________________" +
    "__________________";
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHabitacion.Location = new System.Drawing.Point(263, 21);
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.ReadOnly = true;
            this.txtHabitacion.Size = new System.Drawing.Size(182, 18);
            this.txtHabitacion.TabIndex = 19;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(233, 216);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(224, 18);
            this.txtTotal.TabIndex = 21;
            // 
            // txtPrSer
            // 
            this.txtPrSer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrSer.Location = new System.Drawing.Point(263, 161);
            this.txtPrSer.Name = "txtPrSer";
            this.txtPrSer.ReadOnly = true;
            this.txtPrSer.Size = new System.Drawing.Size(182, 18);
            this.txtPrSer.TabIndex = 24;
            // 
            // txtPrHab
            // 
            this.txtPrHab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrHab.Location = new System.Drawing.Point(263, 114);
            this.txtPrHab.Name = "txtPrHab";
            this.txtPrHab.ReadOnly = true;
            this.txtPrHab.Size = new System.Drawing.Size(182, 18);
            this.txtPrHab.TabIndex = 25;
            // 
            // txtServicios
            // 
            this.txtServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServicios.Location = new System.Drawing.Point(263, 67);
            this.txtServicios.Name = "txtServicios";
            this.txtServicios.ReadOnly = true;
            this.txtServicios.Size = new System.Drawing.Size(182, 18);
            this.txtServicios.TabIndex = 26;
            // 
            // cboboxCliente
            // 
            this.cboboxCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboboxCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboboxCliente.FormattingEnabled = true;
            this.cboboxCliente.Location = new System.Drawing.Point(57, 411);
            this.cboboxCliente.Name = "cboboxCliente";
            this.cboboxCliente.Size = new System.Drawing.Size(217, 25);
            this.cboboxCliente.TabIndex = 27;
            this.cboboxCliente.SelectedIndexChanged += new System.EventHandler(this.cboboxCliente_SelectedIndexChanged);
            this.cboboxCliente.TextChanged += new System.EventHandler(this.cboboxCliente_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Seleccione Cliente :";
            // 
            // txtIDReserva
            // 
            this.txtIDReserva.Location = new System.Drawing.Point(12, 3);
            this.txtIDReserva.Name = "txtIDReserva";
            this.txtIDReserva.ReadOnly = true;
            this.txtIDReserva.Size = new System.Drawing.Size(35, 25);
            this.txtIDReserva.TabIndex = 29;
            this.txtIDReserva.Visible = false;
            // 
            // Cobrar_Habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 459);
            this.Controls.Add(this.txtIDReserva);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboboxCliente);
            this.Controls.Add(this.txtServicios);
            this.Controls.Add(this.txtPrHab);
            this.Controls.Add(this.txtPrSer);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtHabitacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBMetodoPago);
            this.Controls.Add(this.btnCobrarHabitacion);
            this.Controls.Add(this.lblPagoTotal);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "Cobrar_Habitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrar_Habitacion";
            this.Load += new System.EventHandler(this.Cobrar_Habitacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblPagoTotal;
        private Button btnCobrarHabitacion;
        private ComboBox CBMetodoPago;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label2;
        private TextBox txtHabitacion;
        private TextBox txtTotal;
        private TextBox txtPrSer;
        private TextBox txtPrHab;
        private TextBox txtServicios;
        private ComboBox cboboxCliente;
        private Label label8;
        private TextBox txtIDReserva;
    }
}