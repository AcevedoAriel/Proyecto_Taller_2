namespace ProyectoTaller2.CapaPresentacion
{
    partial class Reservar
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
            panel1 = new Panel();
            dataGridHabitaciones = new DataGridView();
            lblCategoria = new Label();
            lblPiso = new Label();
            CBcategoria = new ComboBox();
            CBpiso = new ComboBox();
            label3 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lbl1 = new Label();
            lblDesde = new Label();
            dateTimeFechaDesde = new DateTimePicker();
            btnReservar = new Button();
            dateTimeFechaHasta = new DateTimePicker();
            lblHasta = new Label();
            txtNoHab = new TextBox();
            LNoHab = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHabitaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridHabitaciones);
            panel1.Location = new Point(2, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 241);
            panel1.TabIndex = 21;
            // 
            // dataGridHabitaciones
            // 
            dataGridHabitaciones.AllowUserToAddRows = false;
            dataGridHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHabitaciones.Dock = DockStyle.Fill;
            dataGridHabitaciones.Location = new Point(0, 0);
            dataGridHabitaciones.Name = "dataGridHabitaciones";
            dataGridHabitaciones.RowTemplate.Height = 25;
            dataGridHabitaciones.Size = new Size(827, 241);
            dataGridHabitaciones.TabIndex = 0;
            
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.Location = new Point(129, 112);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(84, 20);
            lblCategoria.TabIndex = 23;
            lblCategoria.Text = "Categoría :";
            // 
            // lblPiso
            // 
            lblPiso.AutoSize = true;
            lblPiso.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPiso.Location = new Point(129, 79);
            lblPiso.Name = "lblPiso";
            lblPiso.Size = new Size(46, 20);
            lblPiso.TabIndex = 24;
            lblPiso.Text = "Piso :";
            // 
            // CBcategoria
            // 
            CBcategoria.FormattingEnabled = true;
            CBcategoria.Items.AddRange(new object[] { "seleccione", "Simple", "Matrimonial", "Ejecutivo" });
            CBcategoria.Location = new Point(219, 114);
            CBcategoria.Name = "CBcategoria";
            CBcategoria.Size = new Size(165, 21);
            CBcategoria.TabIndex = 25;
            CBcategoria.SelectedIndexChanged += CBcategoria_SelectedIndexChanged;
            // 
            // CBpiso
            // 
            CBpiso.FormattingEnabled = true;
            CBpiso.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            CBpiso.Location = new Point(219, 78);
            CBpiso.Name = "CBpiso";
            CBpiso.Size = new Size(165, 21);
            CBpiso.TabIndex = 26;
            CBpiso.SelectedIndexChanged += CBpiso_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(168, 9);
            label3.Name = "label3";
            label3.Size = new Size(478, 37);
            label3.TabIndex = 27;
            label3.Text = "Vista General de Habitaciones";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 105;
            iconPictureBox1.Location = new Point(12, 52);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(105, 105);
            iconPictureBox1.TabIndex = 28;
            iconPictureBox1.TabStop = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(2, 140);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(819, 20);
            lbl1.TabIndex = 29;
            lbl1.Text = "_______________________________________________________________________________________________________________________________________";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDesde.Location = new Point(399, 78);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(56, 20);
            lblDesde.TabIndex = 30;
            lblDesde.Text = "Desde:";
            // 
            // dateTimeFechaDesde
            // 
            dateTimeFechaDesde.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimeFechaDesde.Location = new Point(454, 78);
            dateTimeFechaDesde.Name = "dateTimeFechaDesde";
            dateTimeFechaDesde.Size = new Size(183, 22);
            dateTimeFechaDesde.TabIndex = 31;
            dateTimeFechaDesde.ValueChanged += dateTimeFechaDesde_ValueChanged;
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.White;
            btnReservar.FlatStyle = FlatStyle.Popup;
            btnReservar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReservar.Location = new Point(717, 36);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(75, 46);
            btnReservar.TabIndex = 32;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = false;
            btnReservar.Click += btnReservar_Click;
            // 
            // dateTimeFechaHasta
            // 
            dateTimeFechaHasta.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimeFechaHasta.Location = new Point(454, 115);
            dateTimeFechaHasta.Name = "dateTimeFechaHasta";
            dateTimeFechaHasta.Size = new Size(183, 22);
            dateTimeFechaHasta.TabIndex = 34;
            dateTimeFechaHasta.ValueChanged += dateTimeFechaHasta_ValueChanged;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHasta.Location = new Point(399, 115);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(53, 20);
            lblHasta.TabIndex = 33;
            lblHasta.Text = "Hasta:";
            // 
            // txtNoHab
            // 
            txtNoHab.Location = new Point(668, 115);
            txtNoHab.Name = "txtNoHab";
            txtNoHab.Size = new Size(128, 20);
            txtNoHab.TabIndex = 35;
            
            txtNoHab.KeyPress += txtNoHab_KeyPress;
            // 
            // LNoHab
            // 
            LNoHab.AutoSize = true;
            LNoHab.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LNoHab.Location = new Point(668, 97);
            LNoHab.Name = "LNoHab";
            LNoHab.Size = new Size(99, 15);
            LNoHab.TabIndex = 36;
            LNoHab.Text = "N° de Camas :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 178);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 37;
            label1.Text = "Habitaciones :";
            // 
            // Reservar
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 465);
            Controls.Add(label1);
            Controls.Add(LNoHab);
            Controls.Add(txtNoHab);
            Controls.Add(dateTimeFechaHasta);
            Controls.Add(lblHasta);
            Controls.Add(btnReservar);
            Controls.Add(dateTimeFechaDesde);
            Controls.Add(lblDesde);
            Controls.Add(lbl1);
            Controls.Add(iconPictureBox1);
            Controls.Add(label3);
            Controls.Add(CBpiso);
            Controls.Add(CBcategoria);
            Controls.Add(lblPiso);
            Controls.Add(lblCategoria);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Reservar";
            Text = "Inicio";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridHabitaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label lblCategoria;
        private Label lblPiso;
        private ComboBox CBcategoria;
        private ComboBox CBpiso;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lbl1;
        private Label lblDesde;
        private DateTimePicker dateTimeFechaDesde;
        private Button btnReservar;
        private DateTimePicker dateTimeFechaHasta;
        private Label lblHasta;
        private TextBox txtNoHab;
        private Label LNoHab;
        private DataGridView dataGridHabitaciones;
        private Label label1;
    }
}