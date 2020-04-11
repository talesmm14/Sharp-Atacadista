using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_A1_Supermecado.Classes
{
    public class Historico
    {
        private int id;
        private Empregado empregado;
        private DateTime datetime;
        private String operacao;
        private Lote lote;

        public int Id { get => id; set => id = value; }
        public Empregado Empregado { get => empregado; set => empregado = value; }
        public DateTime Datetime { get => datetime; set => datetime = value; }
        public string Operacao { get => operacao; set => operacao = value; }
        public Lote Lote { get => lote; set => lote = value; }
    }
}
