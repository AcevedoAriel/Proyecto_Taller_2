using ProyectoTaller2.CapaDatos;
using System.Data;
using System.Data.SqlClient;
namespace ProyectoTaller2.CapaPresentacion.Administrador
{
    public partial class CRUDHabitacion : Form
    {
        public CRUDHabitacion()
        {
            InitializeComponent();
            RefreshPantalla();
            btnEditar.Enabled = false;
            btnGuardarCambios.Visible = false;
            btnEliminar.Enabled = false;
            CBCategoriaH.SelectedIndex = 0;
            CBPiso.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
        }

        /*------------------------------------Validaciones en los campos del formulario Habitacion---------------------------*/
        private void THabitacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o la tecla de retroceso (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter presionado
                MessageBox.Show("Ingrese solamente numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void TNroHabitacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o la tecla de retroceso (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter presionado
                MessageBox.Show("Ingrese solamente numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void TPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == 8);
        }



        /*----------------------------------------Botones---------------------------------------------------------------------*/

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (CBEstado.SelectedIndex != 0 && CBPiso.SelectedIndex != 0 && TNroHabitacion.Text != "" && TPrecio.Text != "" && CBCategoriaH.SelectedIndex != 0 && numericCantCamas.Value != 0)
            {
                resultado = MessageBox.Show("Seguro que desea insertar un nuveo registro?", "Confirmar Insercion", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    Habitacion habitacion = new Habitacion();
                    habitacion.piso = Convert.ToInt32(CBPiso.SelectedIndex);
                    habitacion.nro_habitacion = Convert.ToInt32(TNroHabitacion.Text);
                    habitacion.estado = CBEstado.SelectedIndex;
                    habitacion.precio = Convert.ToDouble(TPrecio.Text);
                    habitacion.categoria = CBCategoriaH.SelectedIndex;
                    habitacion.cantidad_camas = Convert.ToInt32(numericCantCamas.Value);

                    int result = Habitacion.AgregarHabitacion(habitacion);
                    if (result != 0)
                    {
                        MessageBox.Show("Se inserto correctamente", "Guardar", MessageBoxButtons.OK);
                        limpiarFormulario();
                        RefreshPantalla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Insertar", "Error", MessageBoxButtons.OK);

                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (CBEstado.SelectedIndex != 0 && CBPiso.SelectedIndex != 0 && TNroHabitacion.Text != "" && TPrecio.Text != "" && CBCategoriaH.SelectedIndex != 0 && numericCantCamas.Value != 0)
            {
                resultado = MessageBox.Show("Seguro que desea actualizar?", "Confirmar Cambios", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    Habitacion habitacion = new Habitacion();
                    habitacion.id = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);
                    habitacion.piso = CBPiso.SelectedIndex;
                    habitacion.nro_habitacion = Convert.ToInt32(TNroHabitacion.Text);
                    habitacion.estado = CBEstado.SelectedIndex;
                    habitacion.precio = Convert.ToDouble(TPrecio.Text);
                    habitacion.categoria = CBCategoriaH.SelectedIndex;
                    habitacion.cantidad_camas = Convert.ToInt32(numericCantCamas.Value);

                    int result = Habitacion.ModificarHabitacion(habitacion);
                    // Agregar una nueva fila al datagrid con los valores
                    if (result > 0)
                    {
                        btnEliminar.Visible = true;
                        MessageBox.Show("Se actualizo correctamente", "Actualizado!", MessageBoxButtons.OK);
                        limpiarFormulario();
                        RefreshPantalla();
                        btnGuardarCambios.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Actualizar", "Error", MessageBoxButtons.OK);

                    }

                    //btnEliminar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cambiar estado a Mantenimiento?", "Confirmar Matenimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (filaSeleccionada != null)
                {
                    Habitacion habitacion = new Habitacion();
                    habitacion.id = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);
                    int result = Habitacion.BajaHabitacion(habitacion);
                    if (result > 0)
                    {
                        MessageBox.Show("La Habitacion fue puesta en Mantenimiento", "Completado", MessageBoxButtons.OK);
                        RefreshPantalla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar la acción", "Error", MessageBoxButtons.OK);

                    }
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada != null)
            {
                btnGuardarCambios.Visible = true;
                btnAgregarHabitacion.Visible = false;

                // Reemplaza "Columna1" con el nombre de tu columna  
                CBPiso.Text = filaSeleccionada.Cells["Piso"].Value.ToString();
                TNroHabitacion.Text = filaSeleccionada.Cells["NroHabitacion"].Value.ToString();
                CBCategoriaH.Text = filaSeleccionada.Cells["Categoria"].Value.ToString();
                numericCantCamas.Text = filaSeleccionada.Cells["NroCamas"].Value.ToString();
                TPrecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();
                CBEstado.Text = filaSeleccionada.Cells["Estado"].Value.ToString();

            }
            btnAgregarHabitacion.Visible = true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {

                MessageBox.Show("El campo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Aqui va el codigo

            }
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Habilitar esta Habitación?", "Confirmo Habilitación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (filaSeleccionada != null)
                {
                    Habitacion habitacion = new Habitacion();
                    habitacion.id = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);
                    int result = Habitacion.AltaHabitacion(habitacion);
                    if (result > 0)
                    {
                        MessageBox.Show("La Habitacion fue Habilitada", "Completado", MessageBoxButtons.OK);
                        RefreshPantalla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar la acción", "Error", MessageBoxButtons.OK);

                    }
                }
            }
        }
        /*---------------------------------------------------------------------------------------------------------------------*/

        public void limpiarFormulario()
        {
            // Limpiar formulario

            CBPiso.SelectedIndex = 0;
            TNroHabitacion.Clear();
            TPrecio.Clear();
            CBCategoriaH.SelectedIndex = 0;
            numericCantCamas.Value = 0;
            CBEstado.SelectedIndex = 0;
        }
        private void dataGridListaHabitacion_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si al menos una fila está seleccionada
            btnEditar.Enabled = dataGridListaHabitacion.SelectedRows.Count > 0;
            btnEliminar.Enabled = dataGridListaHabitacion.SelectedRows.Count > 0;
            if (dataGridListaHabitacion.SelectedRows.Count > 0)
            {
                // Almacena la fila seleccionada en la variable
                filaSeleccionada = dataGridListaHabitacion.SelectedRows[0];
                if (Convert.ToString(filaSeleccionada.Cells["Estado"].Value) == "Mantenimiento")
                {
                    filaSeleccionada.DefaultCellStyle.BackColor = Color.Red;
                    btnEliminar.Visible = false;
                    btnAlta.Visible = true;
                }
                else
                {
                    btnEliminar.Visible = true;
                    btnAlta.Visible = false;
                }
            }
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
                dataGridListaHabitacion.DataSource = dataset;
                dataGridListaHabitacion.DataMember = "Test_table";

            }
        }
        
    }
}
