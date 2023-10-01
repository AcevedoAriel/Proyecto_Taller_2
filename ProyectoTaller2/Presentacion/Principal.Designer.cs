namespace ProyectoTaller2.Administrador
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
            MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            MenuHabitacion = new FontAwesome.Sharp.IconMenuItem();
            MenuReserva = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            MenuPagos = new FontAwesome.Sharp.IconMenuItem();
            MenuAjusteAvanzado = new FontAwesome.Sharp.IconMenuItem();
            SubMenuAjusteBackup = new ToolStripMenuItem();
            MenuTitulo = new MenuStrip();
            MenuSalir = new FontAwesome.Sharp.IconMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            ICTitulo = new FontAwesome.Sharp.IconMenuItem();
            hOTELDELPARANAToolStripMenuItem = new ToolStripMenuItem();
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
            MenuIzquierdo.Items.AddRange(new ToolStripItem[] { MenuInicio, MenuUsuario, MenuHabitacion, MenuReserva, iconMenuItem3, MenuPagos, MenuAjusteAvanzado });
            MenuIzquierdo.Location = new Point(0, 60);
            MenuIzquierdo.Name = "MenuIzquierdo";
            MenuIzquierdo.Size = new Size(152, 504);
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
            // iconMenuItem3
            // 
            iconMenuItem3.AutoSize = false;
            iconMenuItem3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.IconSize = 45;
            iconMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(80, 60);
            iconMenuItem3.Text = "Servicios";
            iconMenuItem3.TextImageRelation = TextImageRelation.ImageAboveText;
            iconMenuItem3.Click += MenuServicios_Click;
            // 
            // MenuPagos
            // 
            MenuPagos.AutoSize = false;
            MenuPagos.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuPagos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            MenuPagos.IconColor = Color.Black;
            MenuPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuPagos.IconSize = 45;
            MenuPagos.ImageScaling = ToolStripItemImageScaling.None;
            MenuPagos.Name = "MenuPagos";
            MenuPagos.Size = new Size(80, 60);
            MenuPagos.Text = "Ingresos";
            MenuPagos.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuPagos.Click += MenuPagos_Click;
            // 
            // MenuAjusteAvanzado
            // 
            MenuAjusteAvanzado.AutoSize = false;
            MenuAjusteAvanzado.DropDownItems.AddRange(new ToolStripItem[] { SubMenuAjusteBackup });
            MenuAjusteAvanzado.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuAjusteAvanzado.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            MenuAjusteAvanzado.IconColor = Color.Black;
            MenuAjusteAvanzado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuAjusteAvanzado.IconSize = 45;
            MenuAjusteAvanzado.ImageScaling = ToolStripItemImageScaling.None;
            MenuAjusteAvanzado.Name = "MenuAjusteAvanzado";
            MenuAjusteAvanzado.Size = new Size(80, 60);
            MenuAjusteAvanzado.Text = "Ajustes";
            MenuAjusteAvanzado.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // SubMenuAjusteBackup
            // 
            SubMenuAjusteBackup.Name = "SubMenuAjusteBackup";
            SubMenuAjusteBackup.Size = new Size(111, 22);
            SubMenuAjusteBackup.Text = "Backup";
            SubMenuAjusteBackup.Click += SubMenuAjusteBackup_Click;
            // 
            // MenuTitulo
            // 
            MenuTitulo.AutoSize = false;
            MenuTitulo.BackColor = Color.SteelBlue;
            MenuTitulo.Items.AddRange(new ToolStripItem[] { MenuSalir, perfilToolStripMenuItem, ICTitulo, hOTELDELPARANAToolStripMenuItem });
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
            PanelPrincipal.Size = new Size(843, 504);
            PanelPrincipal.TabIndex = 2;
            // 
            // FMPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 564);
            Controls.Add(PanelPrincipal);
            Controls.Add(MenuIzquierdo);
            Controls.Add(MenuTitulo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuStrip = MenuIzquierdo;
            Name = "FMPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema G. Hotelera";
            Load += FMInicio_Load;
            MenuIzquierdo.ResumeLayout(false);
            MenuIzquierdo.PerformLayout();
            MenuTitulo.ResumeLayout(false);
            MenuTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip MenuIzquierdo;
        private MenuStrip MenuTitulo;
        private FontAwesome.Sharp.IconMenuItem MenuInicio;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuHabitacion;
        private FontAwesome.Sharp.IconMenuItem MenuReserva;
        private FontAwesome.Sharp.IconMenuItem MenuSalir;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private Panel PanelPrincipal;
        private FontAwesome.Sharp.IconMenuItem MenuPagos;
        private FontAwesome.Sharp.IconMenuItem ICTitulo;
        private ToolStripMenuItem hOTELDELPARANAToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem MenuAjusteAvanzado;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private ToolStripMenuItem SubMenuAjusteBackup;
    }
}