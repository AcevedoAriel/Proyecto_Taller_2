using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.CDatos
{
    public class UsuarioDB
    {
        public static int AgregarUsuario(Usuario usuario) 
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion()) 
            {
                string query = "insert into usuario(dni, apellido, nombre, nombreUsuario, clave, telefono, usuario_perfil, correo, fechaNAc, sexo, estado) values ( "+usuario.dni+" ,'"+usuario.apellido+ "' , '"+usuario.nombre+ "' , '"+usuario.nombreUsuario+ "' , '"+usuario.clave+ "' , '"+usuario.telefono+ "', "+usuario.usuario_perfil+" ,'"+usuario.correo+"' , '"+usuario.fechaNAc+ "' ,  '" + usuario.sexo+ "', 1 )";
                SqlCommand cmd = new SqlCommand(query, conexion);

                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int ModificarUsuario(Usuario usuario) { 
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion()) 
            {
                string query = "update usuario set dni = " + usuario.dni + " , apellido = '" + usuario.apellido + "' , nombre = '" + usuario.nombre + "' , nombreUsuario = '" + usuario.nombreUsuario + "' , telefono = '" + usuario.telefono + "' , usuario_perfil = " + usuario.usuario_perfil + " , correo = '" + usuario.correo + "' , fechaNAc = '" + usuario.fechaNAc + "' , sexo = '" + usuario.sexo + "' where id_usuario = "+usuario.id+" ";
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
                string query = "update usuario set estado = 0 where id_usuario = "+usuario.id+" ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }

    }
}
