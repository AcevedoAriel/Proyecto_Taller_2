﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.CapaPresentacion.Administrador
{
    public partial class Ingresos : Form
    {
        public Ingresos()
        {
            InitializeComponent();
        }

        private void Ingresos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Tbuscar.Text == "")
            {

                MessageBox.Show("El campo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Aqui va el codigo

            }
        }

        private void Tbuscar_TextChanged(object sender, EventArgs e)
        {

        }

     }
}
