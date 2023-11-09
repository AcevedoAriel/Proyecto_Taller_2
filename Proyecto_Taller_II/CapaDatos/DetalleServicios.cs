using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_II.CapaDatos
{
    public class DetalleServicios
    {


        public int id { get; set; }
        public int id_reserva { get; set; }
        
        public int cod_servicio { get; set; }

        
        
        public DetalleServicios() { }

        public DetalleServicios(int id, int id_reserva, int cod_servicio)
        {
            this.id = id;
            this.id_reserva = id_reserva;
            this.cod_servicio = cod_servicio;
        }

        public static void CargarServicios(List<int> serv, int id)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                foreach (int elemento in serv)
                {
                    // Crea una consulta SQL para insertar el elemento en la tabla
                    string query = "insert into DetalleServicios  (cod_servicio, id_reserva) values (@cod_servicio , " + id+" )";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        // Agrega el valor del elemento al parámetro de la consulta
                        command.Parameters.AddWithValue("@cod_servicio", elemento);

                        // Ejecuta la consulta para insertar el elemento en la tabla
                        command.ExecuteNonQuery();
                    }
                }
            }

        }


    }
}
