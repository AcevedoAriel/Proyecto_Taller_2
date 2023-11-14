using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion
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
            this.MenuIzquierdo = new System.Windows.Forms.MenuStrip();
            this.MenuInicio = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReservar = new FontAwesome.Sharp.IconMenuItem();
            this.MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.MenuHabitacion = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReserva = new FontAwesome.Sharp.IconMenuItem();
            this.agregarReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuServicios = new FontAwesome.Sharp.IconMenuItem();
            this.MenuIngresoDePagos = new FontAwesome.Sharp.IconMenuItem();
            this.MenuCliente = new FontAwesome.Sharp.IconMenuItem();
            this.MenuBackup = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.MenuSalir = new FontAwesome.Sharp.IconMenuItem();
            this.UsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ICTitulo = new FontAwesome.Sharp.IconMenuItem();
            this.hOTELDELPARANAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.MenuIzquierdo.SuspendLayout();
            this.MenuTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuIzquierdo
            // 
            this.MenuIzquierdo.AutoSize = false;
            this.MenuIzquierdo.BackColor = System.Drawing.Color.White;
            this.MenuIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuIzquierdo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuInicio,
            this.MenuReservar,
            this.MenuUsuario,
            this.MenuHabitacion,
            this.MenuReserva,
            this.MenuServicios,
            this.MenuIngresoDePagos,
            this.MenuCliente,
            this.MenuBackup});
            this.MenuIzquierdo.Location = new System.Drawing.Point(0, 60);
            this.MenuIzquierdo.Name = "MenuIzquierdo";
            this.MenuIzquierdo.Size = new System.Drawing.Size(152, 587);
            this.MenuIzquierdo.TabIndex = 0;
            this.MenuIzquierdo.Text = "menuStrip1";
            // 
            // MenuInicio
            // 
            this.MenuInicio.AutoSize = false;
            this.MenuInicio.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.MenuInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.MenuInicio.IconColor = System.Drawing.Color.Black;
            this.MenuInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInicio.IconSize = 45;
            this.MenuInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInicio.Name = "MenuInicio";
            this.MenuInicio.Size = new System.Drawing.Size(80, 60);
            this.MenuInicio.Text = "Inicio";
            this.MenuInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuReservar
            // 
            this.MenuReservar.AutoSize = false;
            this.MenuReservar.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.MenuReservar.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.MenuReservar.IconColor = System.Drawing.Color.Black;
            this.MenuReservar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReservar.IconSize = 45;
            this.MenuReservar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReservar.Name = "MenuReservar";
            this.MenuReservar.Size = new System.Drawing.Size(80, 60);
            this.MenuReservar.Text = "Reservar";
            this.MenuReservar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.AutoSize = false;
            this.MenuUsuario.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.MenuUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.MenuUsuario.IconColor = System.Drawing.Color.Black;
            this.MenuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuario.IconSize = 45;
            this.MenuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(80, 60);
            this.MenuUsuario.Text = "Usuario";
            this.MenuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuHabitacion
            // 
            this.MenuHabitacion.AutoSize = false;
            this.MenuHabitacion.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.MenuHabitacion.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.MenuHabitacion.IconColor = System.Drawing.Color.Black;
            this.MenuHabitacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuHabitacion.IconSize = 45;
            this.MenuHabitacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuHabitacion.Name = "MenuHabitacion";
            this.MenuHabitacion.Size = new System.Drawing.Size(80, 60);
            this.MenuHabitacion.Text = "Habitacion";
            this.MenuHabitacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuReserva
            // 
            this.MenuReserva.AutoSize = false;
            this.MenuReserva.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarReservaToolStripMenuItem,
            this.listadoDeReservasToolStripMenuItem});
            this.MenuReserva.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.MenuReserva.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.MenuReserva.IconColor = System.Drawing.Color.Black;
            this.MenuReserva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReserva.IconSize = 45;
            this.MenuReserva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReserva.Name = "MenuReserva";
            this.MenuReserva.Size = new System.Drawing.Size(80, 60);
            this.MenuReserva.Text = "Reservas";
            this.MenuReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // agregarReservaToolStripMenuItem
            // 
            this.agregarReservaToolStripMenuItem.Name = "agregarReservaToolStripMenuItem";
            this.agregarReservaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarReservaToolStripMenuItem.Text = "Agregar Reserva";
            this.agregarReservaToolStripMenuItem.Click += new System.EventHandler(this.agregarReservaToolStripMenuItem_Click);
            // 
            // listadoDeReservasToolStripMenuItem
            // 
            this.listadoDeReservasToolStripMenuItem.Name = "listadoDeReservasToolStripMenuItem";
            this.listadoDeReservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoDeReservasToolStripMenuItem.Text = "Listado de Reservas";
            this.listadoDeReservasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeReservasToolStripMenuItem_Click);
            // 
            // MenuServicios
            // 
            this.MenuServicios.AutoSize = false;
            this.MenuServicios.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.MenuServicios.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            this.MenuServicios.IconColor = System.Drawing.Color.Black;
            this.MenuServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuServicios.IconSize = 45;
            this.MenuServicios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuServicios.Name = "MenuServicios";
            this.MenuServicios.Size = new System.Drawing.Size(80, 60);
            this.MenuServicios.Text = "Servicios";
            this.MenuServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuIngresoDePagos
            // 
            this.MenuIngresoDePagos.AutoSize = false;
            this.MenuIngresoDePagos.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.MenuIngresoDePagos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.MenuIngresoDePagos.IconColor = System.Drawing.Color.Black;
            this.MenuIngresoDePagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuIngresoDePagos.IconSize = 45;
            this.MenuIngresoDePagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuIngresoDePagos.Name = "MenuIngresoDePagos";
            this.MenuIngresoDePagos.Size = new System.Drawing.Size(80, 60);
            this.MenuIngresoDePagos.Text = "Ingresos";
            this.MenuIngresoDePagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuCliente
            // 
            this.MenuCliente.AutoSize = false;
            this.MenuCliente.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.MenuCliente.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.MenuCliente.IconColor = System.Drawing.Color.Black;
            this.MenuCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCliente.IconSize = 45;
            this.MenuCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCliente.Name = "MenuCliente";
            this.MenuCliente.Size = new System.Drawing.Size(80, 60);
            this.MenuCliente.Text = "Clientes";
            this.MenuCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuBackup
            // 
            this.MenuBackup.AutoSize = false;
            this.MenuBackup.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.MenuBackup.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.MenuBackup.IconColor = System.Drawing.Color.Black;
            this.MenuBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuBackup.IconSize = 45;
            this.MenuBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuBackup.Name = "MenuBackup";
            this.MenuBackup.Size = new System.Drawing.Size(80, 60);
            this.MenuBackup.Text = "BackyRest";
            this.MenuBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSalir,
            this.UsuarioToolStripMenuItem,
            this.ICTitulo,
            this.hOTELDELPARANAToolStripMenuItem,
            this.perfilToolStripMenuItem1});
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.Size = new System.Drawing.Size(995, 60);
            this.MenuTitulo.TabIndex = 1;
            this.MenuTitulo.Text = "menuStrip2";
            // 
            // MenuSalir
            // 
            this.MenuSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuSalir.AutoSize = false;
            this.MenuSalir.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.MenuSalir.IconColor = System.Drawing.Color.Black;
            this.MenuSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuSalir.IconSize = 40;
            this.MenuSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuSalir.Name = "MenuSalir";
            this.MenuSalir.Size = new System.Drawing.Size(80, 56);
            this.MenuSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // UsuarioToolStripMenuItem
            // 
            this.UsuarioToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UsuarioToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem";
            this.UsuarioToolStripMenuItem.Size = new System.Drawing.Size(60, 56);
            this.UsuarioToolStripMenuItem.Text = "Usuario";
            // 
            // ICTitulo
            // 
            this.ICTitulo.AutoSize = false;
            this.ICTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ICTitulo.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.ICTitulo.IconColor = System.Drawing.Color.Black;
            this.ICTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICTitulo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ICTitulo.Name = "ICTitulo";
            this.ICTitulo.Size = new System.Drawing.Size(60, 56);
            this.ICTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ICTitulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // hOTELDELPARANAToolStripMenuItem
            // 
            this.hOTELDELPARANAToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.hOTELDELPARANAToolStripMenuItem.Name = "hOTELDELPARANAToolStripMenuItem";
            this.hOTELDELPARANAToolStripMenuItem.Size = new System.Drawing.Size(266, 56);
            this.hOTELDELPARANAToolStripMenuItem.Text = "HOTEL DEL PARANA";
            // 
            // perfilToolStripMenuItem1
            // 
            this.perfilToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.perfilToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.perfilToolStripMenuItem1.Name = "perfilToolStripMenuItem1";
            this.perfilToolStripMenuItem1.Size = new System.Drawing.Size(55, 56);
            this.perfilToolStripMenuItem1.Text = "Perfil :";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(152, 60);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(843, 587);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // FMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 647);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.MenuIzquierdo);
            this.Controls.Add(this.MenuTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MenuIzquierdo;
            this.Name = "FMPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema G. Hotelera";
            this.MenuIzquierdo.ResumeLayout(false);
            this.MenuIzquierdo.PerformLayout();
            this.MenuTitulo.ResumeLayout(false);
            this.MenuTitulo.PerformLayout();
            this.ResumeLayout(false);

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
        private ToolStripMenuItem agregarReservaToolStripMenuItem;
        private ToolStripMenuItem listadoDeReservasToolStripMenuItem;
    }
}