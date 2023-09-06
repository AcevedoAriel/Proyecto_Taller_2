namespace ProyectoTaller2.Administrador
{
    partial class ConsularUsuario
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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            BBuscar = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(12, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(748, 284);
            dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID_Usuario";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellido";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Nombre";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Nombre Usuario";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Contraseña";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Tipo de Perfil";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Eliminar";
            Column7.Name = "Column7";
            // 
            // BBuscar
            // 
            BBuscar.Location = new Point(290, 59);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(75, 23);
            BBuscar.TabIndex = 12;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 13;
            textBox1.Text = "ID o Nombre Usuario";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // ConsularUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(BBuscar);
            Controls.Add(dataGridView1);
            Name = "ConsularUsuario";
            Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button BBuscar;
        private TextBox textBox1;
    }
}