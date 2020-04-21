using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_A1_Supermecado.Classes;
using Trabalho_A1_Supermecado.DAO;

namespace Trabalho_A1_Supermecado.Controller
{
    class EntradaController
    {
        public Boolean cadastrarLote(Lote obj)
        {
            LoteDAO dao = new LoteDAO();
            if (obj.Id != 0)
            {
                dao.update(obj);
                historico(obj, "UPDATE");
                return true;
            }
            else
            {
                obj.DataEntrada = DateTime.Now;
                dao.insert(obj);
                historico(LoteDAO.findByCode(obj.Codigo), "INSERT");
                return true;
            }
        }
        public void historico(Lote obj, String op)
        {
            HistoricoDAO dao = new HistoricoDAO();
            Historico his = new Historico();
            his.Lote = obj;
            his.Operacao = op;
            his.Empregado = EmpregadoDAO.findById(Sessao.UsuarioId);
            his.Datetime = DateTime.Now;
            dao.insert(his);
        }
    }
}
