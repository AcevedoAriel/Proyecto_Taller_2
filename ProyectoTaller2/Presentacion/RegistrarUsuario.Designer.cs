namespace ProyectoTaller2.Administrador
{
    partial class RegistrarUsuario
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
            LNombre = new Label();
            LApellido = new Label();
            LNombreUsuario = new Label();
            LPerfil = new Label();
            LContraseña = new Label();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TClave = new TextBox();
            TNombreUsuario = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            BRegistrar = new Button();
            LMensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(51, 28);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(51, 64);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 1;
            LApellido.Text = "Apellido";
            // 
            // LNombreUsuario
            // 
            LNombreUsuario.AutoSize = true;
            LNombreUsuario.Location = new Point(51, 98);
            LNombreUsuario.Name = "LNombreUsuario";
            LNombreUsuario.Size = new Size(110, 15);
            LNombreUsuario.TabIndex = 2;
            LNombreUsuario.Text = "Nombre de Usuario";
            // 
            // LPerfil
            // 
            LPerfil.AutoSize = true;
            LPerfil.Location = new Point(51, 161);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(60, 15);
            LPerfil.TabIndex = 3;
            LPerfil.Text = "Tipo Perfil";
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Location = new Point(51, 127);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(67, 15);
            LContraseña.TabIndex = 4;
            LContraseña.Text = "Contraseña";
            // 
            // TApellido
            // 
            TApellido.Location = new Point(183, 64);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(121, 23);
            TApellido.TabIndex = 5;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(183, 28);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(121, 23);
            TNombre.TabIndex = 6;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TClave
            // 
            TClave.Location = new Point(183, 127);
            TClave.Name = "TClave";
            TClave.Size = new Size(121, 23);
            TClave.TabIndex = 7;
            TClave.KeyPress += TClave_KeyPress;
            // 
            // TNombreUsuario
            // 
            TNombreUsuario.Location = new Point(183, 98);
            TNombreUsuario.Name = "TNombreUsuario";
            TNombreUsuario.Size = new Size(121, 23);
            TNombreUsuario.TabIndex = 8;
            TNombreUsuario.KeyDown += TNombreUsuario_KeyDown;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Recepcionista" });
            comboBox1.Location = new Point(183, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(12, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(724, 129);
            dataGridView1.TabIndex = 10;
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
            // BRegistrar
            // 
            BRegistrar.Location = new Point(183, 192);
            BRegistrar.Name = "BRegistrar";
            BRegistrar.Size = new Size(91, 55);
            BRegistrar.TabIndex = 11;
            BRegistrar.Text = "Registrar Usuario";
            BRegistrar.UseVisualStyleBackColor = true;
            BRegistrar.Click += BRegistrar_Click;
            // 
            // LMensaje
            // 
            LMensaje.AutoSize = true;
            LMensaje.Location = new Point(325, 101);
            LMensaje.Name = "LMensaje";
            LMensaje.Size = new Size(0, 15);
            LMensaje.TabIndex = 12;
            // 
            // RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 415);
            Controls.Add(LMensaje);
            Controls.Add(BRegistrar);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(TNombreUsuario);
            Controls.Add(TClave);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(LContraseña);
            Controls.Add(LPerfil);
            Controls.Add(LNombreUsuario);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Name = "RegistrarUsuario";
            Text = "Registrar Usuario";
            Load += RegistrarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNombre;
        private Label LApellido;
        private Label LNombreUsuario;
        private Label LPerfil;
        private Label LContraseña;
        private TextBox TApellido;
        private TextBox TNombre;
        private TextBox TClave;
        private TextBox TNombreUsuario;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button BRegistrar;
        private Label LMensaje;
    }
}