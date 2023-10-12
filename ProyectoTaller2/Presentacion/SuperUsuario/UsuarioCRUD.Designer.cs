using System.Windows.Forms;

namespace ProyectoTaller2.Administrador
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
            BEditar = new Button();
            panel2 = new Panel();
            dataGridUsuario = new DataGridView();
            DTFechaNac = new DateTimePicker();
            TSexo = new ComboBox();
            TTelefono = new TextBox();
            TCorreo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BRegistrar = new Button();
            CBPerfil = new ComboBox();
            TNombreUsuario = new TextBox();
            TClave = new TextBox();
            TNombre = new TextBox();
            TApellido = new TextBox();
            LContraseña = new Label();
            LPerfil = new Label();
            LNombreUsuario = new Label();
            LApellido = new Label();
            LNombre = new Label();
            btnEliminar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblMensajeClave = new Label();
            lblMensajeCorreo = new Label();
            BGuardar = new Button();
            pictureBox1 = new PictureBox();
            txtDNI = new TextBox();
            lblDniUsuario = new Label();
            label5 = new Label();
            ID = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BEditar
            // 
            BEditar.BackColor = Color.DodgerBlue;
            BEditar.FlatStyle = FlatStyle.Popup;
            BEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BEditar.Location = new Point(705, 141);
            BEditar.Name = "BEditar";
            BEditar.Size = new Size(110, 47);
            BEditar.TabIndex = 66;
            BEditar.Text = "Editar";
            BEditar.UseVisualStyleBackColor = false;
            BEditar.Click += BEditar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridUsuario);
            panel2.Location = new Point(1, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 185);
            panel2.TabIndex = 65;
            // 
            // dataGridUsuario
            // 
            dataGridUsuario.AllowUserToAddRows = false;
            dataGridUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuario.Columns.AddRange(new DataGridViewColumn[] { ID });
            dataGridUsuario.Dock = DockStyle.Fill;
            dataGridUsuario.Location = new Point(0, 0);
            dataGridUsuario.Name = "dataGridUsuario";
            dataGridUsuario.RowTemplate.Height = 25;
            dataGridUsuario.Size = new Size(827, 185);
            dataGridUsuario.TabIndex = 44;
            dataGridUsuario.SelectionChanged += dataGridUsuario_SelectionChanged;
            // 
            // DTFechaNac
            // 
            DTFechaNac.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DTFechaNac.Location = new Point(510, 242);
            DTFechaNac.Name = "DTFechaNac";
            DTFechaNac.Size = new Size(174, 21);
            DTFechaNac.TabIndex = 64;
            DTFechaNac.ValueChanged += DTFechaNac_ValueChanged;
            // 
            // TSexo
            // 
            TSexo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TSexo.FormattingEnabled = true;
            TSexo.Items.AddRange(new object[] { "[Seleccione Sexo]", "Hombre", "Mujer" });
            TSexo.Location = new Point(510, 174);
            TSexo.Name = "TSexo";
            TSexo.Size = new Size(174, 23);
            TSexo.TabIndex = 63;
            TSexo.TextChanged += CamposTextChanged;
            // 
            // TTelefono
            // 
            TTelefono.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TTelefono.Location = new Point(510, 148);
            TTelefono.MaxLength = 10;
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(174, 21);
            TTelefono.TabIndex = 62;
            TTelefono.TextChanged += CamposTextChanged;
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // TCorreo
            // 
            TCorreo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TCorreo.Location = new Point(510, 205);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(174, 21);
            TCorreo.TabIndex = 61;
            TCorreo.TextChanged += CamposTextChanged;
            TCorreo.KeyPress += TCorreo_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(354, 157);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 60;
            label4.Text = "Teléfono :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(354, 246);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 59;
            label3.Text = "Fecha de Nacimiento :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(354, 182);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 58;
            label2.Text = "Sexo :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(354, 213);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 57;
            label1.Text = "Dirección de Correo :";
            // 
            // BRegistrar
            // 
            BRegistrar.BackColor = Color.Lime;
            BRegistrar.FlatStyle = FlatStyle.Popup;
            BRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BRegistrar.Location = new Point(705, 73);
            BRegistrar.Name = "BRegistrar";
            BRegistrar.Size = new Size(110, 46);
            BRegistrar.TabIndex = 55;
            BRegistrar.Text = "Registrar Usuario";
            BRegistrar.UseVisualStyleBackColor = false;
            BRegistrar.Click += BRegistrar_Click;
            // 
            // CBPerfil
            // 
            CBPerfil.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CBPerfil.FormattingEnabled = true;
            CBPerfil.Items.AddRange(new object[] { "[Seleccione el tipo de usuario]", "Super Usuario", "Administrador", "Recepcionista" });
            CBPerfil.Location = new Point(510, 116);
            CBPerfil.Name = "CBPerfil";
            CBPerfil.Size = new Size(174, 23);
            CBPerfil.TabIndex = 54;
            CBPerfil.TextChanged += CamposTextChanged;
            // 
            // TNombreUsuario
            // 
            TNombreUsuario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TNombreUsuario.Location = new Point(155, 206);
            TNombreUsuario.Name = "TNombreUsuario";
            TNombreUsuario.Size = new Size(175, 21);
            TNombreUsuario.TabIndex = 53;
            TNombreUsuario.TextChanged += CamposTextChanged;
            TNombreUsuario.KeyDown += TNombreUsuario_KeyDown;
            // 
            // TClave
            // 
            TClave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TClave.Location = new Point(155, 233);
            TClave.Name = "TClave";
            TClave.Size = new Size(175, 21);
            TClave.TabIndex = 52;
            TClave.UseSystemPasswordChar = true;
            TClave.TextChanged += CamposTextChanged;
            TClave.KeyPress += TClave_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TNombre.Location = new Point(155, 142);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(175, 21);
            TNombre.TabIndex = 51;
            TNombre.TextChanged += CamposTextChanged;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TApellido.Location = new Point(155, 174);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(175, 21);
            TApellido.TabIndex = 50;
            TApellido.TextChanged += CamposTextChanged;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LContraseña.Location = new Point(13, 232);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(75, 15);
            LContraseña.TabIndex = 49;
            LContraseña.Text = "Contraseña :";
            // 
            // LPerfil
            // 
            LPerfil.AutoSize = true;
            LPerfil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LPerfil.Location = new Point(354, 120);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(70, 15);
            LPerfil.TabIndex = 48;
            LPerfil.Text = "Tipo Perfil :";
            // 
            // LNombreUsuario
            // 
            LNombreUsuario.AutoSize = true;
            LNombreUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LNombreUsuario.Location = new Point(12, 206);
            LNombreUsuario.Name = "LNombreUsuario";
            LNombreUsuario.Size = new Size(121, 15);
            LNombreUsuario.TabIndex = 47;
            LNombreUsuario.Text = "Nombre de Usuario :";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LApellido.Location = new Point(13, 178);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(58, 15);
            LApellido.TabIndex = 46;
            LApellido.Text = "Apellido :";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LNombre.Location = new Point(13, 144);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(59, 15);
            LNombre.TabIndex = 45;
            LNombre.Text = "Nombre :";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(705, 207);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 47);
            btnEliminar.TabIndex = 67;
            btnEliminar.Text = "Dar de Baja";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(738, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(77, 38);
            btnBuscar.TabIndex = 69;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(510, 21);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(194, 23);
            txtBuscar.TabIndex = 70;
            // 
            // lblMensajeClave
            // 
            lblMensajeClave.AutoSize = true;
            lblMensajeClave.Location = new Point(150, 258);
            lblMensajeClave.Name = "lblMensajeClave";
            lblMensajeClave.Size = new Size(0, 15);
            lblMensajeClave.TabIndex = 71;
            // 
            // lblMensajeCorreo
            // 
            lblMensajeCorreo.AutoSize = true;
            lblMensajeCorreo.Location = new Point(510, 227);
            lblMensajeCorreo.Name = "lblMensajeCorreo";
            lblMensajeCorreo.Size = new Size(0, 15);
            lblMensajeCorreo.TabIndex = 71;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.Lime;
            BGuardar.FlatStyle = FlatStyle.Popup;
            BGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BGuardar.Location = new Point(705, 72);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(110, 47);
            BGuardar.TabIndex = 72;
            BGuardar.Text = "Guardar Cambios";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.perfiil;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNI.Location = new Point(155, 112);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(175, 21);
            txtDNI.TabIndex = 75;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // lblDniUsuario
            // 
            lblDniUsuario.AutoSize = true;
            lblDniUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDniUsuario.Location = new Point(13, 116);
            lblDniUsuario.Name = "lblDniUsuario";
            lblDniUsuario.Size = new Size(35, 15);
            lblDniUsuario.TabIndex = 74;
            lblDniUsuario.Text = "DNI :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(133, 3);
            label5.Name = "label5";
            label5.Size = new Size(326, 37);
            label5.TabIndex = 76;
            label5.Text = "Gestión de Usuarios";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 50;
            // 
            // UsuarioCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 465);
            Controls.Add(label5);
            Controls.Add(txtDNI);
            Controls.Add(lblDniUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(BGuardar);
            Controls.Add(lblMensajeClave);
            Controls.Add(lblMensajeCorreo);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(BEditar);
            Controls.Add(panel2);
            Controls.Add(DTFechaNac);
            Controls.Add(TSexo);
            Controls.Add(TTelefono);
            Controls.Add(TCorreo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BRegistrar);
            Controls.Add(CBPerfil);
            Controls.Add(TNombreUsuario);
            Controls.Add(TClave);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(LContraseña);
            Controls.Add(LPerfil);
            Controls.Add(LNombreUsuario);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Name = "UsuarioCRUD";
            Text = "Usuario CRUD";
            Load += UsuarioCRUD_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblMensajeClave;
        private Label lblMensajeCorreo;
        private Button BGuardar;
        private PictureBox pictureBox1;
        private TextBox txtDNI;
        private Label lblDniUsuario;
        private Label label5;
        private DataGridViewTextBoxColumn ID;
    }
}