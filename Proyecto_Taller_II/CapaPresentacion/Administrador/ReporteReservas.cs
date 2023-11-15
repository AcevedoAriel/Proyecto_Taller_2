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
            DateTime desde = dtFechaDesde.Value;
            DateTime hasta = dtFechaHasta.Value;

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT DATEPART(MONTH, fecha_ingreso) AS Nombre_Mes, COUNT (*) AS CantReservas " +
                    " from reserva " +
                    "where(fecha_ingreso BETWEEN @fechadesde AND @fechahasta) OR (fecha_retiro BETWEEN @fechadesde AND @fechahasta) OR (fecha_ingreso < @fechadesde AND fecha_retiro > @fechahasta) " +
                    "GROUP BY DATEPART(MONTH, fecha_ingreso) " +
                    "ORDER BY DATEPART(MONTH, fecha_ingreso) ASC ";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@fechadesde", desde);
                cmd.Parameters.AddWithValue("@fechahasta", hasta);
                SqlDataReader reader = cmd.ExecuteReader();

                ChartReservas.Series[0].Points.Clear();
                while (reader.Read())
                {
                    ChartReservas.Series[0].Points.AddXY(reader["Nombre_Mes"], reader["CantReservas"]);
                }
            }
        }

        private void dtFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtFechaHasta_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }
