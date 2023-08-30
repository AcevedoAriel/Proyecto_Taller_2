namespace ProyectoTaller2.Administrador
{
    partial class Form_Adm
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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            habitacionesToolStripMenuItem = new ToolStripMenuItem();
            agregarHabitaciónToolStripMenuItem = new ToolStripMenuItem();
            buscarHabitaciónToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            piso1ToolStripMenuItem = new ToolStripMenuItem();
            piso2ToolStripMenuItem = new ToolStripMenuItem();
            piso3ToolStripMenuItem = new ToolStripMenuItem();
            reservasToolStripMenuItem = new ToolStripMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            verReservasToolStripMenuItem = new ToolStripMenuItem();
            editarPerfilToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, habitacionesToolStripMenuItem, reservasToolStripMenuItem, perfilToolStripMenuItem, cerrarSesiónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // habitacionesToolStripMenuItem
            // 
            habitacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarHabitaciónToolStripMenuItem, buscarHabitaciónToolStripMenuItem });
            habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            habitacionesToolStripMenuItem.Size = new Size(88, 20);
            habitacionesToolStripMenuItem.Text = "Habitaciones";
            // 
            // agregarHabitaciónToolStripMenuItem
            // 
            agregarHabitaciónToolStripMenuItem.Name = "agregarHabitaciónToolStripMenuItem";
            agregarHabitaciónToolStripMenuItem.Size = new Size(180, 22);
            agregarHabitaciónToolStripMenuItem.Text = "Agregar Habitación";
            agregarHabitaciónToolStripMenuItem.Click += agregarHabitaciónToolStripMenuItem_Click;
            // 
            // buscarHabitaciónToolStripMenuItem
            // 
            buscarHabitaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { piso1ToolStripMenuItem, piso2ToolStripMenuItem, piso3ToolStripMenuItem });
            buscarHabitaciónToolStripMenuItem.Name = "buscarHabitaciónToolStripMenuItem";
            buscarHabitaciónToolStripMenuItem.Size = new Size(180, 22);
            buscarHabitaciónToolStripMenuItem.Text = "Buscar Habitación";
            // 
            // piso1ToolStripMenuItem
            // 
            piso1ToolStripMenuItem.Name = "piso1ToolStripMenuItem";
            piso1ToolStripMenuItem.Size = new Size(180, 22);
            piso1ToolStripMenuItem.Text = "Piso 1";
            // 
            // piso2ToolStripMenuItem
            // 
            piso2ToolStripMenuItem.Name = "piso2ToolStripMenuItem";
            piso2ToolStripMenuItem.Size = new Size(180, 22);
            piso2ToolStripMenuItem.Text = "Piso 2";
            // 
            // piso3ToolStripMenuItem
            // 
            piso3ToolStripMenuItem.Name = "piso3ToolStripMenuItem";
            piso3ToolStripMenuItem.Size = new Size(180, 22);
            piso3ToolStripMenuItem.Text = "Piso 3";
            // 
            // reservasToolStripMenuItem
            // 
            reservasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verReservasToolStripMenuItem });
            reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            reservasToolStripMenuItem.Size = new Size(64, 20);
            reservasToolStripMenuItem.Text = "Reservas";
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editarPerfilToolStripMenuItem });
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(46, 20);
            perfilToolStripMenuItem.Text = "Perfil";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(91, 20);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión ";
            // 
            // verReservasToolStripMenuItem
            // 
            verReservasToolStripMenuItem.Name = "verReservasToolStripMenuItem";
            verReservasToolStripMenuItem.Size = new Size(180, 22);
            verReservasToolStripMenuItem.Text = "Ver Reservas";
            // 
            // editarPerfilToolStripMenuItem
            // 
            editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            editarPerfilToolStripMenuItem.Size = new Size(180, 22);
            editarPerfilToolStripMenuItem.Text = "Editar Perfil";
            // 
            // Form_Adm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Adm";
            Text = "Administrador";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem habitacionesToolStripMenuItem;
        private ToolStripMenuItem agregarHabitaciónToolStripMenuItem;
        private ToolStripMenuItem buscarHabitaciónToolStripMenuItem;
        private ToolStripMenuItem piso1ToolStripMenuItem;
        private ToolStripMenuItem piso2ToolStripMenuItem;
        private ToolStripMenuItem piso3ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem verReservasToolStripMenuItem;
        private ToolStripMenuItem editarPerfilToolStripMenuItem;
    }
}