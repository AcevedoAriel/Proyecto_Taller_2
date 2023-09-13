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
            DTFechaNac = new DateTimePicker();
            TSexo = new ComboBox();
            textBox3 = new TextBox();
            TCorreo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            LMensaje = new Label();
            BRegistrar = new Button();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(DTFechaNac);
            panel1.Controls.Add(TSexo);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(TCorreo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LMensaje);
            panel1.Controls.Add(BRegistrar);
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
            panel1.Size = new Size(843, 415);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // DTFechaNac
            // 
            DTFechaNac.Location = new Point(157, 319);
            DTFechaNac.Name = "DTFechaNac";
            DTFechaNac.Size = new Size(194, 23);
            DTFechaNac.TabIndex = 42;
            // 
            // TSexo
            // 
            TSexo.FormattingEnabled = true;
            TSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            TSexo.Location = new Point(157, 276);
            TSexo.Name = "TSexo";
            TSexo.Size = new Size(194, 23);
            TSexo.TabIndex = 41;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 352);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 23);
            textBox3.TabIndex = 39;
            // 
            // TCorreo
            // 
            TCorreo.Location = new Point(157, 227);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(194, 23);
            TCorreo.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 352);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 36;
            label4.Text = "Teléfono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 319);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 35;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 279);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 34;
            label2.Text = "Sexo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 235);
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
            BRegistrar.Location = new Point(425, 342);
            BRegistrar.Name = "BRegistrar";
            BRegistrar.Size = new Size(125, 40);
            BRegistrar.TabIndex = 26;
            BRegistrar.Text = "Registrar Usuario";
            BRegistrar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Super Usuario", "Administrador", "Recepcionista" });
            comboBox1.Location = new Point(157, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 23);
            comboBox1.TabIndex = 24;
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
            ClientSize = new Size(843, 415);
            Controls.Add(panel1);
            Name = "RegistrarUsuario";
            Text = "Registrar Usuario";
            Load += RegistrarUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LMensaje;
        private Button BRegistrar;
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox TCorreo;
        private ComboBox TSexo;
        private DateTimePicker DTFechaNac;
    }
}