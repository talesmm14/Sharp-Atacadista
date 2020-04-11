using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_A1_Supermecado.Classes
{
    public class Item
    {
        private int id;
        private String nome;
        private String complemento;
        private String imagem;
        private int qtdEstoque;
        private Marca marca;
        private Setor setor;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Imagem { get => imagem; set => imagem = value; }
        public int QtdEstoque { get => qtdEstoque; set => qtdEstoque = value; }
        public Marca Marca { get => marca; set => marca = value; }
        public Setor Setor { get => setor; set => setor = value; }
    }
}
