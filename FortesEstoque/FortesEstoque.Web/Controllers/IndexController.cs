using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FortesEstoque.Web.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Movimentacao");
        }
    }
}