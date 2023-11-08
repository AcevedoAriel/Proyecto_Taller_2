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
            txtIDReserva.Text = id.ToString();
            Factura factura = new Factura();
            DataTable datos = factura.ObtenerDatos(id);
            DataRow fila = datos.Rows[0];
            txtHabitacion.Text = fila["nro_habitacion"].ToString();
            txtPrHab.Text = fila["precio"].ToString();
            txtPrSer.Text = fila["Total Servicios"].ToString();
            txtServicios.Text = fila["Servicios"].ToString();
            double resultado = Convert.ToDouble(fila["precio"]) + Convert.ToDouble(fila["Total Servicios"]);
            txtTotal.Text = resultado.ToString();



            cboboxCliente.DataSource = Cliente.TraerClientes();
            cboboxCliente.DisplayMember = "Cliente";
            cboboxCliente.ValueMember = "id_cliente";

            CBMetodoPago.DataSource = Factura.TraerMetodoPago();
            CBMetodoPago.DisplayMember = "descripcion";
            CBMetodoPago.ValueMember = "id_tipo_pago";
        }

        private void btnCobrarHabitacion_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            if (CBMetodoPago.SelectedIndex != 0)
            {
                resultado = MessageBox.Show("Desea confirmar el Pago?", "Confirmar Pago", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    Factura factura = new Factura();
                    factura.fecha_pago = DateTime.Today;
                    factura.precio_hab = Convert.ToDouble(txtPrHab.Text);
                    factura.precio_ser = Convert.ToDouble(txtPrSer.Text);
                    factura.tipo_pago = CBMetodoPago.SelectedIndex;
                    factura.id_reserva = Convert.ToInt32(txtIDReserva.Text);
                    factura.id_cliente = cboboxCliente.SelectedIndex;
                    factura.total = Convert.ToDouble(txtTotal.Text);
                    int result = Factura.AgregarFactura(factura);
                    if (result != 0)
                    {
                        MessageBox.Show("Pago Guardado con exito", "Guardado", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Guardar", "Error", MessageBoxButtons.OK);
                    }

                   
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK);

            }
        }

        private void CBMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
