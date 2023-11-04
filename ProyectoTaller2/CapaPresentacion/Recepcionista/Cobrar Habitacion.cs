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
        public Cobrar_Habitacion()
        {
            InitializeComponent();
            CBMetodoPago.SelectedIndex = 0;
            txtCliente.Text = string.Empty;
            txtHabitacion.Text = string.Empty;
            txtPrHab.Text = string.Empty;
            txtPrSer.Text = string.Empty;
            txtServicios.Text = string.Empty;
            txtTotal.Text = string.Empty;

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
