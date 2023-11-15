using Proyecto_Taller_II.CapaDatos;
using Proyecto_Taller_II.CapaPresentacion.Recepcionista;
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

namespace Proyecto_Taller_II.CapaPresentacion.Recepcionista
{
    public partial class ListadoDeReservas : Form
    {
        public ListadoDeReservas()
        {
            InitializeComponent();
           
            BEliminar.Enabled = false;
            
            RefreshPantalla();
        }

        


        
        

       

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Confirmar Eliminaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Reserva reserva = new Reserva();

                reserva.id = Convert.ToInt16(filaSeleccionada.Cells["ID"]);
                int result = Reserva.EliminarReserva(reserva);

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

       

        
        


        private void dataGridReserva_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si al menos una fila está seleccionada
           
            BEliminar.Enabled = dataGridReserva.SelectedRows.Count > 0;
            if (dataGridReserva.SelectedRows.Count > 0)
            {
                // Almacena la fila seleccionada en la variable
                filaSeleccionada = dataGridReserva.SelectedRows[0];
                
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

       

        public void RefreshPantalla()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "select reserva.id_reserva as ID,  reserva.fecha_ingreso as FechaIngreso, reserva.fecha_retiro as FechaRetiro, habitacion.nro_habitacion as NroHabitacion, reserva.cant_personas as CantPersonas, reserva.precio as PrecioTotal" +
                    " from reserva " +

                    "JOIN  habitacion ON habitacion.id_habitacion = reserva.id_habitacion ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter dt = new SqlDataAdapter(query, conexion);
                DataSet dataset = new DataSet();
                dt.Fill(dataset, "Test_table");
                dataGridReserva.DataSource = dataset;
                dataGridReserva.DataMember = "Test_table";

            }
        }

        private void TBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TBuscar.Text != "")
            {
              
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        string query = "select reserva.id_reserva as ID,  reserva.fecha_ingreso as FechaIngreso, reserva.fecha_retiro as FechaRetiro, habitacion.nro_habitacion as NroHabitacion, reserva.cant_personas as CantPersonas, reserva.precio as PrecioTotal" +
                    " from reserva " +
                    "JOIN  habitacion ON habitacion.id_habitacion = reserva.id_habitacion " +
                    "where habitacion.nro_habitacion LIKE ('" + TBuscar.Text + "%')";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        SqlDataAdapter dt = new SqlDataAdapter(query, conexion);
                        DataSet dataset = new DataSet();
                        dt.Fill(dataset, "Test_table");
                        dataGridReserva.DataSource = dataset;
                        dataGridReserva.DataMember = "Test_table";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                RefreshPantalla();
            }
        }

        private void TBuscar_KeyPress(object sender, KeyPressEventArgs e)
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
