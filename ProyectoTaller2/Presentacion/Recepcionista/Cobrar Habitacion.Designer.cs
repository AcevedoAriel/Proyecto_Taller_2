namespace ProyectoTaller2.Presentacion.Recepcionista
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
            CBCantidadCuota = new ComboBox();
            lblCantidadDeCuota = new Label();
            label1 = new Label();
            lblSubTotal = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblPagoTotal
            // 
            lblPagoTotal.AutoSize = true;
            lblPagoTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagoTotal.Location = new Point(315, 224);
            lblPagoTotal.Name = "lblPagoTotal";
            lblPagoTotal.Size = new Size(48, 20);
            lblPagoTotal.TabIndex = 2;
            lblPagoTotal.Text = "Total:";
            // 
            // btnCobrarHabitacion
            // 
            btnCobrarHabitacion.BackColor = Color.Lime;
            btnCobrarHabitacion.FlatStyle = FlatStyle.Popup;
            btnCobrarHabitacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCobrarHabitacion.ForeColor = SystemColors.ActiveCaptionText;
            btnCobrarHabitacion.Location = new Point(345, 321);
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
            CBMetodoPago.Location = new Point(67, 307);
            CBMetodoPago.Name = "CBMetodoPago";
            CBMetodoPago.Size = new Size(217, 25);
            CBMetodoPago.TabIndex = 7;
            // 
            // CBCantidadCuota
            // 
            CBCantidadCuota.FormattingEnabled = true;
            CBCantidadCuota.Items.AddRange(new object[] { "[Seleccione Cantidad]", "1", "2", "3", "4", "6", "7", "8", "9", "10", "11", "12" });
            CBCantidadCuota.Location = new Point(67, 383);
            CBCantidadCuota.Name = "CBCantidadCuota";
            CBCantidadCuota.Size = new Size(217, 25);
            CBCantidadCuota.TabIndex = 8;
            // 
            // lblCantidadDeCuota
            // 
            lblCantidadDeCuota.AutoSize = true;
            lblCantidadDeCuota.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidadDeCuota.Location = new Point(67, 352);
            lblCantidadDeCuota.Name = "lblCantidadDeCuota";
            lblCantidadDeCuota.Size = new Size(128, 17);
            lblCantidadDeCuota.TabIndex = 9;
            lblCantidadDeCuota.Text = "Cantidad de Cuotas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 274);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 10;
            label1.Text = "Metodo de Pago:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(67, 224);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(78, 20);
            lblSubTotal.TabIndex = 11;
            lblSubTotal.Text = "Sub Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(67, 26);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 12;
            label3.Text = "Habitación :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(67, 57);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 13;
            label4.Text = "A Nombre de :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(67, 88);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 14;
            label5.Text = "Servicios Adicionados :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(67, 122);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 15;
            label6.Text = "Precio de Habitación :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(67, 160);
            label7.Name = "label7";
            label7.Size = new Size(121, 15);
            label7.TabIndex = 16;
            label7.Text = "Precio por servicios :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(67, 192);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 17;
            label8.Text = "Taza de Intereses :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 244);
            label2.Name = "label2";
            label2.Size = new Size(503, 17);
            label2.TabIndex = 18;
            label2.Text = "___________________________________________________________________________________________________";
            // 
            // Cobrar_Habitacion
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 459);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblSubTotal);
            Controls.Add(label1);
            Controls.Add(lblCantidadDeCuota);
            Controls.Add(CBCantidadCuota);
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
        private ComboBox CBCantidadCuota;
        private Label lblCantidadDeCuota;
        private Label label1;
        private Label lblSubTotal;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label2;
    }
}