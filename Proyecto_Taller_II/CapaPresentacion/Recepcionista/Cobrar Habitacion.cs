using Proyecto_Taller_II.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion.Recepcionista
{
    public partial class Cobrar_Habitacion : Form
    {
        public Cobrar_Habitacion(int id)
        {
            InitializeComponent();
            txtIDReserva.Text = id.ToString();
            Factura factura = new Factura();
            DataTable datos = factura.ObtenerDatos(id);
            DataRow fila = datos.Rows[0];
            txtHabitacion.Text = fila["nro_habitacion"].ToString();
            txtPrHab.Text = fila["precio"].ToString();
            if (!fila.IsNull("Total Servicios") && !fila.IsNull("Servicios")) 
            {
                txtPrSer.Text = fila["Total Servicios"].ToString();
                txtServicios.Text = fila["Servicios"].ToString();
                double resultado = Convert.ToDouble(fila["precio"]) + Convert.ToDouble(fila["Total Servicios"]);
                txtTotal.Text = resultado.ToString();
            }
            else
            {
                txtPrSer.Text = "0";
                txtServicios.Text = "Sin Servicio";
                txtTotal.Text = fila["precio"].ToString();
            }
            



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
            if (cboboxCliente.SelectedIndex != -1 && CBMetodoPago.SelectedIndex != -1)
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
                        MessageBox.Show("Debe completar todos lso Campos", "Error", MessageBoxButtons.OK);

            }




        }

        private void Cobrar_Habitacion_Load(object sender, EventArgs e)
        {

        }

        private void cboboxCliente_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cboboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
