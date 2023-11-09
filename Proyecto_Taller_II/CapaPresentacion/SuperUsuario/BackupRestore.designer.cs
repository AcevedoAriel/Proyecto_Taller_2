using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion.SuperUsuario
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
            this.lblTituloRespaldo = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lblRutaRespaldo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtAbrirGuardar = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.CBBaseDeDatos = new System.Windows.Forms.ComboBox();
            this.btnConectarBD = new System.Windows.Forms.Button();
            this.lblBaseDeDatos = new System.Windows.Forms.Label();
            this.btnAbrirRespaldo = new System.Windows.Forms.Button();
            this.btnAbrirRestaurar = new System.Windows.Forms.Button();
            this.txtAbrirRestaurar = new System.Windows.Forms.TextBox();
            this.lblRestaurar = new System.Windows.Forms.Label();
            this.txtBaseRestaurar = new System.Windows.Forms.TextBox();
            this.lblBaseDeDatosRestaurar = new System.Windows.Forms.Label();
            this.btnRestaruar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloRespaldo
            // 
            this.lblTituloRespaldo.AutoSize = true;
            this.lblTituloRespaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTituloRespaldo.ForeColor = System.Drawing.Color.White;
            this.lblTituloRespaldo.Location = new System.Drawing.Point(75, 8);
            this.lblTituloRespaldo.Name = "lblTituloRespaldo";
            this.lblTituloRespaldo.Size = new System.Drawing.Size(711, 37);
            this.lblTituloRespaldo.TabIndex = 0;
            this.lblTituloRespaldo.Text = "Respaldo y Restauracion de la Base de Datos";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Lime;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBackup.Location = new System.Drawing.Point(313, 193);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(86, 35);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "Respaldar";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblRutaRespaldo
            // 
            this.lblRutaRespaldo.AutoSize = true;
            this.lblRutaRespaldo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRutaRespaldo.Location = new System.Drawing.Point(95, 165);
            this.lblRutaRespaldo.Name = "lblRutaRespaldo";
            this.lblRutaRespaldo.Size = new System.Drawing.Size(93, 15);
            this.lblRutaRespaldo.TabIndex = 2;
            this.lblRutaRespaldo.Text = "Ruta a Guardar:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtAbrirGuardar
            // 
            this.txtAbrirGuardar.Location = new System.Drawing.Point(186, 158);
            this.txtAbrirGuardar.Name = "txtAbrirGuardar";
            this.txtAbrirGuardar.Size = new System.Drawing.Size(349, 20);
            this.txtAbrirGuardar.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 67;
            this.iconPictureBox1.Location = new System.Drawing.Point(75, 44);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(75, 67);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // CBBaseDeDatos
            // 
            this.CBBaseDeDatos.FormattingEnabled = true;
            this.CBBaseDeDatos.Location = new System.Drawing.Point(286, 63);
            this.CBBaseDeDatos.Name = "CBBaseDeDatos";
            this.CBBaseDeDatos.Size = new System.Drawing.Size(159, 21);
            this.CBBaseDeDatos.TabIndex = 5;
            // 
            // btnConectarBD
            // 
            this.btnConectarBD.BackColor = System.Drawing.Color.White;
            this.btnConectarBD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConectarBD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConectarBD.Location = new System.Drawing.Point(461, 51);
            this.btnConectarBD.Name = "btnConectarBD";
            this.btnConectarBD.Size = new System.Drawing.Size(73, 42);
            this.btnConectarBD.TabIndex = 6;
            this.btnConectarBD.Text = "Conectar";
            this.btnConectarBD.UseVisualStyleBackColor = false;
            this.btnConectarBD.Click += new System.EventHandler(this.btnConectarBD_Click);
            // 
            // lblBaseDeDatos
            // 
            this.lblBaseDeDatos.AutoSize = true;
            this.lblBaseDeDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBaseDeDatos.Location = new System.Drawing.Point(194, 70);
            this.lblBaseDeDatos.Name = "lblBaseDeDatos";
            this.lblBaseDeDatos.Size = new System.Drawing.Size(88, 15);
            this.lblBaseDeDatos.TabIndex = 7;
            this.lblBaseDeDatos.Text = "Base de Datos:";
            // 
            // btnAbrirRespaldo
            // 
            this.btnAbrirRespaldo.BackColor = System.Drawing.Color.Silver;
            this.btnAbrirRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirRespaldo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAbrirRespaldo.Location = new System.Drawing.Point(558, 153);
            this.btnAbrirRespaldo.Name = "btnAbrirRespaldo";
            this.btnAbrirRespaldo.Size = new System.Drawing.Size(86, 28);
            this.btnAbrirRespaldo.TabIndex = 9;
            this.btnAbrirRespaldo.Text = "Abrir";
            this.btnAbrirRespaldo.UseVisualStyleBackColor = false;
            this.btnAbrirRespaldo.Click += new System.EventHandler(this.btnAbrirRespaldo_Click);
            // 
            // btnAbrirRestaurar
            // 
            this.btnAbrirRestaurar.BackColor = System.Drawing.Color.Silver;
            this.btnAbrirRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirRestaurar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAbrirRestaurar.Location = new System.Drawing.Point(558, 266);
            this.btnAbrirRestaurar.Name = "btnAbrirRestaurar";
            this.btnAbrirRestaurar.Size = new System.Drawing.Size(86, 28);
            this.btnAbrirRestaurar.TabIndex = 12;
            this.btnAbrirRestaurar.Text = "Abrir";
            this.btnAbrirRestaurar.UseVisualStyleBackColor = false;
            this.btnAbrirRestaurar.Click += new System.EventHandler(this.btnAbrirRestaurar_Click);
            // 
            // txtAbrirRestaurar
            // 
            this.txtAbrirRestaurar.Location = new System.Drawing.Point(186, 271);
            this.txtAbrirRestaurar.Name = "txtAbrirRestaurar";
            this.txtAbrirRestaurar.Size = new System.Drawing.Size(349, 20);
            this.txtAbrirRestaurar.TabIndex = 11;
            // 
            // lblRestaurar
            // 
            this.lblRestaurar.AutoSize = true;
            this.lblRestaurar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRestaurar.Location = new System.Drawing.Point(95, 278);
            this.lblRestaurar.Name = "lblRestaurar";
            this.lblRestaurar.Size = new System.Drawing.Size(93, 15);
            this.lblRestaurar.TabIndex = 10;
            this.lblRestaurar.Text = "Ruta Restaurar:";
            // 
            // txtBaseRestaurar
            // 
            this.txtBaseRestaurar.Location = new System.Drawing.Point(186, 315);
            this.txtBaseRestaurar.Name = "txtBaseRestaurar";
            this.txtBaseRestaurar.Size = new System.Drawing.Size(349, 20);
            this.txtBaseRestaurar.TabIndex = 14;
            // 
            // lblBaseDeDatosRestaurar
            // 
            this.lblBaseDeDatosRestaurar.AutoSize = true;
            this.lblBaseDeDatosRestaurar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBaseDeDatosRestaurar.Location = new System.Drawing.Point(43, 322);
            this.lblBaseDeDatosRestaurar.Name = "lblBaseDeDatosRestaurar";
            this.lblBaseDeDatosRestaurar.Size = new System.Drawing.Size(154, 15);
            this.lblBaseDeDatosRestaurar.TabIndex = 13;
            this.lblBaseDeDatosRestaurar.Text = "Base de Datos a Restaurar:";
            // 
            // btnRestaruar
            // 
            this.btnRestaruar.BackColor = System.Drawing.Color.Lime;
            this.btnRestaruar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestaruar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRestaruar.Location = new System.Drawing.Point(313, 358);
            this.btnRestaruar.Name = "btnRestaruar";
            this.btnRestaruar.Size = new System.Drawing.Size(86, 35);
            this.btnRestaruar.TabIndex = 15;
            this.btnRestaruar.Text = "Restaurar";
            this.btnRestaruar.UseVisualStyleBackColor = false;
            this.btnRestaruar.Click += new System.EventHandler(this.btnRestaruar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(919, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(919, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________________";
            // 
            // FMBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestaruar);
            this.Controls.Add(this.txtBaseRestaurar);
            this.Controls.Add(this.lblBaseDeDatosRestaurar);
            this.Controls.Add(this.btnAbrirRestaurar);
            this.Controls.Add(this.txtAbrirRestaurar);
            this.Controls.Add(this.lblRestaurar);
            this.Controls.Add(this.btnAbrirRespaldo);
            this.Controls.Add(this.lblBaseDeDatos);
            this.Controls.Add(this.btnConectarBD);
            this.Controls.Add(this.CBBaseDeDatos);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtAbrirGuardar);
            this.Controls.Add(this.lblRutaRespaldo);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lblTituloRespaldo);
            this.Name = "FMBackupRestore";
            this.Text = "Backup y Restore";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox txtBaseRestaurar;
        private Label lblBaseDeDatosRestaurar;
        private Button btnRestaruar;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private Label label2;
    }
}