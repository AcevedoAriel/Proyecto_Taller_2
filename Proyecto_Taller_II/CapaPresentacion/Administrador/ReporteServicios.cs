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
    public partial class ReporteServicios : Form
    {
        public ReporteServicios()
        {
            InitializeComponent();

        }

        private void ReporteServicios_Load(object sender, EventArgs e)
        {
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT s.cod_servicio as ID, s.nombre as nombre ,  count(*) as ServiciosCantidad " +
                    "from DetalleServicios ds " +
                    "JOIN servicios s ON ds.cod_servicio = s.cod_servicio " +
                    "GROUP BY s.cod_servicio , s.nombre " +
                    "ORDER BY ServiciosCantidad DESC ";

                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                chartServicios.Series[0].Points.Clear();
                //chartServicios.Series.Clear();
                while (reader.Read())
                {
                    string nombreServicio = reader["nombre"].ToString();
                    int cantidad = Convert.ToInt32(reader["ServiciosCantidad"]);

                    chartServicios.Series[0].Points.AddXY(nombreServicio, cantidad);
                }
            }
        }
    }
}
