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
            splitContainer1 = new SplitContainer();
            labelError = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            LBCLave = new Label();
            LBUsuario = new Label();
            InicioDeSesion = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(labelError);
            splitContainer1.Panel1.Controls.Add(btnAceptar);
            splitContainer1.Panel1.Controls.Add(btnCancelar);
            splitContainer1.Panel1.Controls.Add(txtClave);
            splitContainer1.Panel1.Controls.Add(txtUsuario);
            splitContainer1.Panel1.Controls.Add(LBCLave);
            splitContainer1.Panel1.Controls.Add(LBUsuario);
            splitContainer1.Panel1.Controls.Add(InicioDeSesion);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(594, 293);
            splitContainer1.SplitterDistance = 306;
            splitContainer1.TabIndex = 0;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Californian FB", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(64, 208);
            labelError.Name = "labelError";
            labelError.Size = new Size(174, 14);
            labelError.TabIndex = 8;
            labelError.Text = "El Usuario y/o Contraseña Incorrecta";
            labelError.Visible = false;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Californian FB", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(48, 242);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(101, 30);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Californian FB", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(155, 242);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(64, 172);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(174, 23);
            txtClave.TabIndex = 5;
            txtClave.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(64, 110);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(174, 23);
            txtUsuario.TabIndex = 4;
            // 
            // LBCLave
            // 
            LBCLave.AutoSize = true;
            LBCLave.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LBCLave.Location = new Point(64, 151);
            LBCLave.Name = "LBCLave";
            LBCLave.Size = new Size(85, 18);
            LBCLave.TabIndex = 3;
            LBCLave.Text = "Contraseña:";
            // 
            // LBUsuario
            // 
            LBUsuario.AutoSize = true;
            LBUsuario.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LBUsuario.Location = new Point(64, 89);
            LBUsuario.Name = "LBUsuario";
            LBUsuario.Size = new Size(63, 18);
            LBUsuario.TabIndex = 2;
            LBUsuario.Text = "Usuario:";
            // 
            // InicioDeSesion
            // 
            InicioDeSesion.AutoSize = true;
            InicioDeSesion.Font = new Font("Californian FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            InicioDeSesion.ForeColor = Color.DodgerBlue;
            InicioDeSesion.Location = new Point(73, 28);
            InicioDeSesion.Name = "InicioDeSesion";
            InicioDeSesion.Size = new Size(139, 27);
            InicioDeSesion.TabIndex = 0;
            InicioDeSesion.Text = "Iniciar Sesion";
            InicioDeSesion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 44);
            label1.Name = "label1";
            label1.Size = new Size(164, 21);
            label1.TabIndex = 1;
            label1.Text = "______________________";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.HotelParana;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 293);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FMIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 293);
            Controls.Add(splitContainer1);
            Name = "FMIniciarSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IniciarSesion";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label InicioDeSesion;
        private Label label1;
        private Label LBCLave;
        private Label LBUsuario;
        private TextBox txtClave;
        private TextBox txtUsuario;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label labelError;
    }
}