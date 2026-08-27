namespace PryPosseReg1
{
    public partial class frmGestión : Form
    {
        public frmGestión()
        {
            InitializeComponent();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aggclientes = new frmAgregarClientes();
            // aggclientes.MdiParent = this;
            aggclientes.Show();

        }

        private void clientesOrdPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ordPor = new frmListado();
            //// ordPor.MdiParent = this;
            ordPor.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            this.Close();
        }
    }
}
