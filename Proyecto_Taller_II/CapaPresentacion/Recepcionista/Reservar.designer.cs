using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion
{
    partial class Reservar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridHabitaciones = new System.Windows.Forms.DataGridView();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.CBcategoria = new System.Windows.Forms.ComboBox();
            this.CBpiso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dateTimeFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dateTimeFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNCamas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridHabitaciones);
            this.panel1.Location = new System.Drawing.Point(2, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 241);
            this.panel1.TabIndex = 21;
            // 
            // dataGridHabitaciones
            // 
            this.dataGridHabitaciones.AllowUserToAddRows = false;
            this.dataGridHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridHabitaciones.Location = new System.Drawing.Point(0, 0);
            this.dataGridHabitaciones.Name = "dataGridHabitaciones";
            this.dataGridHabitaciones.RowTemplate.Height = 25;
            this.dataGridHabitaciones.Size = new System.Drawing.Size(827, 241);
            this.dataGridHabitaciones.TabIndex = 8;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(129, 112);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(84, 20);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Categoría :";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPiso.Location = new System.Drawing.Point(129, 79);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(46, 20);
            this.lblPiso.TabIndex = 24;
            this.lblPiso.Text = "Piso :";
            // 
            // CBcategoria
            // 
            this.CBcategoria.FormattingEnabled = true;
            this.CBcategoria.Items.AddRange(new object[] {
            "seleccione",
            "Simple",
            "Matrimonial",
            "Ejecutivo"});
            this.CBcategoria.Location = new System.Drawing.Point(219, 114);
            this.CBcategoria.Name = "CBcategoria";
            this.CBcategoria.Size = new System.Drawing.Size(165, 21);
            this.CBcategoria.TabIndex = 2;
            // 
            // CBpiso
            // 
            this.CBpiso.FormattingEnabled = true;
            this.CBpiso.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CBpiso.Location = new System.Drawing.Point(219, 78);
            this.CBpiso.Name = "CBpiso";
            this.CBpiso.Size = new System.Drawing.Size(165, 21);
            this.CBpiso.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(168, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 37);
            this.label3.TabIndex = 27;
            this.label3.Text = "Vista General de Habitaciones";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 105;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 52);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(105, 105);
            this.iconPictureBox1.TabIndex = 28;
            this.iconPictureBox1.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl1.Location = new System.Drawing.Point(2, 140);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(819, 20);
            this.lbl1.TabIndex = 29;
            this.lbl1.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDesde.Location = new System.Drawing.Point(399, 78);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(56, 20);
            this.lblDesde.TabIndex = 30;
            this.lblDesde.Text = "Desde:";
            // 
            // dateTimeFechaDesde
            // 
            this.dateTimeFechaDesde.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimeFechaDesde.Location = new System.Drawing.Point(454, 78);
            this.dateTimeFechaDesde.Name = "dateTimeFechaDesde";
            this.dateTimeFechaDesde.Size = new System.Drawing.Size(183, 22);
            this.dateTimeFechaDesde.TabIndex = 3;
            this.dateTimeFechaDesde.ValueChanged += new System.EventHandler(this.dateTimeFechaDesde_ValueChanged);
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.White;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReservar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReservar.Location = new System.Drawing.Point(724, 33);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 44);
            this.btnReservar.TabIndex = 6;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // dateTimeFechaHasta
            // 
            this.dateTimeFechaHasta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimeFechaHasta.Location = new System.Drawing.Point(454, 115);
            this.dateTimeFechaHasta.Name = "dateTimeFechaHasta";
            this.dateTimeFechaHasta.Size = new System.Drawing.Size(183, 22);
            this.dateTimeFechaHasta.TabIndex = 4;
            this.dateTimeFechaHasta.ValueChanged += new System.EventHandler(this.dateTimeFechaHasta_ValueChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblHasta.Location = new System.Drawing.Point(399, 115);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(53, 20);
            this.lblHasta.TabIndex = 33;
            this.lblHasta.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Habitaciones :";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.White;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(657, 33);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(61, 44);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nro camas:";
            // 
            // txtNCamas
            // 
            this.txtNCamas.Location = new System.Drawing.Point(678, 119);
            this.txtNCamas.Name = "txtNCamas";
            this.txtNCamas.Size = new System.Drawing.Size(100, 20);
            this.txtNCamas.TabIndex = 7;
            // 
            // Reservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 465);
            this.Controls.Add(this.txtNCamas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeFechaHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dateTimeFechaDesde);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBpiso);
            this.Controls.Add(this.CBcategoria);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Name = "Reservar";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Label lblCategoria;
        private Label lblPiso;
        private ComboBox CBcategoria;
        private ComboBox CBpiso;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lbl1;
        private Label lblDesde;
        private DateTimePicker dateTimeFechaDesde;
        private Button btnReservar;
        private DateTimePicker dateTimeFechaHasta;
        private Label lblHasta;
        private DataGridView dataGridHabitaciones;
        private Label label1;
        private Button btnFiltrar;
        private Label label2;
        private TextBox txtNCamas;
    }
}