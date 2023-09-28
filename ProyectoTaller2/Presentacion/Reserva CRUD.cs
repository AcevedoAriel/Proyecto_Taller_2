using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoTaller2.Presentacion.Administrador
{
    public partial class ReservaCRUD : Form
    {
        public ReservaCRUD()
        {
            InitializeComponent();
            BEditar.Enabled = false;
            BRegistrar.Enabled = false;
            BGuardar.Visible = false;
            BEliminar.Enabled = false;

        }

        private void CamposTextChanged(object sender, EventArgs e)
        {
            // Verifica si todos los TextBoxes tienen datos no vacíos
            bool todosCamposLlenos = !string.IsNullOrWhiteSpace(TNombre.Text)
                                   && !string.IsNullOrWhiteSpace(TApellido.Text)
                                   && !string.IsNullOrWhiteSpace(THabitacion.Text)
                                   && !string.IsNullOrWhiteSpace(TDNI.Text)
                                   && !string.IsNullOrWhiteSpace(DTIngreso.Text)
                                   && !string.IsNullOrWhiteSpace(TTelefono.Text)
                                   && !string.IsNullOrWhiteSpace(DTRetiro.Text)
                                   && !string.IsNullOrWhiteSpace(CBServicio.Text)
                                   && !string.IsNullOrWhiteSpace(NCantidad.Text);

            // Agrega más validaciones para otros TextBoxes si es necesario

            // Habilita o deshabilita el botón de guardar en función de la validación
            BRegistrar.Enabled = todosCamposLlenos;
            BGuardar.Enabled = todosCamposLlenos;
        }

        private void Reservas_Load(object sender, EventArgs e)
        {

        }

        public void limpiarFormulario()
        {
            // Limpiar formulario
            TNombre.Clear();
            TApellido.Clear();
            THabitacion.Clear();
            TDNI.Clear();
            TTelefono.Clear();
            DTIngreso.ResetText();
            DTRetiro.ResetText();
            CBServicio.DataSource = null;
            NCantidad.DataBindings.Clear();
        }

        private void BRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Seguro que desea insertar un nuveo registro?", "Confirmar Insercion", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                string apellido = TApellido.Text;
                string nombre = TNombre.Text;
                string habitacion = THabitacion.Text;
                string dni = TDNI.Text;
                long telefono = long.Parse(TTelefono.Text);
                string cant = NCantidad.Text;
                DateTime ingreso = DTIngreso.Value;
                DateTime retiro = DTRetiro.Value;

                // Agregar una nueva fila al datagrid con los valores
                dataGridReserva.Rows.Add(ingreso, retiro, habitacion, nombre, apellido, dni, telefono, cant);
                MessageBox.Show("Se inserto correctamente", "Guardar", MessageBoxButtons.OK);

                limpiarFormulario();

            }
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada != null)
            {
                BGuardar.Visible = true;
                BRegistrar.Visible = false;
                BEliminar.Visible = false;

                // Reemplaza "Columna1" con el nombre de tu columna  
                DTIngreso.Text = filaSeleccionada.Cells["ingreso"].Value.ToString();
                DTRetiro.Text = filaSeleccionada.Cells["retiro"].Value.ToString();
                TNombre.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                TApellido.Text = filaSeleccionada.Cells["apellido"].Value.ToString();
                THabitacion.Text = filaSeleccionada.Cells["habitacion"].Value.ToString();
                CBServicio.Text = filaSeleccionada.Cells["servicio"].Value.ToString();
                TDNI.Text = filaSeleccionada.Cells["dni"].Value.ToString();
                TTelefono.Text = filaSeleccionada.Cells["telefono"].Value.ToString();
                NCantidad.Text = filaSeleccionada.Cells["cantidad"].Value.ToString();

            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Confirmar Eliminaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (filaSeleccionada != null)
                {
                    dataGridReserva.Rows.Remove(filaSeleccionada);
                }
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Confirma los cambios hechos?", "Confirmar Edicion", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                DateTime ingreso = DTIngreso.Value;
                DateTime retiro = DTRetiro.Value;
                string apellido = TApellido.Text;
                string nombre = TNombre.Text;
                string habitacion = THabitacion.Text;
                string dni = TDNI.Text;
                long telefono = long.Parse(TTelefono.Text);
                string cantidad = NCantidad.Text;

                // Agregar una nueva fila al datagrid con los valores
                if (filaSeleccionada != null)
                {
                    BEliminar.Visible = true;
                    filaSeleccionada.Cells["ingreso"].Value = ingreso;
                    filaSeleccionada.Cells["retiro"].Value = retiro;
                    filaSeleccionada.Cells["nombre"].Value = nombre;
                    filaSeleccionada.Cells["apellido"].Value = apellido;
                    filaSeleccionada.Cells["habitacion"].Value = habitacion;
                    filaSeleccionada.Cells["dni"].Value = dni;
                    filaSeleccionada.Cells["cantidad"].Value = cantidad;
                    filaSeleccionada.Cells["telefono"].Value = telefono;
                }

                MessageBox.Show("Se actualizo correctamente", "actualizado", MessageBoxButtons.OK);
                limpiarFormulario();

            }
        }

        private void THabitacion_KeyPress(object sender, KeyPressEventArgs e)
        {

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


        private void dataGridReserva_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si al menos una fila está seleccionada
            BEditar.Enabled = dataGridReserva.SelectedRows.Count > 0;
            BEliminar.Enabled = dataGridReserva.SelectedRows.Count > 0;
            if (dataGridReserva.SelectedRows.Count > 0)
            {
                // Almacena la fila seleccionada en la variable
                filaSeleccionada = dataGridReserva.SelectedRows[0];
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
    }
}
