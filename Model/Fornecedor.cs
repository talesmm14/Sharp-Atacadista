using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_A1_Supermecado.Classes
{
    public class Fornecedor
    {
        private int id;
        private String nome;
        private String descricao;
        private String cnpj;
        private String endereco;
        private String telefone;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
