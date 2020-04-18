using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_A1_Supermecado.Classes
{
    public class Lote
    {
        private int id;
        private String tipo_estoque;
        private DateTime dias_validade;
        private Decimal peso_kg;
        private Decimal valor_compra;
        private int qtd_estoque;
        private Fornecedor fornecedor;
        private Item item;
        private DateTime dataEntrada;
        private DateTime dataFabricacao;
        private String codigo;

        public int Id { get => id; set => id = value; }
        public string Tipo_estoque { get => tipo_estoque; set => tipo_estoque = value; }
        public DateTime Dias_validade { get => dias_validade; set => dias_validade = value; }
        public Decimal Peso_kg { get => peso_kg; set => peso_kg = value; }
        public Decimal Valor_compra { get => valor_compra; set => valor_compra = value; }
        public int Qtd_estoque { get => qtd_estoque; set => qtd_estoque = value; }
        public Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }
        public Item Item { get => item; set => item = value; }
        public DateTime DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public DateTime DataFabricacao { get => dataFabricacao; set => dataFabricacao = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
