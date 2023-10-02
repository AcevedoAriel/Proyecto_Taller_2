namespace ProyectoTaller2.Presentacion.SuperUsuario
{
    partial class FMBackupRestore
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
            txtAbrirGuardar = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            CBBaseDeDatos = new ComboBox();
            btnConectarBD = new Button();
            lblBaseDeDatos = new Label();
            btnAbrirRespaldo = new Button();
            btnAbrirRestaurar = new Button();
            txtAbrirRestaurar = new TextBox();
            lblRestaurar = new Label();
            textBox2 = new TextBox();
            lblBaseDeDatosRestaurar = new Label();
            btnRestaruar = new Button();
            saveFileDialog1 = new SaveFileDialog();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTituloRespaldo
            // 
            lblTituloRespaldo.AutoSize = true;
            lblTituloRespaldo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTituloRespaldo.ForeColor = Color.White;
            lblTituloRespaldo.Location = new Point(87, 9);
            lblTituloRespaldo.Name = "lblTituloRespaldo";
            lblTituloRespaldo.Size = new Size(711, 37);
            lblTituloRespaldo.TabIndex = 0;
            lblTituloRespaldo.Text = "Respaldo y Restauracion de la Base de Datos";
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.Lime;
            btnBackup.FlatStyle = FlatStyle.Popup;
            btnBackup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackup.Location = new Point(365, 223);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(100, 40);
            btnBackup.TabIndex = 1;
            btnBackup.Text = "Respaldar";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // lblRutaRespaldo
            // 
            lblRutaRespaldo.AutoSize = true;
            lblRutaRespaldo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRutaRespaldo.Location = new Point(111, 190);
            lblRutaRespaldo.Name = "lblRutaRespaldo";
            lblRutaRespaldo.Size = new Size(93, 15);
            lblRutaRespaldo.TabIndex = 2;
            lblRutaRespaldo.Text = "Ruta a Guardar:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtAbrirGuardar
            // 
            txtAbrirGuardar.Location = new Point(217, 182);
            txtAbrirGuardar.Name = "txtAbrirGuardar";
            txtAbrirGuardar.Size = new Size(406, 23);
            txtAbrirGuardar.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 77;
            iconPictureBox1.Location = new Point(2, 9);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(87, 77);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // CBBaseDeDatos
            // 
            CBBaseDeDatos.FormattingEnabled = true;
            CBBaseDeDatos.Location = new Point(334, 73);
            CBBaseDeDatos.Name = "CBBaseDeDatos";
            CBBaseDeDatos.Size = new Size(185, 23);
            CBBaseDeDatos.TabIndex = 5;
            // 
            // btnConectarBD
            // 
            btnConectarBD.BackColor = Color.White;
            btnConectarBD.FlatStyle = FlatStyle.Popup;
            btnConectarBD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConectarBD.Location = new Point(538, 59);
            btnConectarBD.Name = "btnConectarBD";
            btnConectarBD.Size = new Size(85, 49);
            btnConectarBD.TabIndex = 6;
            btnConectarBD.Text = "Conectar";
            btnConectarBD.UseVisualStyleBackColor = false;
            btnConectarBD.Click += btnConectarBD_Click;
            // 
            // lblBaseDeDatos
            // 
            lblBaseDeDatos.AutoSize = true;
            lblBaseDeDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaseDeDatos.Location = new Point(226, 81);
            lblBaseDeDatos.Name = "lblBaseDeDatos";
            lblBaseDeDatos.Size = new Size(88, 15);
            lblBaseDeDatos.TabIndex = 7;
            lblBaseDeDatos.Text = "Base de Datos:";
            // 
            // btnAbrirRespaldo
            // 
            btnAbrirRespaldo.BackColor = Color.Silver;
            btnAbrirRespaldo.FlatStyle = FlatStyle.Popup;
            btnAbrirRespaldo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbrirRespaldo.Location = new Point(651, 176);
            btnAbrirRespaldo.Name = "btnAbrirRespaldo";
            btnAbrirRespaldo.Size = new Size(100, 32);
            btnAbrirRespaldo.TabIndex = 9;
            btnAbrirRespaldo.Text = "Abrir";
            btnAbrirRespaldo.UseVisualStyleBackColor = false;
            btnAbrirRespaldo.Click += btnAbrirRespaldo_Click;
            // 
            // btnAbrirRestaurar
            // 
            btnAbrirRestaurar.BackColor = Color.Silver;
            btnAbrirRestaurar.FlatStyle = FlatStyle.Popup;
            btnAbrirRestaurar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbrirRestaurar.Location = new Point(651, 307);
            btnAbrirRestaurar.Name = "btnAbrirRestaurar";
            btnAbrirRestaurar.Size = new Size(100, 32);
            btnAbrirRestaurar.TabIndex = 12;
            btnAbrirRestaurar.Text = "Abrir";
            btnAbrirRestaurar.UseVisualStyleBackColor = false;
            btnAbrirRestaurar.Click += btnAbrirRestaurar_Click;
            // 
            // txtAbrirRestaurar
            // 
            txtAbrirRestaurar.Location = new Point(217, 313);
            txtAbrirRestaurar.Name = "txtAbrirRestaurar";
            txtAbrirRestaurar.Size = new Size(406, 23);
            txtAbrirRestaurar.TabIndex = 11;
            // 
            // lblRestaurar
            // 
            lblRestaurar.AutoSize = true;
            lblRestaurar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRestaurar.Location = new Point(111, 321);
            lblRestaurar.Name = "lblRestaurar";
            lblRestaurar.Size = new Size(93, 15);
            lblRestaurar.TabIndex = 10;
            lblRestaurar.Text = "Ruta Restaurar:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(217, 364);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(406, 23);
            textBox2.TabIndex = 14;
            // 
            // lblBaseDeDatosRestaurar
            // 
            lblBaseDeDatosRestaurar.AutoSize = true;
            lblBaseDeDatosRestaurar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaseDeDatosRestaurar.Location = new Point(50, 372);
            lblBaseDeDatosRestaurar.Name = "lblBaseDeDatosRestaurar";
            lblBaseDeDatosRestaurar.Size = new Size(154, 15);
            lblBaseDeDatosRestaurar.TabIndex = 13;
            lblBaseDeDatosRestaurar.Text = "Base de Datos a Restaurar:";
            // 
            // btnRestaruar
            // 
            btnRestaruar.BackColor = Color.Lime;
            btnRestaruar.FlatStyle = FlatStyle.Popup;
            btnRestaruar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestaruar.Location = new Point(365, 413);
            btnRestaruar.Name = "btnRestaruar";
            btnRestaruar.Size = new Size(100, 40);
            btnRestaruar.TabIndex = 15;
            btnRestaruar.Text = "Restaurar";
            btnRestaruar.UseVisualStyleBackColor = false;
            btnRestaruar.Click += btnRestaruar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 277);
            label1.Name = "label1";
            label1.Size = new Size(767, 15);
            label1.TabIndex = 16;
            label1.Text = "________________________________________________________________________________________________________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 131);
            label2.Name = "label2";
            label2.Size = new Size(767, 15);
            label2.TabIndex = 17;
            label2.Text = "________________________________________________________________________________________________________________________________________________________";
            // 
            // FMBackupRestore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 465);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRestaruar);
            Controls.Add(textBox2);
            Controls.Add(lblBaseDeDatosRestaurar);
            Controls.Add(btnAbrirRestaurar);
            Controls.Add(txtAbrirRestaurar);
            Controls.Add(lblRestaurar);
            Controls.Add(btnAbrirRespaldo);
            Controls.Add(lblBaseDeDatos);
            Controls.Add(btnConectarBD);
            Controls.Add(CBBaseDeDatos);
            Controls.Add(iconPictureBox1);
            Controls.Add(txtAbrirGuardar);
            Controls.Add(lblRutaRespaldo);
            Controls.Add(btnBackup);
            Controls.Add(lblTituloRespaldo);
            Name = "FMBackupRestore";
            Text = "Backup y Restore";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloRespaldo;
        private Button btnBackup;
        private Label lblRutaRespaldo;
        private OpenFileDialog openFileDialog1;
        private TextBox txtAbrirGuardar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private ComboBox CBBaseDeDatos;
        private Button btnConectarBD;
        private Label lblBaseDeDatos;
        private Button btnAbrirRespaldo;
        private Button btnAbrirRestaurar;
        private TextBox txtAbrirRestaurar;
        private Label lblRestaurar;
        private TextBox textBox2;
        private Label lblBaseDeDatosRestaurar;
        private Button btnRestaruar;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private Label label2;
    }
}