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
    public partial class ServiciosCrud : Form
    {
        public ServiciosCrud()
        {
            InitializeComponent();
            btnEditar.Enabled = false;
            btnGuardarCambios.Visible = false;
            btnEliminar.Enabled = false;
        }

        private void txtCodServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o la tecla de retroceso (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter presionado
                MessageBox.Show("Ingrese solamente numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 95) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o la tecla de retroceso (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter presionado
                MessageBox.Show("Ingrese solamente numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (txtCodServicio.Text != "" && txtNombre.Text != "" && txtPrecio.Text != "")
            {
                resultado = MessageBox.Show("Seguro que desea insertar un nuevo Servicio?", "Confirmar Insercion", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    string codServicio = txtCodServicio.Text;
                    string nombre = txtNombre.Text;
                    string precio = txtPrecio.Text;

                    // Agregar una nueva fila al datagrid con los valores
                    dataGridServicios.Rows.Add(codServicio, nombre, precio);
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
            txtCodServicio.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (txtCodServicio.Text != "" && txtNombre.Text != "" && txtPrecio.Text != "")
            {
                resultado = MessageBox.Show("Confirma los cambios hechos?", "Confirmar Edicion", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    string codServicio = txtCodServicio.Text;
                    string nombre = txtNombre.Text;
                    string precio = txtPrecio.Text;

                    // Agregar una nueva fila al datagrid con los valores
                    if (filaSeleccionada != null)
                    {
                        btnEliminar.Visible = true;
                        filaSeleccionada.Cells["Cod_Servio"].Value = codServicio;
                        filaSeleccionada.Cells["Nombre"].Value = nombre;
                        filaSeleccionada.Cells["Precio"].Value = precio;
                    }

                    MessageBox.Show("Se actualizo correctamente", "actualizado", MessageBoxButtons.OK);
                    limpiarFormulario();
                    btnGuardarCambios.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        private void dataGridServicios_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si al menos una fila está seleccionada
            btnEditar.Enabled = dataGridServicios.SelectedRows.Count > 0;
            btnEliminar.Enabled = dataGridServicios.SelectedRows.Count > 0;
            if (dataGridServicios.SelectedRows.Count > 0)
            {
                // Almacena la fila seleccionada en la variable
                filaSeleccionada = dataGridServicios.SelectedRows[0];
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada != null)
            {
                btnGuardarCambios.Visible = true;
                btnAgregarServicio.Visible = false;
                btnEliminar.Visible = false;

                // Reemplaza "Columna1" con el nombre de tu columna  
                txtCodServicio.Text = filaSeleccionada.Cells["Cod_Servio"].Value.ToString(); ;
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString(); ;
                txtPrecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();

            }
            btnAgregarServicio.Visible = true;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (filaSeleccionada != null)
                {
                    dataGridServicios.Rows.Remove(filaSeleccionada);
                }
            }
        }
    }
}
