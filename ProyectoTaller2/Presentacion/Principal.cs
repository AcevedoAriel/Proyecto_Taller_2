using FontAwesome.Sharp;
using ProyectoTaller2.Presentacion;
using ProyectoTaller2.Presentacion.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.Administrador
{
    public partial class FMPrincipal : Form
    {
        //alcamena el menu que se encuentra activo
        private static IconMenuItem? MenuActivo;
        //ormulario que esta activo en el panel
        private static Form? FormularioActivo;

        public FMPrincipal()
        {
            InitializeComponent();

        }

        private void Menu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
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

        private void SubMenuAgregarUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuUsuario, new UsuarioCRUD());
        }

        private void MenuReserva_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new GestionReserva());
        }

        private void MenuInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Inicio());
        }

        private void FMInicio_Load(object sender, EventArgs e)
        {
            FMIniciarSesion login = new();

            if (login.ShowDialog() != DialogResult.OK)
            {
                Close();
            }
        }


        /* public void MostrarFormularioInicio()
         {
             Inicio formInicio = new Inicio();
             formInicio.TopLevel = false;
             formInicio.Dock = DockStyle.Fill;
             Panel1.Controls.Clear();
             Panel1.Controls.Add(formInicio);
             formInicio.Show();
         }*/

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuHabitacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new CRUDHabitacion());
        }

        private void MenuServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new ServiciosCrud());
        }
    }
}
