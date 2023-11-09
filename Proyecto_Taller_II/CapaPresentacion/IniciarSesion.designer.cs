using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion
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
            this.picboxLogoHOTEL = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelTituloSesion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelClave = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogoHOTEL)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxLogoHOTEL
            // 
            this.picboxLogoHOTEL.Dock = System.Windows.Forms.DockStyle.Right;
            this.picboxLogoHOTEL.Image = global::Proyecto_Taller_II.Properties.Resources.HotelParana;
            this.picboxLogoHOTEL.Location = new System.Drawing.Point(233, 0);
            this.picboxLogoHOTEL.Name = "picboxLogoHOTEL";
            this.picboxLogoHOTEL.Size = new System.Drawing.Size(232, 234);
            this.picboxLogoHOTEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogoHOTEL.TabIndex = 0;
            this.picboxLogoHOTEL.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAceptar.Location = new System.Drawing.Point(33, 190);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 26);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(129, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 26);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelTituloSesion
            // 
            this.labelTituloSesion.AutoSize = true;
            this.labelTituloSesion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.labelTituloSesion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelTituloSesion.Location = new System.Drawing.Point(50, 18);
            this.labelTituloSesion.Name = "labelTituloSesion";
            this.labelTituloSesion.Size = new System.Drawing.Size(164, 28);
            this.labelTituloSesion.TabIndex = 3;
            this.labelTituloSesion.Text = "Iniciar Sesion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(57, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "___________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelUsuario.Location = new System.Drawing.Point(41, 68);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(67, 20);
            this.labelUsuario.TabIndex = 5;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelClave.Location = new System.Drawing.Point(41, 122);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(99, 20);
            this.labelClave.TabIndex = 6;
            this.labelClave.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(41, 88);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(166, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(41, 142);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(166, 20);
            this.txtClave.TabIndex = 8;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // FMIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(465, 234);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelClave);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.picboxLogoHOTEL);
            this.Controls.Add(this.labelTituloSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IniciarSesion";
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogoHOTEL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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