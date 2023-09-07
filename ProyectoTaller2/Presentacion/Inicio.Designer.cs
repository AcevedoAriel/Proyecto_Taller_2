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
            Menu1 = new MenuStrip();
            sISTEMADEGESIONHOTELERAToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            habitacionesToolStripMenuItem = new ToolStripMenuItem();
            agregarHabitacionToolStripMenuItem = new ToolStripMenuItem();
            reservasToolStripMenuItem = new ToolStripMenuItem();
            pagosToolStripMenuItem = new ToolStripMenuItem();
            registrarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            consultarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            Menu1.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Menu1
            // 
            Menu1.AllowDrop = true;
            Menu1.AutoSize = false;
            Menu1.BackColor = Color.SteelBlue;
            Menu1.Items.AddRange(new ToolStripItem[] { sISTEMADEGESIONHOTELERAToolStripMenuItem });
            Menu1.Location = new Point(0, 0);
            Menu1.Name = "Menu1";
            Menu1.RightToLeft = RightToLeft.No;
            Menu1.Size = new Size(800, 55);
            Menu1.TabIndex = 0;
            Menu1.Text = "Menu1";
            // 
            // sISTEMADEGESIONHOTELERAToolStripMenuItem
            // 
            sISTEMADEGESIONHOTELERAToolStripMenuItem.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            sISTEMADEGESIONHOTELERAToolStripMenuItem.ForeColor = Color.Gainsboro;
            sISTEMADEGESIONHOTELERAToolStripMenuItem.Name = "sISTEMADEGESIONHOTELERAToolStripMenuItem";
            sISTEMADEGESIONHOTELERAToolStripMenuItem.Size = new Size(274, 51);
            sISTEMADEGESIONHOTELERAToolStripMenuItem.Text = "SISTEMA DE GESTION HOTELERA";
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 395);
            panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, usuarioToolStripMenuItem, habitacionesToolStripMenuItem, reservasToolStripMenuItem, pagosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(144, 395);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(137, 19);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarUsuarioToolStripMenuItem, consultarUsuarioToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(137, 19);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // habitacionesToolStripMenuItem
            // 
            habitacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarHabitacionToolStripMenuItem });
            habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            habitacionesToolStripMenuItem.Size = new Size(137, 19);
            habitacionesToolStripMenuItem.Text = "Habitaciones";
            // 
            // agregarHabitacionToolStripMenuItem
            // 
            agregarHabitacionToolStripMenuItem.Name = "agregarHabitacionToolStripMenuItem";
            agregarHabitacionToolStripMenuItem.Size = new Size(180, 22);
            agregarHabitacionToolStripMenuItem.Text = "Agregar Habitacion";
            // 
            // reservasToolStripMenuItem
            // 
            reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            reservasToolStripMenuItem.Size = new Size(137, 19);
            reservasToolStripMenuItem.Text = "Reservas";
            // 
            // pagosToolStripMenuItem
            // 
            pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            pagosToolStripMenuItem.Size = new Size(137, 19);
            pagosToolStripMenuItem.Text = "Pagos";
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            registrarUsuarioToolStripMenuItem.Size = new Size(180, 22);
            registrarUsuarioToolStripMenuItem.Text = "Registrar Usuario";
            // 
            // consultarUsuarioToolStripMenuItem
            // 
            consultarUsuarioToolStripMenuItem.Name = "consultarUsuarioToolStripMenuItem";
            consultarUsuarioToolStripMenuItem.Size = new Size(180, 22);
            consultarUsuarioToolStripMenuItem.Text = "Consultar Usuario";
            // 
            // FMInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(Menu1);
            Name = "FMInicio";
            Text = "Inicio";
            Menu1.ResumeLayout(false);
            Menu1.PerformLayout();
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip Menu1;
        private ToolStripMenuItem sISTEMADEGESIONHOTELERAToolStripMenuItem;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem habitacionesToolStripMenuItem;
        private ToolStripMenuItem agregarHabitacionToolStripMenuItem;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private ToolStripMenuItem pagosToolStripMenuItem;
        private ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private ToolStripMenuItem consultarUsuarioToolStripMenuItem;
    }
}