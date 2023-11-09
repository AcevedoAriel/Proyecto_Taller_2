using Proyecto_Taller_II.CapaPresentacion;
using Proyecto_Taller_II.CapaPresentacion.SuperUsuario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Proyecto_Taller_II.CapaDatos
{
    public class Usuario
    {
        public int id { get; set; }
        public int dni { get; set; }
        public string apellido { get; set; }

        public  string nombre { get; set; }

        public string nombreUsuario { get; set; }

        public string clave { get; set; }

        public string telefono { get; set; }

        public int usuario_perfil { get; set; }

        public string correo { get; set; }

        public DateTime fechaNAc { get; set; }

        public string sexo { get; set; }

        public int Estado { get; set; }

        public Usuario() { }
        public Usuario(int id, int dni, string ape, string nom, string nomUs, string clave,  string tel, int usPer, string correo, DateTime nac, string sexo, int estado ) 
        { 
            this.id = id;
            this.dni = dni;
            this.apellido = ape;
            this.nombre = nom;
            this.nombreUsuario = nomUs;
            this.clave = clave;
            this.telefono = tel;
            this.usuario_perfil = usPer;
            this.correo = correo;
            this.fechaNAc = nac;
            this.sexo = sexo;
            this.Estado = estado;

        }
    

    public static int AgregarUsuario(Usuario usuario)
    {
        int retorno = 0;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(usuario.clave);
            using (SqlConnection conexion = Conexion.ObtenerConexion())
        {
            string query = "insert into usuario(dni, apellido, nombre, nombreUsuario, clave, telefono, usuario_perfil, correo, fechaNAc, sexo, estado) values ( " + usuario.dni + " ,'" + usuario.apellido + "' , '" + usuario.nombre + "' , '" + usuario.nombreUsuario + "' , '" + hashedPassword + "' , '" + usuario.telefono + "', " + usuario.usuario_perfil + " ,'" + usuario.correo + "' , '" + usuario.fechaNAc + "' ,  '" + usuario.sexo + "', 'Activo' )";
            SqlCommand cmd = new SqlCommand(query, conexion);

            retorno = cmd.ExecuteNonQuery();
        }
        return retorno;
    }

        public static int ModificarUsuario(Usuario usuario)
        {
            string password = usuario.clave ;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "update usuario set dni = " + usuario.dni + " , apellido = '" + usuario.apellido + "' , nombre = '" + usuario.nombre + "' , nombreUsuario = '" + usuario.nombreUsuario + "', clave = '" + hashedPassword + "'  , telefono = '" + usuario.telefono + "' , usuario_perfil = " + usuario.usuario_perfil + " , correo = '" + usuario.correo + "' , fechaNAc = '" + usuario.fechaNAc + "' , sexo = '" + usuario.sexo + "' where id_usuario = " + usuario.id + " ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }


        public static int BajaUsuario(Usuario usuario)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "update usuario set estado = 'Inactivo' where id_usuario = " + usuario.id + " ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }

        public static int AltaUsuario(Usuario usuario)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "update usuario set estado = 'Activo' where id_usuario = " + usuario.id + " ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }

    }

}
   

