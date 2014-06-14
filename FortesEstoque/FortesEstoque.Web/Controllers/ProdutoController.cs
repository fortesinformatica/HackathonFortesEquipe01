using FortesEstoque.Business;
using FortesEstoque.DAO;
using FortesEstoque.Web.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FortesEstoque.Web.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(string inputNome, int inputQtdMinima, int inputQtd, int inputConsumivel)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Movimentar()
        {
            ViewBag.setores = DropDown.Setores();
            ViewBag.operacoes = DropDown.Operacoes();
            ViewBag.produtos = DropDown.Produtos();
            return View();
        }

        [HttpPost]
        public ActionResult Movimentar(ProdutoHistorico produtoHistorico)
        {
            ProdutoBusiness produtoBusiness = new ProdutoBusiness();
            try
            {
                produtoBusiness.Movimentar(produtoHistorico);
                var retorno = new { sucesso = true, mensagem = "Movimentação Cadastrada com Sucesso." };
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                var retorno = new { sucesso = false, mensagem = ex.Message };
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult Consultar(int produto)
        {
            ProdutoBusiness produtoBusiness = new ProdutoBusiness();
            List<ProdutoHistorico> movimentacoes;
            try
            {
                movimentacoes = produtoBusiness.ConsultarMovimentacoes(produto);
                return View(movimentacoes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}