using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonalMedico: Persona
    {
        private List<Consulta> consultas;
        private bool esResidenete;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento,bool esResidente) : base(nombre, apellido, nacimiento)
        {
            this.esResidenete = esResidente;
            consultas = new List<Consulta>();
        }
        public override string FichaExtra()
        {
            string esResi = this.esResidenete ? "SI" : "NO";

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"¿Finalizó residencia? {esResi}");
            sb.AppendLine("ATENCIONES:");

            foreach (Consulta consulta in consultas)
            {
                sb.AppendLine(consulta.ToString()); 
            }

            return sb.ToString();
        }

        public static Consulta operator +(PersonalMedico medico,Paciente paciente)
        {
            Consulta nuevaConsulta = new Consulta(DateTime.Now, paciente);
            medico.consultas.Add(nuevaConsulta);
            return nuevaConsulta;
        }
    }
}
