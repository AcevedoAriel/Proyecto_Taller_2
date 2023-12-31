﻿using Proyecto_Taller_II.CapaDatos;
using Proyecto_Taller_II.CapaPresentacion.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion.Recepcionista
{
    public partial class Asignar_Reserva : Form
    {
        public Asignar_Reserva(int id_hab, int nro_habitacion, int cant_camas, string categoria, int piso, double precio)
        {
            InitializeComponent();
            txtIDhab.Text = id_hab.ToString();
            txtNroHabitacion.Text = nro_habitacion.ToString();
            txtCantCamas.Text = cant_camas.ToString();
            txtCategoria.Text = categoria;
            txtPiso.Text = piso.ToString();
            txtPrecio.Text = precio.ToString();




        }

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

        private void TDNI_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BReservar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            if (DTRetiro.Value != DateTimePicker.MinimumDateTime && DTIngreso.Value != DateTimePicker.MinimumDateTime && NCantidad.Value != 0)
            {
                resultado = MessageBox.Show("Confirma la Reserva Ingresada?", "Confirmar Reserva", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    Reserva reserva = new Reserva();

                    reserva.id_hab = Convert.ToInt32(txtIDhab.Text);
                    reserva.cantPersonas = Convert.ToInt16(NCantidad.Value);
                    reserva.ingreso = DTIngreso.Value;
                    reserva.retiro = DTRetiro.Value;
                    TimeSpan diferencia = DTRetiro.Value.Subtract(DTIngreso.Value);
                    reserva.precio = (diferencia.Days + 1 )* Convert.ToDouble(txtPrecio.Text);
                    int result = Reserva.AgregarREserva(reserva);
                    if (result != 0)
                    {
                       MessageBox.Show("Reserva guardada con exito", "Guardado", MessageBoxButtons.OK);
                        this.Close();
                        AgregarServicios serv = new AgregarServicios(result);
                        serv.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Guardar", "Error", MessageBoxButtons.OK);
                        this.Close();
                    }

                    
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");

            }
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Cancelar Reserva?", "Confirmar Reserva", MessageBoxButtons.OK);
            if (resultado == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void DTIngreso_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DTIngreso.Value.Date;

            // Validar si la fecha seleccionada es pasada
            if (fechaSeleccionada < DateTime.Today)
            {
                MessageBox.Show("No puedes seleccionar una fecha pasada.");
                DTIngreso.Value = DateTime.Today; // Establecer la fecha actual
            }
        }

        private void DTRetiro_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DTRetiro.Value.Date;

            // Validar si la fecha seleccionada es pasada
            if (fechaSeleccionada < DateTime.Today)
            {
                MessageBox.Show("No puedes seleccionar una fecha pasada.");
                DTRetiro.Value = DateTime.Today; // Establecer la fecha actual
            }
        }

        



    }
}