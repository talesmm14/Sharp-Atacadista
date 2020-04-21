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
    public class HistoricoDAO
    {
        public Historico insert(Historico historico)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Historico(datetime, operacao, fk_id_lote, tipo_estoque, validade, peso_kg, valor_compra, qtd_estoque, fk_item, fk_fornecedor, fk_empregado, data_entrada, data_fabricacao, codigo) output INSERTED.id " +
                                      "values (@datetime, @operacao, @fk_id_lote, @tipo_estoque, @dias_validade, @peso_kg, @valor_compra, @qtd_estoque, @fk_item, @fk_fornecedor, @fk_empregado, @data_entrada, @data_fabricacao, @codigo)";
            cmd.Parameters.AddWithValue("@datetime", historico.Datetime);
            cmd.Parameters.AddWithValue("@operacao", historico.Operacao);
            cmd.Parameters.AddWithValue("@fk_id_lote", historico.Lote.Id);
            cmd.Parameters.AddWithValue("@tipo_estoque", historico.Lote.Tipo_estoque);
            cmd.Parameters.AddWithValue("@dias_validade", historico.Lote.Dias_validade);
            cmd.Parameters.AddWithValue("@peso_kg", historico.Lote.Peso_kg);
            cmd.Parameters.AddWithValue("@valor_compra", historico.Lote.Valor_compra);
            cmd.Parameters.AddWithValue("@qtd_estoque", historico.Lote.Qtd_estoque);
            cmd.Parameters.AddWithValue("@fk_item", historico.Lote.Item.Id);
            cmd.Parameters.AddWithValue("@fk_fornecedor", historico.Lote.Fornecedor.Id);
            cmd.Parameters.AddWithValue("@fk_empregado", historico.Empregado.Id);
            cmd.Parameters.AddWithValue("@data_fabricacao", historico.Lote.DataFabricacao);
            cmd.Parameters.AddWithValue("@data_entrada", historico.Lote.DataEntrada);
            cmd.Parameters.AddWithValue("@codigo", historico.Lote.Codigo);
            if (Conexao.CRUD(cmd))
                return historico;
            return null;
        }
       public Historico update(Historico historico)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Historico set datetime = @datetime, operacao = @operacao, fk_id_lote = @fk_id_lote, " +
                "tipo_estoque = @tipo_estoque, validade = @dias_validade, peso_kg = @peso_kg, valor_compra = @valor_compra," +
                "qtd_estoque = @qtd_estoque, fk_item = @fk_item, fk_fornecedor = @fk_fornecedor, fk_empregado = @fk_empregado," +
                " data_entrada = @data_entrada, data_fabricacao = @data_fabricacao, codigo = @codigo,  id = @id where id = @id";
            cmd.Parameters.AddWithValue("@id", historico.Id);
            cmd.Parameters.AddWithValue("@datetime", historico.Datetime);
            cmd.Parameters.AddWithValue("@operacao", historico.Operacao);
            cmd.Parameters.AddWithValue("@fk_id_lote", historico.Lote.Id);
            cmd.Parameters.AddWithValue("@tipo_estoque", historico.Lote.Tipo_estoque);
            cmd.Parameters.AddWithValue("@dias_validade", historico.Lote.Dias_validade);
            cmd.Parameters.AddWithValue("@peso_kg", historico.Lote.Peso_kg);
            cmd.Parameters.AddWithValue("@valor_compra", historico.Lote.Valor_compra);
            cmd.Parameters.AddWithValue("@qtd_estoque", historico.Lote.Qtd_estoque);
            cmd.Parameters.AddWithValue("@fk_item", historico.Lote.Item.Id);
            cmd.Parameters.AddWithValue("@fk_fornecedor", historico.Lote.Fornecedor.Id);
            cmd.Parameters.AddWithValue("@fk_empregado", historico.Empregado.Id);
            cmd.Parameters.AddWithValue("@data_fabricacao", historico.Lote.DataFabricacao);
            cmd.Parameters.AddWithValue("@data_entrada", historico.Lote.DataEntrada);
            cmd.Parameters.AddWithValue("@codigo", historico.Lote.Codigo);
            if (Conexao.CRUD(cmd))
                return historico;
            return null;
        }
        public void delete(Historico historico)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Historico WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", historico.Id);
            Conexao.CRUD(cmd);
        }
        public Historico findById(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Historico WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = Conexao.selecionar(cmd);

            Historico obj = new Historico();
            if (dr.HasRows)
            {
                dr.Read();
                obj.Id = (int)dr["id"];
                obj.Datetime = (DateTime)dr["datetime"];
                obj.Operacao = dr["operacao"].ToString();
                obj.Lote.Id = (int)dr["fk_id_lote"];
                obj.Lote.Tipo_estoque = dr["tipo_estoque"].ToString();
                obj.Lote.Dias_validade = (DateTime)dr["validade"];
                obj.Lote.Peso_kg = (Decimal)dr["peso_kg"];
                obj.Lote.Valor_compra = (Decimal)dr["valor_compra"];
                obj.Lote.Qtd_estoque = (int)dr["qtd_estoque"];
                obj.Lote.Item = ItemDAO.findById((int)dr["fk_item"]);
                obj.Lote.Fornecedor = FornecedorDAO.findById((int)dr["fk_fornecedor"]);
                obj.Empregado = EmpregadoDAO.findById((int)dr["fk_empregado"]);
                obj.Lote.DataEntrada = (DateTime)dr["data_entrada"];
                obj.Lote.DataFabricacao = (DateTime)dr["data_fabricacao"];
                obj.Lote.Codigo = (String)dr["codigo"];
            }
            else
            {
                obj = null;
            }
            return obj;
        }
        public List<Historico> findAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Historico";
            SqlDataReader dr = Conexao.selecionar(cmd);
            List<Historico> objs = new List<Historico>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dr.Read();
                    Historico obj = new Historico();
                    obj.Id = (int)dr["id"];
                    obj.Datetime = (DateTime)dr["datetime"];
                    obj.Operacao = dr["operacao"].ToString();
                    obj.Lote.Id = (int)dr["fk_id_lote"];
                    obj.Lote.Tipo_estoque = dr["tipo_estoque"].ToString();
                    obj.Lote.Dias_validade = (DateTime)dr["validade"];
                    obj.Lote.Peso_kg = (Decimal)dr["peso_kg"];
                    obj.Lote.Valor_compra = (Decimal)dr["valor_compra"];
                    obj.Lote.Qtd_estoque = (int)dr["qtd_estoque"];
                    obj.Lote.Item = ItemDAO.findById((int)dr["fk_item"]);
                    obj.Lote.Fornecedor = FornecedorDAO.findById((int)dr["fk_fornecedor"]);
                    obj.Empregado = EmpregadoDAO.findById((int)dr["fk_empregado"]);
                    obj.Lote.DataEntrada = (DateTime)dr["data_entrada"];
                    obj.Lote.DataFabricacao = (DateTime)dr["data_fabricacao"];
                    obj.Lote.Codigo = (String)dr["codigo"];
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
            cmd.CommandText = "SELECT * FROM Historico";
            SqlDataReader dr = Conexao.selecionar(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Conexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
