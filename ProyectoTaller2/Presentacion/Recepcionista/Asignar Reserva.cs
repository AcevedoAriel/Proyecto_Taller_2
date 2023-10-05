using ProyectoTaller2.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.Presentacion.Recepcionista
{
    public partial class Asignar_Reserva : Form
    {
        public Asignar_Reserva()
        {
            InitializeComponent();
            CBServicio.SelectedIndex = 0;
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 95) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 95) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar)) // Comparas si la tecla presionada corresponde a un signo de puntuación
            {
                e.Handled = true; // Si coincide, se controla el evento, es decir, no se escribe el carácter
            }
            if (Char.IsSymbol(e.KeyChar)) // Comparas si la tecla presionada corresponde a un símbolo
            {
                e.Handled = true;
            }
            if (Char.IsLetter(e.KeyChar)) // Comparas si la tecla presionada corresponde a una letra
            {
                e.Handled = true;
            }
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar)) // Comparas si la tecla presionada corresponde a un signo de puntuación
            {
                e.Handled = true; // Si coincide, se controla el evento, es decir, no se escribe el carácter
            }
            if (Char.IsSymbol(e.KeyChar)) // Comparas si la tecla presionada corresponde a un símbolo
            {
                e.Handled = true;
            }
            if (Char.IsLetter(e.KeyChar)) // Comparas si la tecla presionada corresponde a una letra
            {
                e.Handled = true;
            }
        }

        private void BReservar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            if (TNombre.Text != "" && TApellido.Text != "" && TDNI.Text != "" && TTelefono.Text != "" && DTRetiro.Value != DateTimePicker.MinimumDateTime && DTIngreso.Value != DateTimePicker.MinimumDateTime && CBServicio.SelectedIndex != 0 && NCantidad.Value != 0)
            {
                resultado = MessageBox.Show("Confirma la Reserva Ingresada?", "Confirmar Reserva", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    string apellido = TApellido.Text;
                    string nombre = TNombre.Text;
                    string dni = TDNI.Text;
                    long telefono = long.Parse(TTelefono.Text);
                    NumericUpDown cantPersona = new NumericUpDown();
                    DateTime ingreso = DTIngreso.Value;
                    DateTime retiro = DTRetiro.Value;
                    MessageBox.Show("Reserva guardada con exito", "Guardado");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");

            }
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DTIngreso_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DTIngreso.Value.Date;

            // Validar si la fecha seleccionada es pasada
            if (fechaSeleccionada < DateTime.Today)
            {
                MessageBox.Show("No puedes seleccionar una fecha pasada.");
                DTIngreso.Value = DateTime.Today; // Establecer la fecha actual
            }
        }

        private void DTRetiro_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DTRetiro.Value.Date;

            // Validar si la fecha seleccionada es pasada
            if (fechaSeleccionada < DateTime.Today)
            {
                MessageBox.Show("No puedes seleccionar una fecha pasada.");
                DTRetiro.Value = DateTime.Today; // Establecer la fecha actual
            }
        }
    }
}
