using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.Administrador
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        //Validaciones en los campos
        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 95) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 95) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (TNombreUsuario.Text.Length >= 8)
            {
                e.Handled = true; // evita que se siga escribiendo
            }
        }

        private void TClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtener la contraseña ingresada
            string contraseña = TClave.Text + e.KeyChar;

            // Verificar si tiene al menos 6 caracteres
            if (contraseña.Length >= 6)
            {
                // Mostrar un mensaje de éxito
                LMensaje.Text = "Contraseña válida";
                LMensaje.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                // Mostrar un mensaje de error
                LMensaje.Text = "Contraseña inválida";
                LMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void BRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BRegistrar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (TNombre.Text != "" && TApellido.Text != "" && TNombreUsuario.Text != "" && TClave.Text != "" && TCorreo.Text != "" && CBPerfil.Text != "" && TSexo.Text != "" && DTFechaNac.Text != "" && TTelefono.Text != "")
            {
                resultado = MessageBox.Show("Seguro que desea insertar un nuveo registro?", "Confirmar Insercion", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    DateTime fecha = DTFechaNac.Value;
                    string apellido = TApellido.Text;
                    string nombre = TNombre.Text;
                    string clave = TClave.Text;
                    string correo = TCorreo.Text;
                    string nombreUsuario = TNombreUsuario.Text;
                    string telefono = TTelefono.Text;

                    // Agregar una nueva fila al datagrid con los valores
                    ConsularUsuario consularUsuario = new ConsularUsuario();
                    //FALTA SOLUCIONAR
                    //consultarUsuario.dataGridView1.Rows.Add(apellido, nombre, fecha, this.Tsexo(), saldo, imagen, TFoto.Text);
                    MessageBox.Show("Se inserto correctamente", "Guardar", MessageBoxButtons.OK);
                }
                // Limpiar formulario
                /*TNombre.Clear();
                TApellido.Clear();
                TSaldo.Clear();
                TFoto.Clear();
                PBHombre.Image = null;
                PBMujer.Image = null;*/
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }
    }
}
