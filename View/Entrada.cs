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

namespace Trabalho_A1_Supermecado.View
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            EntradaController con = new EntradaController();
            Lote obj = new Lote();
            obj.Tipo_estoque = cbEstoqueTipo.Text;
            obj.Dias_validade = (DateTime)validadeDias.Value;
            obj.Peso_kg = (Decimal)pesoKg.Value;
            obj.Qtd_estoque = (int)estoque.Value;
            obj.Item = ItemDAO.findById((int)cbItem.SelectedValue);
            obj.Fornecedor = FornecedorDAO.findById((int)cbFornecedor.SelectedValue);
            obj.Valor_compra = (Decimal)valorCompra.Value;
            obj.DataFabricacao = (DateTime)dtFabricacao.Value;
            obj.Codigo = (String)tbxCodigo.Text;

            if (cbEstoqueTipo.SelectedValue != null || pesoKg.Value != 0 || estoque.Value != 0 ||
                cbItem.SelectedValue != null || cbFornecedor.SelectedValue != null || valorCompra.Value != 0 ||
                tbxCodigo.Text != "")
            {
                if (con.cadastrarLote(obj))
                {
                    MessageBox.Show("Cadastro realizado!!");
                    pesoKg.Value = 0;
                    estoque.Value = 0;
                    cbEstoqueTipo.SelectedIndex = 0;
                    cbItem.SelectedIndex = 0;
                    cbFornecedor.SelectedIndex = 0;
                    valorCompra.Value = 0;
                    tbxCodigo.Text = "";
                }
                else
                {
                    MessageBox.Show("Cadastro não realizado!!");
                }
            }
        }

        private void btnAddF_Click(object sender, EventArgs e)
        {
            Cadastros cad = new Cadastros();
            cad.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
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
        private void Entrada_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Item'. Você pode movê-la ou removê-la conforme necessário.
            this.itemTableAdapter1.Fill(this.supermecadoDataSet1.Item);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter1.Fill(this.supermecadoDataSet1.Fornecedor);

        }
    }
}
