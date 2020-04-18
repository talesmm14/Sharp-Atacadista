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
using Trabalho_A1_Supermecado.DAO;
using Trabalho_A1_Supermecado.Forms;

namespace Trabalho_A1_Supermecado
{
    public partial class Cadastros : Form
    {
        CadastrosController controller = new CadastrosController();
        public Cadastros()
        {
            InitializeComponent();
            perfilToolStripMenuItem.Text = Sessao.NomeUsuario;
        }

        private void sairToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Sessao.logout();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            DialogResult dres2 = opnfd.ShowDialog();
            Item_tbxImagem.Text = opnfd.FileName;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void Departamento()
        {
            Departamento obj = new Departamento();
            obj.Nome = Departamento_tbxNome.Text;
            obj.Descricao = Departamento_tbxDescricao.Text;
            if (Departamento_tbxNome.Text != "")
            {
                if (controller.cadastrarDepartamento(obj) != null)
                {
                    MessageBox.Show("Cadastro realizado de :" + obj.Nome);
                    DataTable dt = new DataTable();
                    dt = DepartamentoDAO.returnDataSource();
                    SubDepartamento_cbDepartamento.DataSource = dt;
                    Departamento_tbxNome.Text = "";
                    Departamento_tbxDescricao.Text = "";
                }
                else
                {
                    MessageBox.Show("Cadastro não realizado de :" + obj.Nome);
                }
            }
        }
        private void SubDepartamento()
        {
            Subdepartamento obj = new Subdepartamento();
            obj.Nome = SubDepartamento_tbxNome.Text;
            obj.Descricao = SubDepartamento_tbxDescricao.Text;
            obj.Departamento = DepartamentoDAO.findById((int)SubDepartamento_cbDepartamento.SelectedValue);
            if (SubDepartamento_tbxNome.Text != "" || SubDepartamento_cbDepartamento.SelectedValue != null)
            {
                if (controller.CadastrarSubDepartamento(obj) != null)
                {
                    MessageBox.Show("Cadastro realizado de :" + obj.Nome);
                    DataTable dt = new DataTable();
                    dt = SetorDAO.returnDataSource();
                    Setor_cbSubDepartamento.DataSource = dt;
                    SubDepartamento_tbxNome.Text = "";
                    SubDepartamento_tbxDescricao.Text = "";
                }
                else
                {
                    MessageBox.Show("Cadastro não realizado de :" + obj.Nome);
                }
            }
        }
        private void Setor()
        {
            Setor obj = new Setor();
            obj.Nome = Setor_tbxNome.Text;
            obj.Descricao = Setor_tbxDescricao.Text;
            obj.SubDepartamento = SubdepartamentoDAO.findById((int)Setor_cbSubDepartamento.SelectedValue);
            if (Setor_tbxNome.Text != "" || Setor_cbSubDepartamento.SelectedValue != null)
            {
                if (controller.CadastrarSetor(obj) != null)
                {
                    MessageBox.Show("Cadastro realizado de :" + obj.Nome);
                    DataTable dt = new DataTable();
                    dt = SetorDAO.returnDataSource();
                    Item_cbSetor.DataSource = dt;
                    Setor_tbxNome.Text = "";
                    Setor_tbxDescricao.Text = "";
                }
                else
                {
                    MessageBox.Show("Cadastro não realizado de :" + obj.Nome);
                }
            }
        }
        private void Marca()
        {
            Marca obj = new Marca();
            obj.Nome = Marca_tbxNome.Text;
            obj.Descricao = Marca_tbxDescricao.Text;
            obj.Endereco = Marca_tbxEndereco.Text;
            obj.Cnpj = Marca_tbxCNPJ.Text;
            obj.Telefone = Marca_tbxTelefone.Text;
            if (Marca_tbxNome.Text != "")
            {
                if (controller.CadastrarMarca(obj) != null)
                {
                    MessageBox.Show("Cadastro realizado de :" + obj.Nome);
                    DataTable dt = new DataTable();
                    dt = MarcaDAO.returnDataSource();
                    Item_cbMarca.DataSource = dt;
                    Marca_tbxNome.Text = "";
                    Marca_tbxDescricao.Text = "";
                    Marca_tbxEndereco.Text = "";
                    Marca_tbxCNPJ.Text = "";
                    Marca_tbxTelefone.Text = "";
                }
                else
                {
                    MessageBox.Show("Cadastro não realizado de :" + obj.Nome);
                }
            }
        }
        private void Fornecedor()
        {
            Fornecedor obj = new Fornecedor();
            obj.Nome = Fornecedor_tbxNome.Text;
            obj.Descricao = Fornecedor_tbxDescricao.Text;
            obj.Endereco = Fornecedor_tbxEndereco.Text;
            obj.Cnpj = Fornecedor_tbxCNPJ.Text;
            obj.Telefone = Fornecedor_tbxTelefone.Text;
            if (Fornecedor_tbxNome.Text != "" || Fornecedor_tbxEndereco.Text != "" || Fornecedor_tbxCNPJ.Text != "" ||
                Fornecedor_tbxTelefone.Text != "")
            {
                if (controller.CadastrarFornecedor(obj) != null)
                {
                    MessageBox.Show("Cadastro realizado de :" + obj.Nome);
                    Fornecedor_tbxNome.Text = "";
                    Fornecedor_tbxDescricao.Text = "";
                    Fornecedor_tbxEndereco.Text = "";
                    Fornecedor_tbxCNPJ.Text = "";
                    Fornecedor_tbxTelefone.Text = "";
                }
                else
                {
                    MessageBox.Show("Cadastro não realizado de :" + obj.Nome);
                }
            }
        }
        private void Item()
        {
            Item obj = new Item();
            obj.Nome = Item_tbxNome.Text;
            obj.Setor = SetorDAO.findById((int)Item_cbSetor.SelectedValue);
            obj.Marca = MarcaDAO.findById((int)Item_cbMarca.SelectedValue);
            obj.Complemento = Item_tbxComplemento.Text;
            obj.Imagem = Item_tbxImagem.Text;
            if (Item_tbxNome.Text != "" || Item_cbSetor.SelectedValue != null || Item_cbMarca.SelectedValue != null)
            {
                if (controller.CadastrarItem(obj) != null)
                {
                    MessageBox.Show("Cadastro realizado de :" + obj.Nome);
                    Item_tbxNome.Text = "";
                    Item_tbxImagem.Text = "";
                }
                else
                {
                    MessageBox.Show("Cadastro não realizado de :" + obj.Nome);
                }
            }
        }
        private void Funcionario()
        {
            Empregado obj = new Empregado();
            obj.NomeCompleto = Funcionario_NomeCompleto.Text;
            obj.Cpf = Funcionario_tbcCPF.Text;
            obj.Senha = Funcionario_tbxSenha.Text;
            obj.Funcao = Funcionario_tbxSenha.Text;
            if (Funcionario_NomeCompleto.Text != "" || Funcionario_tbcCPF.Text != "" || Funcionario_tbxSenha.Text != "" ||
                Funcionario_tbxSenha.Text != "")
                if (Funcionario_tbxSenha.Text == Funcionario_tbxConfirmar.Text)
                {
                    controller.CadastrarFuncionario(obj);
                    MessageBox.Show("Ação realizada!!");
                    Funcionario_NomeCompleto.Text = "";
                    Funcionario_tbcCPF.Text = "";
                    Funcionario_tbxSenha.Text = "";
                    Funcionario_tbxSenha.Text = "";
                }
                else
                    Funcionario_lbConfirmar.Text = "As senhas não são iguais!!";
        }

