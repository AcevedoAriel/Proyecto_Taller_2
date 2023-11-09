using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_II.CapaDatos
{
    public class Servicio
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }

        public Servicio() { }
        public Servicio(int id, string nombre, double precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
        }

        public static int AgregarServicio(Servicio servicio)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "insert into servicios( nombre, precio) values ( '" + servicio.nombre + "' ,'" + servicio.precio + "' )";
                SqlCommand cmd = new SqlCommand(query, conexion);

                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int ModificarServicio(Servicio servicio)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "update servicios set nombre = '" + servicio.nombre + "', precio = '" + servicio.precio + "' where cod_servicio = " + servicio.id + " ";
                SqlCommand cmd = new SqlCommand(query, conexion);

                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int EliminarServicio(Servicio servicio)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "delete from servicios where cod_servicio = " + servicio.id + " ";
                SqlCommand cmd = new SqlCommand(query, conexion);

                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }

        public static DataTable TraerServicios()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "select cod_servicio, nombre, precio  from servicios ";
                SqlDataAdapter daTraer = new SqlDataAdapter(query, conexion);
                daTraer.Fill(dt);
            }
            return dt;
        }



        

    }
}
