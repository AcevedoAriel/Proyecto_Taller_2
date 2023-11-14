using FontAwesome.Sharp;
using Proyecto_Taller_II.CapaPresentacion.Administrador;
using Proyecto_Taller_II.CapaPresentacion.Recepcionista;
using Proyecto_Taller_II.CapaPresentacion.SuperUsuario;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion
{
    public partial class FMPrincipal : Form
    {
        //alcamena el menu que se encuentra activo
        public static IconMenuItem MenuActivo;
        //Formulario que esta activo en el panel
        public static Form FormularioActivo;

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
            fm.BackColor = Color.LightSkyBlue;
            PanelPrincipal.Controls.Add(fm);
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
            
        }

        public void MenuReservar_Click(object sender, EventArgs e)
        {
            
        }

        public void FMInicio_Load(object sender, EventArgs e)
        {
            if (perfilToolStripMenuItem1.Text == "Administrador:")
            {
                Inicio_Admin iniAdmin = new Inicio_Admin();
                MostrarFormulario(iniAdmin);
                MenuBackup.Visible = false;
                MenuReserva.Visible = false;
                MenuUsuario.Visible = false;
            }
            else if (perfilToolStripMenuItem1.Text == "Recepcionista:")
            {
                Inicio_Recep iniRecep = new Inicio_Recep();
                MostrarFormulario(iniRecep);
                MenuUsuario.Visible = false;
                MenuBackup.Visible = false;
                MenuServicios.Visible = false;
                MenuIngresoDePagos.Visible = false;
                MenuHabitacion.Visible = false;
            }
            else if (perfilToolStripMenuItem1.Text == "Super Usuario:")
            {
                Inicio_SuperUsuario iniSuper = new Inicio_SuperUsuario();
                MostrarFormulario(iniSuper);
                MenuServicios.Visible = false;
                MenuHabitacion.Visible = false;
                MenuReserva.Visible = false;
                MenuIngresoDePagos.Visible = false;
            }

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

        private void iconMenuInicio_Click(object sender, EventArgs e)
        {
            if (perfilToolStripMenuItem1.Text == "Administrador:")
            {
                AbrirFormulario(MenuBackup, new Inicio_Admin());
            }
            else if (perfilToolStripMenuItem1.Text == "Recepcionista:")
            {
                AbrirFormulario(MenuBackup, new Inicio_Recep());
            }
            else if (perfilToolStripMenuItem1.Text == "Super Usuario:")
            {
                AbrirFormulario(MenuBackup, new Inicio_SuperUsuario());
            }

        }

        private void MenuCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new AsignarCliente());
        }

        private void agregarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReserva, new Reservar());
        }

        private void listadoDeReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReserva, new ListadoDeReservas());
        }
    }
}
