namespace ProyectoTaller2.CapaPresentacion.Administrador
{
    partial class Ingresos
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
            Tbuscar = new TextBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            medioPago = new DataGridViewTextBoxColumn();
            fechaPago = new DataGridViewTextBoxColumn();
            cuotas = new DataGridViewTextBoxColumn();
            costoServ = new DataGridViewTextBoxColumn();
            costoHab = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            interes = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Tbuscar
            // 
            Tbuscar.Location = new Point(171, 66);
            Tbuscar.Name = "Tbuscar";
            Tbuscar.Size = new Size(228, 23);
            Tbuscar.TabIndex = 3;
            Tbuscar.TextChanged += Tbuscar_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(3, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 351);
            panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, medioPago, fechaPago, cuotas, costoServ, costoHab, subtotal, interes, total });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(826, 351);
            dataGridView1.TabIndex = 1;
            // 
            // nombre
            // 
            nombre.HeaderText = "A Nombre de";
            nombre.Name = "nombre";
            nombre.Width = 200;
            // 
            // medioPago
            // 
            medioPago.HeaderText = "Medio de Pago";
            medioPago.Name = "medioPago";
            // 
            // fechaPago
            // 
            fechaPago.HeaderText = "Fecha de Pago";
            fechaPago.Name = "fechaPago";
            // 
            // cuotas
            // 
            cuotas.HeaderText = "N° de Cuotas";
            cuotas.Name = "cuotas";
            // 
            // costoServ
            // 
            costoServ.HeaderText = "Costo por Servicio";
            costoServ.Name = "costoServ";
            // 
            // costoHab
            // 
            costoHab.HeaderText = "Costo por Habitación";
            costoHab.Name = "costoHab";
            // 
            // subtotal
            // 
            subtotal.HeaderText = "SubTotal";
            subtotal.Name = "subtotal";
            // 
            // interes
            // 
            interes.HeaderText = "Interes";
            interes.Name = "interes";
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.Name = "total";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(421, 59);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(78, 34);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(515, 3);
            label1.Name = "label1";
            label1.Size = new Size(300, 37);
            label1.TabIndex = 6;
            label1.Text = "Ingresos de Pagos";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = Color.Black;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            iconPictureBox1.IconColor = Color.Black;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 100;
            iconPictureBox1.Location = new Point(3, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(100, 101);
            iconPictureBox1.TabIndex = 7;
            iconPictureBox1.TabStop = false;
            // 
            // Ingresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 465);
            Controls.Add(iconPictureBox1);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(panel1);
            Controls.Add(Tbuscar);
            ForeColor = Color.White;
            Name = "Ingresos";
            Text = "Ingresos";
            Load += Ingresos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Tbuscar;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn medioPago;
        private DataGridViewTextBoxColumn fechaPago;
        private DataGridViewTextBoxColumn cuotas;
        private DataGridViewTextBoxColumn costoServ;
        private DataGridViewTextBoxColumn costoHab;
        private DataGridViewTextBoxColumn subtotal;
        private DataGridViewTextBoxColumn interes;
        private DataGridViewTextBoxColumn total;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}