using System.Windows.Forms;
using Trabalho_A1_Supermecado.Controller;
using Trabalho_A1_Supermecado.Forms;
using Trabalho_A1_Supermecado.View;

namespace Trabalho_A1_Supermecado
{
    public partial class Home : Form
    {
        Login login = new Login();
        public Home()
        {
            InitializeComponent();
            perfil.Text = Sessao.NomeUsuario;
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
            Movimentacoes mov = new Movimentacoes();
            mov.Show();
            this.Hide();
        }

        private void btn_Entrada_Click(object sender, System.EventArgs e)
        {
            Entrada mov = new Entrada();
            mov.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sessao.logout();
        }
    }
}
