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
                string query = "insert into usuario(dni, apellido, nombre, nombreUsuario, clave, telefono, usuario_perfil, correo, fechaNAc, sexo, estado) values ("+usuario.dni+" ,'"+usuario.apellido+ "' , '"+usuario.nombre+ "' , '"+usuario.nombreUsuario+ "' , '"+usuario.clave+ "' , '"+usuario.telefono+ "', "+usuario.usuario_perfil+" ,'"+usuario.correo+"' , '"+usuario.fechaNAc+ "' ,  '" + usuario.sexo+ "',  '" + usuario.estado+ "'  )";
                SqlCommand cmd = new SqlCommand(query, conexion);

                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }


        public static List<Usuario> PresentarRegistro() 
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection conexion = Conexion.ObtenerConexion()) 
            {
                string query = "select * from usuario";
                SqlCommand cmd = new SqlCommand (query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    Usuario usuario = new Usuario();
                    usuario.dni = reader.GetInt32(0);
                    usuario.apellido = reader.GetString(1);
                    usuario.nombre = reader.GetString(2);
                    usuario.nombreUsuario = reader.GetString(3);
                    usuario.clave = reader.GetString(4);
                    usuario.telefono = reader.GetString(5);
                    usuario.usuario_perfil = reader.GetInt32(6);
                    usuario.correo = reader.GetString(7);
                    usuario.fechaNAc = reader.GetDateTime(8);
                    usuario.sexo = reader.GetString(9);
                    usuario.estado = reader.GetString(10);
                    lista.Add(usuario);
                }
                conexion.Close();
                return lista;
            }
        }
    }
}
