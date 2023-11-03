using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.CapaDatos
{
    public class Factura
    {
        public int id { get; set; }

        public string tipo_pago { get; set; }

        public int id_cliente { get; set; }
        
        public int nro_cuotas { get; set; } 

        public DateTime fecha_pago { get; set; }    

        public double precio_hab { get; set; }  

        public double precio_ser { get; set; }

        public double total { get; set; }


        public Factura() { }

        public Factura(int id, string tipo_pago, int id_cliente, int nro_cuotas, DateTime fecha_pago, double precio_hab, double precio_ser, double total)
        {
            this.id = id;
            this.tipo_pago = tipo_pago;
            this.id_cliente = id_cliente;
            this.nro_cuotas = nro_cuotas;
            this.fecha_pago = fecha_pago;
            this.precio_hab = precio_hab;
            this.precio_ser = precio_ser;
            this.total = total;
        }






    }
}
