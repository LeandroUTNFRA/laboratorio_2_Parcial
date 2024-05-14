using System.Drawing;
using System.Text;

namespace Entidades
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        public abstract bool  EsColor { get;  }
        public virtual bool  HayStock 
        {
            get
            {
                return this.stock >0 && this.importe > 0;
            }
        
        }

        public float Importe { get; }

        public int Stock
        {
            get { return this.stock; }
            set
            {
                if (value>= 0)
                {
                    stock = value;
                }
            }
        }
        public Publicacion(string nombre)
        {
          
            this.nombre = nombre;
      
        }

        public Publicacion(string nombre, int stock):this(nombre)
        {
            Stock = stock;
        }
        public Publicacion( string nombre, int stock, float importe) :this(nombre,stock)
        {
            this.importe = importe;
        }

        public string ObtenerInformacionApp()
        {

            string esColor = EsColor ? "SI" : "NO";

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Importe: {this.importe}");
            sb.AppendLine($"Stock: {this.stock}");
            sb.AppendLine($"Es color: {esColor}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}