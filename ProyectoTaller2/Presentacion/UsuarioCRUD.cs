using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.Administrador
{
    public partial class UsuarioCRUD : Form
    {
        public UsuarioCRUD()
        {
            InitializeComponent();
            BEditar.Enabled = false;
            BRegistrar.Enabled = false;
            BGuardar.Visible = false;

            TNombre.TextChanged += CamposTextChanged;
            TApellido.TextChanged += CamposTextChanged;
            TNombreUsuario.TextChanged += CamposTextChanged;
            TClave.TextChanged += CamposTextChanged;
            TCorreo.TextChanged += CamposTextChanged;
            TTelefono.TextChanged += CamposTextChanged;
            TSexo.TextChanged += CamposTextChanged;
            CBPerfil.TextChanged += CamposTextChanged;

        }

        private void CamposTextChanged(object sender, EventArgs e)
        {
            // Verifica si todos los TextBoxes tienen datos no vacíos
            bool todosCamposLlenos = !string.IsNullOrWhiteSpace(TNombre.Text)
                                   && !string.IsNullOrWhiteSpace(TApellido.Text)
                                   && !string.IsNullOrWhiteSpace(TNombreUsuario.Text)
                                   && !string.IsNullOrWhiteSpace(TClave.Text)
                                   && !string.IsNullOrWhiteSpace(TCorreo.Text)
                                   && !string.IsNullOrWhiteSpace(TTelefono.Text);
            // Agrega más validaciones para otros TextBoxes si es necesario

            // Habilita o deshabilita el botón de guardar en función de la validación
            BRegistrar.Enabled = todosCamposLlenos;
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
                lblMensaje.Text = "Contraseña válida";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                // Mostrar un mensaje de error
                lblMensaje.Text = "Ingrese al menos 6 caracteres";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
        private DataGridViewRow filaSeleccionada = null;
        private void dataGridUsuario_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si al menos una fila está seleccionada
            BEditar.Enabled = dataGridUsuario.SelectedRows.Count > 0;
            if (dataGridUsuario.SelectedRows.Count > 0)
            {
                // Almacena la fila seleccionada en la variable
                filaSeleccionada = dataGridUsuario.SelectedRows[0];
            }
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar)) // Comparas si la tecla presionada corresponde a un signo de puntuación
            {
                e.Handled = true; // Si coincide, se controla el evento, es decir, no se escribe el carácter
            }
            if (Char.IsSymbol(e.KeyChar)) // Comparas si la tecla presionada corresponde a un símbolo
            {
                e.Handled = true;
            }
            if (Char.IsLetter(e.KeyChar)) // Comparas si la tecla presionada corresponde a una letra
            {
                e.Handled = true;
            }
        }

        private void BRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Seguro que desea insertar un nuveo registro?", "Confirmar Insercion", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                string apellido = TApellido.Text;
                string nombre = TNombre.Text;
                string nombreUsuario = TNombreUsuario.Text;
                string clave = TClave.Text;
                long telefono = long.Parse(TTelefono.Text);
                string correo = TCorreo.Text;
                DateTime fecha = DTFechaNac.Value;

                // Agregar una nueva fila al datagrid con los valores
                dataGridUsuario.Rows.Add(CBPerfil.Text, apellido, nombre, nombreUsuario, clave, correo, TSexo.Text, fecha, telefono);
                MessageBox.Show("Se inserto correctamente", "Guardar", MessageBoxButtons.OK);

                limpiarFormulario();

            }
        }

        public void limpiarFormulario()
        {
            // Limpiar formulario
            TNombre.Clear();
            TApellido.Clear();
            TNombreUsuario.Clear();
            TClave.Clear();
            TTelefono.Clear();
            TCorreo.Clear();
            DTFechaNac.ResetText();
            //DTFechaNac = null;
            CBPerfil.DataSource = null;
            CBPerfil.Items.Clear();
            TSexo.DataSource = null;
            TSexo.Items.Clear();
        }

        private void BEditar_Click(object sender, EventArgs e)
        {

            if (filaSeleccionada != null)
            {
                BGuardar.Visible = true;
                BRegistrar.Visible = false;
                string nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
                string apellido = filaSeleccionada.Cells["apellido"].Value.ToString();
                string usuario = filaSeleccionada.Cells["usuario"].Value.ToString();
                string perfil = filaSeleccionada.Cells["Perfil"].Value.ToString();
                string clave = filaSeleccionada.Cells["clave"].Value.ToString();
                string sexo = filaSeleccionada.Cells["sexo"].Value.ToString();
                string email = filaSeleccionada.Cells["email"].Value.ToString();
                string nac = filaSeleccionada.Cells["fechaNac"].Value.ToString();
                string telefono = filaSeleccionada.Cells["telefono"].Value.ToString();
                // Reemplaza "Columna1" con el nombre de tu columna

                TNombre.Text = nombre;
                TApellido.Text = apellido;
                TNombreUsuario.Text = usuario;
                CBPerfil.Text = perfil;
                TClave.Text = clave;
                TSexo.Text = sexo;
                TCorreo.Text = email;
                DTFechaNac.Text = nac;
                TTelefono.Text = telefono;

            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Confirma los cambios hechos?", "Confirmar Edicion", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                string apellido = TApellido.Text;
                string nombre = TNombre.Text;
                string nombreUsuario = TNombreUsuario.Text;
                string clave = TClave.Text;
                long telefono = long.Parse(TTelefono.Text);
                string correo = TCorreo.Text;
                DateTime fecha = DTFechaNac.Value;

                // Agregar una nueva fila al datagrid con los valores
                if (filaSeleccionada != null)
                {
                    filaSeleccionada.Cells["nombre"].Value = nombre;
                    filaSeleccionada.Cells["apellido"].Value = apellido;
                    filaSeleccionada.Cells["usuario"].Value = nombreUsuario;
                    filaSeleccionada.Cells["Perfil"].Value = CBPerfil.Text;
                    filaSeleccionada.Cells["clave"].Value = clave;
                    filaSeleccionada.Cells["sexo"].Value = TSexo.Text;
                    filaSeleccionada.Cells["email"].Value = correo;
                    filaSeleccionada.Cells["fechaNac"].Value = fecha;
                    filaSeleccionada.Cells["telefono"].Value = telefono;
                }

                MessageBox.Show("Se actualizo correctamente", "actualizado", MessageBoxButtons.OK);
                limpiarFormulario();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Confirmar Eliminaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (filaSeleccionada != null) { 
                    dataGridUsuario.Rows.Remove(filaSeleccionada);
                }
            }
        }
    }
}
