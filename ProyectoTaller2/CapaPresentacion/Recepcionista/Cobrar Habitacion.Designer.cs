namespace ProyectoTaller2.CapaPresentacion.Recepcionista
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
            lblPagoTotal = new Label();
            btnCobrarHabitacion = new Button();
            CBMetodoPago = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            txtHabitacion = new TextBox();
            txtCliente = new TextBox();
            txtTotal = new TextBox();
            txtPrSer = new TextBox();
            txtPrHab = new TextBox();
            txtServicios = new TextBox();
            SuspendLayout();
            // 
            // lblPagoTotal
            // 
            lblPagoTotal.AutoSize = true;
            lblPagoTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagoTotal.Location = new Point(67, 216);
            lblPagoTotal.Name = "lblPagoTotal";
            lblPagoTotal.Size = new Size(137, 25);
            lblPagoTotal.TabIndex = 2;
            lblPagoTotal.Text = "Total a Pagar :";
            // 
            // btnCobrarHabitacion
            // 
            btnCobrarHabitacion.BackColor = Color.Lime;
            btnCobrarHabitacion.FlatStyle = FlatStyle.Popup;
            btnCobrarHabitacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCobrarHabitacion.ForeColor = SystemColors.ActiveCaptionText;
            btnCobrarHabitacion.Location = new Point(363, 339);
            btnCobrarHabitacion.Name = "btnCobrarHabitacion";
            btnCobrarHabitacion.Size = new Size(119, 58);
            btnCobrarHabitacion.TabIndex = 4;
            btnCobrarHabitacion.Text = "Cobrar Habitacion";
            btnCobrarHabitacion.UseVisualStyleBackColor = false;
            btnCobrarHabitacion.Click += btnCobrarHabitacion_Click;
            // 
            // CBMetodoPago
            // 
            CBMetodoPago.FormattingEnabled = true;
            CBMetodoPago.Items.AddRange(new object[] { "[Eliga la Opcion de Pago]", "Efectivo", "Credito", "Debito", "MercadoPago" });
            CBMetodoPago.Location = new Point(50, 354);
            CBMetodoPago.Name = "CBMetodoPago";
            CBMetodoPago.Size = new Size(217, 29);
            CBMetodoPago.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 321);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 10;
            label1.Text = "Metodo de Pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(67, 26);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 12;
            label3.Text = "Habitación :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(67, 57);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 13;
            label4.Text = "A Nombre de :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(67, 88);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 14;
            label5.Text = "Servicios Incluidos :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(67, 122);
            label6.Name = "label6";
            label6.Size = new Size(164, 20);
            label6.TabIndex = 15;
            label6.Text = "Costo por Habitación :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(67, 160);
            label7.Name = "label7";
            label7.Size = new Size(151, 20);
            label7.TabIndex = 16;
            label7.Text = "Costo por Servicios :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 257);
            label2.Name = "label2";
            label2.Size = new Size(703, 23);
            label2.TabIndex = 18;
            label2.Text = "___________________________________________________________________________________________________";
            // 
            // txtHabitacion
            // 
            txtHabitacion.BorderStyle = BorderStyle.None;
            txtHabitacion.Location = new Point(263, 21);
            txtHabitacion.Name = "txtHabitacion";
            txtHabitacion.ReadOnly = true;
            txtHabitacion.Size = new Size(182, 22);
            txtHabitacion.TabIndex = 19;
            // 
            // txtCliente
            // 
            txtCliente.BorderStyle = BorderStyle.None;
            txtCliente.Location = new Point(263, 52);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(182, 22);
            txtCliente.TabIndex = 20;
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Location = new Point(233, 216);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(224, 22);
            txtTotal.TabIndex = 21;
            // 
            // txtPrSer
            // 
            txtPrSer.BorderStyle = BorderStyle.None;
            txtPrSer.Location = new Point(263, 155);
            txtPrSer.Name = "txtPrSer";
            txtPrSer.ReadOnly = true;
            txtPrSer.Size = new Size(182, 22);
            txtPrSer.TabIndex = 24;
            // 
            // txtPrHab
            // 
            txtPrHab.BorderStyle = BorderStyle.None;
            txtPrHab.Location = new Point(263, 117);
            txtPrHab.Name = "txtPrHab";
            txtPrHab.ReadOnly = true;
            txtPrHab.Size = new Size(182, 22);
            txtPrHab.TabIndex = 25;
            // 
            // txtServicios
            // 
            txtServicios.BorderStyle = BorderStyle.None;
            txtServicios.Location = new Point(263, 83);
            txtServicios.Name = "txtServicios";
            txtServicios.ReadOnly = true;
            txtServicios.Size = new Size(182, 22);
            txtServicios.TabIndex = 26;
            // 
            // Cobrar_Habitacion
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 459);
            Controls.Add(txtServicios);
            Controls.Add(txtPrHab);
            Controls.Add(txtPrSer);
            Controls.Add(txtTotal);
            Controls.Add(txtCliente);
            Controls.Add(txtHabitacion);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(CBMetodoPago);
            Controls.Add(btnCobrarHabitacion);
            Controls.Add(lblPagoTotal);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Cobrar_Habitacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cobrar_Habitacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPagoTotal;
        private Button btnCobrarHabitacion;
        private ComboBox CBMetodoPago;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label2;
        private TextBox txtHabitacion;
        private TextBox txtCliente;
        private TextBox txtTotal;
        private TextBox txtPrSer;
        private TextBox txtPrHab;
        private TextBox txtServicios;
    }
}