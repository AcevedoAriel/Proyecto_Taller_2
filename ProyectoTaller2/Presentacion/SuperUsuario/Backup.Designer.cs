namespace ProyectoTaller2.Presentacion.SuperUsuario
{
    partial class FMBackup
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
            lblTituloRespaldo = new Label();
            btnBackup = new Button();
            lblRutaRespaldo = new Label();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTituloRespaldo
            // 
            lblTituloRespaldo.AutoSize = true;
            lblTituloRespaldo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTituloRespaldo.ForeColor = Color.White;
            lblTituloRespaldo.Location = new Point(107, 22);
            lblTituloRespaldo.Name = "lblTituloRespaldo";
            lblTituloRespaldo.Size = new Size(475, 37);
            lblTituloRespaldo.TabIndex = 0;
            lblTituloRespaldo.Text = "Respaldo de la Base de Datos";
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.Lime;
            btnBackup.FlatStyle = FlatStyle.Popup;
            btnBackup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackup.Location = new Point(474, 203);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(100, 40);
            btnBackup.TabIndex = 1;
            btnBackup.Text = "Respaldar";
            btnBackup.UseVisualStyleBackColor = false;
            // 
            // lblRutaRespaldo
            // 
            lblRutaRespaldo.AutoSize = true;
            lblRutaRespaldo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRutaRespaldo.Location = new Point(120, 118);
            lblRutaRespaldo.Name = "lblRutaRespaldo";
            lblRutaRespaldo.Size = new Size(134, 15);
            lblRutaRespaldo.TabIndex = 2;
            lblRutaRespaldo.Text = "Ruta del Respaldo :";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(454, 23);
            textBox1.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 86;
            iconPictureBox1.Location = new Point(12, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(89, 86);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // FMBackup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 465);
            Controls.Add(iconPictureBox1);
            Controls.Add(textBox1);
            Controls.Add(lblRutaRespaldo);
            Controls.Add(btnBackup);
            Controls.Add(lblTituloRespaldo);
            Name = "FMBackup";
            Text = "Backup";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloRespaldo;
        private Button btnBackup;
        private Label lblRutaRespaldo;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}