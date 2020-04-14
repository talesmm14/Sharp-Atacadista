using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_A1_Supermecado.Classes;
using Trabalho_A1_Supermecado.Controller;

namespace Trabalho_A1_Supermecado.Forms
{
    public partial class Login : Form
    {
        Empregado user = new Empregado();
        public Empregado User { get => user; set => user = value; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            User = Sessao.login(cpf.Text, senha.Text);
            if (User != null)
            {
                Home home = new Home();
                this.Hide();
                home.Show();
            }
            aviso.Text = "CPF ou Senha incorretos!!";
            senha.Text = "";
        }
    }
}
