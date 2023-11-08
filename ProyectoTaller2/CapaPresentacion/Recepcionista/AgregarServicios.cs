using ProyectoTaller2.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.CapaPresentacion.Recepcionista
{
    public partial class AgregarServicios : Form
    {
        public AgregarServicios(int id)
        {
            InitializeComponent();
            CBServicios.DataSource = Servicio.TraerServicios();
            CBServicios.DisplayMember = "nombre";
            CBServicios.ValueMember = "cod_servicio";
            txtID.Text = id.ToString();
        }

        private void bntCobrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;


            resultado = MessageBox.Show("Confirma los Servicios Ingresados?", "Confirmar Servicios", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                int id = Convert.ToInt32(txtID.Text);
                DetalleServicios.CargarServicios(listServicios, id);
                Cobrar_Habitacion cobrar = new Cobrar_Habitacion();
                cobrar.Show();
                this.Close();
            }
        }

        private void btnServicio_Click_1(object sender, EventArgs e)
        {
            // Obtener el DataRowView del elemento seleccionado
            DataRowView selectedRow = (DataRowView)CBServicios.SelectedItem;

            // Acceder al valor de la columna "NombreServicio"
            string nombreServicio = selectedRow["nombre"].ToString();

            if (!listServicios.Items.Contains(nombreServicio))
            {
                // Agregar el nombre del servicio al ListBox
                listServicios.Items.Add(nombreServicio);
            }
        }

        private void lblServicio_Click(object sender, EventArgs e)
        {

        }

        private void CBServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

