using ProyectoTaller2.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ProyectoTaller2.CapaDatos
{
    public class Factura
    {
        public int id { get; set; }

        public int tipo_pago { get; set; }

        public int id_cliente { get; set; }

        public int id_reserva { get; set; }
        
        

        public DateTime fecha_pago { get; set; }    

        public double precio_hab { get; set; }  

        public double precio_ser { get; set; }

        public double total { get; set; }


        public Factura() { }

        public Factura(int id, int tipo_pago, int id_cliente,int id_reserva, DateTime fecha_pago, double precio_hab, double precio_ser, double total)
        {
            this.id = id;
            this.tipo_pago = tipo_pago;
            this.id_cliente = id_cliente;
            this.id_reserva = id_reserva;
            
            this.fecha_pago = fecha_pago;
            this.precio_hab = precio_hab;
            this.precio_ser = precio_ser;
            this.total = total;
        }


        public static int AgregarFactura(Factura factura)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "insert into factura(id_tipo_pago, id_cliente, id_reserva, fecha_pago, costo_habitacion, costo_servicios, costo_total) values ('" + factura.tipo_pago + "', "+ factura.id_cliente +", " + factura.id_reserva + ", '" + factura.fecha_pago + "', '" + factura.precio_hab + "', '"+ factura.precio_ser + "', '"+factura.total+"')";
                SqlCommand cmd = new SqlCommand(query, conexion);

                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }

        

        public static int EliminarFactura(Factura factura)         
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "delete from factura " +
                    "where id_factura = " + factura.id + "";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }



        public DataTable ObtenerDatos(int id) {
            DataTable datos = new DataTable();
            using (SqlConnection conexion = Conexion.ObtenerConexion()) 
            {
                string query = "select h.nro_habitacion, r.precio,  sum(s.precio) as 'Total Servicios', STRING_AGG(s.nombre, ',') as 'Servicios' " +
                    "from reserva as r " +
                    "full outer join DetalleServicios as ds on r.id_reserva = ds.id_reserva "+
                    "full outer join servicios as s on ds.cod_servicio = s.cod_servicio " +
                    "full outer join habitacion as h on r.id_habitacion = h.id_habitacion " +
                    "where r.id_reserva = "+id+" " +
                    "GROUP BY  h.nro_habitacion, r.precio ";
                SqlDataAdapter tabla = new SqlDataAdapter(query, conexion);
                tabla.Fill(datos);
            }
                return datos;

        }


        public static DataTable TraerMetodoPago()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "select id_tipo_pago, descripcion " +
                    " from tipo_pago ";
                SqlDataAdapter daTraer = new SqlDataAdapter(query, conexion);
                daTraer.Fill(dt);
            }
            return dt;
        }

    }
}
