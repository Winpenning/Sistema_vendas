using Sistema_vendas.view;
namespace Sistema_vendas
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {

        }

        private void botaosair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botaoclientes_Click(object sender, EventArgs e)
        {
            FCliente tela = new FCliente();
            tela.TopLevel = true;
            tela.FormBorderStyle = FormBorderStyle.None;

            tabControl1.TabPages.Add("Clientes");
            int abas = tabControl1.TabPages.Count;
            tabControl1.TabPages[abas-1].Controls.Add(tela);
            tela.Dock = DockStyle.Fill;
            tela.Show();
            Refresh();
        }
    }
}