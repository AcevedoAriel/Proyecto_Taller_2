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

namespace ProyectoTaller2.CapaPresentacion.Administrador
{
    public partial class Ingresos : Form
    {
        public Ingresos()
        {
            InitializeComponent();
            RefreshPantalla();
        }

        private void Ingresos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Tbuscar.Text == "")
            {

                MessageBox.Show("El campo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Aqui va el codigo

            }
        }

        private void Tbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar esta Factura de forma Permanente?", "Eliminar Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (filaSeleccionada != null)
                {
                    Factura factura = new Factura();
                    factura.id = Convert.ToInt32(filaSeleccionada.Cells["id_factura"].Value);
                    int result = Factura.EliminarFactura(factura);
                    if (result > 0)
                    {
                        MessageBox.Show("Factura Eliminada", "Eliminado", MessageBoxButtons.OK);
                        RefreshPantalla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar la acción", "Error", MessageBoxButtons.OK);

                    }
                }
            }
        }


        public void RefreshPantalla()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "select * from factura";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter dt = new SqlDataAdapter(query, conexion);
                DataSet dataset = new DataSet();
                dt.Fill(dataset, "Test_table");
                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "Test_table";

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                filaSeleccionada = dataGridView1.SelectedRows[0];
            }
        }
    }
}

