﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.CapaPresentacion.Recepcionista
{
    public partial class ServiciosAdicionales : Form
    {
        public ServiciosAdicionales()
        {
            InitializeComponent();
        }

        private void Bagregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los Servicios fueron correctamente agregados" ,"Servicios Agregados", MessageBoxButtons.OK);
            this.Close();

        }
    }
}