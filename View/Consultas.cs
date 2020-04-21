using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class Consultas : Form
    {
        
        public Consultas()
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

        private void Consultas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Empregado'. Você pode movê-la ou removê-la conforme necessário.
            this.empregadoTableAdapter1.Fill(this.supermecadoDataSet1.Empregado);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Item'. Você pode movê-la ou removê-la conforme necessário.
            this.itemTableAdapter1.Fill(this.supermecadoDataSet1.Item);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter1.Fill(this.supermecadoDataSet1.Fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter1.Fill(this.supermecadoDataSet1.Marca);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Setor'. Você pode movê-la ou removê-la conforme necessário.
            this.setorTableAdapter1.Fill(this.supermecadoDataSet1.Setor);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Sub_departamento'. Você pode movê-la ou removê-la conforme necessário.
            this.sub_departamentoTableAdapter1.Fill(this.supermecadoDataSet1.Sub_departamento);
            // TODO: esta linha de código carrega dados na tabela 'supermecadoDataSet1.Departamento'. Você pode movê-la ou removê-la conforme necessário.
            this.departamentoTableAdapter1.Fill(this.supermecadoDataSet1.Departamento);

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

        private void Departamento_btnBuscar_Click(object sender, EventArgs e)
        {
            if (Departamento_Id.Text == "0" || Departamento_Id.Text == "")
            {
                Departamento_dg.DataSource = Conexao.pesquisar("SELECT * FROM Departamento WHERE " +
                    "nome IS NULL OR nome LIKE '%" + Departamento_Nome.Text + "%'");
            }
            else
            {
                Departamento_Nome.Text = "";
                Departamento_dg.DataSource = Conexao.pesquisar("SELECT * FROM Departamento WHERE (id = " + Departamento_Id.Text + ")");
            }
        }

        private void Departamento_btnLimpar_Click(object sender, EventArgs e)
        {
            Departamento_Id.Text = "";
            Departamento_Nome.Text = "";
            Departamento_dg.DataSource = Conexao.pesquisar("SELECT * FROM Departamento");
        }

        private void SubDepartamento_Buscar_Click(object sender, EventArgs e)
        {
            if (SubDepartamento_Id.Text == "0" || SubDepartamento_Id.Text == "")
            {
                SubDepartamento_dg.DataSource = Conexao.pesquisar("SELECT * FROM Sub_departamento WHERE " +
                    "((nome IS NULL OR nome LIKE '%" + SubDepartamento_Nome.Text + "%') " +
                    "AND (fk_departamento = " + ((int)SubDepartamento_cbDepartamento.SelectedValue) + "))");
            }
            else
            {
                SubDepartamento_Nome.Text = "";
                SubDepartamento_dg.DataSource = Conexao.pesquisar("SELECT * FROM Sub_departamento WHERE (id = " + SubDepartamento_Id.Text + ")");
            }
        }

        private void SubDepartamento_Limpar_Click(object sender, EventArgs e)
        {
            SubDepartamento_Id.Text = "";
            SubDepartamento_Nome.Text = "";
            SubDepartamento_dg.DataSource = Conexao.pesquisar("SELECT * FROM Sub_departamento");
        }

        private void Setor_Buscar_Click(object sender, EventArgs e)
        {
            if (Setor_Id.Text == "0" || Setor_Id.Text == "")
            {
                Setor_dg.DataSource = Conexao.pesquisar("SELECT * FROM Setor WHERE " +
                    "((nome IS NULL OR nome LIKE '%" + Setor_Nome.Text + "%') " +
                    "AND (fk_sub_departamento = " + ((int)Setor_cbSubDepartamento.SelectedValue) + "))");
            }
            else
            {
                Setor_Nome.Text = "";
                Setor_dg.DataSource = Conexao.pesquisar("SELECT * FROM Setor WHERE (id = " + Setor_Id.Text + ")");
            }
        }

        private void Setor_Limpar_Click(object sender, EventArgs e)
        {
            Setor_Id.Text = "";
            Setor_Nome.Text = "";
            Setor_dg.DataSource = Conexao.pesquisar("SELECT * FROM Setor");
        }

        private void Marca_Buscar_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT * FROM Marca WHERE ";
            int count = 0;
            if (Marca_Id.Text == "0" || Marca_Id.Text == "")
            {
                if (Marca_Nome.Text != "")
                {
                    if (count != 0)
                        consulta += " AND ";
                    consulta += "(nome LIKE '%" + Marca_Nome.Text + "%')";
                    count += 1;
                }
                if (Marca_Cnpj.Text != "")
                {
                    if (count != 0)
                        consulta += " AND ";
                    consulta += "(cnpj LIKE '%" + Marca_Cnpj.Text + "%')";
                    count += 1;
                }
                Marca_dg.DataSource = Conexao.pesquisar(consulta);
            }
            else
            {
                Marca_Nome.Text = "";
                Marca_Cnpj.Text = "";
                Marca_dg.DataSource = Conexao.pesquisar("SELECT * FROM Marca WHERE (id = " + Marca_Id.Text + ")");
            }
        }

        private void Marca_Limpar_Click(object sender, EventArgs e)
        {
            Marca_Id.Text = "";
            Marca_Nome.Text = "";
            Marca_Cnpj.Text = "";
            Marca_dg.DataSource = Conexao.pesquisar("SELECT * FROM Marca");
        }

        private void Fornecedor_Buscar_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT * FROM Fornecedor WHERE ";
            int count = 0;
            if (Fornecedor_Id.Text == "0" || Fornecedor_Id.Text == "")
            {
                if (Fornecedor_Nome.Text != "")
                {
                    if (count != 0)
                        consulta += " AND ";
                    consulta += "(nome LIKE '%" + Fornecedor_Nome.Text + "%')";
                    count += 1;
                }
                if (Fornecedor_Cnpj.Text != "")
                {
                    if (count != 0)
                        consulta += " AND ";
                    consulta += "(cnpj LIKE '%" + Fornecedor_Cnpj.Text + "%')";
                    count += 1;
                }
                if (count == 0)
                    consulta = "SELECT * FROM Historico";
                Marca_dg.DataSource = Conexao.pesquisar(consulta);
            }
            else
            {
                Fornecedor_Nome.Text = "";
                Fornecedor_Cnpj.Text = "";
                Fornecedor_dg.DataSource = Conexao.pesquisar("SELECT * FROM Fornecedor WHERE (id = " + Fornecedor_Id.Text + ")");
            }
        }

        private void Fornecedor_Limpar_Click(object sender, EventArgs e)
        {
            Fornecedor_Id.Text = "";
            Fornecedor_Nome.Text = "";
            Fornecedor_Cnpj.Text = "";
            Fornecedor_dg.DataSource = Conexao.pesquisar("SELECT * FROM Fornecedor");
        }

        private void Item_Buscar_Click(object sender, EventArgs e)
        {
            if (Item_Id.Text == "0" || Item_Id.Text == "")
            {
                Item_dg.DataSource = Conexao.pesquisar("SELECT * FROM Item WHERE " +
                    "(nome IS NULL OR nome LIKE '%" + Item_Nome.Text + "%') " +
                    "AND (" +
                    "(fk_marca = " + ((int)Item_cbMarca.SelectedValue) + ")" +
                    "AND " +
                    "(fk_setor = " + ((int)Item_cbSetor.SelectedValue) + "))");
            }
            else
            {
                Item_Nome.Text = "";
                Item_dg.DataSource = Conexao.pesquisar("SELECT * FROM Item WHERE (id = " + Item_Id.Text + ")");
            }
        }

        private void Item_Limpar_Click(object sender, EventArgs e)
        {
            Item_Id.Text = "";
            Item_Nome.Text = "";
            Item_dg.DataSource = Conexao.pesquisar("SELECT * FROM Item");
        }

        private void Funcionario_Buscar_Click(object sender, EventArgs e)
        {
            if (Funcionario_Id.Text == "0" || Funcionario_Id.Text == "")
            {
                Funcionario_dg.DataSource = Conexao.pesquisar("SELECT * FROM Empregado WHERE " +
                    "(nome LIKE '%" + Funcionario_Nome.Text + "%')");
            }
            else
            {
                Funcionario_Nome.Text = "";
                Funcionario_dg.DataSource = Conexao.pesquisar("SELECT * FROM Empregado WHERE (id = " + Funcionario_Id.Text + ")");
            }
        }

        private void Funcionario_Limpar_Click(object sender, EventArgs e)
        {
            Funcionario_Id.Text = "";
            Funcionario_Nome.Text = "";
            Funcionario_dg.DataSource = Conexao.pesquisar("SELECT * FROM Empregado");
        }

    }
}
