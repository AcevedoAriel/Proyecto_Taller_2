using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.CDatos
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

        public string estado { get; set; }

        public Usuario() { }
        public Usuario(int id, int dni, string ape, string nom, string nomUs, string clave, string tel, int usPer, string correo, DateTime nac, string sexo, string estado ) 
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
            this.estado = estado;

        }
    }
}
