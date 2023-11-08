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
    public partial class Cobrar_Habitacion : Form
    {
        public Cobrar_Habitacion(int id)
        {
            InitializeComponent();
            CBMetodoPago.SelectedIndex = 0;
            Factura factura = new Factura();
            DataTable datos = factura.ObtenerDatos(id);
            DataRow fila = datos.Rows[0];
            txtHabitacion.Text = fila["nro_habitacion"].ToString() ;
            txtPrHab.Text = fila["precio"].ToString();
            txtPrSer.Text = fila["Total Servicios"].ToString();
            txtServicios.Text = fila["Servicios"].ToString();
            double resultado = Convert.ToDouble(fila["precio"]) + Convert.ToDouble(fila["Total Servicios"]);
            txtTotal.Text = resultado.ToString();



            cboboxCliente.DataSource = Cliente.TraerClientes();
            cboboxCliente.DisplayMember = "Cliente";
            cboboxCliente.ValueMember = "id_cliente";
        }

        private void btnCobrarHabitacion_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            if (CBMetodoPago.SelectedIndex != 0)
            {
                resultado = MessageBox.Show("Desea confirmar el Pago?", "Confirmar Pago", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {


                    MessageBox.Show("Pago Guardado con exito", "Guardado");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");

            }
        }

    }
}
