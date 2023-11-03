namespace ProyectoTaller2.CapaPresentacion.Recepcionista
{
    partial class ServiciosAdicionales
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
            checkBox1 = new CheckBox();
            label5 = new Label();
            checkBox2 = new CheckBox();
            label4 = new Label();
            checkBox3 = new CheckBox();
            label3 = new Label();
            checkBox4 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            Bagregar = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(208, 104);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 6;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += checkBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(81, 223);
            label5.Name = "label5";
            label5.Size = new Size(80, 16);
            label5.TabIndex = 4;
            label5.Text = "Televisión";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(208, 144);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 7;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(81, 183);
            label4.Name = "label4";
            label4.Size = new Size(94, 16);
            label4.TabIndex = 3;
            label4.Text = "Despertador";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(208, 225);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 14);
            checkBox3.TabIndex = 8;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(82, 142);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 2;
            label3.Text = "Cena";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(208, 185);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(15, 14);
            checkBox4.TabIndex = 9;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(82, 102);
            label2.Name = "label2";
            label2.Size = new Size(77, 16);
            label2.TabIndex = 1;
            label2.Text = "Desayuno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(238, 25);
            label1.TabIndex = 0;
            label1.Text = "Servicios Adicionales";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(Bagregar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(50, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 325);
            panel1.TabIndex = 11;
            // 
            // Bagregar
            // 
            Bagregar.BackColor = Color.White;
            Bagregar.FlatStyle = FlatStyle.Popup;
            Bagregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Bagregar.Location = new Point(93, 268);
            Bagregar.Name = "Bagregar";
            Bagregar.Size = new Size(111, 40);
            Bagregar.TabIndex = 10;
            Bagregar.Text = "Agregar";
            Bagregar.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Desayuno", "Cena" });
            listBox1.Location = new Point(193, 142);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(83, 239);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            // 
            // ServiciosAdicionales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 386);
            Controls.Add(panel1);
            Name = "ServiciosAdicionales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBox1;
        private Label label5;
        private CheckBox checkBox2;
        private Label label4;
        private CheckBox checkBox3;
        private Label label3;
        private CheckBox checkBox4;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button Bagregar;
        private ComboBox comboBox1;
        private ListBox listBox1;
    }
}