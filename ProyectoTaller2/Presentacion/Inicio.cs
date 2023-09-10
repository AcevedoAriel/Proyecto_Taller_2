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
    public partial class FMInicio : Form
    {
        //alcamena el menu que se encuentra activo
        private static IconMenuItem? MenuActivo;
        //ormulario que esta activo en el panel
        private static Form? FormularioActivo;

        public FMInicio()
        {
            InitializeComponent();
        }

        private void Menu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AgregarHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarHabitacion hab = new AgregarHabitacion();
            hab.ShowDialog();


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

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void SubMenuAgregarUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new RegistrarUsuario());
        }

        private void SubMenuConsultarUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new ConsularUsuario());
        }

        private void MenuReserva_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Reservas());
        }

        private void SubMenuAgregarHabitacion_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new AgregarHabitacion());
        }
    }
}
