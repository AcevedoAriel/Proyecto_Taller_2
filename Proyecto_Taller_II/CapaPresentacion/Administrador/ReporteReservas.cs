using Proyecto_Taller_II.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_II.CapaPresentacion.Administrador
{
    public partial class ReporteReservas : Form
    {
        public ReporteReservas()
        {
            InitializeComponent();
        }

        private void chartReserva_Click(object sender, EventArgs e)
        {

        }

        private void ReporteReservas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            int ano = Convert.ToInt32(txtAño.Text);
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT DATEPART(MONTH, fecha_ingreso) as MesIngreso, DATEPART(MONTH, fecha_retiro) as MesRetiro, COUNT (*) AS CantReservas " +
                    " from reserva " +
                    "where DATEPART(YEAR, fecha_ingreso) = @añoingresado AND DATEPART(YEAR, fecha_retiro) = @añoingresado " +
                    "GROUP BY DATEPART(MONTH, fecha_ingreso), DATEPART(MONTH, fecha_retiro) ";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@añoingresado", ano);
                SqlDataReader reader = cmd.ExecuteReader();

                ChartReservas.Series[0].Points.Clear();
                while (reader.Read())
                {
                    ChartReservas.Series[0].Points.AddXY(reader["MesIngreso"], reader["CantReservas"]);
                }
            }
        }


     }
    }
