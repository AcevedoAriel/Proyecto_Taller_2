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
            panel1 = new Panel();
            BEditar = new Button();
            BEliminar = new Button();
            LMensaje = new Label();
            BRegistrar = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            TNombreUsuario = new TextBox();
            TClave = new TextBox();
            TNombre = new TextBox();
            TApellido = new TextBox();
            LContraseña = new Label();
            LPerfil = new Label();
            LNombreUsuario = new Label();
            LApellido = new Label();
            LNombre = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BEditar);
            panel1.Controls.Add(BEliminar);
            panel1.Controls.Add(LMensaje);
            panel1.Controls.Add(BRegistrar);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(TNombreUsuario);
            panel1.Controls.Add(TClave);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LContraseña);
            panel1.Controls.Add(LPerfil);
            panel1.Controls.Add(LNombreUsuario);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LNombre);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 415);
            panel1.TabIndex = 0;
            // 
            // BEditar
            // 
            BEditar.Location = new Point(507, 109);
            BEditar.Name = "BEditar";
            BEditar.Size = new Size(125, 40);
            BEditar.TabIndex = 31;
            BEditar.Text = "Editar";
            BEditar.UseVisualStyleBackColor = true;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(507, 170);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(125, 40);
            BEliminar.TabIndex = 30;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            // 
            // LMensaje
            // 
            LMensaje.AutoSize = true;
            LMensaje.Location = new Point(425, 95);
            LMensaje.Name = "LMensaje";
            LMensaje.Size = new Size(0, 15);
            LMensaje.TabIndex = 27;
            // 
            // BRegistrar
            // 
            BRegistrar.BackColor = Color.FromArgb(0, 192, 0);
            BRegistrar.FlatStyle = FlatStyle.System;
            BRegistrar.Location = new Point(507, 41);
            BRegistrar.Name = "BRegistrar";
            BRegistrar.Size = new Size(125, 40);
            BRegistrar.TabIndex = 26;
            BRegistrar.Text = "Registrar Usuario";
            BRegistrar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(29, 264);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(724, 129);
            dataGridView1.TabIndex = 25;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Recepcionista" });
            comboBox1.Location = new Point(231, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 23);
            comboBox1.TabIndex = 24;
            // 
            // TNombreUsuario
            // 
            TNombreUsuario.Location = new Point(231, 106);
            TNombreUsuario.Name = "TNombreUsuario";
            TNombreUsuario.Size = new Size(194, 23);
            TNombreUsuario.TabIndex = 23;
            // 
            // TClave
            // 
            TClave.Location = new Point(231, 146);
            TClave.Name = "TClave";
            TClave.Size = new Size(194, 23);
            TClave.TabIndex = 22;
            TClave.KeyPress += TClave_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(231, 27);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(194, 23);
            TNombre.TabIndex = 21;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(231, 66);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(194, 23);
            TApellido.TabIndex = 20;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Location = new Point(75, 149);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(67, 15);
            LContraseña.TabIndex = 19;
            LContraseña.Text = "Contraseña";
            // 
            // LPerfil
            // 
            LPerfil.AutoSize = true;
            LPerfil.Location = new Point(75, 190);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(60, 15);
            LPerfil.TabIndex = 18;
            LPerfil.Text = "Tipo Perfil";
            // 
            // LNombreUsuario
            // 
            LNombreUsuario.AutoSize = true;
            LNombreUsuario.Location = new Point(75, 109);
            LNombreUsuario.Name = "LNombreUsuario";
            LNombreUsuario.Size = new Size(110, 15);
            LNombreUsuario.TabIndex = 17;
            LNombreUsuario.Text = "Nombre de Usuario";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(75, 66);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 16;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(75, 30);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 15;
            LNombre.Text = "Nombre";
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
            Column6.Width = 110;
            // 
            // RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 415);
            Controls.Add(panel1);
            Name = "RegistrarUsuario";
            Text = "Registrar Usuario";
            Load += RegistrarUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LMensaje;
        private Button BRegistrar;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox TNombreUsuario;
        private TextBox TClave;
        private TextBox TNombre;
        private TextBox TApellido;
        private Label LContraseña;
        private Label LPerfil;
        private Label LNombreUsuario;
        private Label LApellido;
        private Label LNombre;
        private Button BEditar;
        private Button BEliminar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}