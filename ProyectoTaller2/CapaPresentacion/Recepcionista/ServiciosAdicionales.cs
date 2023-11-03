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
    public partial class ServiciosAdicionales : Form

    {
        List<int> servcAgregado;
        public ServiciosAdicionales()
        {
            InitializeComponent();
            servcAgregado = new List<int>();
        }

        private List<int> Bagregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los Servicios fueron correctamente agregados", "Servicios Agregados", MessageBoxButtons.OK);
            this.Close();
            return servcAgregado;

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                servcAgregado.Add(0);
            }
            else
            {
                servcAgregado.Remove(0);
            }
        }

        private List<int> ServiciosAdicionales_FormClosing(object sender, FormClosingEventArgs e)
        {
            return servcAgregado;
        }
    }
}
