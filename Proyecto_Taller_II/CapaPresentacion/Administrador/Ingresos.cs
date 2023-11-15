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

namespace Proyecto_Taller_II.CapaPresentacion.Administrador
{
    public partial class Ingresos : Form
    {
        public Ingresos()
        {
            InitializeComponent();
            RefreshPantalla();
        }

        private void Tbuscar_TextChanged(object sender, EventArgs e)
        {
            if (Tbuscar.Text != "")
            {

                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        string query = " select CONCAT(c.nombre, ' ' , c.apellido) as 'A Nombre de',  f.id_reserva as ReservaNro, p.descripcion as Metodo_Pago,  f.fecha_pago as Fecha_Pago, f.costo_habitacion as Costo_Habitacion, f.costo_servicios as Costo_Servicios, f.costo_total as Costo_Total " +
                    " from factura as f " +
                    "JOIN tipo_pago as p ON p.id_tipo_pago = f.id_tipo_pago " +
                    "JOIN cliente as c ON c.id_cliente = f.id_cliente " +
                          "where f.id_reserva LIKE ('" + Tbuscar.Text + "%') OR c.nombre LIKE ('" + Tbuscar.Text + "%') OR c.apellido LIKE ('" + Tbuscar.Text + "%') ";
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
                string query = " select CONCAT(c.nombre, ' ' , c.apellido) as A_Nombre_De,  f.id_reserva as ReservaNro, p.descripcion as Metodo_Pago,  f.fecha_pago as Fecha_Pago, f.costo_habitacion as Costo_Habitacion, f.costo_servicios as Costo_Servicios, f.costo_total as Costo_Total " +
                    " from factura as f " +
                    "JOIN tipo_pago as p ON p.id_tipo_pago = f.id_tipo_pago " +
                    "JOIN cliente as c ON c.id_cliente = f.id_cliente ";
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

        private void Ingresos_Load(object sender, EventArgs e)
        {

        }

        private void Tbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

