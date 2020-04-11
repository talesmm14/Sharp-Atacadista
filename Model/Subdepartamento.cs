using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_A1_Supermecado.Classes
{
    public class Subdepartamento
    {
        private int id;
        private String nome;
        private String descricao;
        private Departamento departamento;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Departamento Departamento { get => departamento; set => departamento = value; }
    }
}
