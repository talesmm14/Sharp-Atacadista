﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_A1_Supermecado.DAO;

namespace Trabalho_A1_Supermecado
{
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
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
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.supermecadoDataSet.Fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet.Item'. Você pode movê-la ou removê-la conforme necessário.
            this.itemTableAdapter.Fill(this.supermecadoDataSet.Item);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet.Historico'. Você pode movê-la ou removê-la conforme necessário.
            this.historicoTableAdapter.Fill(this.supermecadoDataSet.Historico);

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (id.Text == "0" || id.Text == "")
            {
                dataGrid.DataSource = Conexao.pesquisar("SELECT * FROM Item WHERE " +
                    "(datetime IS NULL OR datetime '" + DateTIme.Value.ToString() + "') " +
                    "AND (" +
                    "(fk_item = " + ((int)cb_produto.SelectedValue) + ")" +
                    "AND " +
                    "(fk_empregado = " + ((int)cb_empregado.SelectedValue) + ")" +
                    "AND " +
                    "(fk_fornecedor = " + ((int)cb_fornecedor.SelectedValue) + "))");
            }
            else
            {
                dataGrid.DataSource = Conexao.pesquisar("SELECT * FROM Empregado WHERE (id = " + id.Text + ")");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = Conexao.pesquisar("SELECT * FROM Historico");
        }
    }
}
