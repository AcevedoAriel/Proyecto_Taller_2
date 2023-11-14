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
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT s.cod_servicio s.nombre as nombre ,  count(*) as ServiciosCantidad " +
                    "from DetalleServicios ds " +
                    "join servicios s ON ds.cod_servicio = s.cod_servicio " +
                    "GROUP BY s.cod_servicio, s.nombre as nombre " +
                    "ORDER BY ServiciosCantidad ";

                SqlCommand cmd = new SqlCommand(query, conexion);
                
                SqlDataReader reader = cmd.ExecuteReader();

                chartServicios.Series.Clear();
                while (reader.Read())
                {
                    chartServicios.Series[0].Points.AddXY(reader["nombre"], reader["ServiciosCantidad"]);
                }
            }
        }
    }
}
