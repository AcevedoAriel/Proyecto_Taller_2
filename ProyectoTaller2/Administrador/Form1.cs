﻿using System;
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
    public partial class Form_Adm : Form
    {
        public Form_Adm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agregarHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this); 
            form.Show();
        }
    }
}
