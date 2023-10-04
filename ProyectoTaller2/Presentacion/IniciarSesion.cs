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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtClave.Text == "123" || txtUsuario.Text == "Recep" && txtClave.Text == "123" || txtUsuario.Text == "SupUsr" && txtClave.Text == "123")
            {
                this.DialogResult = DialogResult.OK;

                //FMPrincipal frmPrincipal = new FMPrincipal();
                //frmPrincipal.AbrirFormulario(frmPrincipal);

                // Luego muestra el formulario que quieres dentro del panel
                //Inicio formInicio = new Inicio();
                //frmPrincipal.MostrarFormulario(formInicio);

            }
            else if (txtUsuario.Text == "" || txtClave.Text == "")
            {
                //labelError.Visible = true;
                MessageBox.Show("El campo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.DialogResult = DialogResult.None;
            }

        }
    }
}
