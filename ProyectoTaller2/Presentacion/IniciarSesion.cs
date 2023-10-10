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
            Application.Exit();
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario, clave;
            usuario = txtUsuario.Text;
            clave = txtClave.Text;

            if (usuario == "Admin" && clave == "123")
            {
                //this.DialogResult = DialogResult.OK;
                FMPrincipal principal = new FMPrincipal();
                principal.Show();
                this.Hide();

            }
            else if (usuario == "Recep" && clave == "456")
            {
                //this.DialogResult = DialogResult.OK;
                FMPrincipal principal = new FMPrincipal();
                principal.Show();
                this.Hide();
            }
            else if (usuario == "SupUsr" && clave == "789")
            {
                //this.DialogResult = DialogResult.OK;
                FMPrincipal principal = new FMPrincipal();
                principal.Show();
                this.Hide();
            }
            else if(usuario == "" || clave == "" )
            {
                MessageBox.Show("Debes completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Error de Autenticación.", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
