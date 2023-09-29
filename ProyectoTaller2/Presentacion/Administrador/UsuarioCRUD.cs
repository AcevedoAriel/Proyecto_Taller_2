using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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
            //BRegistrar.Enabled = false;
            BGuardar.Visible = false;
            btnEliminar.Enabled = false;
        }

        private void CamposTextChanged(object sender, EventArgs e)
        {
            // Verifica si todos los TextBoxes tienen datos no vacíos
            bool todosCamposLlenos = !string.IsNullOrWhiteSpace(TNombre.Text)
                                   && !string.IsNullOrWhiteSpace(TApellido.Text)
                                   && !string.IsNullOrWhiteSpace(TNombreUsuario.Text)
                                   && !string.IsNullOrWhiteSpace(TClave.Text)
                                   && !string.IsNullOrWhiteSpace(TCorreo.Text)
                                   && !string.IsNullOrWhiteSpace(TTelefono.Text)
                                   && !string.IsNullOrWhiteSpace(CBPerfil.Text)
                                   && !string.IsNullOrWhiteSpace(TSexo.Text)
                                   && !string.IsNullOrWhiteSpace(DTFechaNac.Text);

            // Agrega más validaciones para otros TextBoxes si es necesario

            // Habilita o deshabilita el botón de guardar en función de la validación
            //BRegistrar.Enabled = todosCamposLlenos;
            //BGuardar.Enabled = todosCamposLlenos;
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
                lblMensajeClave.Text = "Contraseña válida";
                lblMensajeClave.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                // Mostrar un mensaje de error
                lblMensajeClave.Text = "Ingrese al menos 6 caracteres";
                lblMensajeClave.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void dataGridUsuario_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si al menos una fila está seleccionada
            BEditar.Enabled = dataGridUsuario.SelectedRows.Count > 0;
            btnEliminar.Enabled = dataGridUsuario.SelectedRows.Count > 0;
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
            if (TNombre.Text != "" && TApellido.Text != "" && TNombreUsuario.Text != "" && (TClave.Text != "" && TClave.Text.Length >= 6) && TTelefono.Text != "" && (TCorreo.Text != "" && ValidarCorreo(TCorreo.Text)) && DTFechaNac.Value != DateTimePicker.MinimumDateTime && CBPerfil.SelectedIndex != 0 && TSexo.SelectedIndex != 0)
            {
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
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
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
            CBPerfil.SelectedIndex = 0;
            TSexo.SelectedIndex = 0;
            lblMensajeClave.ResetText();
            lblMensajeCorreo.ResetText();
        }

        private void BEditar_Click(object sender, EventArgs e)
        {

            if (filaSeleccionada != null)
            {
                BGuardar.Visible = true;
                BRegistrar.Visible = false;
                btnEliminar.Visible = false;

                // Reemplaza "Columna1" con el nombre de tu columna  
                TNombre.Text = filaSeleccionada.Cells["nombre"].Value.ToString(); ;
                TApellido.Text = filaSeleccionada.Cells["apellido"].Value.ToString(); ;
                TNombreUsuario.Text = filaSeleccionada.Cells["usuario"].Value.ToString();
                CBPerfil.Text = filaSeleccionada.Cells["Perfil"].Value.ToString();
                TClave.Text = filaSeleccionada.Cells["clave"].Value.ToString();
                TSexo.Text = filaSeleccionada.Cells["sexo"].Value.ToString();
                TCorreo.Text = filaSeleccionada.Cells["email"].Value.ToString();
                DTFechaNac.Text = filaSeleccionada.Cells["fechaNac"].Value.ToString();
                TTelefono.Text = filaSeleccionada.Cells["telefono"].Value.ToString();

            }
            BRegistrar.Visible = true;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (TNombre.Text != "" && TApellido.Text != "" && TNombreUsuario.Text != "" && (TClave.Text != "" && TClave.Text.Length >= 6) && TTelefono.Text != "" && (TCorreo.Text != "" && ValidarCorreo(TCorreo.Text)) && DTFechaNac.Value != DateTimePicker.MinimumDateTime && CBPerfil.SelectedIndex != 0 && TSexo.SelectedIndex != 0)
            {
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
                        btnEliminar.Visible = true;
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
                    BGuardar.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (filaSeleccionada != null)
                {
                    dataGridUsuario.Rows.Remove(filaSeleccionada);
                }
            }
        }

        private void UsuarioCRUD_Load(object sender, EventArgs e)
        {
            CBPerfil.SelectedIndex = 0;
            TSexo.SelectedIndex = 0;
        }

        private void TCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string correo = TCorreo.Text; // Aquí debes obtener el correo del formulario

            if (ValidarCorreo(correo))
            {
                lblMensajeCorreo.Text = "Dirección de Correo válida";
                lblMensajeCorreo.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMensajeCorreo.Text = "Dirección de Correo no válida";
                lblMensajeCorreo.ForeColor = System.Drawing.Color.Red;
            }
        }

        static bool ValidarCorreo(string correo)
        {
            string patron = @"^[\w-]+(\.[\w-]+)*@([a-z0-9-]+\.)+[a-z]{2,7}$";
            //Regex regex = new Regex(patron, RegexOptions.IgnoreCase);
            return Regex.IsMatch(correo, patron);
        }

    }
}
