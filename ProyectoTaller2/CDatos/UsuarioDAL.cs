﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.CDatos
{
    public class UsuarioDAL
    {
        public static int AgregarUsuario(Usuario usuario) 
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion()) 
            {
                string query = "insert into usuario(dni, apellido, nombre, nombreUsuario, clave, telefono, usuario_perfil, correo, fechaNAc, sexo) values ("+usuario.dni+" ,'"+usuario.apellido+ "' , '"+usuario.nombre+ "' , '"+usuario.nombreUsuario+ "' , '"+usuario.clave+ "' , '"+usuario.telefono+ "', "+usuario.usuario_perfil+" ,'"+usuario.correo+"' , '"+usuario.fechaNAc+ "' ,  '" + usuario.sexo+ "' )";
                SqlCommand cmd = new SqlCommand(query, conexion);

                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}