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
            if (txtUsuario.Text == "Admin" && txtClave.Text == "123")
            {
                this.DialogResult = DialogResult.OK;
                
            }
            else if (txtUsuario.Text == "" && txtClave.Text == "")
            {
                labelError.Visible = true;
                this.DialogResult = DialogResult.None;
            }
            
         
        }
    }
}
