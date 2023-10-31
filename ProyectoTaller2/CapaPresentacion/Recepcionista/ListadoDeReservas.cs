using ProyectoTaller2.CapaDatos;
using ProyectoTaller2.CapaPresentacion.Recepcionista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoTaller2.CapaPresentacion.Recepcionista
{
    public partial class ListadoDeReservas : Form
    {
        public ListadoDeReservas()
        {
            InitializeComponent();
            BGuardar.Enabled = false;
            BEditar.Enabled = false;
            BEliminar.Enabled = false;
            BServicios.Enabled = false;

        }

        private void CamposTextChanged(object sender, EventArgs e)
        {
            // Verifica si todos los TextBoxes tienen datos no vacíos
            bool todosCamposLlenos = !string.IsNullOrWhiteSpace(TNombre.Text)
                                   && !string.IsNullOrWhiteSpace(TApellido.Text)
                                   && !string.IsNullOrWhiteSpace(TDNI.Text)
                                   && !string.IsNullOrWhiteSpace(DTIngreso.Text)
                                   && !string.IsNullOrWhiteSpace(TTelefono.Text)
                                   && !string.IsNullOrWhiteSpace(DTRetiro.Text)
                                   && !string.IsNullOrWhiteSpace(lblNroHabitacion.Text)
                                   && !string.IsNullOrWhiteSpace(NCantidad.Text);


            // Agrega más validaciones para otros TextBoxes si es necesario

            // Habilita o deshabilita el botón de guardar en función de la validación
            // BRegistrar.Enabled = todosCamposLlenos;
            // BGuardar.Enabled = todosCamposLlenos;
        }


        public void limpiarFormulario()
        {
            // Limpiar formulario
            TNombre.Clear();
            TApellido.Clear();

            TDNI.Clear();
            TTelefono.Clear();
            DTIngreso.ResetText();
            DTRetiro.ResetText();
            NCantidad.Value = 0;
        }

        private void BReservar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            if (txtNroHabitacion.Text != "" && TNombre.Text != "" && TApellido.Text != "" && TDNI.Text != "" && TTelefono.Text != "" && DTRetiro.Value != DateTimePicker.MinimumDateTime && DTIngreso.Value != DateTimePicker.MinimumDateTime)
            {
                resultado = MessageBox.Show("Seguro que desea insertar una nueva reserva?", "Confirmar Rerserva", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    Reserva reserva = new Reserva();
                    Cliente cliente = new Cliente();
                    reserva.ingreso = DTIngreso.Value;
                    reserva.retiro = DTRetiro.Value;
                    cliente.apellido = TApellido.Text;
                    cliente.nombre = TNombre.Text;
                    cliente.dni = Convert.ToInt16(TDNI.Text);
                    string nroHabitacion = txtNroHabitacion.Text;
                    cliente.telefono = TTelefono.Text;
                    reserva.cantPersonas = Convert.ToInt16(NCantidad.Value);
                    
                    



                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");

            }

        }
       
        private void BEditar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada != null)
            {
                BGuardar.Visible = true;
                BEliminar.Visible = false;

                 //Reemplaza "Columna1" con el nombre de tu columna  
                DTIngreso.Text = filaSeleccionada.Cells["FechaIngreso"].Value.ToString();
                DTRetiro.Text = filaSeleccionada.Cells["FechaRetiro"].Value.ToString();
                txtNroHabitacion.Text = filaSeleccionada.Cells["NroHabitacion"].Value.ToString();
                TNombre.Text = filaSeleccionada.Cells["NombreCliente"].Value.ToString();
                TApellido.Text = filaSeleccionada.Cells["ApellidoCliente"].Value.ToString();
                TDNI.Text = filaSeleccionada.Cells["DNICliente"].Value.ToString();
                TTelefono.Text = filaSeleccionada.Cells["TelCliente"].Value.ToString();
                NCantidad.Text = filaSeleccionada.Cells["CantPersonas"].Value.ToString();

            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Confirmar Eliminaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Reserva reserva = new Reserva();
                int result = Reserva.EliminarReserva(reserva);
                reserva.id  = 0;
                if (result != 0)
                {
                    MessageBox.Show("Se eliminó correctamente", "Reserva Eliminada", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No se pudo Eliminar", "Error");

                }
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (txtNroHabitacion.Text != "" && TNombre.Text != "" && TApellido.Text != "" && TDNI.Text != "" && TTelefono.Text != "" && DTRetiro.Value != DateTimePicker.MinimumDateTime && DTIngreso.Value != DateTimePicker.MinimumDateTime)
            {
                resultado = MessageBox.Show("Confirma los cambios hechos?", "Confirmar Edicion", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Reserva reserva = new Reserva();
                    Cliente cliente = new Cliente();
                    reserva.ingreso = DTIngreso.Value;
                    reserva.retiro = DTRetiro.Value;
                    cliente.apellido = TApellido.Text;
                    cliente.nombre = TNombre.Text;
                    cliente.dni = Convert.ToInt16(TDNI.Text);
                    string nroHabitacion = txtNroHabitacion.Text;
                    cliente.telefono = TTelefono.Text;
                    reserva.cantPersonas =Convert.ToInt16(NCantidad.Value);
                    int result = Reserva.ModificarReserva(reserva);
                    int result1 = Cliente.ModificarCliente(cliente);
                    if (result != 0 && result1 != 0)
                    {
                        MessageBox.Show("Se actualizo correctamente", "actualizado", MessageBoxButtons.OK);
                        limpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Actualizar", "Error");

                    }

                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");

            }
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
            BServicios.Enabled = dataGridReserva.SelectedRows.Count > 0;
            if (dataGridReserva.SelectedRows.Count > 0)
            {
                // Almacena la fila seleccionada en la variable
                filaSeleccionada = dataGridReserva.SelectedRows[0];
            }
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o la tecla de retroceso (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true; // Ignorar el carácter presionado
                MessageBox.Show("Ingrese solamente numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o la tecla de retroceso (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true; // Ignorar el carácter presionado
                MessageBox.Show("Ingrese solamente numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNroHabitacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o la tecla de retroceso (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true; // Ignorar el carácter presionado
                MessageBox.Show("Ingrese solamente numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (TBuscar.Text == "")
            {

                MessageBox.Show("El campo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Aqui va el codigo

            }
        }

        private void BServicios_Click(object sender, EventArgs e)
        {
            ServiciosAdicionales fm = new ServiciosAdicionales();
            fm.BackColor = Color.LightSkyBlue;
            fm.ShowDialog(); //muestra el formulario sin poder manipular el form anterior
            this.Hide(); //oculta el formulario actual
        }

        public void RefreshPantalla()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "select reserva.id_reserva as ID,  reserva.fecha_ingreso as FechaIngreso, reserva.fechaRetiro as FechaRetiro, habitacion.nro_habitacion as NroHabitacion, cliente.nombre as NombreCliente, cliente.apellido as ApellidoCliente, cliente.dni as DNICliente, cliente.telefono as TelCliente, reserva.cant_personas as CantPersonas, reserva.precio as PrecioTotal" +
                    " from reserva " +
                    "JOIN  cliente ON cliente.id_cliente = reserva.id_cliente " +
                    "JOIN  habitacion ON habitacion.id_habitacion = reserva.id_habitacion ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter dt = new SqlDataAdapter(query, conexion);
                DataSet dataset = new DataSet();
                dt.Fill(dataset, "Test_table");
                dataGridReserva.DataSource = dataset;
                dataGridReserva.DataMember = "Test_table";

            }
        }


    }
}
