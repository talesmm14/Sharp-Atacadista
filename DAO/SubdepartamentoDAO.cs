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
    public class SubdepartamentoDAO
    {
        public Subdepartamento insert(Subdepartamento subdepartamento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Sub_departamento(nome, descricao, fk_departamento) output INSERTED.id values (@nome, @descricao, @fk_departamento)";
            cmd.Parameters.AddWithValue("@nome", subdepartamento.Nome);
            cmd.Parameters.AddWithValue("@descricao", subdepartamento.Descricao);
            cmd.Parameters.AddWithValue("@fk_departamento", subdepartamento.Departamento.Id);
            if (Conexao.CRUD(cmd))
                return subdepartamento;
            return null;
        }
        public Subdepartamento update(Subdepartamento subdepartamento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Sub_departamento set nome = @nome, descricao = @descricao, fk_departamento = @fk_departamento, id = @id where id = @id";
            cmd.Parameters.AddWithValue("@id", subdepartamento.Id);
            cmd.Parameters.AddWithValue("@nome", subdepartamento.Nome);
            cmd.Parameters.AddWithValue("@descricao", subdepartamento.Descricao);
            cmd.Parameters.AddWithValue("@fk_departamento", subdepartamento.Departamento.Id);
            if (Conexao.CRUD(cmd))
                return subdepartamento;
            return null;
        }
        public void delete(Subdepartamento subdepartamento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Sub_departamento WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", subdepartamento.Id);
            Conexao.CRUD(cmd);
        }
        public static Subdepartamento findById(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Sub_departamento WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Subdepartamento obj = new Subdepartamento();
            if (dr.HasRows)
            {
                dr.Read();
                obj.Id = (int)dr["id"];
                obj.Nome = dr["nome"].ToString();
                obj.Descricao = dr["descricao"].ToString();
                obj.Departamento = DepartamentoDAO.findById((int) dr["fk_departamento"]);
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
            cmd.CommandText = "SELECT * FROM Sub_departamento WHERE nome = @nome";
            cmd.Parameters.AddWithValue("@nome", nome);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Departamento obj = new Departamento();
            if (dr.HasRows)
            {
                return true;
            }
            return false;
        }
        public List<Subdepartamento> findAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Sub_departamento";
            SqlDataReader dr = Conexao.selecionar(cmd);
            List<Subdepartamento> objs = new List<Subdepartamento>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dr.Read();
                    Subdepartamento obj = new Subdepartamento();
                    obj.Id = (int)dr["id"];
                    obj.Nome = dr["nome"].ToString();
                    obj.Descricao = dr["descricao"].ToString();
                    obj.Departamento = DepartamentoDAO.findById((int)dr["fk_departamento"]);
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
            cmd.CommandText = "SELECT * FROM Sub_departamento";
            SqlDataReader dr = Conexao.selecionar(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Conexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
