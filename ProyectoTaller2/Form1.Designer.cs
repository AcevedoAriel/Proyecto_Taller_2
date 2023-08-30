namespace ProyectoTaller2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TUsuario = new TextBox();
            TContraseña = new TextBox();
            label4 = new Label();
            BLogin = new Button();
            LError = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 30);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(208, 30);
            label2.TabIndex = 1;
            label2.Text = "_______________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // TUsuario
            // 
            TUsuario.Location = new Point(34, 109);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(163, 23);
            TUsuario.TabIndex = 3;
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(34, 161);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(163, 23);
            TContraseña.TabIndex = 4;
            TContraseña.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 5;
            label4.Text = "Contraseña";
            // 
            // BLogin
            // 
            BLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BLogin.Location = new Point(55, 196);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(123, 51);
            BLogin.TabIndex = 6;
            BLogin.Text = "Iniciar Sesion";
            BLogin.UseVisualStyleBackColor = true;
            BLogin.Click += button1_Click;
            // 
            // LError
            // 
            LError.AutoSize = true;
            LError.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LError.ForeColor = Color.Red;
            LError.Location = new Point(12, 55);
            LError.Name = "LError";
            LError.Size = new Size(212, 16);
            LError.TabIndex = 7;
            LError.Text = "El usuario y/o contrseña incorrecta";
            LError.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(240, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(240, 217);
            label6.Name = "label6";
            label6.Size = new Size(208, 30);
            label6.TabIndex = 9;
            label6.Text = "_______________";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(474, 259);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(LError);
            Controls.Add(BLogin);
            Controls.Add(label4);
            Controls.Add(TContraseña);
            Controls.Add(TUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TUsuario;
        private TextBox TContraseña;
        private Label label4;
        private Button BLogin;
        private Label LError;
        private PictureBox pictureBox1;
        private Label label6;
    }
}