using Entidades;

namespace La_Libreria
{
    public partial class FrmTest1 : Form
    {
        private Vendedor vendedor;
        public FrmTest1()
        {
            InitializeComponent();
            vendedor = new Vendedor("Don Capricho");
        }


        private void FrmTest1_Load_1(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("A�o Uno (Batman)", false, 3, 1270);

            lstStock.Items.Add(p1);
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);
        }

        private void btnVender_Click_1(object sender, EventArgs e)
        {
            Publicacion publicacion = lstStock.SelectedItem as Publicacion;

            if (publicacion != null)
            {
                if (vendedor + publicacion)
                {
                    MessageBox.Show("Venta exitosa", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La venta no pudo realizarse por falta de stock.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            rtbInforme.Text = Vendedor.ObtenerInformeDeVentas(vendedor);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTest1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("�Seguro desea salir?", "Confirmaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}