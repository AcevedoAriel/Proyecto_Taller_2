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
            SqlConnection cnx = new SqlConnection("Server=. \\SQLEXPRESS;Integrated Security=True;Database=GESTION_HOTELERA;");
            cnx.Open();
            return cnx;
        }


        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Server=. \\SQLEXPRESS;Integrated Security=True;Database=GESTION_HOTELERA;");
                cn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); 
               
            }
        }

       
    }
}
