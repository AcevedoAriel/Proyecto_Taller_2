using ProyectoTaller2.Administrador;
using System;
using System.Collections;
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

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtClave.Text == "123")
            {
                this.DialogResult = DialogResult.OK;
            }
            else if (txtUsuario.Text == "Recep" || txtClave.Text == "456")
            {
                this.DialogResult = DialogResult.OK;
                

            }else if (txtUsuario.Text == "SupUsr" || txtClave.Text == "789")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("El campo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*public int perfil ()
        {
            switch (txtUsuario.Text)
            {
                case "Admin":
                    if (txtClave.Text == "123")
                    {
                        // Funciones para el perfil de Administrador

                        return 1;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                    break;

                case "Recep":
                    if (txtClave.Text == "456")
                    {
                        // Funciones para el perfil de Recepcionista
                        return 2;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                    break;

                case "SupUsr":
                    if (txtClave.Text == "789")
                    {
                        // Funciones para el perfil de Superusuario
                        return 3;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                    break;

                default:
                    MessageBox.Show("El usuario ingresado no tiene un perfil válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                    break;

            }
        }*/

    }
}
