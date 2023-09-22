namespace ProyectoTaller2.Presentacion
{
    partial class AgregarHabitacion
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
            LTItuloHabitacion = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNroHabitacion = new TextBox();
            UPDOWNPiso = new NumericUpDown();
            txtCategoria = new ComboBox();
            dateTimeFechaInauguracion = new DateTimePicker();
            label5 = new Label();
            txtPrecio = new TextBox();
            btnAgregarHabitacion = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)UPDOWNPiso).BeginInit();
            SuspendLayout();
            // 
            // LTItuloHabitacion
            // 
            LTItuloHabitacion.AutoSize = true;
            LTItuloHabitacion.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LTItuloHabitacion.Location = new Point(98, 21);
            LTItuloHabitacion.Name = "LTItuloHabitacion";
            LTItuloHabitacion.Size = new Size(243, 28);
            LTItuloHabitacion.TabIndex = 0;
            LTItuloHabitacion.Text = "Agregar Habitacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 98);
            label1.Name = "label1";
            label1.Size = new Size(34, 17);
            label1.TabIndex = 1;
            label1.Text = "Piso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 135);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 2;
            label2.Text = "Nro. Habitación:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 188);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 3;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(70, 229);
            label4.Name = "label4";
            label4.Size = new Size(122, 17);
            label4.TabIndex = 4;
            label4.Text = "Fecha Inaguración:";
            // 
            // txtNroHabitacion
            // 
            txtNroHabitacion.Location = new Point(193, 135);
            txtNroHabitacion.Name = "txtNroHabitacion";
            txtNroHabitacion.Size = new Size(167, 23);
            txtNroHabitacion.TabIndex = 5;
            // 
            // UPDOWNPiso
            // 
            UPDOWNPiso.Location = new Point(193, 92);
            UPDOWNPiso.Name = "UPDOWNPiso";
            UPDOWNPiso.Size = new Size(167, 23);
            UPDOWNPiso.TabIndex = 6;
            // 
            // txtCategoria
            // 
            txtCategoria.FormattingEnabled = true;
            txtCategoria.Items.AddRange(new object[] { "Simple", "Doble", "Matrimonial" });
            txtCategoria.Location = new Point(193, 182);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(167, 23);
            txtCategoria.TabIndex = 7;
            // 
            // dateTimeFechaInauguracion
            // 
            dateTimeFechaInauguracion.Location = new Point(194, 229);
            dateTimeFechaInauguracion.Name = "dateTimeFechaInauguracion";
            dateTimeFechaInauguracion.Size = new Size(166, 23);
            dateTimeFechaInauguracion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(70, 276);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 10;
            label5.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(193, 275);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(172, 23);
            txtPrecio.TabIndex = 11;
            // 
            // btnAgregarHabitacion
            // 
            btnAgregarHabitacion.BackColor = Color.Lime;
            btnAgregarHabitacion.FlatStyle = FlatStyle.Popup;
            btnAgregarHabitacion.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarHabitacion.Location = new Point(155, 322);
            btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            btnAgregarHabitacion.Size = new Size(168, 35);
            btnAgregarHabitacion.TabIndex = 12;
            btnAgregarHabitacion.Text = "Agregar Habitación";
            btnAgregarHabitacion.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 49);
            label6.Name = "label6";
            label6.Size = new Size(202, 15);
            label6.TabIndex = 13;
            label6.Text = "_______________________________________";
            // 
            // AgregarHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 378);
            Controls.Add(label6);
            Controls.Add(btnAgregarHabitacion);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(dateTimeFechaInauguracion);
            Controls.Add(txtCategoria);
            Controls.Add(UPDOWNPiso);
            Controls.Add(txtNroHabitacion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LTItuloHabitacion);
            Name = "AgregarHabitacion";
            Text = "AgregarHabitacion";
            ((System.ComponentModel.ISupportInitialize)UPDOWNPiso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LTItuloHabitacion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNroHabitacion;
        private NumericUpDown UPDOWNPiso;
        private ComboBox txtCategoria;
        private DateTimePicker dateTimeFechaInauguracion;
        private Label label5;
        private TextBox txtPrecio;
        private Button btnAgregarHabitacion;
        private Label label6;
    }
}