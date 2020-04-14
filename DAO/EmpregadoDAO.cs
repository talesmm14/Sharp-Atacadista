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
    public class EmpregadoDAO
    {
        public Empregado insert(Empregado empregado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Empregado(nome_completo, cpf, senha, funcao ) output INSERTED.id values (@nome_completo, @cpf, @senha, @funcao)";
            cmd.Parameters.AddWithValue("@nome_completo", empregado.NomeCompleto);
            cmd.Parameters.AddWithValue("@cpf", empregado.Cpf);
            cmd.Parameters.AddWithValue("@senha", empregado.Senha);
            cmd.Parameters.AddWithValue("@funcao", empregado.Funcao);
            if (Conexao.CRUD(cmd))
                return empregado;
            return null;
        }
        public Empregado update(Empregado empregado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Empregado set nome_completo = @nome_completo, cpf = @cpf, senha = @senha, funcao = @funcao, id = @id where id = @id";
            cmd.Parameters.AddWithValue("@id", empregado.Id);
            cmd.Parameters.AddWithValue("@nome_completo", empregado.NomeCompleto);
            cmd.Parameters.AddWithValue("@cpf", empregado.Cpf);
            cmd.Parameters.AddWithValue("@senha", empregado.Senha);
            cmd.Parameters.AddWithValue("@funcao", empregado.Funcao);
            if (Conexao.CRUD(cmd))
                return empregado;
            return null;
        }
        public void delete(Empregado empregado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Empregado WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", empregado.Id);
            Conexao.CRUD(cmd);
        }
        public static Empregado findById(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Empregado WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Empregado obj = new Empregado();
            if (dr.HasRows)
            {
                dr.Read();
                obj.Id = (int)dr["id"];
                obj.NomeCompleto = dr["nome_completo"].ToString();
                obj.Cpf = dr["cpf"].ToString();
                obj.Senha = dr["senha"].ToString();
                obj.Funcao = dr["funcao"].ToString();
            }
            else
            {
                obj = null;
            }
            return obj;
        }
        public List<Empregado> findAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Empregado";
            SqlDataReader dr = Conexao.selecionar(cmd);
            List<Empregado> objs = new List<Empregado>();
            EmpregadoDAO objDAO = new EmpregadoDAO();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dr.Read();
                    Empregado obj = new Empregado();
                    obj.Id = (int)dr["id"];
                    obj.NomeCompleto = dr["nome_completo"].ToString();
                    obj.Cpf = dr["cpf"].ToString();
                    obj.Senha = dr["senha"].ToString();
                    obj.Funcao = dr["funcao"].ToString();
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
            cmd.CommandText = "SELECT * FROM Empregado";
            SqlDataReader dr = Conexao.selecionar(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Conexao.conectar());
            da.Fill(dt);
            return dt;
        }
        public static Empregado authenticated(String cpf, String senha)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Empregado WHERE cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Empregado obj = new Empregado();
            if (dr.HasRows)
            {
                dr.Read();
                obj.Id = (int)dr["id"];
                obj.NomeCompleto = dr["nome_completo"].ToString();
                obj.Cpf = dr["cpf"].ToString();
                obj.Senha = dr["senha"].ToString();
                obj.Funcao = dr["funcao"].ToString();
                if (senha != obj.Senha)
                {
                    obj = null;
                }
            }
            else
            {
                obj = null;
            }
            return obj;
        }
    }
}
