namespace ProyectoTaller2.Presentacion
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            Bbuscar = new Button();
            Tbuscar = new TextBox();
            nombre = new DataGridViewTextBoxColumn();
            medioPago = new DataGridViewTextBoxColumn();
            fechaPago = new DataGridViewTextBoxColumn();
            cuotas = new DataGridViewTextBoxColumn();
            costoServ = new DataGridViewTextBoxColumn();
            costoHab = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            descuento = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, medioPago, fechaPago, cuotas, costoServ, costoHab, subtotal, descuento, total });
            dataGridView1.Location = new Point(3, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1044, 150);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 65);
            label1.Name = "label1";
            label1.Size = new Size(252, 31);
            label1.TabIndex = 1;
            label1.Text = "Registro de Ingresos";
            // 
            // Bbuscar
            // 
            Bbuscar.Location = new Point(874, 86);
            Bbuscar.Name = "Bbuscar";
            Bbuscar.Size = new Size(75, 23);
            Bbuscar.TabIndex = 2;
            Bbuscar.Text = "Buscar";
            Bbuscar.UseVisualStyleBackColor = true;
            Bbuscar.Click += Bbuscar_Click;
            // 
            // Tbuscar
            // 
            Tbuscar.Location = new Point(636, 86);
            Tbuscar.Name = "Tbuscar";
            Tbuscar.Size = new Size(198, 23);
            Tbuscar.TabIndex = 3;
            Tbuscar.TextChanged += Tbuscar_TextChanged;
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
            subtotal.HeaderText = "Subtotal ";
            subtotal.Name = "subtotal";
            // 
            // descuento
            // 
            descuento.HeaderText = "Descuento";
            descuento.Name = "descuento";
            // 
            // total
            // 
            total.HeaderText = "Monto Total";
            total.Name = "total";
            // 
            // Ingresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 450);
            Controls.Add(Tbuscar);
            Controls.Add(Bbuscar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Ingresos";
            Text = "Ingresos";
            Load += Ingresos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button Bbuscar;
        private TextBox Tbuscar;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn medioPago;
        private DataGridViewTextBoxColumn fechaPago;
        private DataGridViewTextBoxColumn cuotas;
        private DataGridViewTextBoxColumn costoServ;
        private DataGridViewTextBoxColumn costoHab;
        private DataGridViewTextBoxColumn subtotal;
        private DataGridViewTextBoxColumn descuento;
        private DataGridViewTextBoxColumn total;
    }
}