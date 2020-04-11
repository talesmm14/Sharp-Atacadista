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
    public class ItemDAO
    {
        public Item insert(Item item)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Item(nome, complemento, imagem, qtd_estoque, fk_marca, fk_setor)" +
                  " output INSERTED.id values (@nome,@complemento,@imagem,@qtd_estoque,@fk_marca,@fk_setor)";
            cmd.Parameters.AddWithValue("@nome", item.Nome);
            cmd.Parameters.AddWithValue("@complemento", item.Complemento);
            cmd.Parameters.AddWithValue("@imagem", item.Imagem);
            cmd.Parameters.AddWithValue("@qtd_estoque", item.QtdEstoque);
            cmd.Parameters.AddWithValue("@fk_marca", item.Marca.Id);
            cmd.Parameters.AddWithValue("@fk_setor", item.Setor.Id);
            if (Conexao.CRUD(cmd))
                return item;
            return null;
        }
        public Item update(Item item)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Item set nome = @nome, complemento = @complemento, imagem = @imagem, qtd_estoque = @qtd_estoque, fk_marca = @fk_marca, fk_setor = @fk_setor, id = @id where id = @id";
            cmd.Parameters.AddWithValue("@id", item.Id);
            cmd.Parameters.AddWithValue("@nome", item.Nome);
            cmd.Parameters.AddWithValue("@complemento", item.Complemento);
            cmd.Parameters.AddWithValue("@imagem", item.Imagem);
            cmd.Parameters.AddWithValue("@qtd_estoque", item.QtdEstoque);
            cmd.Parameters.AddWithValue("@fk_marca", item.Marca.Id);
            cmd.Parameters.AddWithValue("@fk_setor", item.Setor.Id);
            if (Conexao.CRUD(cmd))
                return item;
            return null;
        }
        public void delete(Item item)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Item WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", item.Id);
            Conexao.CRUD(cmd);
        }
        public static Item findById(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Item WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Item obj = new Item();
            if (dr.HasRows)
            {
                dr.Read();
                obj.Id = (int)dr["id"];
                obj.Nome = dr["nome"].ToString();
                obj.Complemento = dr["complemento"].ToString();
                obj.Imagem = dr["imagem"].ToString();
                obj.QtdEstoque = (int)dr["qtd_estoque"];
                obj.Marca = MarcaDAO.findById((int)dr["fk_marca"]);
                obj.Setor = SetorDAO.findById((int)dr["fk_setor"]);
            }
            else
            {
                obj = null;
            }
            return obj;
        }
        public List<Item> findAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Item";
            SqlDataReader dr = Conexao.selecionar(cmd);
            List<Item> objs = new List<Item>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dr.Read();
                    Item obj = new Item();
                    obj.Id = (int)dr["id"];
                    obj.Nome = dr["nome"].ToString();
                    obj.Complemento = dr["complemento"].ToString();
                    obj.Imagem = dr["imagem"].ToString();
                    obj.QtdEstoque = (int)dr["qtd_estoque"];
                    obj.Marca = MarcaDAO.findById((int)dr["fk_marca"]);
                    obj.Setor = SetorDAO.findById((int)dr["fk_setor"]);
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
            cmd.CommandText = "SELECT * FROM Item";
            SqlDataReader dr = Conexao.selecionar(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Conexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
