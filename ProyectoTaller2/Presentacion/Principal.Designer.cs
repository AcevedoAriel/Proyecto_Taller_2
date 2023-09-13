namespace ProyectoTaller2.Administrador
{
    partial class FMInicio
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
            MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            SubMenuAgregarUsuario = new FontAwesome.Sharp.IconMenuItem();
            SubMenuConsultarUsuario = new FontAwesome.Sharp.IconMenuItem();
            MenuHabitacion = new FontAwesome.Sharp.IconMenuItem();
            SubMenuAgregarHabitacion = new FontAwesome.Sharp.IconMenuItem();
            MenuReserva = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            MenuServicios = new FontAwesome.Sharp.IconMenuItem();
            MenuTitulo = new MenuStrip();
            MenuSalir = new FontAwesome.Sharp.IconMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            ICTitulo = new FontAwesome.Sharp.IconMenuItem();
            hOTELDELPARANAToolStripMenuItem = new ToolStripMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            Contenedor = new Panel();
            MenuIzquierdo.SuspendLayout();
            MenuTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // MenuIzquierdo
            // 
            MenuIzquierdo.AutoSize = false;
            MenuIzquierdo.BackColor = Color.White;
            MenuIzquierdo.Dock = DockStyle.Left;
            MenuIzquierdo.Items.AddRange(new ToolStripItem[] { MenuInicio, MenuUsuario, MenuHabitacion, MenuReserva, iconMenuItem3, MenuServicios });
            MenuIzquierdo.Location = new Point(0, 60);
            MenuIzquierdo.Name = "MenuIzquierdo";
            MenuIzquierdo.Size = new Size(152, 466);
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
            MenuInicio.Click += MenuInicio_Click;
            // 
            // MenuUsuario
            // 
            MenuUsuario.AutoSize = false;
            MenuUsuario.DropDownItems.AddRange(new ToolStripItem[] { SubMenuAgregarUsuario, SubMenuConsultarUsuario });
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
            // 
            // SubMenuAgregarUsuario
            // 
            SubMenuAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuAgregarUsuario.IconColor = Color.Black;
            SubMenuAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuAgregarUsuario.Name = "SubMenuAgregarUsuario";
            SubMenuAgregarUsuario.Size = new Size(162, 22);
            SubMenuAgregarUsuario.Text = "Agregar Usuario";
            SubMenuAgregarUsuario.Click += SubMenuAgregarUsuario_Click;
            // 
            // SubMenuConsultarUsuario
            // 
            SubMenuConsultarUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuConsultarUsuario.IconColor = Color.Black;
            SubMenuConsultarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuConsultarUsuario.Name = "SubMenuConsultarUsuario";
            SubMenuConsultarUsuario.Size = new Size(162, 22);
            SubMenuConsultarUsuario.Text = "Consultar Usuario";
            SubMenuConsultarUsuario.Click += SubMenuConsultarUsuario_Click;
            // 
            // MenuHabitacion
            // 
            MenuHabitacion.AutoSize = false;
            MenuHabitacion.DropDownItems.AddRange(new ToolStripItem[] { SubMenuAgregarHabitacion });
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
            // 
            // SubMenuAgregarHabitacion
            // 
            SubMenuAgregarHabitacion.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuAgregarHabitacion.IconColor = Color.Black;
            SubMenuAgregarHabitacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuAgregarHabitacion.Name = "SubMenuAgregarHabitacion";
            SubMenuAgregarHabitacion.Size = new Size(166, 22);
            SubMenuAgregarHabitacion.Text = "Agregar Habitacion";
            SubMenuAgregarHabitacion.Click += SubMenuAgregarHabitacion_Click_1;
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
            // iconMenuItem3
            // 
            iconMenuItem3.AutoSize = false;
            iconMenuItem3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Pager;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.IconSize = 45;
            iconMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(80, 60);
            iconMenuItem3.Text = "Pagos";
            iconMenuItem3.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MenuServicios
            // 
            MenuServicios.AutoSize = false;
            MenuServicios.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuServicios.IconChar = FontAwesome.Sharp.IconChar.Server;
            MenuServicios.IconColor = Color.Black;
            MenuServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuServicios.IconSize = 45;
            MenuServicios.ImageScaling = ToolStripItemImageScaling.None;
            MenuServicios.Name = "MenuServicios";
            MenuServicios.Size = new Size(80, 60);
            MenuServicios.Text = "Servicios";
            MenuServicios.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MenuTitulo
            // 
            MenuTitulo.AutoSize = false;
            MenuTitulo.BackColor = Color.SteelBlue;
            MenuTitulo.Items.AddRange(new ToolStripItem[] { MenuSalir, perfilToolStripMenuItem, ICTitulo, hOTELDELPARANAToolStripMenuItem });
            MenuTitulo.Location = new Point(0, 0);
            MenuTitulo.Name = "MenuTitulo";
            MenuTitulo.Size = new Size(1035, 60);
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
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            perfilToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(49, 56);
            perfilToolStripMenuItem.Text = "Perfil";
            // 
            // ICTitulo
            // 
            ICTitulo.AutoSize = false;
            ICTitulo.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            ICTitulo.IconColor = Color.Black;
            ICTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ICTitulo.ImageScaling = ToolStripItemImageScaling.None;
            ICTitulo.Name = "ICTitulo";
            ICTitulo.Size = new Size(122, 56);
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
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // Contenedor
            // 
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(152, 60);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(883, 466);
            Contenedor.TabIndex = 2;
            Contenedor.Paint += Contenedor_Paint;
            // 
            // FMInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 526);
            Controls.Add(Contenedor);
            Controls.Add(MenuIzquierdo);
            Controls.Add(MenuTitulo);
            MainMenuStrip = MenuIzquierdo;
            Name = "FMInicio";
            Text = "Sistema G. Hotelera";
            MenuIzquierdo.ResumeLayout(false);
            MenuIzquierdo.PerformLayout();
            MenuTitulo.ResumeLayout(false);
            MenuTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip MenuIzquierdo;
        private MenuStrip MenuTitulo;
        private FontAwesome.Sharp.IconMenuItem MenuServicios;
        private FontAwesome.Sharp.IconMenuItem MenuInicio;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuHabitacion;
        private FontAwesome.Sharp.IconMenuItem MenuReserva;
        private FontAwesome.Sharp.IconMenuItem MenuSalir;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private Panel Contenedor;
        private FontAwesome.Sharp.IconMenuItem SubMenuAgregarUsuario;
        private FontAwesome.Sharp.IconMenuItem SubMenuConsultarUsuario;
        private FontAwesome.Sharp.IconMenuItem SubMenuAgregarHabitacion;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem ICTitulo;
        private ToolStripMenuItem hOTELDELPARANAToolStripMenuItem;
    }
}