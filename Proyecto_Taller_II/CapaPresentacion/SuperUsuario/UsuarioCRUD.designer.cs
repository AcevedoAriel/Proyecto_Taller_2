using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion.SuperUsuario
{
    partial class UsuarioCRUD
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
            this.BEditar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.DTFechaNac = new System.Windows.Forms.DateTimePicker();
            this.TSexo = new System.Windows.Forms.ComboBox();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.TCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BRegistrar = new System.Windows.Forms.Button();
            this.CBPerfil = new System.Windows.Forms.ComboBox();
            this.TNombreUsuario = new System.Windows.Forms.TextBox();
            this.TClave = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LContraseña = new System.Windows.Forms.Label();
            this.LPerfil = new System.Windows.Forms.Label();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblMensajeClave = new System.Windows.Forms.Label();
            this.lblMensajeCorreo = new System.Windows.Forms.Label();
            this.BGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDniUsuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BntAlta = new System.Windows.Forms.Button();
            this.lblBuscarNombre = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BEditar.Location = new System.Drawing.Point(702, 125);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(94, 41);
            this.BEditar.TabIndex = 14;
            this.BEditar.Text = "Editar";
            this.BEditar.UseVisualStyleBackColor = false;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridUsuario);
            this.panel2.Location = new System.Drawing.Point(1, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 302);
            this.panel2.TabIndex = 65;
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.AllowUserToAddRows = false;
            this.dataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsuario.Location = new System.Drawing.Point(0, 0);
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.RowTemplate.Height = 25;
            this.dataGridUsuario.Size = new System.Drawing.Size(826, 302);
            this.dataGridUsuario.TabIndex = 16;
            this.dataGridUsuario.SelectionChanged += new System.EventHandler(this.dataGridUsuario_SelectionChanged);
            // 
            // DTFechaNac
            // 
            this.DTFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DTFechaNac.Location = new System.Drawing.Point(437, 210);
            this.DTFechaNac.Name = "DTFechaNac";
            this.DTFechaNac.Size = new System.Drawing.Size(150, 21);
            this.DTFechaNac.TabIndex = 11;
            this.DTFechaNac.ValueChanged += new System.EventHandler(this.DTFechaNac_ValueChanged);
            // 
            // TSexo
            // 
            this.TSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TSexo.FormattingEnabled = true;
            this.TSexo.Items.AddRange(new object[] {
            "[Seleccione Sexo]",
            "Hombre",
            "Mujer"});
            this.TSexo.Location = new System.Drawing.Point(437, 151);
            this.TSexo.Name = "TSexo";
            this.TSexo.Size = new System.Drawing.Size(150, 23);
            this.TSexo.TabIndex = 9;
            // 
            // TTelefono
            // 
            this.TTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TTelefono.Location = new System.Drawing.Point(437, 125);
            this.TTelefono.MaxLength = 10;
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(150, 21);
            this.TTelefono.TabIndex = 8;
            this.TTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TTelefono_KeyPress);
            // 
            // TCorreo
            // 
            this.TCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TCorreo.Location = new System.Drawing.Point(437, 178);
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Size = new System.Drawing.Size(150, 21);
            this.TCorreo.TabIndex = 10;
            this.TCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCorreo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(303, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "Teléfono :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(303, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 59;
            this.label3.Text = "Fecha de Nacimiento :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(303, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "Sexo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(303, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "Dirección de Correo :";
            // 
            // BRegistrar
            // 
            this.BRegistrar.BackColor = System.Drawing.Color.Lime;
            this.BRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BRegistrar.Location = new System.Drawing.Point(702, 77);
            this.BRegistrar.Name = "BRegistrar";
            this.BRegistrar.Size = new System.Drawing.Size(94, 40);
            this.BRegistrar.TabIndex = 12;
            this.BRegistrar.Text = "Registrar Usuario";
            this.BRegistrar.UseVisualStyleBackColor = false;
            this.BRegistrar.Click += new System.EventHandler(this.BRegistrar_Click);
            // 
            // CBPerfil
            // 
            this.CBPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CBPerfil.FormattingEnabled = true;
            this.CBPerfil.Items.AddRange(new object[] {
            "[Seleccione el tipo de usuario]",
            "Super Usuario",
            "Administrador",
            "Recepcionista"});
            this.CBPerfil.Location = new System.Drawing.Point(437, 94);
            this.CBPerfil.Name = "CBPerfil";
            this.CBPerfil.Size = new System.Drawing.Size(150, 23);
            this.CBPerfil.TabIndex = 7;
            // 
            // TNombreUsuario
            // 
            this.TNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TNombreUsuario.Location = new System.Drawing.Point(133, 178);
            this.TNombreUsuario.Name = "TNombreUsuario";
            this.TNombreUsuario.Size = new System.Drawing.Size(151, 21);
            this.TNombreUsuario.TabIndex = 5;
            // 
            // TClave
            // 
            this.TClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TClave.Location = new System.Drawing.Point(133, 202);
            this.TClave.Name = "TClave";
            this.TClave.Size = new System.Drawing.Size(151, 21);
            this.TClave.TabIndex = 6;
            this.TClave.UseSystemPasswordChar = true;
            // 
            // TNombre
            // 
            this.TNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TNombre.Location = new System.Drawing.Point(133, 122);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(151, 21);
            this.TNombre.TabIndex = 3;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TApellido.Location = new System.Drawing.Point(133, 151);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(151, 21);
            this.TApellido.TabIndex = 4;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // LContraseña
            // 
            this.LContraseña.AutoSize = true;
            this.LContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LContraseña.Location = new System.Drawing.Point(11, 205);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(75, 15);
            this.LContraseña.TabIndex = 49;
            this.LContraseña.Text = "Contraseña :";
            // 
            // LPerfil
            // 
            this.LPerfil.AutoSize = true;
            this.LPerfil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LPerfil.Location = new System.Drawing.Point(303, 97);
            this.LPerfil.Name = "LPerfil";
            this.LPerfil.Size = new System.Drawing.Size(70, 15);
            this.LPerfil.TabIndex = 48;
            this.LPerfil.Text = "Tipo Perfil :";
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LNombreUsuario.Location = new System.Drawing.Point(10, 178);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(121, 15);
            this.LNombreUsuario.TabIndex = 47;
            this.LNombreUsuario.Text = "Nombre de Usuario :";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LApellido.Location = new System.Drawing.Point(11, 154);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(58, 15);
            this.LApellido.TabIndex = 46;
            this.LApellido.Text = "Apellido :";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LNombre.Location = new System.Drawing.Point(11, 124);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(59, 15);
            this.LNombre.TabIndex = 45;
            this.LNombre.Text = "Nombre :";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(702, 172);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 41);
            this.btnEliminar.TabIndex = 67;
            this.btnEliminar.Text = "Dar de Baja";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(486, 14);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(241, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblMensajeClave
            // 
            this.lblMensajeClave.AutoSize = true;
            this.lblMensajeClave.Location = new System.Drawing.Point(129, 224);
            this.lblMensajeClave.Name = "lblMensajeClave";
            this.lblMensajeClave.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeClave.TabIndex = 71;
            // 
            // lblMensajeCorreo
            // 
            this.lblMensajeCorreo.AutoSize = true;
            this.lblMensajeCorreo.Location = new System.Drawing.Point(437, 197);
            this.lblMensajeCorreo.Name = "lblMensajeCorreo";
            this.lblMensajeCorreo.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeCorreo.TabIndex = 71;
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.Lime;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BGuardar.Location = new System.Drawing.Point(702, 76);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(94, 41);
            this.BGuardar.TabIndex = 13;
            this.BGuardar.Text = "Guardar Cambios";
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Taller_II.Properties.Resources.perfiil;
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDNI.Location = new System.Drawing.Point(133, 92);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(151, 21);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblDniUsuario
            // 
            this.lblDniUsuario.AutoSize = true;
            this.lblDniUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDniUsuario.Location = new System.Drawing.Point(11, 95);
            this.lblDniUsuario.Name = "lblDniUsuario";
            this.lblDniUsuario.Size = new System.Drawing.Size(35, 15);
            this.lblDniUsuario.TabIndex = 74;
            this.lblDniUsuario.Text = "DNI :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(114, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 37);
            this.label5.TabIndex = 76;
            this.label5.Text = "Gestión de Usuarios";
            // 
            // BntAlta
            // 
            this.BntAlta.BackColor = System.Drawing.Color.Lime;
            this.BntAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BntAlta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BntAlta.Location = new System.Drawing.Point(702, 172);
            this.BntAlta.Name = "BntAlta";
            this.BntAlta.Size = new System.Drawing.Size(94, 41);
            this.BntAlta.TabIndex = 15;
            this.BntAlta.Text = "Dar de Alta";
            this.BntAlta.UseVisualStyleBackColor = false;
            this.BntAlta.Visible = false;
            this.BntAlta.Click += new System.EventHandler(this.BntAlta_Click);
            // 
            // lblBuscarNombre
            // 
            this.lblBuscarNombre.AutoSize = true;
            this.lblBuscarNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBuscarNombre.Location = new System.Drawing.Point(483, 37);
            this.lblBuscarNombre.Name = "lblBuscarNombre";
            this.lblBuscarNombre.Size = new System.Drawing.Size(158, 15);
            this.lblBuscarNombre.TabIndex = 78;
            this.lblBuscarNombre.Text = "Buscar por Nombre o Perfil";
            // 
            // UsuarioCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 548);
            this.Controls.Add(this.lblBuscarNombre);
            this.Controls.Add(this.BntAlta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDniUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.lblMensajeClave);
            this.Controls.Add(this.lblMensajeCorreo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DTFechaNac);
            this.Controls.Add(this.TSexo);
            this.Controls.Add(this.TTelefono);
            this.Controls.Add(this.TCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BRegistrar);
            this.Controls.Add(this.CBPerfil);
            this.Controls.Add(this.TNombreUsuario);
            this.Controls.Add(this.TClave);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.LContraseña);
            this.Controls.Add(this.LPerfil);
            this.Controls.Add(this.LNombreUsuario);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Name = "UsuarioCRUD";
            this.Text = "Usuario CRUD";
            this.Load += new System.EventHandler(this.UsuarioCRUD_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridViewRow filaSeleccionada = null;

        private Button BEditar;
        private Panel panel2;
        private DataGridView dataGridUsuario;
        private DateTimePicker DTFechaNac;
        private ComboBox TSexo;
        private TextBox TTelefono;
        private TextBox TCorreo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BRegistrar;
        private ComboBox CBPerfil;
        private TextBox TNombreUsuario;
        private TextBox TClave;
        private TextBox TNombre;
        private TextBox TApellido;
        private Label LContraseña;
        private Label LPerfil;
        private Label LNombreUsuario;
        private Label LApellido;
        private Label LNombre;
        private Button btnEliminar;
        private TextBox txtBuscar;
        private Label lblMensajeClave;
        private Label lblMensajeCorreo;
        private Button BGuardar;
        private PictureBox pictureBox1;
        private TextBox txtDNI;
        private Label lblDniUsuario;
        private Label label5;
        private Button BntAlta;
        private Label lblBuscarNombre;
    }
}