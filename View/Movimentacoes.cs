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

namespace Trabalho_A1_Supermecado.Forms
{
    public partial class Movimentacoes : Form
    {
        Lote objLote = new Lote();
        public Movimentacoes()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, System.EventArgs e)
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

        private void btn_voltar_Click(object sender, EventArgs e)
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

        private void Movimentacoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet2.Lote'. Você pode movê-la ou removê-la conforme necessário.
            this.loteTableAdapter1.Fill(this.supermecadoDataSet2.Lote);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet2.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter1.Fill(this.supermecadoDataSet2.Fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet2.Item'. Você pode movê-la ou removê-la conforme necessário.
            this.itemTableAdapter1.Fill(this.supermecadoDataSet2.Item);

        }

        private void btn_add_fornecedor_Click(object sender, EventArgs e)
        {
            Cadastros cad = new Cadastros();
            cad.Show();
            this.Hide();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            MovimentacoesController controller = new MovimentacoesController();
            objLote.Qtd_estoque = (int)nuRetirar.Value;
            LoteDAO dao = new LoteDAO();
            if (controller.CadastrarLote(objLote))
            {
                MessageBox.Show("Retirado!!");
                dataGrid.DataSource = LoteDAO.returnDataSource();
            }
            else
                MessageBox.Show("Erro!!");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT * FROM Lote WHERE ";
            int count = 0;
            if (checkValidade.Checked)
            {
                if (count != 0)
                    consulta += " AND ";
                consulta += "(cast ([validade] as date) = '" + nValidade.Value.Date.ToString("yyyy-MM-dd") + "')";
                count += 1;
            }
            if (checkProduto.Checked)
            {
                if (count != 0)
                    consulta += " AND ";
                consulta += "(fk_item = " + (int)cbPesquisarProduto.SelectedValue + ")";
                count += 1;
            }
            if (checkFornecedor.Checked)
            {
                if (count != 0)
                    consulta += " AND ";
                consulta += "(fk_fornecedor = " + (int)cbPesquisarFornecedor.SelectedValue + ")";
                count += 1;
            }
            if (checkCod.Checked)
            {
                if (count != 0)
                    consulta += " AND ";
                consulta += "(codigo = '" + codPesquisarLote.Text + "')";
                count += 1;
            }
            if (checkEstoque.Checked)
            {
                if (count != 0)
                    consulta += " AND ";
                consulta += "(tipo_estoque = '" + (String)cbEstoque.Text + "')";
                count += 1;
            }

            if (id.Text == "0" || id.Text == "")
            {
                if (count == 0)
                    dataGrid.DataSource = Conexao.pesquisar("SELECT * FROM Lote");
                else
                    dataGrid.DataSource = Conexao.pesquisar(consulta);
            }
            else
            {
                dataGrid.DataSource = Conexao.pesquisar("SELECT * FROM Lote WHERE (id = " + id.Text + ")");
                checkProduto.Checked = false;
                checkValidade.Checked = false;
                checkFornecedor.Checked = false;
                checkCod.Checked = false;
                checkEstoque.Checked = false;
            }
        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                objLote = LoteDAO.findById((int)row.Cells["dataGridViewTextBoxColumn1"].Value);
                nomeLote.Text = "Lote " + objLote.Id +" "+ objLote.Codigo;
                nuRetirar.Value = objLote.Qtd_estoque;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = Conexao.pesquisar("SELECT * FROM Lote");
            checkProduto.Checked = false;
            checkValidade.Checked = false;
            checkFornecedor.Checked = false;
            checkCod.Checked = false;
            checkEstoque.Checked = false;
        }
    }
}
