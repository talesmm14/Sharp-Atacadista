using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_A1_Supermecado.Classes;
using Trabalho_A1_Supermecado.DAO;

namespace Trabalho_A1_Supermecado.Controller
{
    class MovimentacoesController
    {
        public Lote CadastrarItem(Lote obj)
        {
            if (obj.Item != null || obj.Fornecedor != null)
            {
                LoteDAO dao = new LoteDAO();
                if (obj.Id != 0)
                {
                    return dao.update(obj);
                }
                return dao.insert(obj);
            }
            return null;
        }

        public Historico CadastrarHistorico(Historico obj)
        {
            if (obj.Empregado != null || obj.Lote != null)
            {
                HistoricoDAO dao = new HistoricoDAO();
                if (obj.Id != 0)
                {
                    return dao.update(obj);
                }
                return dao.insert(obj);
            }
            return null;
        }
    }
}
