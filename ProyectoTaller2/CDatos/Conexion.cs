using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoTaller2.CDatos
{
    internal class Conexion
    {
        SqlConnection cn;

        public static SqlConnection ObtenerConexion() 
        {
            SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-45C6NCU\\SQLEXPRESS;Persist Security Info=False;Initial Catalog=GESTION_HOTELERA;User ID=sa;Password=12345678");
            cnx.Open();
            return cnx;
        }

       
    }
}
