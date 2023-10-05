namespace ProyectoTaller2.Presentacion
{
    partial class FMIniciarSesion
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
            picboxLogoHOTEL = new PictureBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            labelTituloSesion = new Label();
            label2 = new Label();
            labelUsuario = new Label();
            labelClave = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picboxLogoHOTEL).BeginInit();
            SuspendLayout();
            // 
            // picboxLogoHOTEL
            // 
            picboxLogoHOTEL.Dock = DockStyle.Right;
            picboxLogoHOTEL.Image = Properties.Resources.HotelParana;
            picboxLogoHOTEL.Location = new Point(271, 0);
            picboxLogoHOTEL.Name = "picboxLogoHOTEL";
            picboxLogoHOTEL.Size = new Size(271, 270);
            picboxLogoHOTEL.SizeMode = PictureBoxSizeMode.Zoom;
            picboxLogoHOTEL.TabIndex = 0;
            picboxLogoHOTEL.TabStop = false;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(38, 219);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(91, 30);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(150, 219);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 30);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // labelTituloSesion
            // 
            labelTituloSesion.AutoSize = true;
            labelTituloSesion.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTituloSesion.ForeColor = Color.DodgerBlue;
            labelTituloSesion.Location = new Point(58, 21);
            labelTituloSesion.Name = "labelTituloSesion";
            labelTituloSesion.Size = new Size(164, 28);
            labelTituloSesion.TabIndex = 3;
            labelTituloSesion.Text = "Iniciar Sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(67, 49);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 4;
            label2.Text = "___________________________";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuario.Location = new Point(48, 78);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(67, 20);
            labelUsuario.TabIndex = 5;
            labelUsuario.Text = "Usuario:";
            // 
            // labelClave
            // 
            labelClave.AutoSize = true;
            labelClave.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelClave.Location = new Point(48, 141);
            labelClave.Name = "labelClave";
            labelClave.Size = new Size(99, 20);
            labelClave.TabIndex = 6;
            labelClave.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(48, 101);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(193, 23);
            txtUsuario.TabIndex = 7;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(48, 164);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(193, 23);
            txtClave.TabIndex = 8;
            txtClave.UseSystemPasswordChar = true;
            // 
            // FMIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancelar;
            ClientSize = new Size(542, 270);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(labelClave);
            Controls.Add(labelUsuario);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(picboxLogoHOTEL);
            Controls.Add(labelTituloSesion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FMIniciarSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IniciarSesion";
            ((System.ComponentModel.ISupportInitialize)picboxLogoHOTEL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picboxLogoHOTEL;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label labelTituloSesion;
        private Label label2;
        private Label labelUsuario;
        private Label labelClave;
        public TextBox txtUsuario;
        public TextBox txtClave;
    }
}