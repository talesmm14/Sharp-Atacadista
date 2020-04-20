using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_A1_Supermecado.Classes;
using Trabalho_A1_Supermecado.DAO;

namespace Trabalho_A1_Supermecado.Controller
{
    public static class Sessao
    {
        private static int _usuarioId;
        private static String _nomeUsuario;
        private static String _funcaoUsuario;

        //get e set
        public static int UsuarioId
        {
            get { return Sessao._usuarioId; }
            set { Sessao._usuarioId = value; }
        }
        public static String NomeUsuario
        {
            get { return Sessao._nomeUsuario; }
            set { Sessao._nomeUsuario = value; }
        }
        public static String FuncaoUsuario
        {
            get { return Sessao._funcaoUsuario; }
            set { Sessao._funcaoUsuario = value; }
        }

        public static Empregado login(String cpf, String senha)
        {
            Empregado user = EmpregadoDAO.authenticated(cpf, senha);
            if (user != null)
            {
                Sessao.NomeUsuario = user.NomeCompleto;
                Sessao.UsuarioId = user.Id;
                Sessao.FuncaoUsuario = user.Funcao;
                return user;
            }
            return null;
        }
        public static void logout()
        {
            Sessao.NomeUsuario = null;
            Sessao.UsuarioId = 0;
            Sessao.FuncaoUsuario = null;
        }
        public static Boolean active()
        {
            if (Sessao.NomeUsuario != null && Sessao.UsuarioId > 0)
                return true;
            return false;
        }
    }
}
