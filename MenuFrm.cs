namespace Calculadora_Proyecto
{
    public partial class MenuFrm : Form
    {
        public MenuFrm()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadorafrm formulario = new Calculadorafrm();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}