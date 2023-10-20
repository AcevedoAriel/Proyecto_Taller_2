﻿using FontAwesome.Sharp;
using ProyectoTaller2.CapaPresentacion.Administrador;
using ProyectoTaller2.CapaPresentacion.Recepcionista;
using ProyectoTaller2.CapaPresentacion.SuperUsuario;

namespace ProyectoTaller2.CapaPresentacion
{
    public partial class FMPrincipal : Form
    {
        //alcamena el menu que se encuentra activo
        public static IconMenuItem? MenuActivo;
        //Formulario que esta activo en el panel
        public static Form? FormularioActivo;

        public FMPrincipal(string perfil, string nombre)
        {
            InitializeComponent();
            UsuarioToolStripMenuItem.Text = nombre;
            perfilToolStripMenuItem1.Text = perfil + ":";
        }

        private void Menu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void MostrarFormulario(Form fm)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = fm;
            //indica que no es un formulario padre
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            //se ajusta al panel
            fm.Dock = DockStyle.Fill;
            fm.Show();
        }

        public void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            //si hay un menu activo anteriormente que se regrese al color blanco
            if (MenuActivo != null)
            {

                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            //si el formulario no es nulo es decir si se abre otro formulario, la anterior se cierra.
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            //indica que no es un formulario padre
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            //se ajusta al panel
            formulario.Dock = DockStyle.Fill;

            formulario.BackColor = Color.LightSkyBlue;

            //es el contenedor donde se mostrará el formulario hijo.
            PanelPrincipal.Controls.Add(formulario);
            formulario.Show();
        }


        public void MenuReserva_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new ListadoDeReservas());
        }

        public void MenuInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Inicio());
        }

        public void FMInicio_Load(object sender, EventArgs e)
        {

            /* FMIniciarSesion login = new();

             switch (login.ShowDialog())
             {
                 case DialogResult.OK:
                     switch (login.txtUsuario.Text)
                     {
                         case "Admin":
                             if (login.txtClave.Text == "123")
                             {
                                 MenuBackup.Visible = false;
                                 MenuReserva.Visible = false;
                                 MenuUsuario.Visible = false;
                             }
                             break;
                         case "Recep":
                             if (login.txtClave.Text == "456")
                             {
                                 MenuUsuario.Visible = false;
                                 MenuBackup.Visible = false;
                                 MenuServicios.Visible = false;
                                 MenuIngresoDePagos.Visible = false;
                                 MenuHabitacion.Visible = false;
                             }
                             break;
                         case "SupUsr":
                             if (login.txtClave.Text == "789")
                             {
                                 MenuServicios.Visible = false;
                                 MenuHabitacion.Visible = false;
                                 MenuReserva.Visible = false;
                                 MenuIngresoDePagos.Visible = false;
                             }
                             break;
                         default:
                             this.Close();
                             break;
                     }
                     break;
                 default:
                     this.Close();
                     break;
             }*/

        }

        public void MenuSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea cerrar sesion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FMIniciarSesion sesion = new FMIniciarSesion();
                sesion.Show();
                this.Close();
            }

        }

        public void MenuHabitacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new CRUDHabitacion());
        }

        public void MenuServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new ServiciosCrud());
        }

        public void MenuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuUsuario, new UsuarioCRUD());
        }

        public void MenuPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuIngresoDePagos, new Ingresos());

        }

        public void MenuBackup_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuBackup, new FMBackupRestore());
        }
    }
}