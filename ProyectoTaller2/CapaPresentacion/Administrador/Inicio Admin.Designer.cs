namespace ProyectoTaller2.CapaPresentacion.Administrador
{
    partial class Inicio_Admin
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
            lblBienvenido1 = new Label();
            lblBienvenido2 = new Label();
            SuspendLayout();
            // 
            // lblBienvenido1
            // 
            lblBienvenido1.AutoSize = true;
            lblBienvenido1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido1.Location = new Point(229, 139);
            lblBienvenido1.Name = "lblBienvenido1";
            lblBienvenido1.Size = new Size(368, 65);
            lblBienvenido1.TabIndex = 0;
            lblBienvenido1.Text = "¡¡¡BIENVENIDO";
            // 
            // lblBienvenido2
            // 
            lblBienvenido2.AutoSize = true;
            lblBienvenido2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido2.Location = new Point(168, 241);
            lblBienvenido2.Name = "lblBienvenido2";
            lblBienvenido2.Size = new Size(525, 65);
            lblBienvenido2.TabIndex = 1;
            lblBienvenido2.Text = "ADMINISTRADOR!!! :)";
            // 
            // Inicio_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 465);
            Controls.Add(lblBienvenido2);
            Controls.Add(lblBienvenido1);
            Name = "Inicio_Admin";
            Text = "Inicio_Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido1;
        private Label lblBienvenido2;
    }
}