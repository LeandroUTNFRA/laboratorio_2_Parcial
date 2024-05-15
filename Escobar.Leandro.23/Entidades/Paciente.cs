using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        private string diagnostico;

        public string Diagnostico { get; set; }
        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencia )
            : base(nombre, apellido, nacimiento, barrioResidencia)
        {
            
        }

        public override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Reside en: {this.barrioResidencia}");
            sb.AppendLine($"Diagnóstico: {Diagnostico}");

            return sb.ToString();
        }
    }
}
