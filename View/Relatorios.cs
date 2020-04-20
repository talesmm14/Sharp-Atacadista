using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_A1_Supermecado.Controller;
using Trabalho_A1_Supermecado.DAO;
using Trabalho_A1_Supermecado.Forms;

namespace Trabalho_A1_Supermecado
{
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
            perfilToolStripMenuItem.Text = Sessao.NomeUsuario;
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

        private void Relatorios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter1.Fill(this.supermecadoDataSet1.Fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Item'. Você pode movê-la ou removê-la conforme necessário.
            this.itemTableAdapter1.Fill(this.supermecadoDataSet1.Item);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Empregado'. Você pode movê-la ou removê-la conforme necessário.
            this.empregadoTableAdapter1.Fill(this.supermecadoDataSet1.Empregado);

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT * FROM Historico WHERE ";
            int count = 0;
            if (checkData.Checked)
            {
                if (count != 0)
                    consulta += " AND ";
                consulta += "(cast ([datetime] as date) = '" + dateTIme.Value.Date.ToString("yyyy-MM-dd") + "')";
                count += 1;
            }
            if (checkProtudo.Checked)
            {
                if (count != 0)
                    consulta += " AND ";
                consulta += "(fk_item = " + (int)cb_produto.SelectedValue + ")";
                count += 1;
            }
            if (checkResponsavel.Checked)
            {
                if (count != 0)
                    consulta += " AND ";
                consulta += "(fk_empregado = " + (int)cb_empregado.SelectedValue + ")";
                count += 1;
            }
            if (checkFornecedor.Checked)
            {
                if (count != 0)
                    consulta += " AND ";
                consulta += "(fk_fornecedor = " + (int)cb_fornecedor.SelectedValue + ")";
                count += 1;
            }
            if (id.Text == "0" || id.Text == "")
            {
                if (count == 0)
                    dataGrid.DataSource = Conexao.pesquisar("SELECT * FROM Historico");
                else
                    dataGrid.DataSource = Conexao.pesquisar(consulta);
            }
            else
            {
                dataGrid.DataSource = Conexao.pesquisar("SELECT * FROM Historico WHERE (id = " + id.Text + ")");
                checkProtudo.Checked = false;
                checkData.Checked = false;
                checkFornecedor.Checked = false;
                checkResponsavel.Checked = false;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = Conexao.pesquisar("SELECT * FROM Historico");
            checkProtudo.Checked = false;
            checkData.Checked = false;
            checkFornecedor.Checked = false;
            checkResponsavel.Checked = false;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.empregadoTableAdapter1.FillBy(this.supermecadoDataSet1.Empregado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
