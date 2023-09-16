using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.Administrador
{
    public partial class ConsularUsuario : Form
    {
        public ConsularUsuario()
        {
            InitializeComponent();
        }

        private void BEditar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {



        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                BEditar.Visible = false;
            }
            else
            {
                BEditar.Visible = true;

            }
        }

        private void ConsularUsuario_Load(object sender, EventArgs e)
        {
            //cargar datos estáticos
            dataGridView1.Rows.Add("01", "Administrador", "Pineyro", "Juan", "juanpineyro", "642312", "juan@gmail", "Hombre", "12/01/95", "6543234", "activo");
        }
    }
}
