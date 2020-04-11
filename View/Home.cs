using System.Windows.Forms;
using Trabalho_A1_Supermecado.Forms;

namespace Trabalho_A1_Supermecado
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ajudaMenuItem_Click(object sender, System.EventArgs e)
        {
            Ajuda ajudaform = new Ajuda();
            ajudaform.Show();
            this.Hide();
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            Ajuda ajudaform = new Ajuda();
            ajudaform.Show();
            this.Hide();
        }

        private void cadastroMenuItem_Click(object sender, System.EventArgs e)
        {
            Cadastros cadastros = new Cadastros();
            cadastros.Show();
            this.Hide();
        }

        private void consultasMenuItem_Click(object sender, System.EventArgs e)
        {
            Consultas consultas = new Consultas();
            consultas.Show();
            this.Hide();
        }

        private void relatoriosMenuItem_Click(object sender, System.EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.Show();
            this.Hide();
        }

        private void btn_retirada_Click(object sender, System.EventArgs e)
        {

        }

        private void btn_Entrada_Click(object sender, System.EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