        private void sair()
        {
            if (Application.OpenForms.Count != 0)
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is Form)
                    {
                        this.Close();
                        openForm.Show();
                        break;
                    }
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void Departamento_btnCadastrar_Click(object sender, EventArgs e)
        {
            Departamento();
        }

        private void SubDepartamnto_btnCadastrar_Click(object sender, EventArgs e)
        {
            SubDepartamento();
        }

        private void Setor_btnCadastrar_Click(object sender, EventArgs e)
        {
            Setor();
        }

        private void Marca_btnCadastrar_Click(object sender, EventArgs e)
        {
            Marca();
        }

        private void Fornecedor_btnCadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor();
        }

        private void Item_btnCadastrar_Click(object sender, EventArgs e)
        {
            Item();
        }

        private void Funcionario_btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario();
        }

        private void Cadastros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter1.Fill(this.supermecadoDataSet1.Marca);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Setor'. Você pode movê-la ou removê-la conforme necessário.
            this.setorTableAdapter1.Fill(this.supermecadoDataSet1.Setor);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Sub_departamento'. Você pode movê-la ou removê-la conforme necessário.
            this.sub_departamentoTableAdapter1.Fill(this.supermecadoDataSet1.Sub_departamento);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Departamento'. Você pode movê-la ou removê-la conforme necessário.
            this.departamentoTableAdapter1.Fill(this.supermecadoDataSet1.Departamento);

        }
    }
}
