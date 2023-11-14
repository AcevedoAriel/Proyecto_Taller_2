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
    public partial class ReporteMedioPago : Form
    {
        public ReporteMedioPago()
        {
            InitializeComponent();
        }

        private void ReporteMedioPago_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT tp.descripcion AS 'Forma de Pago', SUM(f.costo_total) AS Recaudacion " +
                    "FROM factura f " +
                    "FULL OUTER JOIN tipo_pago tp ON f.id_tipo_pago = tp.id_tipo_pago " +
                    "GROUP BY tp.descripcion " ;

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                chartMedioPago.Series[0].Points.Clear();
                while (reader.Read())
                {
                    chartMedioPago.Series[0].Points.AddXY(reader["Forma de Pago"], reader["Recaudacion"]);
                }
            }
        }
    }
}
