using ProyectoTaller2.CapaPresentacion.Recepcionista;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProyectoTaller2.CapaDatos;

namespace ProyectoTaller2.CapaPresentacion
{
    public partial class Reservar : Form
    {
        public Reservar()
        {
            InitializeComponent();
            // Recupera los datos de la tabla SQL
            RefreshPantalla();

        }

        public void RefreshPantalla()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "select habitacion.id_habitacion as ID, habitacion.piso as Piso, habitacion.nro_habitacion as NroHabitacion, estado_habitacion.descripcion as Estado, habitacion.precio as Precio, categoriaHabitacion.descripcion as Categoria, habitacion.cantidad_camas as NroCamas  " +
                    " from habitacion " +
                    "JOIN estado_habitacion ON habitacion.id_estado = estado_habitacion.id_estado " +
                    "JOIN categoriaHabitacion ON habitacion.categoria = categoriaHabitacion.id_categoria";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter dt = new SqlDataAdapter(query, conexion);
                DataSet dataset = new DataSet();
                dt.Fill(dataset, "Test_table");
                dataGridHabitaciones.DataSource = dataset;
                dataGridHabitaciones.DataMember = "Test_table";

            }
        }


        private void btnReservar_Click(object sender, EventArgs e)
        {

            if (dataGridHabitaciones.SelectedRows.Count > 0)
            {
                int id_hab = Convert.ToInt32(dataGridHabitaciones.SelectedRows[0].Cells["ID"].Value);
                int nro_habitacion = Convert.ToInt32(dataGridHabitaciones.SelectedRows[0].Cells["NroHabitacion"].Value);
                int cantidad_camas = Convert.ToInt16(dataGridHabitaciones.SelectedRows[0].Cells["NroCamas"].Value);
                string categoria = Convert.ToString(dataGridHabitaciones.SelectedRows[0].Cells["Categoria"].Value);
                int piso = Convert.ToInt16(dataGridHabitaciones.SelectedRows[0].Cells["Piso"].Value);
                double precio = Convert.ToDouble(dataGridHabitaciones.SelectedRows[0].Cells["Precio"].Value);

                //Array[] habitacion = { nro_habitacion,  };
                Asignar_Reserva asignar = new Asignar_Reserva(id_hab, nro_habitacion, cantidad_camas, categoria, piso, precio);
                asignar.BackColor = Color.LightSkyBlue;
                asignar.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una habitación antes de realizar la reserva.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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

        private void CBpiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBpiso.SelectedIndex != 0)
            {
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        string query = " select habitacion.id_habitacion as ID, habitacion.piso as Piso, habitacion.nro_habitacion as NroHabitacion, estado_habitacion.descripcion as Estado, habitacion.precio as Precio, categoriaHabitacion.descripcion as Categoria, habitacion.cantidad_camas as NroCamas" + " from habitacion " +
                            "JOIN estado_habitacion ON habitacion.id_estado = estado_habitacion.id_estado " +
                    "JOIN categoriaHabitacion ON habitacion.categoria = categoriaHabitacion.id_categoria" +
                          " WHERE  habitacion.piso LIKE ('" + CBpiso.SelectedIndex + "%') ";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        SqlDataAdapter dt = new SqlDataAdapter(query, conexion);
                        DataSet dataset = new DataSet();
                        dt.Fill(dataset, "Test_table");
                        dataGridHabitaciones.DataSource = dataset;
                        dataGridHabitaciones.DataMember = "Test_table";

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

        private void CBcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBcategoria.SelectedIndex != 0)
            {
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        string query = " select habitacion.id_habitacion as ID, habitacion.piso as Piso, habitacion.nro_habitacion as NroHabitacion, estado_habitacion.descripcion as Estado, habitacion.precio as Precio, categoriaHabitacion.descripcion as Categoria, habitacion.cantidad_camas as NroCamas" + " from habitacion " +
                            "JOIN estado_habitacion ON habitacion.id_estado = estado_habitacion.id_estado " +
                    "JOIN categoriaHabitacion ON habitacion.categoria = categoriaHabitacion.id_categoria" +
                          " WHERE  habitacion.categoria LIKE ('" + CBcategoria.SelectedIndex + "%') ";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        SqlDataAdapter dt = new SqlDataAdapter(query, conexion);
                        DataSet dataset = new DataSet();
                        dt.Fill(dataset, "Test_table");
                        dataGridHabitaciones.DataSource = dataset;
                        dataGridHabitaciones.DataMember = "Test_table";

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

        private void dateTimeFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaDesde = dateTimeFechaDesde.Value;

            // Validar que la fecha seleccionada no sea una fecha pasada
            if (fechaDesde < DateTime.Today)
            {
                MessageBox.Show("No se puede Reservar una fecha Pasada");
                return; // Salir del evento sin realizar el filtrado
            }
        }

        private void dateTimeFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaDesde = dateTimeFechaDesde.Value;
            DateTime fechaHasta = dateTimeFechaHasta.Value;
            if (fechaHasta < fechaDesde)
            {
                MessageBox.Show("La fecha de retiro debe ser mayor que la Fecha de Ingreso");
                return; // Salir del evento sin realizar el filtrado
            }
        }

       

    }
}
