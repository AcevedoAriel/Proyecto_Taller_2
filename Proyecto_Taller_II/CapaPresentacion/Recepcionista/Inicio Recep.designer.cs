using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion.Recepcionista
{
    partial class Inicio_Recep
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
            lblBienvenido2 = new Label();
            lblBienvenido1 = new Label();
            SuspendLayout();
            // 
            // lblBienvenido2
            // 
            lblBienvenido2.AutoSize = true;
            lblBienvenido2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido2.Location = new Point(168, 250);
            lblBienvenido2.Name = "lblBienvenido2";
            lblBienvenido2.Size = new Size(482, 65);
            lblBienvenido2.TabIndex = 3;
            lblBienvenido2.Text = "RECEPCIONISTA!!! :)";
            // 
            // lblBienvenido1
            // 
            lblBienvenido1.AutoSize = true;
            lblBienvenido1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido1.Location = new Point(212, 149);
            lblBienvenido1.Name = "lblBienvenido1";
            lblBienvenido1.Size = new Size(368, 65);
            lblBienvenido1.TabIndex = 2;
            lblBienvenido1.Text = "¡¡¡BIENVENIDO";
            // 
            // Inicio_Recep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 465);
            Controls.Add(lblBienvenido2);
            Controls.Add(lblBienvenido1);
            Name = "Inicio_Recep";
            Text = "Inicio_Recep";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido2;
        private Label lblBienvenido1;
    }
}