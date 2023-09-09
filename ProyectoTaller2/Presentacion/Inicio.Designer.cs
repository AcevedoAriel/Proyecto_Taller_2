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
            SubMenuAgregarHabitacion = new ToolStripMenuItem();
            MenuReserva = new FontAwesome.Sharp.IconMenuItem();
            MenuPagos = new FontAwesome.Sharp.IconMenuItem();
            MenuTitulo = new MenuStrip();
            sISTEMADEGESIONHOTELERAToolStripMenuItem = new ToolStripMenuItem();
            MenuSalir = new FontAwesome.Sharp.IconMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
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
            MenuIzquierdo.Items.AddRange(new ToolStripItem[] { MenuInicio, MenuUsuario, MenuHabitacion, MenuReserva, MenuPagos });
            MenuIzquierdo.Location = new Point(0, 60);
            MenuIzquierdo.Name = "MenuIzquierdo";
            MenuIzquierdo.Size = new Size(152, 387);
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
            SubMenuAgregarUsuario.Size = new Size(180, 22);
            SubMenuAgregarUsuario.Text = "Agregar Usuario";
            SubMenuAgregarUsuario.Click += SubMenuAgregarUsuario_Click;
            // 
            // SubMenuConsultarUsuario
            // 
            SubMenuConsultarUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuConsultarUsuario.IconColor = Color.Black;
            SubMenuConsultarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuConsultarUsuario.Name = "SubMenuConsultarUsuario";
            SubMenuConsultarUsuario.Size = new Size(180, 22);
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
            SubMenuAgregarHabitacion.Name = "SubMenuAgregarHabitacion";
            SubMenuAgregarHabitacion.Size = new Size(180, 22);
            SubMenuAgregarHabitacion.Text = "Agregar Habitacion";
            SubMenuAgregarHabitacion.Click += SubMenuAgregarHabitacion_Click;
            // 
            // MenuReserva
            // 
            MenuReserva.AutoSize = false;
            MenuReserva.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuReserva.IconChar = FontAwesome.Sharp.IconChar.Researchgate;
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
            // MenuPagos
            // 
            MenuPagos.AutoSize = false;
            MenuPagos.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuPagos.IconChar = FontAwesome.Sharp.IconChar.Pager;
            MenuPagos.IconColor = Color.Black;
            MenuPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuPagos.IconSize = 45;
            MenuPagos.ImageScaling = ToolStripItemImageScaling.None;
            MenuPagos.Name = "MenuPagos";
            MenuPagos.Size = new Size(80, 60);
            MenuPagos.Text = "Pagos";
            MenuPagos.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MenuTitulo
            // 
            MenuTitulo.AutoSize = false;
            MenuTitulo.BackColor = Color.SteelBlue;
            MenuTitulo.Items.AddRange(new ToolStripItem[] { sISTEMADEGESIONHOTELERAToolStripMenuItem, MenuSalir, perfilToolStripMenuItem });
            MenuTitulo.Location = new Point(0, 0);
            MenuTitulo.Name = "MenuTitulo";
            MenuTitulo.Size = new Size(815, 60);
            MenuTitulo.TabIndex = 1;
            MenuTitulo.Text = "menuStrip2";
            // 
            // sISTEMADEGESIONHOTELERAToolStripMenuItem
            // 
            sISTEMADEGESIONHOTELERAToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sISTEMADEGESIONHOTELERAToolStripMenuItem.ForeColor = SystemColors.GradientInactiveCaption;
            sISTEMADEGESIONHOTELERAToolStripMenuItem.Name = "sISTEMADEGESIONHOTELERAToolStripMenuItem";
            sISTEMADEGESIONHOTELERAToolStripMenuItem.Size = new Size(208, 56);
            sISTEMADEGESIONHOTELERAToolStripMenuItem.Text = "SISTEMA DE GESION HOTELERA";
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
            Contenedor.Size = new Size(663, 387);
            Contenedor.TabIndex = 2;
            // 
            // FMInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 447);
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
        private FontAwesome.Sharp.IconMenuItem MenuPagos;
        private ToolStripMenuItem sISTEMADEGESIONHOTELERAToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem MenuInicio;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuHabitacion;
        private FontAwesome.Sharp.IconMenuItem MenuReserva;
        private FontAwesome.Sharp.IconMenuItem MenuSalir;
        private ToolStripMenuItem SubMenuAgregarHabitacion;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private Panel Contenedor;
        private FontAwesome.Sharp.IconMenuItem SubMenuAgregarUsuario;
        private FontAwesome.Sharp.IconMenuItem SubMenuConsultarUsuario;
    }
}