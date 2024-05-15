using Entidades;

namespace Parcial_Labo
{
    public partial class FrmAtencion : Form
    {
        public FrmAtencion()
        {
            InitializeComponent();
        }
        private void FrmAtencion_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            Paciente paciente = lstPacientes.SelectedItem as Paciente;
            PersonalMedico medico = lstMedicos.SelectedItem as PersonalMedico;


            if (paciente == null || medico == null)
            {
                MessageBox.Show("Debe seleccionar un Médico y un Paciente para poder continuar.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

               
            }

        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonalMedico medicoSeleccionado = lstMedicos.SelectedItem as PersonalMedico;
            if (medicoSeleccionado != null)
            {
                rtbInfoMedico.Text = medicoSeleccionado.FichaExtra();
            }
        }

        private void FrmAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}