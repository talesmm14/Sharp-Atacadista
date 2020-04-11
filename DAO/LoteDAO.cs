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
    public class LoteDAO
    {
        public Lote insert(Lote lote)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Lote(tipo_estoque, dias_validade, peso_kg, valor_compra, qtd_estoque, fk_item, fk_fornecedor) output INSERTED.id " +
                                      "values (@tipo_estoque, @dias_validade, @peso_kg, @valor_compra, @qtd_estoque, @fk_item, @fk_fornecedor)";
            cmd.Parameters.AddWithValue("@tipo_estoque", lote.Tipo_estoque);
            cmd.Parameters.AddWithValue("@dias_validade", lote.Dias_validade);
            cmd.Parameters.AddWithValue("@peso_kg", lote.Peso_kg);
            cmd.Parameters.AddWithValue("@valor_compra", lote.Valor_compra);
            cmd.Parameters.AddWithValue("@qtd_estoque", lote.Qtd_estoque);
            cmd.Parameters.AddWithValue("@fk_item", lote.Item.Id);
            cmd.Parameters.AddWithValue("@fk_fornecedor", lote.Fornecedor.Id);
            if (Conexao.CRUD(cmd))
                return lote;
            return null;
        }
        public Lote update(Lote lote)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Lote set tipo_estoque = @tipo_estoque, dias_validade = @dias_validade, peso_kg = @peso_kg, " +
                "valor_compra = @valor_compra, qtd_estoque = @qtd_estoque, fk_item = @fk_item, fk_fornecedor = @fk_fornecedor, id = @id where id = @id";
            cmd.Parameters.AddWithValue("@id", lote.Id);
            cmd.Parameters.AddWithValue("@tipo_estoque", lote.Tipo_estoque);
            cmd.Parameters.AddWithValue("@dias_validade", lote.Dias_validade);
            cmd.Parameters.AddWithValue("@peso_kg", lote.Peso_kg);
            cmd.Parameters.AddWithValue("@valor_compra", lote.Valor_compra);
            cmd.Parameters.AddWithValue("@qtd_estoque", lote.Qtd_estoque);
            cmd.Parameters.AddWithValue("@fk_item", lote.Item.Id);
            cmd.Parameters.AddWithValue("@fk_fornecedor", lote.Fornecedor.Id);
            if (Conexao.CRUD(cmd))
                return lote;
            return null;
        }
        public void delete(Lote lote)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Lote WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", lote.Id);
            Conexao.CRUD(cmd);
        }
        public static Lote findById(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Lote WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Lote obj = new Lote();
            if (dr.HasRows)
            {
                dr.Read();
                obj.Id = (int)dr["id"];
                obj.Tipo_estoque = dr["tipo_estoque"].ToString();
                obj.Dias_validade = (int)dr["dias_validade"];
                obj.Peso_kg = (float)dr["peso_kg"];
                obj.Valor_compra = (float)dr["valor_compra"];
                obj.Qtd_estoque = (int)dr["qtd_estoque"];
                obj.Item = ItemDAO.findById((int)dr["fk_item"]);
                obj.Fornecedor = FornecedorDAO.findById((int)dr["fk_fornecedor"]);
            }
            else
            {
                obj = null;
            }
            return obj;
        }
        public List<Lote> findAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Lote";
            SqlDataReader dr = Conexao.selecionar(cmd);
            List<Lote> objs = new List<Lote>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dr.Read();
                    Lote obj = new Lote();
                    obj.Id = (int)dr["id"];
                    obj.Tipo_estoque = dr["tipo_estoque"].ToString();
                    obj.Dias_validade = (int)dr["dias_validade"];
                    obj.Peso_kg = (float)dr["peso_kg"];
                    obj.Valor_compra = (float)dr["valor_compra"];
                    obj.Qtd_estoque = (int)dr["qtd_estoque"];
                    obj.Item = ItemDAO.findById((int)dr["fk_item"]);
                    obj.Fornecedor = FornecedorDAO.findById((int)dr["fk_fornecedor"]);
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
            cmd.CommandText = "SELECT * FROM Lote";
            SqlDataReader dr = Conexao.selecionar(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Conexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
