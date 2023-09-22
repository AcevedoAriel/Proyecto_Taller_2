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
            Perfil = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            clave = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            sexo = new DataGridViewTextBoxColumn();
            fechaNac = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
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
            lblTituloUsuario = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblMensaje = new Label();
            BGuardar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuario).BeginInit();
            SuspendLayout();
            // 
            // BEditar
            // 
            BEditar.BackColor = Color.DodgerBlue;
            BEditar.FlatStyle = FlatStyle.Popup;
            BEditar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BEditar.Location = new Point(694, 147);
            BEditar.Name = "BEditar";
            BEditar.Size = new Size(110, 40);
            BEditar.TabIndex = 66;
            BEditar.Text = "Editar";
            BEditar.UseVisualStyleBackColor = false;
            BEditar.Click += BEditar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridUsuario);
            panel2.Location = new Point(0, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 235);
            panel2.TabIndex = 65;
            // 
            // dataGridUsuario
            // 
            dataGridUsuario.AllowUserToAddRows = false;
            dataGridUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuario.Columns.AddRange(new DataGridViewColumn[] { Perfil, apellido, nombre, usuario, clave, email, sexo, fechaNac, telefono, estado });
            dataGridUsuario.Dock = DockStyle.Fill;
            dataGridUsuario.Location = new Point(0, 0);
            dataGridUsuario.Name = "dataGridUsuario";
            dataGridUsuario.RowTemplate.Height = 25;
            dataGridUsuario.Size = new Size(815, 235);
            dataGridUsuario.TabIndex = 44;
            dataGridUsuario.SelectionChanged += dataGridUsuario_SelectionChanged;
            // 
            // Perfil
            // 
            Perfil.HeaderText = "Tipo de Perfil";
            Perfil.Name = "Perfil";
            Perfil.Resizable = DataGridViewTriState.True;
            Perfil.Width = 110;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // usuario
            // 
            usuario.HeaderText = "Nombre Usuario";
            usuario.Name = "usuario";
            // 
            // clave
            // 
            clave.HeaderText = "Contraseña";
            clave.Name = "clave";
            // 
            // email
            // 
            email.HeaderText = "Driección de Correo";
            email.Name = "email";
            // 
            // sexo
            // 
            sexo.HeaderText = "Sexo";
            sexo.Name = "sexo";
            sexo.Resizable = DataGridViewTriState.True;
            // 
            // fechaNac
            // 
            fechaNac.HeaderText = "Fecha de Nacimiento";
            fechaNac.Name = "fechaNac";
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            // 
            // DTFechaNac
            // 
            DTFechaNac.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DTFechaNac.Location = new Point(485, 219);
            DTFechaNac.Name = "DTFechaNac";
            DTFechaNac.Size = new Size(174, 21);
            DTFechaNac.TabIndex = 64;
            // 
            // TSexo
            // 
            TSexo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TSexo.FormattingEnabled = true;
            TSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            TSexo.Location = new Point(485, 147);
            TSexo.Name = "TSexo";
            TSexo.Size = new Size(174, 23);
            TSexo.TabIndex = 63;
            // 
            // TTelefono
            // 
            TTelefono.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TTelefono.Location = new Point(485, 113);
            TTelefono.MaxLength = 10;
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(174, 21);
            TTelefono.TabIndex = 62;
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // TCorreo
            // 
            TCorreo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TCorreo.Location = new Point(485, 183);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(174, 21);
            TCorreo.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(342, 118);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 60;
            label4.Text = "Teléfono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(342, 224);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 59;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(342, 152);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 58;
            label2.Text = "Sexo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(342, 188);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 57;
            label1.Text = "Dirección de Correo";
            // 
            // BRegistrar
            // 
            BRegistrar.BackColor = Color.Lime;
            BRegistrar.FlatStyle = FlatStyle.Popup;
            BRegistrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrar.Location = new Point(694, 69);
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
            CBPerfil.Items.AddRange(new object[] { "Super Usuario", "Administrador", "Recepcionista" });
            CBPerfil.Location = new Point(485, 77);
            CBPerfil.Name = "CBPerfil";
            CBPerfil.Size = new Size(174, 23);
            CBPerfil.TabIndex = 54;
            // 
            // TNombreUsuario
            // 
            TNombreUsuario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TNombreUsuario.Location = new Point(139, 183);
            TNombreUsuario.Name = "TNombreUsuario";
            TNombreUsuario.Size = new Size(175, 21);
            TNombreUsuario.TabIndex = 53;
            TNombreUsuario.KeyDown += TNombreUsuario_KeyDown;
            // 
            // TClave
            // 
            TClave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TClave.Location = new Point(139, 221);
            TClave.Name = "TClave";
            TClave.Size = new Size(175, 21);
            TClave.TabIndex = 52;
            TClave.KeyPress += TClave_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TNombre.Location = new Point(139, 110);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(175, 21);
            TNombre.TabIndex = 51;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TApellido.Location = new Point(139, 147);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(175, 21);
            TApellido.TabIndex = 50;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LContraseña.Location = new Point(12, 226);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(70, 15);
            LContraseña.TabIndex = 49;
            LContraseña.Text = "Contraseña";
            // 
            // LPerfil
            // 
            LPerfil.AutoSize = true;
            LPerfil.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LPerfil.Location = new Point(342, 84);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(62, 15);
            LPerfil.TabIndex = 48;
            LPerfil.Text = "Tipo Perfil";
            // 
            // LNombreUsuario
            // 
            LNombreUsuario.AutoSize = true;
            LNombreUsuario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreUsuario.Location = new Point(12, 186);
            LNombreUsuario.Name = "LNombreUsuario";
            LNombreUsuario.Size = new Size(115, 15);
            LNombreUsuario.TabIndex = 47;
            LNombreUsuario.Text = "Nombre de Usuario";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.Location = new Point(12, 150);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 46;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.Location = new Point(12, 113);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(52, 15);
            LNombre.TabIndex = 45;
            LNombre.Text = "Nombre";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(694, 221);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 40);
            btnEliminar.TabIndex = 67;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblTituloUsuario
            // 
            lblTituloUsuario.AutoSize = true;
            lblTituloUsuario.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTituloUsuario.ForeColor = Color.FloralWhite;
            lblTituloUsuario.Location = new Point(34, 24);
            lblTituloUsuario.Name = "lblTituloUsuario";
            lblTituloUsuario.Size = new Size(240, 37);
            lblTituloUsuario.TabIndex = 68;
            lblTituloUsuario.Text = "Usuario CRUD";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Location = new Point(552, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(77, 38);
            btnBuscar.TabIndex = 69;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(390, 24);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(156, 23);
            txtBuscar.TabIndex = 70;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(158, 246);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 71;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.Lime;
            BGuardar.FlatStyle = FlatStyle.Popup;
            BGuardar.Location = new Point(694, 69);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(110, 47);
            BGuardar.TabIndex = 72;
            BGuardar.Text = "Guardar Cambios";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // UsuarioCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 515);
            Controls.Add(BGuardar);
            Controls.Add(lblMensaje);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(lblTituloUsuario);
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
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label lblTituloUsuario;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblMensaje;
        private DataGridViewTextBoxColumn Perfil;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn clave;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn sexo;
        private DataGridViewTextBoxColumn fechaNac;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn estado;
        private Button BGuardar;
    }
}