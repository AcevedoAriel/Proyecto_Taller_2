using System;
using System.Data.SqlClient;
using System.Windows;

namespace Proyecto_Taller_II.CapaDatos
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
