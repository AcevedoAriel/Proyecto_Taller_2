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
            splitContainer1 = new SplitContainer();
            BBuscar = new Button();
            LDescripcionBusqueda = new Label();
            TBusqueda = new TextBox();
            LListaUsuario = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BBuscar);
            splitContainer1.Panel1.Controls.Add(LDescripcionBusqueda);
            splitContainer1.Panel1.Controls.Add(TBusqueda);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(LListaUsuario);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(873, 388);
            splitContainer1.SplitterDistance = 201;
            splitContainer1.TabIndex = 0;
            // 
            // BBuscar
            // 
            BBuscar.Location = new Point(12, 134);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(75, 23);
            BBuscar.TabIndex = 16;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            // 
            // LDescripcionBusqueda
            // 
            LDescripcionBusqueda.AutoSize = true;
            LDescripcionBusqueda.ForeColor = Color.Red;
            LDescripcionBusqueda.Location = new Point(12, 78);
            LDescripcionBusqueda.Name = "LDescripcionBusqueda";
            LDescripcionBusqueda.Size = new Size(134, 15);
            LDescripcionBusqueda.TabIndex = 18;
            LDescripcionBusqueda.Text = "ID o Nombre de Usuario";
            // 
            // TBusqueda
            // 
            TBusqueda.Location = new Point(12, 105);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(160, 23);
            TBusqueda.TabIndex = 17;
            TBusqueda.TextAlign = HorizontalAlignment.Center;
            // 
            // LListaUsuario
            // 
            LListaUsuario.BackColor = Color.White;
            LListaUsuario.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LListaUsuario.Location = new Point(12, 20);
            LListaUsuario.Name = "LListaUsuario";
            LListaUsuario.Size = new Size(285, 32);
            LListaUsuario.TabIndex = 19;
            LListaUsuario.Text = "Lista de Usuarios:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column2, Column3, Column5, Column6 });
            dataGridView1.Location = new Point(12, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(644, 287);
            dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID_Usuario";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Nombre Usuario";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellido";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nombre";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Clave";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Tipo de Perfil";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // ConsularUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 388);
            Controls.Add(splitContainer1);
            Name = "ConsularUsuario";
            Text = "Consulta";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button BBuscar;
        private Label LDescripcionBusqueda;
        private TextBox TBusqueda;
        private DataGridView dataGridView1;
        private Label LListaUsuario;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}