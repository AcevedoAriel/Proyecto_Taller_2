using ProyectoTaller2.Presentacion.Recepcionista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ProyectoTaller2.Presentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnHabitacion1_Click(object sender, EventArgs e)
        {
            Asignar_Reserva fm = new Asignar_Reserva();
            fm.BackColor = Color.LightSkyBlue;
            fm.ShowDialog(); //muestra el formulario sin poder manipular el form anterior
            this.Hide(); //oculta el formulario actual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Asignar_Reserva fm = new Asignar_Reserva();
            fm.BackColor = Color.LightSkyBlue;
            fm.ShowDialog(); //muestra el formulario sin poder manipular el form anterior
            this.Hide(); //oculta el formulario actual
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Asignar_Reserva fm = new Asignar_Reserva();
            fm.BackColor = Color.LightSkyBlue;
            fm.ShowDialog(); //muestra el formulario sin poder manipular el form anterior
            this.Hide(); //oculta el formulario actual
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Asignar_Reserva fm = new Asignar_Reserva();
            fm.BackColor = Color.LightSkyBlue;
            fm.ShowDialog(); //muestra el formulario sin poder manipular el form anterior
            this.Hide(); //oculta el formulario actual
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cobrar_Habitacion fm = new Cobrar_Habitacion();
            fm.BackColor = Color.LightSkyBlue;
            fm.ShowDialog(); //muestra el formulario sin poder manipular el form anterior
            this.Hide(); //oculta el formulario actual
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cobrar_Habitacion fm = new Cobrar_Habitacion();
            fm.BackColor = Color.LightSkyBlue;
            fm.ShowDialog(); //muestra el formulario sin poder manipular el form anterior
            this.Hide(); //oculta el formulario actual
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cobrar_Habitacion fm = new Cobrar_Habitacion();
            fm.BackColor = Color.LightSkyBlue;
            fm.ShowDialog(); //muestra el formulario sin poder manipular el form anterior
            this.Hide(); //oculta el formulario actual
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cobrar_Habitacion fm = new Cobrar_Habitacion();
            fm.BackColor = Color.LightSkyBlue;
            fm.ShowDialog(); //muestra el formulario sin poder manipular el form anterior
            this.Hide(); //oculta el formulario actual
        }

        private void btnFiltrarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dateTimeFechaDesde.Value;

            // Validar que la fecha seleccionada no sea una fecha pasada
            if (fechaDesde < DateTime.Now)
            {
                MessageBox.Show("No se puede Reservar una fecha Pasada");
                return; // Salir del evento sin realizar el filtrado
            }

            DateTime fechaHasta = dateTimeFechaHasta.Value;
            if (fechaHasta < fechaDesde)
            {
                MessageBox.Show("La fecha de retirno debe ser mayor que la Fecha de Ingreso");
                return; // Salir del evento sin realizar el filtrado
            }


        }

        private void txtNoHab_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoHab_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o la tecla de retroceso (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter presionado
                MessageBox.Show("Ingrese solamente numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
