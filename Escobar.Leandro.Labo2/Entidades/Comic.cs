using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comic : Publicacion
    {

        private bool esColor;
        public override bool EsColor
        {
            get
            {
                return this.esColor;
            }
        }

        public Comic(string nombre, bool esColor, int stock, float importe):base(nombre,stock,importe)
        {
            this.esColor = esColor;
        }
    }
}
