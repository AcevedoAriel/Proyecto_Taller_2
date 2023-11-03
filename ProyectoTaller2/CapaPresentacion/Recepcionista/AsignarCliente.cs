using ProyectoTaller2.CapaDatos;
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

namespace ProyectoTaller2.CapaPresentacion.Recepcionista
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
                    cliente.apellido = TApellido.Text;
                    cliente.nombre = TNombre.Text;
                    cliente.dni = Convert.ToInt16(TDNI.Text);
                    cliente.telefono = TTelefono.Text;

                    int result = Cliente.ModificarCliente(cliente);

                    if (result != 0)
                    {
                        MessageBox.Show("Se actualizo correctamente", "Guardar", MessageBoxButtons.OK);

                        RefreshPantalla();
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
                string query = "select  dni as DNI, nombre as Nombre, apellido as Apellido, telefono as Telefono  " +
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
    }
}
