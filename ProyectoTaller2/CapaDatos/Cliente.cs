using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.CapaDatos
{
    public class Cliente
    {
        public int id { get; set; }

        public int dni { get; set; }

        public string apellido { get; set; }

        public string nombre { get; set; } 
        
        public string telefono { get; set; }    
        
        public Cliente() { }

        public Cliente(int id, int dni, string apellido, string nombre, string telefono) 
        {
            this.id = id;
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
            this.telefono = telefono;
        }

        public static int AgregarCliente(Cliente cliente)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "insert into cliente( dni, apellido, nombre, telefono) values (" +cliente.dni+ ", '" +cliente.apellido+ "', '" +cliente.nombre+ "', '"+cliente.telefono+"')";
                SqlCommand cmd = new SqlCommand(query, conexion);

                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int ModificarCliente(Cliente cliente)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "update cliente set dni = " + cliente.dni + " , apellido = '" + cliente.apellido + "' , nombre = '" + cliente.nombre + "' , telefono = '" + cliente.telefono +  "' where id_cliente = " + cliente.id + " ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }

        public static int EliminarCliente(Cliente cliente)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "delete from cliente" +
                    "where id_cliente = " + cliente.id + "";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }

        public static DataTable TraerClientes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "select id_cliente, dni, CONCAT(nombre, ' ' , apellido) as Cliente, telefono " + " from cliente ";
                SqlDataAdapter daTraer = new SqlDataAdapter(query, conexion);
                daTraer.Fill(dt);
            }
            return dt;
        }
    }
}
