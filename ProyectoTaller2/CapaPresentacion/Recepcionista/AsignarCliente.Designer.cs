namespace ProyectoTaller2.CapaPresentacion.Recepcionista
{
    partial class AsignarCliente
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
            label2 = new Label();
            TTelefono = new TextBox();
            LTel = new Label();
            LDNI = new Label();
            TDNI = new TextBox();
            TNombre = new TextBox();
            TApellido = new TextBox();
            LApellido = new Label();
            LNombre = new Label();
            panel1 = new Panel();
            txtFiltrar = new TextBox();
            btnRegistrar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(697, 230);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 20);
            label2.Name = "label2";
            label2.Size = new Size(217, 32);
            label2.TabIndex = 2;
            label2.Text = "Registrar Cliente :";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(494, 169);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(160, 23);
            TTelefono.TabIndex = 43;
            // 
            // LTel
            // 
            LTel.AutoSize = true;
            LTel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LTel.Location = new Point(349, 177);
            LTel.Name = "LTel";
            LTel.Size = new Size(124, 15);
            LTel.TabIndex = 42;
            LTel.Text = "Telefono del Cliente :";
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LDNI.Location = new Point(22, 105);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(97, 15);
            LDNI.TabIndex = 41;
            LDNI.Text = "DNI del Cliente :";
            // 
            // TDNI
            // 
            TDNI.Location = new Point(149, 102);
            TDNI.Name = "TDNI";
            TDNI.Size = new Size(160, 23);
            TDNI.TabIndex = 40;
            // 
            // TNombre
            // 
            TNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TNombre.Location = new Point(149, 177);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(160, 23);
            TNombre.TabIndex = 39;
            // 
            // TApellido
            // 
            TApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TApellido.Location = new Point(494, 110);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(160, 23);
            TApellido.TabIndex = 38;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LApellido.Location = new Point(349, 110);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(120, 15);
            LApellido.TabIndex = 37;
            LApellido.Text = "Apellido del Cliente :";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LNombre.Location = new Point(22, 180);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(121, 15);
            LNombre.TabIndex = 36;
            LNombre.Text = "Nombre del Cliente :";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(41, 224);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 230);
            panel1.TabIndex = 44;
            // 
            // txtFiltrar
            // 
            txtFiltrar.Location = new Point(586, 31);
            txtFiltrar.Name = "txtFiltrar";
            txtFiltrar.Size = new Size(164, 23);
            txtFiltrar.TabIndex = 45;
            txtFiltrar.TextChanged += txtFiltrar_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Lime;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(697, 60);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 48);
            btnRegistrar.TabIndex = 46;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Lime;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(697, 114);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 48);
            btnGuardar.TabIndex = 47;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(467, 34);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 48;
            label1.Text = "Buscar por  DNI :";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DeepSkyBlue;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(697, 172);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 48);
            btnEditar.TabIndex = 49;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // AsignarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtFiltrar);
            Controls.Add(panel1);
            Controls.Add(TTelefono);
            Controls.Add(LTel);
            Controls.Add(LDNI);
            Controls.Add(TDNI);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(label2);
            Name = "AsignarCliente";
            Text = "AsignarCliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox TTelefono;
        private Label LTel;
        private Label LDNI;
        private TextBox TDNI;
        private TextBox TNombre;
        private TextBox TApellido;
        private Label LApellido;
        private Label LNombre;
        private Panel panel1;
        private TextBox txtFiltrar;
        private Button btnRegistrar;
        private Button btnGuardar;
        private Label label1;
        private Button btnEditar;
    }
}