using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion.Administrador
{
    partial class CRUDHabitacion
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
            this.dataGridListaHabitacion = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblNroHabitacion = new System.Windows.Forms.Label();
            this.lblCantidadCama = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAgregarHabitacion = new System.Windows.Forms.Button();
            this.TNroHabitacion = new System.Windows.Forms.TextBox();
            this.TPrecio = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.CBCategoriaH = new System.Windows.Forms.ComboBox();
            this.numericCantCamas = new System.Windows.Forms.NumericUpDown();
            this.CBPiso = new System.Windows.Forms.ComboBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaHabitacion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantCamas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridListaHabitacion
            // 
            this.dataGridListaHabitacion.AllowUserToAddRows = false;
            this.dataGridListaHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaHabitacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridListaHabitacion.Location = new System.Drawing.Point(0, 0);
            this.dataGridListaHabitacion.Name = "dataGridListaHabitacion";
            this.dataGridListaHabitacion.RowTemplate.Height = 25;
            this.dataGridListaHabitacion.Size = new System.Drawing.Size(653, 143);
            this.dataGridListaHabitacion.TabIndex = 13;
            this.dataGridListaHabitacion.SelectionChanged += new System.EventHandler(this.dataGridListaHabitacion_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridListaHabitacion);
            this.panel1.Location = new System.Drawing.Point(27, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 143);
            this.panel1.TabIndex = 1;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPiso.Location = new System.Drawing.Point(59, 193);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(29, 15);
            this.lblPiso.TabIndex = 3;
            this.lblPiso.Text = "Piso";
            // 
            // lblNroHabitacion
            // 
            this.lblNroHabitacion.AutoSize = true;
            this.lblNroHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNroHabitacion.Location = new System.Drawing.Point(59, 224);
            this.lblNroHabitacion.Name = "lblNroHabitacion";
            this.lblNroHabitacion.Size = new System.Drawing.Size(90, 15);
            this.lblNroHabitacion.TabIndex = 4;
            this.lblNroHabitacion.Text = "Nro Habitacion";
            // 
            // lblCantidadCama
            // 
            this.lblCantidadCama.AutoSize = true;
            this.lblCantidadCama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidadCama.Location = new System.Drawing.Point(388, 220);
            this.lblCantidadCama.Name = "lblCantidadCama";
            this.lblCantidadCama.Size = new System.Drawing.Size(110, 15);
            this.lblCantidadCama.TabIndex = 5;
            this.lblCantidadCama.Text = "Cantidad de Camas";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(388, 151);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 15);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(388, 186);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(60, 15);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria";
            // 
            // btnAgregarHabitacion
            // 
            this.btnAgregarHabitacion.BackColor = System.Drawing.Color.Lime;
            this.btnAgregarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarHabitacion.Location = new System.Drawing.Point(172, 61);
            this.btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            this.btnAgregarHabitacion.Size = new System.Drawing.Size(100, 35);
            this.btnAgregarHabitacion.TabIndex = 6;
            this.btnAgregarHabitacion.Text = "Agregar Habitacion";
            this.btnAgregarHabitacion.UseVisualStyleBackColor = false;
            this.btnAgregarHabitacion.Click += new System.EventHandler(this.btnAgregarHabitacion_Click);
            // 
            // TNroHabitacion
            // 
            this.TNroHabitacion.Location = new System.Drawing.Point(172, 217);
            this.TNroHabitacion.Name = "TNroHabitacion";
            this.TNroHabitacion.Size = new System.Drawing.Size(145, 20);
            this.TNroHabitacion.TabIndex = 2;
            this.TNroHabitacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNroHabitacion_KeyPress);
            // 
            // TPrecio
            // 
            this.TPrecio.Location = new System.Drawing.Point(501, 144);
            this.TPrecio.Name = "TPrecio";
            this.TPrecio.Size = new System.Drawing.Size(145, 20);
            this.TPrecio.TabIndex = 3;
            this.TPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TPrecio_KeyPress);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(339, 61);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 35);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.Red;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeshabilitar.Location = new System.Drawing.Point(519, 61);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(100, 35);
            this.btnDeshabilitar.TabIndex = 10;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // CBCategoriaH
            // 
            this.CBCategoriaH.FormattingEnabled = true;
            this.CBCategoriaH.Items.AddRange(new object[] {
            "[Seleccione]",
            "Simple",
            "Matrimonial",
            "Ejecutivo"});
            this.CBCategoriaH.Location = new System.Drawing.Point(501, 179);
            this.CBCategoriaH.Name = "CBCategoriaH";
            this.CBCategoriaH.Size = new System.Drawing.Size(145, 21);
            this.CBCategoriaH.TabIndex = 4;
            // 
            // numericCantCamas
            // 
            this.numericCantCamas.Location = new System.Drawing.Point(501, 213);
            this.numericCantCamas.Name = "numericCantCamas";
            this.numericCantCamas.Size = new System.Drawing.Size(145, 20);
            this.numericCantCamas.TabIndex = 5;
            // 
            // CBPiso
            // 
            this.CBPiso.FormattingEnabled = true;
            this.CBPiso.Items.AddRange(new object[] {
            "[Seleccione]",
            "Piso 1",
            "Piso 2",
            "Piso 3",
            "Piso 4",
            "Piso 5"});
            this.CBPiso.Location = new System.Drawing.Point(172, 186);
            this.CBPiso.Name = "CBPiso";
            this.CBPiso.Size = new System.Drawing.Size(145, 21);
            this.CBPiso.TabIndex = 1;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Lime;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCambios.Location = new System.Drawing.Point(172, 61);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(100, 35);
            this.btnGuardarCambios.TabIndex = 7;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Gestión de Habitaciones";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(172, 144);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(149, 20);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.Lime;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAlta.Location = new System.Drawing.Point(519, 61);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(100, 35);
            this.btnAlta.TabIndex = 9;
            this.btnAlta.Text = "Habilitar";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Visible = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Taller_II.Properties.Resources.room_1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 35);
            this.label2.TabIndex = 22;
            this.label2.Text = "Filtrar por Piso o Categoria :";
            // 
            // CRUDHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.CBPiso);
            this.Controls.Add(this.numericCantCamas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CBCategoriaH);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.TPrecio);
            this.Controls.Add(this.TNroHabitacion);
            this.Controls.Add(this.btnAgregarHabitacion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidadCama);
            this.Controls.Add(this.lblNroHabitacion);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.panel1);
            this.Name = "CRUDHabitacion";
            this.Text = "Gestion Habitacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaHabitacion)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericCantCamas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridViewRow filaSeleccionada = null;

        private DataGridView dataGridListaHabitacion;
        private Panel panel1;
        private Label lblPiso;
        private Label lblNroHabitacion;
        private Label lblCantidadCama;
        private Label lblPrecio;
        private Label lblCategoria;
        private Button btnAgregarHabitacion;
        private TextBox TNroHabitacion;
        private TextBox TPrecio;
        private Button btnEditar;
        private Button btnDeshabilitar;
        private ComboBox CBCategoriaH;
        private PictureBox pictureBox1;
        private NumericUpDown numericCantCamas;
        private ComboBox CBPiso;
        private Button btnGuardarCambios;
        private Label label1;
        private TextBox txtBuscar;
        private Button btnAlta;
        private Label label2;
    }
}