using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion.Recepcionista
{
    partial class AgregarServicios
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
            this.lblServicio = new System.Windows.Forms.Label();
            this.btnServicio = new System.Windows.Forms.Button();
            this.CBServicios = new System.Windows.Forms.ComboBox();
            this.listServicios = new System.Windows.Forms.ListBox();
            this.bntCobrar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(83, 31);
            this.lblServicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(112, 13);
            this.lblServicio.TabIndex = 52;
            this.lblServicio.Text = "Seleccione Servicios :";
            // 
            // btnServicio
            // 
            this.btnServicio.BackColor = System.Drawing.Color.LightGreen;
            this.btnServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicio.Location = new System.Drawing.Point(124, 138);
            this.btnServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(54, 23);
            this.btnServicio.TabIndex = 3;
            this.btnServicio.Text = "Agregar";
            this.btnServicio.UseVisualStyleBackColor = false;
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click_1);
            // 
            // CBServicios
            // 
            this.CBServicios.FormattingEnabled = true;
            this.CBServicios.Location = new System.Drawing.Point(83, 45);
            this.CBServicios.Margin = new System.Windows.Forms.Padding(2);
            this.CBServicios.Name = "CBServicios";
            this.CBServicios.Size = new System.Drawing.Size(148, 21);
            this.CBServicios.TabIndex = 1;
            // 
            // listServicios
            // 
            this.listServicios.FormattingEnabled = true;
            this.listServicios.Location = new System.Drawing.Point(83, 74);
            this.listServicios.Margin = new System.Windows.Forms.Padding(2);
            this.listServicios.Name = "listServicios";
            this.listServicios.Size = new System.Drawing.Size(148, 56);
            this.listServicios.TabIndex = 2;
            // 
            // bntCobrar
            // 
            this.bntCobrar.Location = new System.Drawing.Point(116, 177);
            this.bntCobrar.Margin = new System.Windows.Forms.Padding(2);
            this.bntCobrar.Name = "bntCobrar";
            this.bntCobrar.Size = new System.Drawing.Size(73, 34);
            this.bntCobrar.TabIndex = 5;
            this.bntCobrar.Text = "Siguiente";
            this.bntCobrar.UseVisualStyleBackColor = true;
            this.bntCobrar.Click += new System.EventHandler(this.bntCobrar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(23, 18);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(31, 20);
            this.txtID.TabIndex = 54;
            this.txtID.Visible = false;
            // 
            // AgregarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 233);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.bntCobrar);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.btnServicio);
            this.Controls.Add(this.CBServicios);
            this.Controls.Add(this.listServicios);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarServicios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblServicio;
        private Button btnServicio;
        private ComboBox CBServicios;
        private ListBox listServicios;
        private Button bntCobrar;
        private TextBox txtID;
    }
}