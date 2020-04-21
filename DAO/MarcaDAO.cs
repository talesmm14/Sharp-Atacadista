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
    public class MarcaDAO
    {
        public Marca insert(Marca marca)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Marca(nome, complemento, cnpj, endereco, telefone) output INSERTED.id values (@nome, @complemento, @cnpj, @endereco, @telefone)";
            cmd.Parameters.AddWithValue("@nome", marca.Nome);
            cmd.Parameters.AddWithValue("@complemento", marca.Descricao);
            cmd.Parameters.AddWithValue("@cnpj", marca.Cnpj);
            cmd.Parameters.AddWithValue("@endereco", marca.Endereco);
            cmd.Parameters.AddWithValue("@telefone", marca.Telefone);
            if (Conexao.CRUD(cmd))
                return marca;
            return null;
        }
        public Marca update(Marca marca)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Marca set nome = @nome, complemento = @complemento, cnpj = @cnpj, endereco = @endereco, telefone = @telefone, id = @id where id = @id";
            cmd.Parameters.AddWithValue("@id", marca.Id);
            cmd.Parameters.AddWithValue("@nome", marca.Nome);
            cmd.Parameters.AddWithValue("@complemento", marca.Descricao);
            cmd.Parameters.AddWithValue("@cnpj", marca.Cnpj);
            cmd.Parameters.AddWithValue("@endereco", marca.Endereco);
            cmd.Parameters.AddWithValue("@telefone", marca.Telefone);
            if (Conexao.CRUD(cmd))
                return marca;
            return null;
        }
        public void delete(Marca marca)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Marca WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", marca.Id);
            Conexao.CRUD(cmd);
        }
        public static Marca findById(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Marca WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Marca obj = new Marca();
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
            cmd.CommandText = "SELECT * FROM Marca WHERE nome = @nome";
            cmd.Parameters.AddWithValue("@nome", nome);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Departamento obj = new Departamento();
            if (dr.HasRows)
            {
                return true;
            }
            return false;
        }
        public List<Marca> findAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Marca";
            SqlDataReader dr = Conexao.selecionar(cmd);
            List<Marca> objs = new List<Marca>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dr.Read();
                    Marca obj = new Marca();
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
            cmd.CommandText = "SELECT * FROM Marca";
            SqlDataReader dr = Conexao.selecionar(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Conexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
