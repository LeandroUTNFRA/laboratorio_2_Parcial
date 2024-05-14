using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {

        private string nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            ventas = new List<Publicacion>();
        }
        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            float gananciaTotal = 0;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{vendedor.nombre.ToUpper()}");
            sb.AppendLine("-------------------------------");

            foreach (Publicacion venta in vendedor.ventas)
            {
                sb.AppendLine($"Publicacion: {venta.ObtenerInformacionApp()}");
                gananciaTotal+= venta.Importe;
            }

            sb.AppendLine($"Ganacia Total: {gananciaTotal}");

            return sb.ToString();
        }
        public static bool operator  +(Vendedor vendedor, Publicacion publicacion)
        {
            if (publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock--;

                return true;
            }
            return false;
        }

        
    }
}
