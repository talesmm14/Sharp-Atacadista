using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_A1_Supermecado.Classes;
using Trabalho_A1_Supermecado.DAO;

namespace Trabalho_A1_Supermecado.Controller
{
    public class CadastrosController
    {
        public Departamento cadastrarDepartamento(Departamento obj)
        {
            DepartamentoDAO dao = new DepartamentoDAO();
            if (obj.Id != 0)
            {
                return dao.update(obj);
            }
            return dao.insert(obj);
        }
        public Subdepartamento CadastrarSubDepartamento(Subdepartamento obj)
        {
            if (obj.Departamento != null)
            {
                SubdepartamentoDAO dao = new SubdepartamentoDAO();
                if (obj.Id != 0)
                {
                    return dao.update(obj);
                }
                return dao.insert(obj);
            }
            return null;
        }
        public Setor CadastrarSetor(Setor obj)
        {
            if (obj.SubDepartamento != null)
            {
                SetorDAO dao = new SetorDAO();
                if (obj.Id != 0)
                {
                    return dao.update(obj);
                }
                return dao.insert(obj);
            }
            return null;
        }
        public Marca CadastrarMarca(Marca obj)
        {
            MarcaDAO dao = new MarcaDAO();
            if (obj.Id != 0)
            {
                return dao.update(obj);
            }
            return dao.insert(obj);
        }
        public Fornecedor CadastrarFornecedor(Fornecedor obj)
        {
            FornecedorDAO dao = new FornecedorDAO();
            if (obj.Id != 0)
            {
                return dao.update(obj);
            }
            return dao.insert(obj);
        }
        public Item CadastrarItem(Item obj)
        {
            if (obj.Marca != null || obj.Setor != null)
            {
                ItemDAO dao = new ItemDAO();
                if (obj.Id != 0)
                {
                    return dao.update(obj);
                }
                return dao.insert(obj);
            }
            return null;
        }
        public Empregado CadastrarFuncionario(Empregado obj)
        {
            EmpregadoDAO dao = new EmpregadoDAO();
            if (obj.Id != 0)
            {
                return dao.update(obj);
            }
            return dao.insert(obj);
        }
        public Departamento deletarDepartamento(Departamento obj)
        {
            DepartamentoDAO dao = new DepartamentoDAO();
            return dao.delete(obj);
        }
        public Subdepartamento deletarSubDepartamento(Subdepartamento obj)
        {
               SubdepartamentoDAO dao = new SubdepartamentoDAO();
               return dao.delete(obj);
        }
        public Setor deletarSetor(Setor obj)
        {
                SetorDAO dao = new SetorDAO();
                return dao.delete(obj);
        }
        public Marca deletarMarca(Marca obj)
        {
            MarcaDAO dao = new MarcaDAO();
            return dao.delete(obj);
        }
        public Fornecedor deletarFornecedor(Fornecedor obj)
        {
            FornecedorDAO dao = new FornecedorDAO();
            return dao.delete(obj);
        }
        public Item deletarItem(Item obj)
        {
                ItemDAO dao = new ItemDAO();
                return dao.delete(obj);
        }
        public Empregado deletarFuncionario(Empregado obj)
        {
            EmpregadoDAO dao = new EmpregadoDAO();
            return dao.delete(obj);
        }
    }
}
