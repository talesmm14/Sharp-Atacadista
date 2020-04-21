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
        Departamento objDepartamento = new Departamento();
        Subdepartamento objSubDepartamento = new Subdepartamento();
        Setor objSetor = new Setor();
        Marca objMarca = new Marca();
        Fornecedor objFornecedor = new Fornecedor();
        Item objItem = new Item();
        Empregado objEmpregado = new Empregado();
        CadastrosController controller = new CadastrosController();
        public Cadastros()
        {
            InitializeComponent();
            perfilToolStripMenuItem.Text = Sessao.NomeUsuario;
            if (Sessao.FuncaoUsuario != "ADMIN")
            {
                panelFuncionario.Visible = false;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
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
            objDepartamento.Id = 0;
            objDepartamento.Nome = Departamento_tbxNome.Text;
            objDepartamento.Descricao = Departamento_tbxDescricao.Text;
            if (Departamento_tbxNome.Text != "")
            {
                if (DepartamentoDAO.isExists(Departamento_tbxNome.Text) == false)
                {
                    if (controller.cadastrarDepartamento(objDepartamento) != null)
                    {
                        MessageBox.Show("Cadastro realizado de :" + objDepartamento.Nome);
                        DataTable dt = DepartamentoDAO.returnDataSource();
                        SubDepartamento_cbDepartamento.DataSource = dt;
                        Departamento_tbxNome.Clear();
                        Departamento_tbxDescricao.Clear();
                        tabDepartamento.ForeColor = Color.Black;
                    }
                }
                else
                {
                    tabDepartamento.ForeColor = Color.Red;
                }
            }
        }
        private void SubDepartamento()
        {
            objSubDepartamento.Id = 0;
            objSubDepartamento.Nome = SubDepartamento_tbxNome.Text;
            objSubDepartamento.Descricao = SubDepartamento_tbxDescricao.Text;
            objSubDepartamento.Departamento = DepartamentoDAO.findById((int)SubDepartamento_cbDepartamento.SelectedValue);
            if (SubDepartamento_tbxNome.Text != "" || SubDepartamento_cbDepartamento.SelectedValue != null)
            {
                if (SubdepartamentoDAO.isExists(SubDepartamento_tbxNome.Text) == false)
                {
                    if (controller.CadastrarSubDepartamento(objSubDepartamento) != null)
                    {
                        MessageBox.Show("Cadastro realizado de :" + objSubDepartamento.Nome);
                        DataTable dt = new DataTable();
                        dt = SubdepartamentoDAO.returnDataSource();
                        Setor_cbSubDepartamento.DataSource = dt;
                        SubDepartamento_tbxNome.Clear();
                        SubDepartamento_tbxDescricao.Clear();
                        tabSubDepartamento.ForeColor = Color.Black;
                    }
                }
                else
                {
                    tabSubDepartamento.ForeColor = Color.Red;
                }
            }
        }
        private void Setor()
        {
            objSetor.Id = 0;
            objSetor.Nome = Setor_tbxNome.Text;
            objSetor.Descricao = Setor_tbxDescricao.Text;
            objSetor.SubDepartamento = SubdepartamentoDAO.findById((int)Setor_cbSubDepartamento.SelectedValue);
            if (Setor_tbxNome.Text != "" || Setor_cbSubDepartamento.SelectedValue != null)
            {
                if (SetorDAO.isExists(Setor_tbxNome.Text) == false)
                {
                    if (controller.CadastrarSetor(objSetor) != null)
                    {
                        MessageBox.Show("Cadastro realizado de :" + objSetor.Nome);
                        DataTable dt = new DataTable();
                        dt = SetorDAO.returnDataSource();
                        Item_cbSetor.DataSource = dt;
                        Setor_tbxNome.Clear();
                        Setor_tbxDescricao.Clear();
                        tabSetor.ForeColor = Color.Black;
                    }
                }
                else
                {
                    tabSetor.ForeColor = Color.Red;
                }
            }
        }
        private void Marca()
        {
            objMarca.Id = 0;
            objMarca.Nome = Marca_tbxNome.Text;
            objMarca.Descricao = Marca_tbxDescricao.Text;
            objMarca.Endereco = Marca_tbxEndereco.Text;
            objMarca.Cnpj = Marca_tbxCNPJ.Text;
            objMarca.Telefone = Marca_tbxTelefone.Text;
            if (Marca_tbxNome.Text != "")
            {
                if (MarcaDAO.isExists(Marca_tbxNome.Text) == false)
                {
                    if (controller.CadastrarMarca(objMarca) != null)
                    {
                        MessageBox.Show("Cadastro realizado de :" + objMarca.Nome);
                        DataTable dt = new DataTable();
                        dt = MarcaDAO.returnDataSource();
                        Item_cbMarca.DataSource = dt;
                        Marca_tbxNome.Clear();
                        Marca_tbxDescricao.Clear();
                        Marca_tbxEndereco.Clear();
                        Marca_tbxCNPJ.Clear();
                        Marca_tbxTelefone.Clear();
                        tabMarca.ForeColor = Color.Black;
                    }
                }
                else
                {
                    tabMarca.ForeColor = Color.Red;
                }
            }
        }
        private void Fornecedor()
        {
            objFornecedor.Id = 0;
            objFornecedor.Nome = Fornecedor_tbxNome.Text;
            objFornecedor.Descricao = Fornecedor_tbxDescricao.Text;
            objFornecedor.Endereco = Fornecedor_tbxEndereco.Text;
            objFornecedor.Cnpj = Fornecedor_tbxCNPJ.Text;
            objFornecedor.Telefone = Fornecedor_tbxTelefone.Text;
            if (Fornecedor_tbxNome.Text != "" || Fornecedor_tbxEndereco.Text != "" || Fornecedor_tbxCNPJ.Text != "" ||
                Fornecedor_tbxTelefone.Text != "")
            {
                if (FornecedorDAO.isExists(Fornecedor_tbxNome.Text) == false)
                {
                    if (controller.CadastrarFornecedor(objFornecedor) != null)
                    {
                        MessageBox.Show("Cadastro realizado de :" + objFornecedor.Nome);
                        Fornecedor_tbxNome.Clear();
                        Fornecedor_tbxDescricao.Clear();
                        Fornecedor_tbxEndereco.Clear();
                        Fornecedor_tbxCNPJ.Clear();
                        Fornecedor_tbxTelefone.Clear();
                        tabFornecedor.ForeColor = Color.Black;
                    }
                }
                else
                {
                    tabFornecedor.ForeColor = Color.Red;
                }
            }
        }
        private void Item()
        {
            objItem.Id = 0;
            objItem.Nome = Item_tbxNome.Text;
            objItem.Setor = SetorDAO.findById((int)Item_cbSetor.SelectedValue);
            objItem.Marca = MarcaDAO.findById((int)Item_cbMarca.SelectedValue);
            objItem.Complemento = Item_tbxComplemento.Text;
            objItem.Imagem = Item_tbxImagem.Text;
            if (Item_tbxNome.Text != "" || Item_cbSetor.SelectedValue != null || Item_cbMarca.SelectedValue != null)
            {
                if (ItemDAO.isExists(Item_tbxNome.Text) == false)
                {
                    if (controller.CadastrarItem(objItem) != null)
                    {
                        MessageBox.Show("Cadastro realizado de :" + objItem.Nome);
                        Item_tbxNome.Clear();
                        Item_tbxComplemento.Clear();
                        Item_tbxImagem.Clear();
                        tabProduto.ForeColor = Color.Black;
                    }
                }
                else
                {
                    tabProduto.ForeColor = Color.Red;
                }
            }
        }
        private void Funcionario()
        {
            objEmpregado.Id = 0;
            objEmpregado.NomeCompleto = Funcionario_NomeCompleto.Text;
            objEmpregado.Cpf = Funcionario_tbcCPF.Text;
            objEmpregado.Senha = Funcionario_tbxSenha.Text;
            objEmpregado.Funcao = Funcionario_tbxSenha.Text;
            if (Funcionario_NomeCompleto.Text != "" || Funcionario_tbcCPF.Text != "" || Funcionario_tbxSenha.Text != "" ||
                Funcionario_tbxSenha.Text != "")
            {
                if (Funcionario_tbxSenha.Text == Funcionario_tbxConfirmar.Text)
                {
                    if (EmpregadoDAO.isExists(Funcionario_NomeCompleto.Text) == false)
                    {
                        if (controller.CadastrarFuncionario(objEmpregado) != null)
                        {
                            MessageBox.Show("Cadastro realizado de :" + objEmpregado.NomeCompleto);
                            Funcionario_NomeCompleto.Clear();
                            Funcionario_tbcCPF.Clear();
                            Funcionario_tbxSenha.Clear();
                            Funcionario_tbxConfirmar.Clear();
                            Funcionario_lbConfirmar.Text = "";
                            tabFuncionario.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        tabFuncionario.ForeColor = Color.Red;
                    }
                }
                else
                {
                    Funcionario_lbConfirmar.Text = "As senhas não são iguais!!";
                }
            }
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
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Empregado'. Você pode movê-la ou removê-la conforme necessário.
            this.empregadoTableAdapter.Fill(this.supermecadoDataSet1.Empregado);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Item'. Você pode movê-la ou removê-la conforme necessário.
            this.itemTableAdapter.Fill(this.supermecadoDataSet1.Item);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.supermecadoDataSet1.Fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter1.Fill(this.supermecadoDataSet1.Marca);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Setor'. Você pode movê-la ou removê-la conforme necessário.
            this.setorTableAdapter1.Fill(this.supermecadoDataSet1.Setor);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Sub_departamento'. Você pode movê-la ou removê-la conforme necessário.
            this.sub_departamentoTableAdapter1.Fill(this.supermecadoDataSet1.Sub_departamento);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Departamento'. Você pode movê-la ou removê-la conforme necessário.
            this.departamentoTableAdapter1.Fill(this.supermecadoDataSet1.Departamento);

        }

        private void dataGridDepartamento_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridDepartamento.Rows[e.RowIndex];
                objDepartamento = DepartamentoDAO.findById((int)row.Cells["idDepartamento"].Value);
                Departamento_tbxNome.Text = objDepartamento.Nome;
                Departamento_tbxDescricao.Text = objDepartamento.Descricao;
                Departamento_btnDeletar.Visible = true;
            }
        }

        private void dataGridSubDepartamento_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridSubDepartamento.Rows[e.RowIndex];
                objSubDepartamento = SubdepartamentoDAO.findById((int)row.Cells["idSubDepartamento"].Value);
                SubDepartamento_tbxNome.Text = objSubDepartamento.Nome;
                SubDepartamento_tbxDescricao.Text = objSubDepartamento.Descricao;
                SubDepartamento_cbDepartamento.SelectedValue = objSubDepartamento.Departamento.Id;
                SubDepartamnto_btnDeletar.Visible = true;
            }
        }

        private void dataGridSetor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridSetor.Rows[e.RowIndex];
                objSetor = SetorDAO.findById((int)row.Cells["idSetor"].Value);
                Setor_tbxNome.Text = objSetor.Nome;
                Setor_tbxDescricao.Text = objSetor.Descricao;
                Setor_cbSubDepartamento.SelectedValue = objSetor.SubDepartamento.Id;
                Setor_btnDeletar.Visible = true;
            }
        }

        private void dataGridMarca_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridMarca.Rows[e.RowIndex];
                objMarca = MarcaDAO.findById((int)row.Cells["idMarca"].Value);
                Marca_tbxNome.Text = objMarca.Nome;
                Marca_tbxDescricao.Text = objMarca.Descricao;
                Marca_tbxEndereco.Text = objMarca.Endereco;
                Marca_tbxCNPJ.Text = objMarca.Cnpj;
                Marca_tbxTelefone.Text = objMarca.Telefone;
                Marca_btnDeletar.Visible = true;
            }
        }

        private void dataGridFornecedor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridFornecedor.Rows[e.RowIndex];
                objFornecedor = FornecedorDAO.findById((int)row.Cells["idFornecedor"].Value);
                Fornecedor_tbxNome.Text = objFornecedor.Nome;
                Fornecedor_tbxDescricao.Text = objFornecedor.Descricao;
                Fornecedor_tbxEndereco.Text = objFornecedor.Endereco;
                Fornecedor_tbxCNPJ.Text = objFornecedor.Cnpj;
                Fornecedor_tbxTelefone.Text = objFornecedor.Telefone;
                Fornecedor_btnDeletar.Visible = true;
            }
        }

        private void dataGridItem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridItem.Rows[e.RowIndex];
                objItem = ItemDAO.findById((int)row.Cells["idItem"].Value);
                Item_tbxNome.Text = objItem.Nome;
                Item_tbxComplemento.Text = objItem.Complemento;
                Item_tbxImagem.Text = objItem.Imagem;
                Item_cbMarca.SelectedValue = objItem.Marca.Id;
                Item_cbSetor.SelectedValue = objItem.Setor.Id;
                Item_btnDeletar.Visible = true;
            }
        }

        private void dataGridFuncionario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridFuncionario.Rows[e.RowIndex];
                objEmpregado = EmpregadoDAO.findById((int)row.Cells["idEmpregado"].Value);
                Funcionario_NomeCompleto.Text = objEmpregado.NomeCompleto;
                Funcionario_tbcCPF.Text = objEmpregado.Cpf;
                Funcionario_tbxSenha.Text = objEmpregado.Senha;
                Funcionario_tbxConfirmar.Text = objEmpregado.Senha;
                Funcionario_cbFuncao.Text = objEmpregado.Funcao;
                Funcionario_btnDeletar.Visible = true;
            }
        }

        private void Departamento_btnLimpar_Click(object sender, EventArgs e)
        {
            Departamento_tbxNome.Clear();
            Departamento_tbxDescricao.Clear();
            Departamento_btnDeletar.Visible = false;
            tabDepartamento.ForeColor = Color.Black;
        }

        private void Departamento_btnDeletar_Click(object sender, EventArgs e)
        {
            if (objDepartamento.Id != 0)
            {
                controller.deletarDepartamento(objDepartamento);
                DataTable dt = DepartamentoDAO.returnDataSource();
                dataGridDepartamento.DataSource = dt;
                Departamento_btnLimpar_Click(sender,e);
            }
        }

        private void SubDepartamnto_btnDeletar_Click(object sender, EventArgs e)
        {
            if (objSubDepartamento.Id != 0)
            {
                controller.deletarSubDepartamento(objSubDepartamento);
                DataTable dt = SubdepartamentoDAO.returnDataSource();
                dataGridSubDepartamento.DataSource = dt;
                Setor_btnLimpar_Click(sender, e);
            }
        }

        private void Setor_btnDeletar_Click(object sender, EventArgs e)
        {
            if (objSetor.Id != 0)
            {
                controller.deletarSetor(objSetor);
                DataTable dt = SetorDAO.returnDataSource();
                dataGridSetor.DataSource = dt;
                Setor_btnLimpar_Click(sender, e);
            }
        }

        private void Marca_btnDeletar_Click(object sender, EventArgs e)
        {
            if (objMarca.Id != 0)
            {
                controller.deletarMarca(objMarca);
                DataTable dt = MarcaDAO.returnDataSource();
                dataGridMarca.DataSource = dt;
                Marca_btnLimpar_Click(sender, e);
            }
        }

        private void Fornecedor_btnDeletar_Click(object sender, EventArgs e)
        {
            if (objFornecedor.Id != 0)
            {
                controller.deletarFornecedor(objFornecedor);
                DataTable dt = FornecedorDAO.returnDataSource();
                dataGridFornecedor.DataSource = dt;
                Fornecedor_btnLimpar_Click(sender, e);
            }
        }

        private void Item_btnDeletar_Click(object sender, EventArgs e)
        {
            if (objItem.Id != 0)
            {
                controller.deletarItem(objItem);
                DataTable dt = ItemDAO.returnDataSource();
                dataGridItem.DataSource = dt;
                Item_btnLimpar_Click(sender, e);
            }
        }

        private void Funcionario_btnDeletar_Click(object sender, EventArgs e)
        {
            if (objEmpregado.Id != 0)
            {
                controller.deletarFuncionario(objEmpregado);
                DataTable dt = EmpregadoDAO.returnDataSource();
                dataGridFuncionario.DataSource = dt;
                Funcionario_btnLimpar_Click(sender, e);
            }
        }

        private void SubDepartamnto_btnLimpar_Click(object sender, EventArgs e)
        {
            SubDepartamento_tbxNome.Clear();
            SubDepartamento_tbxDescricao.Clear();
            SubDepartamnto_btnDeletar.Visible = false;
            tabSubDepartamento.ForeColor = Color.Black;
        }

        private void Setor_btnLimpar_Click(object sender, EventArgs e)
        {
            Setor_tbxNome.Clear();
            Setor_tbxDescricao.Clear();
            Setor_btnDeletar.Visible = false;
            tabSetor.ForeColor = Color.Black;
        }

        private void Marca_btnLimpar_Click(object sender, EventArgs e)
        {
            Marca_tbxNome.Clear();
            Marca_tbxDescricao.Clear();
            Marca_tbxEndereco.Clear();
            Marca_tbxCNPJ.Clear();
            Marca_tbxTelefone.Clear();
            Marca_btnDeletar.Visible = false;
            tabMarca.ForeColor = Color.Black;
        }

        private void Fornecedor_btnLimpar_Click(object sender, EventArgs e)
        {
            Fornecedor_tbxNome.Clear();
            Fornecedor_tbxDescricao.Clear();
            Fornecedor_tbxEndereco.Clear();
            Fornecedor_tbxCNPJ.Clear();
            Fornecedor_tbxTelefone.Clear();
            Fornecedor_btnDeletar.Visible = false;
            tabFornecedor.ForeColor = Color.Black;
        }

        private void Item_btnLimpar_Click(object sender, EventArgs e)
        {
            Item_tbxNome.Clear();
            Item_tbxComplemento.Clear();
            Item_tbxImagem.Clear();
            Item_btnDeletar.Visible = false;
            tabProduto.ForeColor = Color.Black;
        }

        private void Funcionario_btnLimpar_Click(object sender, EventArgs e)
        {
            Funcionario_NomeCompleto.Clear();
            Funcionario_tbcCPF.Clear();
            Funcionario_tbxSenha.Clear();
            Funcionario_tbxConfirmar.Clear();
            Funcionario_lbConfirmar.Text = "";
            Funcionario_btnDeletar.Visible = false;
            tabFuncionario.ForeColor = Color.Black;
        }
    }
}
