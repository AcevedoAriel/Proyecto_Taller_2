using Proyecto_Taller_II.CapaDatos;
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

namespace Proyecto_Taller_II.CapaPresentacion.Recepcionista
{
    public partial class AsignarCliente : Form
    {
        public AsignarCliente()
        {
            InitializeComponent();
            RefreshPantalla();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (TDNI.Text != "" && TNombre.Text != "" && TApellido.Text != "" && TTelefono.Text != "")
            {
                resultado = MessageBox.Show("Seguro que desea registrar un nuevo cliente?", "Confirmar cliente", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    Cliente cliente = new Cliente();
                    cliente.apellido = TApellido.Text;
                    cliente.nombre = TNombre.Text;
                    cliente.dni = Convert.ToInt32(TDNI.Text);
                    cliente.telefono = TTelefono.Text;

                    int result = Cliente.AgregarCliente(cliente);

                    if (result != 0)
                    {
                        MessageBox.Show("Se inserto correctamente", "Guardar", MessageBoxButtons.OK);

                        RefreshPantalla();
                        LimpiarFormulario();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (TDNI.Text != "" && TNombre.Text != "" && TApellido.Text != "" && TTelefono.Text != "")
            {
                resultado = MessageBox.Show("Seguro que desea actualizar cliente?", "Confirmar cliente", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    Cliente cliente = new Cliente();
                    cliente.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    cliente.apellido = TApellido.Text;
                    cliente.nombre = TNombre.Text;
                    cliente.dni = Convert.ToInt32(TDNI.Text);
                    cliente.telefono = TTelefono.Text;

                    int result = Cliente.ModificarCliente(cliente);

                    if (result != 0)
                    {
                        MessageBox.Show("Se actualizo correctamente", "Guardar", MessageBoxButtons.OK);

                        RefreshPantalla();
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar", "Error", MessageBoxButtons.OK);

                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0] != null)
            {
                TDNI.Text = dataGridView1.SelectedRows[0].Cells["DNI"].Value.ToString();
                TNombre.Text = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                TApellido.Text = dataGridView1.SelectedRows[0].Cells["Apellido"].Value.ToString();
                TTelefono.Text = dataGridView1.SelectedRows[0].Cells["Telefono"].Value.ToString();
            }
        }

        public void RefreshPantalla()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "select id_cliente as ID, dni as DNI, nombre as Nombre, apellido as Apellido, telefono as Telefono  " +
                    " from cliente ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter dt = new SqlDataAdapter(query, conexion);
                DataSet dataset = new DataSet();
                dt.Fill(dataset, "Test_table");
                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "Test_table";

            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltrar.Text != "")
            {
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        string query = " select  dni as DNI, nombre as Nombre, apellido as Apellido, telefono as Telefono  " +
                    " from cliente " +
                          " WHERE  dni LIKE ('" + txtFiltrar.Text + "%') ";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        SqlDataAdapter dt = new SqlDataAdapter(query, conexion);
                        DataSet dataset = new DataSet();
                        dt.Fill(dataset, "Test_table");
                        dataGridView1.DataSource = dataset;
                        dataGridView1.DataMember = "Test_table";

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

        private void LimpiarFormulario()
        {
            TApellido.Text = string.Empty;
            TNombre.Text = string.Empty;
            TDNI.Text = string.Empty;
            TTelefono.Text = string.Empty;
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

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
