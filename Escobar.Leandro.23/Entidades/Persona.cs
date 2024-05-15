using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioResidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public string NombreCompleto 
        {
            get
            {
                return $"{this.apellido},{this.nombre}";
            }
        }

        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(this.nacimiento.Ticks).Year;
            }
        }

        public Persona(string nombre,  string apellido, DateTime nacimiento)
        {
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
        }
        public Persona(string nombre, string apellido, DateTime nacimiento,string barrioResidencia):this(nombre,apellido,nacimiento)
        {
            this.barrioResidencia= barrioResidencia;
        }

        public static string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{p.apellido} {p.nombre}");
            sb.AppendLine($"BARRIO RESIDENCIA: {p.barrioResidencia}");
            sb.AppendLine($"EDAD: {p.Edad}");

            return sb.ToString();
        }

        public abstract string FichaExtra();

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}