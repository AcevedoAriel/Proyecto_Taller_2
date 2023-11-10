using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_II.CapaDatos
{
    public class Habitacion
    {
        public int id { get; set; }
        public int piso { get; set; }
        public int nro_habitacion { get; set; }
        public int estado { get; set; }
        public string precio { get; set; }
        public int categoria { get; set; }
        public int cantidad_camas { get; set; }

        public Habitacion() { }
        public Habitacion(int id, int piso, int nro_habitacion, int estado, string precio, int categoria, int cantidad_camas) 
        {

            this.id = id;
            this.piso = piso;
            this.nro_habitacion = nro_habitacion;
            this.estado = estado;
            this.precio = precio;
            this.categoria = categoria;
            this.cantidad_camas = cantidad_camas;
        }

        
   
        public static int AgregarHabitacion(Habitacion habitacion)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "insert into habitacion( piso, nro_habitacion, id_estado, precio, categoria, cantidad_camas) values ( " + habitacion.piso + " ," + habitacion.nro_habitacion + " , 2 , '" + habitacion.precio + "' , " + habitacion.categoria + " , " + habitacion.cantidad_camas + " )";
                SqlCommand cmd = new SqlCommand(query, conexion);

                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int ModificarHabitacion(Habitacion habitacion)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "update habitacion set piso = " + habitacion.piso + " , nro_habitacion = " + habitacion.nro_habitacion + " , precio = '" + habitacion.precio + "' , categoria = " + habitacion.categoria + ", cantidad_camas = '" + habitacion.cantidad_camas + "' where id_habitacion = " + habitacion.id + " ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }


        public static int BajaHabitacion(Habitacion habitacion)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "update habitacion set id_estado = 3  where id_habitacion = " + habitacion.id + " ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }

        public static int AltaHabitacion(Habitacion habitacion)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "update habitacion set id_estado = 2 where id_habitacion = " + habitacion.id + " ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }



        public static int LiberarHabitacion(Habitacion habitacion)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "update habitacion set id_estado = 2 where nro_habitacion = " + habitacion.nro_habitacion + " ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }

        public static int OcuparHabitacion(Habitacion habitacion)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "update habitacion set id_estado = 1 where id_habitacion = " + habitacion.id + " ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }

        public static int ActualizarEstadoHabitacion(int idHabitacion, string nuevoEstado)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "UPDATE habitacion SET estado = @estado WHERE id_habitacion = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@id", idHabitacion);

                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }

        public static Habitacion ObtenerHabitacionPorID(int id)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM habitacion WHERE id_habitacion = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Habitacion habitacion = new Habitacion();
                    habitacion.id = Convert.ToInt32(reader["id_habitacion"]);
                    habitacion.piso = Convert.ToInt32(reader["piso"]);
                    habitacion.nro_habitacion = Convert.ToInt32(reader["nro_habitacion"]);
                    habitacion.precio = Convert.ToString(reader["precio"]);
                    habitacion.categoria = Convert.ToInt32(reader["categoria"]);
                    habitacion.cantidad_camas = Convert.ToInt32(reader["cantidad_camas"]);
                    habitacion.estado = Convert.ToInt32(reader["estado"]);

                    return habitacion;
                }
            }

            return null; // Devuelve null si no se encuentra la habitación con el ID dado
        }




    }
}
