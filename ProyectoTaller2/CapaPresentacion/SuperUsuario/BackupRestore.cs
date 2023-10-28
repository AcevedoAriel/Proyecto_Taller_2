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
            saveFileDialog1.Filter = "SQL Backup files|*.bak";
            saveFileDialog1.FileName = $"{CBBaseDeDatos.Text}-{DateTime.Today.ToString("dd-MM-yyyy")}-{DateTime.Now.ToString("h.mm")}.bak";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
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
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        CBBaseDeDatos.Items.Add(fila[0].ToString());
                    }
                    
                    CBBaseDeDatos.SelectedIndex = 0;
                
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que exista la carpeta, en caso contrario la crea
                if (!Directory.Exists(@"C:\Users\ariel\OneDrive\Documentos\Backup"))
                {
                    Directory.CreateDirectory(@"C:\Users\ariel\OneDrive\Documentos\Backup");
                }

                System.Diagnostics.Process.Start("cmd", $"/k sqlcmd -S localhost\\SQLEXPRESS -E -Q \"BACKUP DATABASE [{CBBaseDeDatos.Text}] TO DISK='{txtAbrirGuardar.Text}'\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
