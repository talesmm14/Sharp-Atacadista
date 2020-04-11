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
        private int dias_validade;
        private float peso_kg;
        private float valor_compra;
        private int qtd_estoque;
        private Fornecedor fornecedor;
        private Item item;

        public int Id { get => id; set => id = value; }
        public string Tipo_estoque { get => tipo_estoque; set => tipo_estoque = value; }
        public int Dias_validade { get => dias_validade; set => dias_validade = value; }
        public float Peso_kg { get => peso_kg; set => peso_kg = value; }
        public float Valor_compra { get => valor_compra; set => valor_compra = value; }
        public int Qtd_estoque { get => qtd_estoque; set => qtd_estoque = value; }
        public Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }
        public Item Item { get => item; set => item = value; }
    }
}
