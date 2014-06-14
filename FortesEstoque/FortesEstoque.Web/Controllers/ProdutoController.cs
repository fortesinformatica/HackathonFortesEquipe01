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
    }
}