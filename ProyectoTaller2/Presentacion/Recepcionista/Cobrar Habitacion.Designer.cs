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
            label2 = new Label();
            lblPagoTotal = new Label();
            btnCobrarHabitacion = new Button();
            btnBuscarHabitacion = new Button();
            textBox1 = new TextBox();
            CBMetodoPago = new ComboBox();
            CBCantidadCuota = new ComboBox();
            lblCantidadDeCuota = new Label();
            label1 = new Label();
            lblSubTotal = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 93);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // lblPagoTotal
            // 
            lblPagoTotal.AutoSize = true;
            lblPagoTotal.Location = new Point(121, 302);
            lblPagoTotal.Name = "lblPagoTotal";
            lblPagoTotal.Size = new Size(35, 15);
            lblPagoTotal.TabIndex = 2;
            lblPagoTotal.Text = "Total:";
            // 
            // btnCobrarHabitacion
            // 
            btnCobrarHabitacion.Location = new Point(169, 334);
            btnCobrarHabitacion.Name = "btnCobrarHabitacion";
            btnCobrarHabitacion.Size = new Size(104, 59);
            btnCobrarHabitacion.TabIndex = 4;
            btnCobrarHabitacion.Text = "Cobrar Habitacion";
            btnCobrarHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnBuscarHabitacion
            // 
            btnBuscarHabitacion.Location = new Point(334, 12);
            btnBuscarHabitacion.Name = "btnBuscarHabitacion";
            btnBuscarHabitacion.Size = new Size(113, 38);
            btnBuscarHabitacion.TabIndex = 5;
            btnBuscarHabitacion.Text = "Buscar Habitacion";
            btnBuscarHabitacion.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 23);
            textBox1.TabIndex = 6;
            // 
            // CBMetodoPago
            // 
            CBMetodoPago.FormattingEnabled = true;
            CBMetodoPago.Items.AddRange(new object[] { "[Eliga la Opcion de Pago]", "Efectivo", "Credito", "Debito", "MercadoPago" });
            CBMetodoPago.Location = new Point(121, 120);
            CBMetodoPago.Name = "CBMetodoPago";
            CBMetodoPago.Size = new Size(190, 23);
            CBMetodoPago.TabIndex = 7;
            // 
            // CBCantidadCuota
            // 
            CBCantidadCuota.FormattingEnabled = true;
            CBCantidadCuota.Items.AddRange(new object[] { "[Seleccione Cantidad]", "1", "2", "3", "4", "6", "7", "8", "9", "10", "11", "12" });
            CBCantidadCuota.Location = new Point(121, 198);
            CBCantidadCuota.Name = "CBCantidadCuota";
            CBCantidadCuota.Size = new Size(190, 23);
            CBCantidadCuota.TabIndex = 8;
            // 
            // lblCantidadDeCuota
            // 
            lblCantidadDeCuota.AutoSize = true;
            lblCantidadDeCuota.Location = new Point(121, 180);
            lblCantidadDeCuota.Name = "lblCantidadDeCuota";
            lblCantidadDeCuota.Size = new Size(111, 15);
            lblCantidadDeCuota.TabIndex = 9;
            lblCantidadDeCuota.Text = "Cantidad de Cuotas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 93);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 10;
            label1.Text = "Metodo de Pago:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(121, 266);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(58, 15);
            lblSubTotal.TabIndex = 11;
            lblSubTotal.Text = "Sub Total:";
            // 
            // Cobrar_Habitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 405);
            Controls.Add(lblSubTotal);
            Controls.Add(label1);
            Controls.Add(lblCantidadDeCuota);
            Controls.Add(CBCantidadCuota);
            Controls.Add(CBMetodoPago);
            Controls.Add(textBox1);
            Controls.Add(btnBuscarHabitacion);
            Controls.Add(btnCobrarHabitacion);
            Controls.Add(lblPagoTotal);
            Controls.Add(label2);
            Name = "Cobrar_Habitacion";
            Text = "Cobrar_Habitacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label lblPagoTotal;
        private Button btnCobrarHabitacion;
        private Button btnBuscarHabitacion;
        private TextBox textBox1;
        private ComboBox CBMetodoPago;
        private ComboBox CBCantidadCuota;
        private Label lblCantidadDeCuota;
        private Label label1;
        private Label lblSubTotal;
    }
}