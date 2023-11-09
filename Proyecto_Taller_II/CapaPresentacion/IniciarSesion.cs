using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using Proyecto_Taller_II.CapaDatos;
using BCrypt.Net;
using System.Windows.Forms;
using System;

namespace Proyecto_Taller_II.CapaPresentacion
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
                    //SqlCommand cmd = new SqlCommand("SELECT nombreUsuario, usuario_perfil FROM usuario WHERE nombreUsuario = @nombreUsuario AND clave = @pas", conexion);
                    SqlCommand cmd = new SqlCommand("SELECT u.nombreUsuario, p.nombre, u.clave " +
                                            "FROM usuario u " +
                                            "JOIN perfil p ON u.usuario_perfil = p.cod_perfil " +
                                            "WHERE u.nombreUsuario = @nombreUsuario", conexion);
                    cmd.Parameters.AddWithValue("nombreUsuario", nombreUsuario);
                
                    //cmd.Parameters.AddWithValue("clave", contrasena);
                    
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    bool isPasswordCorrect = false;
                    if (dt.Rows.Count == 1)
                    {
                        string hash = dt.Rows[0][2].ToString();
                        isPasswordCorrect = BCrypt.Net.BCrypt.Verify(contrasena, hash);
                    }

                    if (dt.Rows.Count == 1 && isPasswordCorrect)
                    {
                        this.Hide();
                        if (dt.Rows[0][1].ToString() == "Super Usuario")
                        {
                            new FMPrincipal(dt.Rows[0][1].ToString(), dt.Rows[0][0].ToString()).Show();
                            
                        }
                        else if(dt.Rows[0][1].ToString() == "Administrador")
                        {
                            new FMPrincipal(dt.Rows[0][1].ToString(), dt.Rows[0][0].ToString()).Show();
                        }
                        else if ((dt.Rows[0][1].ToString() == "Recepcionista"))
                        {
                            new FMPrincipal(dt.Rows[0][1].ToString(), dt.Rows[0][0].ToString()).Show();
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
            if(txtUsuario.Text != "" && txtClave.Text != "")
            {
                logear(txtUsuario.Text, txtClave.Text);
            }
            else
            {
                MessageBox.Show("Debes completar todo los campos!!");
            }
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
