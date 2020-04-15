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

namespace Trabalho_A1_Supermecado.Forms
{
    public partial class Movimentacoes : Form
    {
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
        }

        private void Movimentacoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet.Lote'. Você pode movê-la ou removê-la conforme necessário.
            this.loteTableAdapter.Fill(this.supermecadoDataSet.Lote);

        }

        private void btn_add_fornecedor_Click(object sender, EventArgs e)
        {
            Cadastros cad = new Cadastros();
            cad.Show();
            this.Hide();
        }
    }
}
