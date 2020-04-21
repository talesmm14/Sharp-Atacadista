using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_A1_Supermecado.Classes;

namespace Trabalho_A1_Supermecado.DAO
{
    public class SetorDAO
    {
        public Setor insert(Setor setor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Setor(nome, descricao, fk_sub_departamento, qtd_estoque) output INSERTED.id values (@nome, @descricao, @fk_sub_departamento, @qtd_estoque)";
            cmd.Parameters.AddWithValue("@nome", setor.Nome);
            cmd.Parameters.AddWithValue("@descricao", setor.Descricao);
            cmd.Parameters.AddWithValue("@fk_sub_departamento", setor.SubDepartamento.Id);
            cmd.Parameters.AddWithValue("@qtd_estoque", setor.QtdEstoque);
            if (Conexao.CRUD(cmd))
                return setor;
            return null;
        }
        public Setor update(Setor setor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Setor set nome = @nome, descricao = @descricao, fk_sub_departamento = @fk_sub_departamento, qtd_estoque = @qtd_estoque, id = @id where id = @id";
            cmd.Parameters.AddWithValue("@id", setor.Id);
            cmd.Parameters.AddWithValue("@nome", setor.Nome);
            cmd.Parameters.AddWithValue("@descricao", setor.Descricao);
            cmd.Parameters.AddWithValue("@fk_sub_departamento", setor.SubDepartamento.Id);
            cmd.Parameters.AddWithValue("@qtd_estoque", setor.QtdEstoque);
            if (Conexao.CRUD(cmd))
                return setor;
            return null;
        }
        public void delete(Setor setor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Setor WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", setor.Id);
            Conexao.CRUD(cmd);
        }
        public static Setor findById(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Setor WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Setor obj = new Setor();
            if (dr.HasRows)
            {
                dr.Read();
                obj.Id = (int)dr["id"];
                obj.Nome = dr["nome"].ToString();
                obj.Descricao = dr["descricao"].ToString();
                obj.SubDepartamento = SubdepartamentoDAO.findById((int)dr["fk_sub_departamento"]);
                obj.QtdEstoque = (int)dr["qtd_estoque"];
            }
            else
            {
                obj = null;
            }
            return obj;
        }
        public static Boolean isExists(string nome)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Setor WHERE nome = @nome";
            cmd.Parameters.AddWithValue("@nome", nome);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Departamento obj = new Departamento();
            if (dr.HasRows)
            {
                return true;
            }
            return false;
        }
        public List<Setor> findAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Setor";
            SqlDataReader dr = Conexao.selecionar(cmd);
            List<Setor> objs = new List<Setor>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dr.Read();
                    Setor obj = new Setor();
                    obj.Id = (int)dr["id"];
                    obj.Nome = dr["nome"].ToString();
                    obj.Descricao = dr["descricao"].ToString();
                    obj.SubDepartamento = SubdepartamentoDAO.findById((int)dr["fk_sub_departamento"]);
                    obj.QtdEstoque = (int)dr["qtd_estoque"];
                    objs.Add(obj);
                }
            }
            else
            {
                objs = null;
            }
            return objs;
        }
        public static DataTable returnDataSource()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Setor";
            SqlDataReader dr = Conexao.selecionar(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Conexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
