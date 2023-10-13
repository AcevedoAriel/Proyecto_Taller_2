using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using ProyectoTaller2.CapaDatos;

namespace ProyectoTaller2.CapaPresentacion
{
    public partial class FMIniciarSesion : Form
    {
        public FMIniciarSesion()
        {
            InitializeComponent();
        }

        public void logear (string nombreUsuario,  string contrasena)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT nombreUsuario, usuario_perfil FROM usuario WHERE nombreUsuario = @nombreUsuario AND clave = @pas", conexion);
                    cmd.Parameters.AddWithValue("nombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("pas", contrasena);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if(dt.Rows.Count == 1)
                    {
                        this.Hide();
                        if (dt.Rows[0][1].ToString() == "1")
                        {
                            new FMPrincipal(dt.Rows[0][0].ToString()).Show();
                        }
                        else if(dt.Rows[0][1].ToString() == "2")
                        {
                            new FMPrincipal(dt.Rows[0][0].ToString()).Show();
                        }
                        else if ((dt.Rows[0][1].ToString() == "3"))
                        {
                            new FMPrincipal(dt.Rows[0][0].ToString()).Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o Contraseña incorrecta!");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            logear(txtUsuario.Text, txtClave.Text);
            //string usuario, clave;
            //usuario = txtUsuario.Text;
            //clave = txtClave.Text;

            //if (usuario == "Admin" && clave == "123")
            //{
            //    this.DialogResult = DialogResult.OK;
            //    FMPrincipal principal = new FMPrincipal();
            //    principal.Show();
            //    this.Hide();

            //}
            //else if (usuario == "Recep" && clave == "456")
            //{
            //    this.DialogResult = DialogResult.OK;
            //    FMPrincipal principal = new FMPrincipal();
            //    principal.Show();
            //    this.Hide();
            //}
            //else if (usuario == "SupUsr" && clave == "789")
            //{
            //    this.DialogResult = DialogResult.OK;
            //    FMPrincipal principal = new FMPrincipal();
            //    principal.Show();
            //    this.Hide();
            //}
            //else if(usuario == "" || clave == "" )
            //{
            //    MessageBox.Show("Debes completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    MessageBox.Show("Error de Autenticación.", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

    }
}
