namespace ProyectoTaller2.Presentacion
{
    partial class Pagos
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
            motivo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { motivo, nombre, fecha, monto });
            dataGridView1.Location = new Point(23, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(645, 154);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // motivo
            // 
            motivo.HeaderText = "Motivo del Pago";
            motivo.Name = "motivo";
            motivo.Width = 200;
            // 
            // nombre
            // 
            nombre.HeaderText = "A Nombre de";
            nombre.Name = "nombre";
            nombre.Width = 200;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha del Pago";
            fecha.Name = "fecha";
            // 
            // monto
            // 
            monto.HeaderText = "Monto Pagado";
            monto.Name = "monto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 48);
            label1.Name = "label1";
            label1.Size = new Size(357, 31);
            label1.TabIndex = 1;
            label1.Text = "Registro de Pagos Realizados";
            label1.Click += label1_Click;
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Pagos";
            Text = "Pagos Realizados";
            Load += Pagos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn motivo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn monto;
        private Label label1;
    }
}