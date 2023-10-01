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

namespace ProyectoTaller2.Presentacion
{
    public partial class CRUDHabitacion : Form
    {
        public CRUDHabitacion()
        {
            InitializeComponent();
            btnEditar.Enabled = false;
            btnGuardarCambios.Visible = false;
            btnEliminar.Enabled = false;
            CBCategoriaH.SelectedIndex = 0;
            CBPiso.SelectedIndex = 0;
        }

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
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (TIDHabitacion.Text != "" && CBPiso.SelectedIndex != 0 && TNroHabitacion.Text != "" && TPrecio.Text != "" && CBCategoriaH.SelectedIndex != 0 && numericCantCamas.Value != 0)
            {
                resultado = MessageBox.Show("Seguro que desea insertar un nuveo registro?", "Confirmar Insercion", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    string IDHabitacion = TIDHabitacion.Text;
                    string Piso = CBPiso.Text;
                    string NroHabiacion = TNroHabitacion.Text;
                    string Precio = TPrecio.Text;
                    string Categoria = CBCategoriaH.Text;
                    decimal numeroDeCamas = numericCantCamas.Value;

                    // Agregar una nueva fila al datagrid con los valores
                    dataGridListaHabitacion.Rows.Add(IDHabitacion, Piso, NroHabiacion, Precio, Categoria, numeroDeCamas);
                    MessageBox.Show("Se inserto correctamente", "Guardar", MessageBoxButtons.OK);

                    limpiarFormulario();

                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        public void limpiarFormulario()
        {
            // Limpiar formulario
            TIDHabitacion.Clear();
            CBPiso.SelectedIndex = 0;
            TNroHabitacion.Clear();
            TPrecio.Clear();
            CBCategoriaH.SelectedIndex = 0;
            numericCantCamas.Value = 0;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (TIDHabitacion.Text != "" && CBPiso.SelectedIndex != 0 && TNroHabitacion.Text != "" && TPrecio.Text != "" && CBCategoriaH.SelectedIndex != 0 && numericCantCamas.Value != 0)
            {
                resultado = MessageBox.Show("Seguro que desea insertar un nuveo registro?", "Confirmar Insercion", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    string IDHabitacion = TIDHabitacion.Text;
                    string Piso = CBPiso.Text;
                    string NroHabiacion = TNroHabitacion.Text;
                    string Precio = TPrecio.Text;
                    string Categoria = CBCategoriaH.Text;
                    decimal numeroDeCamas = numericCantCamas.Value;

                    // Agregar una nueva fila al datagrid con los valores
                    if (filaSeleccionada != null)
                    {
                        btnEliminar.Visible = true;
                        filaSeleccionada.Cells["Colum1IDHabitacion"].Value = IDHabitacion;
                        filaSeleccionada.Cells["Colum2Piso"].Value = Piso;
                        filaSeleccionada.Cells["Colum3NroHabitacion"].Value = NroHabiacion;
                        filaSeleccionada.Cells["Colum4Categoria"].Value = Categoria;
                        filaSeleccionada.Cells["Colum5CantidadDeCamas"].Value = numeroDeCamas;
                        filaSeleccionada.Cells["Colum6Precio"].Value = Precio;
                    }

                    MessageBox.Show("Se actualizo correctamente", "actualizado", MessageBoxButtons.OK);
                    limpiarFormulario();
                    btnGuardarCambios.Visible = false;
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
            if (MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (filaSeleccionada != null)
                {
                    dataGridListaHabitacion.Rows.Remove(filaSeleccionada);
                }
            }
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
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada != null)
            {
                btnGuardarCambios.Visible = true;
                btnAgregarHabitacion.Visible = false;

                // Reemplaza "Columna1" con el nombre de tu columna  
                TIDHabitacion.Text = filaSeleccionada.Cells["Colum1IDHabitacion"].Value.ToString();
                CBPiso.Text = filaSeleccionada.Cells["Colum2Piso"].Value.ToString();
                TNroHabitacion.Text = filaSeleccionada.Cells["Colum3NroHabitacion"].Value.ToString();
                CBCategoriaH.Text = filaSeleccionada.Cells["Colum4Categoria"].Value.ToString();
                numericCantCamas.Text = filaSeleccionada.Cells["Colum5CantidadDeCamas"].Value.ToString();
                TPrecio.Text = filaSeleccionada.Cells["Colum6Precio"].Value.ToString();

            }
            btnAgregarHabitacion.Visible = true;
        }

    }
}
