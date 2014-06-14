using FortesEstoque.Business;
using FortesEstoque.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FortesEstoque.Web.Classes
{
    public class DropDown
    {
        public static SelectList Produtos()
        {
            ProdutoBusiness produtoBusiness = new ProdutoBusiness();
            List<Produto> produtos;
            try
            {
                produtos = produtoBusiness.Consultar();
                produtos.Insert(0,new Produto() { Id = 0, Nome = "Selecione..." });
                return new SelectList(produtos, "Id", "Nome");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static SelectList Setores()
        {
            SetorBusiness setorBusiness = new SetorBusiness();
            List<Setor> setores;
            try
            {
                setores = setorBusiness.Consultar();
                setores.Insert(0,new Setor() { Id = 0, Nome = "Selecione..." });
                return new SelectList(setores, "Id", "Nome");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static SelectList Operacoes()
        {
            Dictionary<string, string> operacoes = new Dictionary<string, string>();
            operacoes.Add("Selecione...", "Selecione...");
            operacoes.Add("E", "Entrada");
            operacoes.Add("S", "Saídas");
            return new SelectList(operacoes, "key", "value");
        }

    }
}