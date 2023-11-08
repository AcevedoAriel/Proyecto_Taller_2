using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.CapaDatos
{
    public class Reserva
    {
        public int id { get; set; }

        public int cantPersonas { get; set; }
        public DateTime ingreso { get; set; }
        public DateTime retiro { get; set; }
        public int id_hab { get; set; }
        
        public double precio { get; set; }

        public Reserva(int id, int cantPersonas, DateTime ingreso, DateTime retiro, int id_hab, double precio) 
        {
            this.id = id;   
            this.cantPersonas = cantPersonas;
            this.ingreso = ingreso; 
            this.retiro = retiro;
            this.id_hab = id_hab;
            this.precio = precio;
        }
        public Reserva() {}

        public static int AgregarREserva(Reserva reserva)
        {
            int id_reserva = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "insert into reserva( cant_personas, fecha_ingreso, fecha_retiro, id_habitacion, precio) values ("+reserva.cantPersonas+", '"+reserva.ingreso+"', '"+reserva.retiro+"', "+reserva.id_hab+", '"+reserva.precio+"')" +
                    "SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(query, conexion);

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    id_reserva = Convert.ToInt32(result);
                }
            }
            return id_reserva;
        }

        public static int ModificarReserva(Reserva reserva)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "update reserva set cant_personas = "+reserva.cantPersonas+ " , fecha_ingreso = '"+reserva.ingreso+ "' , fecha_retiro = '" +reserva.retiro+ "' , id_habitacion =  '" +reserva.id_hab+ "' ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }

        public static int EliminarReserva(Reserva reserva)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "delete from reserva" +
                    "where id_reserva = " + reserva.id + "";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }

        


    }
}
