namespace ProyectoTaller2.CapaPresentacion
{
    partial class FMPrincipal
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
            MenuIzquierdo = new MenuStrip();
            MenuInicio = new FontAwesome.Sharp.IconMenuItem();
            MenuReservar = new FontAwesome.Sharp.IconMenuItem();
            MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            MenuHabitacion = new FontAwesome.Sharp.IconMenuItem();
            MenuReserva = new FontAwesome.Sharp.IconMenuItem();
            MenuServicios = new FontAwesome.Sharp.IconMenuItem();
            MenuIngresoDePagos = new FontAwesome.Sharp.IconMenuItem();
            MenuCliente = new FontAwesome.Sharp.IconMenuItem();
            MenuBackup = new FontAwesome.Sharp.IconMenuItem();
            MenuTitulo = new MenuStrip();
            MenuSalir = new FontAwesome.Sharp.IconMenuItem();
            UsuarioToolStripMenuItem = new ToolStripMenuItem();
            ICTitulo = new FontAwesome.Sharp.IconMenuItem();
            hOTELDELPARANAToolStripMenuItem = new ToolStripMenuItem();
            perfilToolStripMenuItem1 = new ToolStripMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            PanelPrincipal = new Panel();
            MenuIzquierdo.SuspendLayout();
            MenuTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // MenuIzquierdo
            // 
            MenuIzquierdo.AutoSize = false;
            MenuIzquierdo.BackColor = Color.White;
            MenuIzquierdo.Dock = DockStyle.Left;
            MenuIzquierdo.Items.AddRange(new ToolStripItem[] { MenuInicio, MenuReservar, MenuUsuario, MenuHabitacion, MenuReserva, MenuServicios, MenuIngresoDePagos, MenuCliente, MenuBackup });
            MenuIzquierdo.Location = new Point(0, 60);
            MenuIzquierdo.Name = "MenuIzquierdo";
            MenuIzquierdo.Size = new Size(152, 587);
            MenuIzquierdo.TabIndex = 0;
            MenuIzquierdo.Text = "menuStrip1";
            // 
            // MenuInicio
            // 
            MenuInicio.AutoSize = false;
            MenuInicio.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            MenuInicio.IconColor = Color.Black;
            MenuInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuInicio.IconSize = 45;
            MenuInicio.ImageScaling = ToolStripItemImageScaling.None;
            MenuInicio.Name = "MenuInicio";
            MenuInicio.Size = new Size(80, 60);
            MenuInicio.Text = "Inicio";
            MenuInicio.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuInicio.Click += iconMenuInicio_Click;
            // 
            // MenuReservar
            // 
            MenuReservar.AutoSize = false;
            MenuReservar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuReservar.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            MenuReservar.IconColor = Color.Black;
            MenuReservar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuReservar.IconSize = 45;
            MenuReservar.ImageScaling = ToolStripItemImageScaling.None;
            MenuReservar.Name = "MenuReservar";
            MenuReservar.Size = new Size(80, 60);
            MenuReservar.Text = "Reservar";
            MenuReservar.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuReservar.Click += MenuReservar_Click;
            // 
            // MenuUsuario
            // 
            MenuUsuario.AutoSize = false;
            MenuUsuario.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            MenuUsuario.IconColor = Color.Black;
            MenuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuUsuario.IconSize = 45;
            MenuUsuario.ImageScaling = ToolStripItemImageScaling.None;
            MenuUsuario.Name = "MenuUsuario";
            MenuUsuario.Size = new Size(80, 60);
            MenuUsuario.Text = "Usuario";
            MenuUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuUsuario.Click += MenuUsuario_Click;
            // 
            // MenuHabitacion
            // 
            MenuHabitacion.AutoSize = false;
            MenuHabitacion.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuHabitacion.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            MenuHabitacion.IconColor = Color.Black;
            MenuHabitacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuHabitacion.IconSize = 45;
            MenuHabitacion.ImageScaling = ToolStripItemImageScaling.None;
            MenuHabitacion.Name = "MenuHabitacion";
            MenuHabitacion.Size = new Size(80, 60);
            MenuHabitacion.Text = "Habitacion";
            MenuHabitacion.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuHabitacion.Click += MenuHabitacion_Click;
            // 
            // MenuReserva
            // 
            MenuReserva.AutoSize = false;
            MenuReserva.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuReserva.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            MenuReserva.IconColor = Color.Black;
            MenuReserva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuReserva.IconSize = 45;
            MenuReserva.ImageScaling = ToolStripItemImageScaling.None;
            MenuReserva.Name = "MenuReserva";
            MenuReserva.Size = new Size(80, 60);
            MenuReserva.Text = "Reservas";
            MenuReserva.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuReserva.Click += MenuReserva_Click;
            // 
            // MenuServicios
            // 
            MenuServicios.AutoSize = false;
            MenuServicios.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuServicios.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            MenuServicios.IconColor = Color.Black;
            MenuServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuServicios.IconSize = 45;
            MenuServicios.ImageScaling = ToolStripItemImageScaling.None;
            MenuServicios.Name = "MenuServicios";
            MenuServicios.Size = new Size(80, 60);
            MenuServicios.Text = "Servicios";
            MenuServicios.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuServicios.Click += MenuServicios_Click;
            // 
            // MenuIngresoDePagos
            // 
            MenuIngresoDePagos.AutoSize = false;
            MenuIngresoDePagos.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuIngresoDePagos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            MenuIngresoDePagos.IconColor = Color.Black;
            MenuIngresoDePagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuIngresoDePagos.IconSize = 45;
            MenuIngresoDePagos.ImageScaling = ToolStripItemImageScaling.None;
            MenuIngresoDePagos.Name = "MenuIngresoDePagos";
            MenuIngresoDePagos.Size = new Size(80, 60);
            MenuIngresoDePagos.Text = "Ingresos";
            MenuIngresoDePagos.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuIngresoDePagos.Click += MenuPagos_Click;
            // 
            // MenuCliente
            // 
            MenuCliente.AutoSize = false;
            MenuCliente.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuCliente.IconChar = FontAwesome.Sharp.IconChar.Person;
            MenuCliente.IconColor = Color.Black;
            MenuCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuCliente.IconSize = 45;
            MenuCliente.ImageScaling = ToolStripItemImageScaling.None;
            MenuCliente.Name = "MenuCliente";
            MenuCliente.Size = new Size(80, 60);
            MenuCliente.Text = "Clientes";
            MenuCliente.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuCliente.Click += MenuCliente_Click;
            // 
            // MenuBackup
            // 
            MenuBackup.AutoSize = false;
            MenuBackup.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuBackup.IconChar = FontAwesome.Sharp.IconChar.Database;
            MenuBackup.IconColor = Color.Black;
            MenuBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuBackup.IconSize = 45;
            MenuBackup.ImageScaling = ToolStripItemImageScaling.None;
            MenuBackup.Name = "MenuBackup";
            MenuBackup.Size = new Size(80, 60);
            MenuBackup.Text = "BackyRest";
            MenuBackup.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuBackup.Click += MenuBackup_Click;
            // 
            // MenuTitulo
            // 
            MenuTitulo.AutoSize = false;
            MenuTitulo.BackColor = Color.SteelBlue;
            MenuTitulo.Items.AddRange(new ToolStripItem[] { MenuSalir, UsuarioToolStripMenuItem, ICTitulo, hOTELDELPARANAToolStripMenuItem, perfilToolStripMenuItem1 });
            MenuTitulo.Location = new Point(0, 0);
            MenuTitulo.Name = "MenuTitulo";
            MenuTitulo.Size = new Size(995, 60);
            MenuTitulo.TabIndex = 1;
            MenuTitulo.Text = "menuStrip2";
            // 
            // MenuSalir
            // 
            MenuSalir.Alignment = ToolStripItemAlignment.Right;
            MenuSalir.AutoSize = false;
            MenuSalir.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            MenuSalir.IconColor = Color.Black;
            MenuSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuSalir.IconSize = 40;
            MenuSalir.ImageScaling = ToolStripItemImageScaling.None;
            MenuSalir.Name = "MenuSalir";
            MenuSalir.Size = new Size(80, 56);
            MenuSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuSalir.Click += MenuSalir_Click;
            // 
            // UsuarioToolStripMenuItem
            // 
            UsuarioToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            UsuarioToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem";
            UsuarioToolStripMenuItem.Size = new Size(60, 56);
            UsuarioToolStripMenuItem.Text = "Usuario";
            // 
            // ICTitulo
            // 
            ICTitulo.AutoSize = false;
            ICTitulo.BackgroundImageLayout = ImageLayout.Center;
            ICTitulo.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            ICTitulo.IconColor = Color.Black;
            ICTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ICTitulo.ImageScaling = ToolStripItemImageScaling.None;
            ICTitulo.Name = "ICTitulo";
            ICTitulo.Size = new Size(60, 56);
            ICTitulo.TextAlign = ContentAlignment.BottomCenter;
            ICTitulo.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // hOTELDELPARANAToolStripMenuItem
            // 
            hOTELDELPARANAToolStripMenuItem.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            hOTELDELPARANAToolStripMenuItem.Name = "hOTELDELPARANAToolStripMenuItem";
            hOTELDELPARANAToolStripMenuItem.Size = new Size(266, 56);
            hOTELDELPARANAToolStripMenuItem.Text = "HOTEL DEL PARANA";
            // 
            // perfilToolStripMenuItem1
            // 
            perfilToolStripMenuItem1.Alignment = ToolStripItemAlignment.Right;
            perfilToolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            perfilToolStripMenuItem1.Name = "perfilToolStripMenuItem1";
            perfilToolStripMenuItem1.Size = new Size(55, 56);
            perfilToolStripMenuItem1.Text = "Perfil :";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.Dock = DockStyle.Fill;
            PanelPrincipal.Location = new Point(152, 60);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Size = new Size(843, 587);
            PanelPrincipal.TabIndex = 2;
            // 
            // FMPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 647);
            Controls.Add(PanelPrincipal);
            Controls.Add(MenuIzquierdo);
            Controls.Add(MenuTitulo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = MenuIzquierdo;
            Name = "FMPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema G. Hotelera";
            Load += FMInicio_Load;
            Click += MenuReservar_Click;
            MenuIzquierdo.ResumeLayout(false);
            MenuIzquierdo.PerformLayout();
            MenuTitulo.ResumeLayout(false);
            MenuTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip MenuIzquierdo;
        private MenuStrip MenuTitulo;
        private FontAwesome.Sharp.IconMenuItem MenuReservar;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuHabitacion;
        private FontAwesome.Sharp.IconMenuItem MenuReserva;
        private FontAwesome.Sharp.IconMenuItem MenuSalir;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private ToolStripMenuItem UsuarioToolStripMenuItem;
        private Panel PanelPrincipal;
        private FontAwesome.Sharp.IconMenuItem MenuIngresoDePagos;
        private FontAwesome.Sharp.IconMenuItem ICTitulo;
        private ToolStripMenuItem hOTELDELPARANAToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem MenuBackup;
        private FontAwesome.Sharp.IconMenuItem MenuServicios;
        private ToolStripMenuItem perfilToolStripMenuItem1;
        private FontAwesome.Sharp.IconMenuItem MenuInicio;
        private FontAwesome.Sharp.IconMenuItem MenuCliente;
    }
}