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
    public class DepartamentoDAO
    {
        public Departamento insert(Departamento departamento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Departamento(nome, descricao ) output INSERTED.id values (@nome, @descricao)";
            cmd.Parameters.AddWithValue("@nome", departamento.Nome);
            cmd.Parameters.AddWithValue("@descricao", departamento.Descricao);
            if (Conexao.CRUD(cmd))
                return departamento;
            return null;
        }
        public Departamento update(Departamento departamento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Departamento set nome = @nome, descricao = @descricao where id = @id";
            cmd.Parameters.AddWithValue("@id", departamento.Id);
            cmd.Parameters.AddWithValue("@nome", departamento.Nome);
            cmd.Parameters.AddWithValue("@descricao", departamento.Descricao);
            if (Conexao.CRUD(cmd))
                return departamento;
            return null;
        }
        public Departamento delete(Departamento departamento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Departamento WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", departamento.Id);
            if (Conexao.CRUD(cmd))
                return departamento;
            return null;
        }
        public static Departamento findById(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Departamento WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Departamento obj = new Departamento();
            if (dr.HasRows)
            {
                dr.Read();
                obj.Id = (int)dr["id"];
                obj.Nome = dr["nome"].ToString();
                obj.Descricao = dr["descricao"].ToString();
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
            cmd.CommandText = "SELECT * FROM Departamento WHERE nome = @nome";
            cmd.Parameters.AddWithValue("@nome", nome);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Departamento obj = new Departamento();
            if (dr.HasRows)
            {
                return true;
            }
            return false;
        }
        public List<Departamento> findAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Departamento";
            SqlDataReader dr = Conexao.selecionar(cmd);
            List<Departamento> objs = new List<Departamento>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dr.Read();
                    Departamento obj = new Departamento();
                    obj.Id = (int)dr["id"];
                    obj.Nome = dr["nome"].ToString();
                    obj.Descricao = dr["descricao"].ToString();
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
            cmd.CommandText = "SELECT * FROM Departamento";
            SqlDataReader dr = Conexao.selecionar(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Conexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
