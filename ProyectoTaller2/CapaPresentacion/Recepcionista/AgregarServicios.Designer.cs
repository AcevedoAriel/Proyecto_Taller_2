namespace ProyectoTaller2.CapaPresentacion.Recepcionista
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
            lblServicio = new Label();
            btnServicio = new Button();
            CBServicios = new ComboBox();
            listServicios = new ListBox();
            bntCobrar = new Button();
            txtID = new TextBox();
            SuspendLayout();
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(139, 60);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(177, 25);
            lblServicio.TabIndex = 52;
            lblServicio.Text = "Seleccione Servicios :";
            lblServicio.Click += lblServicio_Click;
            // 
            // btnServicio
            // 
            btnServicio.BackColor = Color.LightGreen;
            btnServicio.FlatStyle = FlatStyle.Flat;
            btnServicio.Location = new Point(207, 266);
            btnServicio.Name = "btnServicio";
            btnServicio.Size = new Size(90, 45);
            btnServicio.TabIndex = 51;
            btnServicio.Text = "Agregar";
            btnServicio.UseVisualStyleBackColor = false;
            btnServicio.Click += btnServicio_Click_1;
            // 
            // CBServicios
            // 
            CBServicios.FormattingEnabled = true;
            CBServicios.Location = new Point(139, 87);
            CBServicios.Name = "CBServicios";
            CBServicios.Size = new Size(244, 33);
            CBServicios.TabIndex = 50;
            CBServicios.SelectedIndexChanged += CBServicios_SelectedIndexChanged;
            // 
            // listServicios
            // 
            listServicios.FormattingEnabled = true;
            listServicios.ItemHeight = 25;
            listServicios.Location = new Point(139, 142);
            listServicios.Name = "listServicios";
            listServicios.Size = new Size(244, 104);
            listServicios.TabIndex = 49;
            listServicios.SelectedIndexChanged += listServicios_SelectedIndexChanged;
            // 
            // bntCobrar
            // 
            bntCobrar.Location = new Point(194, 341);
            bntCobrar.Name = "bntCobrar";
            bntCobrar.Size = new Size(122, 65);
            bntCobrar.TabIndex = 53;
            bntCobrar.Text = "Siguiente";
            bntCobrar.UseVisualStyleBackColor = true;
            bntCobrar.Click += bntCobrar_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(39, 34);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(49, 31);
            txtID.TabIndex = 54;
            txtID.Visible = false;
            // 
            // AgregarServicios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 449);
            Controls.Add(txtID);
            Controls.Add(bntCobrar);
            Controls.Add(lblServicio);
            Controls.Add(btnServicio);
            Controls.Add(CBServicios);
            Controls.Add(listServicios);
            Name = "AgregarServicios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarServicios";
            ResumeLayout(false);
            PerformLayout();
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