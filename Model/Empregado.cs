using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_A1_Supermecado.Classes
{
    public class Empregado
    {
        private int id;
        private String nomeCompleto;
        private String funcao;
        private String cpf;
        private String senha;

        public int Id { get => id; set => id = value; }
        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public string Funcao { get => funcao; set => funcao = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Senha { get => senha; set => senha = value; }

    }
}
