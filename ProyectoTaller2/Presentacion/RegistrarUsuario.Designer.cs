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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            sexo = new DataGridViewTextBoxColumn();
            fechaNac = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            DTFechaNac = new DateTimePicker();
            TSexo = new ComboBox();
            TTelefono = new TextBox();
            TCorreo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            LMensaje = new Label();
            BRegistrar = new Button();
            CBPerfil = new ComboBox();
            TNombreUsuario = new TextBox();
            TClave = new TextBox();
            TNombre = new TextBox();
            TApellido = new TextBox();
            LContraseña = new Label();
            LPerfil = new Label();
            LNombreUsuario = new Label();
            LApellido = new Label();
            LNombre = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BEditar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(DTFechaNac);
            panel1.Controls.Add(TSexo);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(TCorreo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LMensaje);
            panel1.Controls.Add(BRegistrar);
            panel1.Controls.Add(CBPerfil);
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
            panel1.Size = new Size(816, 515);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BEditar
            // 
            BEditar.Location = new Point(157, 242);
            BEditar.Name = "BEditar";
            BEditar.Size = new Size(108, 25);
            BEditar.TabIndex = 44;
            BEditar.Text = "Editar";
            BEditar.UseVisualStyleBackColor = true;
            BEditar.Click += BEditar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(-17, 287);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 215);
            panel2.TabIndex = 43;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column6, Column2, Column3, Column4, Column5, email, sexo, fechaNac, telefono, estado });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(786, 215);
            dataGridView1.TabIndex = 44;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID_Usuario";
            Column1.Name = "Column1";
            // 
            // Column6
            // 
            Column6.HeaderText = "Tipo de Perfil";
            Column6.Name = "Column6";
            Column6.Width = 110;
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
            // email
            // 
            email.HeaderText = "Driección de Correo";
            email.Name = "email";
            // 
            // sexo
            // 
            sexo.HeaderText = "Sexo";
            sexo.Name = "sexo";
            // 
            // fechaNac
            // 
            fechaNac.HeaderText = "Fecha de Nacimiento";
            fechaNac.Name = "fechaNac";
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            // 
            // DTFechaNac
            // 
            DTFechaNac.Location = new Point(525, 111);
            DTFechaNac.Name = "DTFechaNac";
            DTFechaNac.Size = new Size(194, 23);
            DTFechaNac.TabIndex = 42;
            // 
            // TSexo
            // 
            TSexo.FormattingEnabled = true;
            TSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            TSexo.Location = new Point(525, 63);
            TSexo.Name = "TSexo";
            TSexo.Size = new Size(194, 23);
            TSexo.TabIndex = 41;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(525, 154);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(194, 23);
            TTelefono.TabIndex = 39;
            // 
            // TCorreo
            // 
            TCorreo.Location = new Point(525, 24);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(194, 23);
            TCorreo.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 154);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 36;
            label4.Text = "Teléfono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 111);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 35;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 66);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 34;
            label2.Text = "Sexo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 27);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 33;
            label1.Text = "Dirección de Correo";
            label1.Click += label1_Click;
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
            BRegistrar.Location = new Point(550, 199);
            BRegistrar.Name = "BRegistrar";
            BRegistrar.Size = new Size(125, 40);
            BRegistrar.TabIndex = 26;
            BRegistrar.Text = "Registrar Usuario";
            BRegistrar.UseVisualStyleBackColor = false;
            BRegistrar.Click += BRegistrar_Click_1;
            // 
            // CBPerfil
            // 
            CBPerfil.FormattingEnabled = true;
            CBPerfil.Items.AddRange(new object[] { "Super Usuario", "Administrador", "Recepcionista" });
            CBPerfil.Location = new Point(157, 184);
            CBPerfil.Name = "CBPerfil";
            CBPerfil.Size = new Size(194, 23);
            CBPerfil.TabIndex = 24;
            // 
            // TNombreUsuario
            // 
            TNombreUsuario.Location = new Point(157, 103);
            TNombreUsuario.Name = "TNombreUsuario";
            TNombreUsuario.Size = new Size(194, 23);
            TNombreUsuario.TabIndex = 23;
            // 
            // TClave
            // 
            TClave.Location = new Point(157, 146);
            TClave.Name = "TClave";
            TClave.Size = new Size(194, 23);
            TClave.TabIndex = 22;
            TClave.KeyPress += TClave_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(157, 24);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(194, 23);
            TNombre.TabIndex = 21;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(157, 58);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(194, 23);
            TApellido.TabIndex = 20;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Location = new Point(31, 146);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(67, 15);
            LContraseña.TabIndex = 19;
            LContraseña.Text = "Contraseña";
            // 
            // LPerfil
            // 
            LPerfil.AutoSize = true;
            LPerfil.Location = new Point(31, 187);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(60, 15);
            LPerfil.TabIndex = 18;
            LPerfil.Text = "Tipo Perfil";
            // 
            // LNombreUsuario
            // 
            LNombreUsuario.AutoSize = true;
            LNombreUsuario.Location = new Point(31, 106);
            LNombreUsuario.Name = "LNombreUsuario";
            LNombreUsuario.Size = new Size(110, 15);
            LNombreUsuario.TabIndex = 17;
            LNombreUsuario.Text = "Nombre de Usuario";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(31, 66);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 16;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(31, 27);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 15;
            LNombre.Text = "Nombre";
            // 
            // RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 515);
            Controls.Add(panel1);
            Name = "RegistrarUsuario";
            Text = "Registrar Usuario";
            Load += RegistrarUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LMensaje;
        private Button BRegistrar;
        private ComboBox CBPerfil;
        private TextBox TNombreUsuario;
        private TextBox TClave;
        private TextBox TNombre;
        private TextBox TApellido;
        private Label LContraseña;
        private Label LPerfil;
        private Label LNombreUsuario;
        private Label LApellido;
        private Label LNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TTelefono;
        private TextBox TCorreo;
        private ComboBox TSexo;
        private DateTimePicker DTFechaNac;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn sexo;
        private DataGridViewTextBoxColumn fechaNac;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn estado;
        private Button BEditar;
    }
}