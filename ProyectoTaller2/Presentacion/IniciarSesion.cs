using ProyectoTaller2.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.Presentacion
{
    public partial class FMIniciarSesion : Form
    {
        public FMIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtClave.Text == "123" || txtUsuario.Text == "Recep" && txtClave.Text == "123" || txtUsuario.Text == "SupUsr" && txtClave.Text == "123")
            {
                this.DialogResult = DialogResult.OK;


            }
            else if (txtUsuario.Text == "" || txtClave.Text == "")
            {
                
                MessageBox.Show("El campo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }*/
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (txtUsuario.Text)
            {
                case "Admin":
                    if (txtClave.Text == "123")
                    {
                        // Funciones para el perfil de Administrador

                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Recep":
                    if (txtClave.Text == "123")
                    {
                        // Funciones para el perfil de Recepcionista
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "SupUsr":
                    if (txtClave.Text == "123")
                    {
                        // Funciones para el perfil de Superusuario
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("El usuario ingresado no tiene un perfil válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

    }
}
