using Proyecto_Taller_II.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion.SuperUsuario
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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "SQL Backup Files|*.bak";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAbrirRestaurar.Text = openFileDialog1.FileName;
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
                // Verifica que exista la carpeta, en caso contrario la crea//
                if (!Directory.Exists(@"D:\Backup"))
                {
                    Directory.CreateDirectory(@"D:\Backup");
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
            string baseName = txtBaseRestaurar.Text;
            string rutaRestaurar = txtAbrirRestaurar.Text;

            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/k Sqlcmd -S localhost\\SQLEXPRESS -E -Q \"RESTORE DATABASE [{baseName}] FROM DISK = '{rutaRestaurar}'\"";
            System.Diagnostics.Process.Start(startInfo);
        }
    }
}
