using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.CapaPresentacion.SuperUsuario
{
    public partial class FMBackupRestore : Form
    {
        public FMBackupRestore()
        {
            InitializeComponent();
        }

        private void btnAbrirRespaldo_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Aqui va el codigo para abrir y leer el archivo.

                txtAbrirGuardar.Text = saveFileDialog1.FileName;
            }
        }

        private void btnAbrirRestaurar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Aqui va el codigo para Salvar.

                txtAbrirRestaurar.Text = saveFileDialog1.FileName;
            }
        }

        private void btnConectarBD_Click(object sender, EventArgs e)
        {

            if (CBBaseDeDatos.Text == "")
            {

                MessageBox.Show("El campo está vacío. Por favor Conecte el Motor de la BD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Aqui va el codigo

            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (txtAbrirGuardar.Text == "")
            {

                MessageBox.Show("El campo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Aqui va el codigo

            }
        }

        private void btnRestaruar_Click(object sender, EventArgs e)
        {
            if (txtAbrirRestaurar.Text == "")
            {

                MessageBox.Show("El campo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Aqui va el codigo

            }
        }
    }
}
