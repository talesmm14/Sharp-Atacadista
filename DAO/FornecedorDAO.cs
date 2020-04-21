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
    public class FornecedorDAO
    {
        public Fornecedor insert(Fornecedor fornecedor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Fornecedor(nome, complemento, cnpj, endereco, telefone) output INSERTED.id values (@nome, @complemento, @cnpj, @endereco, @telefone)";
            cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
            cmd.Parameters.AddWithValue("@complemento", fornecedor.Descricao);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            cmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
            cmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
            if (Conexao.CRUD(cmd))
                return fornecedor;
            return null;
        }
        public Fornecedor update(Fornecedor fornecedor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Fornecedor set nome = @nome, complemento = @complemento, cnpj = @cnpj, endereco = @endereco, telefone = @telefone where id = @id";
            cmd.Parameters.AddWithValue("@id", fornecedor.Id);
            cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
            cmd.Parameters.AddWithValue("@complemento", fornecedor.Descricao);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            cmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
            cmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
            if (Conexao.CRUD(cmd))
                return fornecedor;
            return null;
        }
        public Fornecedor delete(Fornecedor fornecedor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Fornecedor WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", fornecedor.Id);
            if (Conexao.CRUD(cmd))
                return fornecedor;
            return null;
        }
        public static Fornecedor findById(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Fornecedor WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Fornecedor obj = new Fornecedor();
            if (dr.HasRows)
            {
                dr.Read();
                obj.Id = (int)dr["id"];
                obj.Nome = dr["nome"].ToString();
                obj.Descricao = dr["complemento"].ToString();
                obj.Cnpj = dr["cnpj"].ToString();
                obj.Endereco = dr["endereco"].ToString();
                obj.Telefone = dr["telefone"].ToString();
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
            cmd.CommandText = "SELECT * FROM Fornecedor WHERE nome = @nome";
            cmd.Parameters.AddWithValue("@nome", nome);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Departamento obj = new Departamento();
            if (dr.HasRows)
            {
                return true;
            }
            return false;
        }
        public List<Fornecedor> findAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Fornecedor";
            SqlDataReader dr = Conexao.selecionar(cmd);
            List<Fornecedor> objs = new List<Fornecedor>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dr.Read();
                    Fornecedor obj = new Fornecedor();
                    obj.Id = (int)dr["id"];
                    obj.Nome = dr["nome"].ToString();
                    obj.Descricao = dr["complemento"].ToString();
                    obj.Cnpj = dr["cnpj"].ToString();
                    obj.Endereco = dr["endereco"].ToString();
                    obj.Telefone = dr["telefone"].ToString();
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
            cmd.CommandText = "SELECT * FROM Fornecedor";
            SqlDataReader dr = Conexao.selecionar(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Conexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
