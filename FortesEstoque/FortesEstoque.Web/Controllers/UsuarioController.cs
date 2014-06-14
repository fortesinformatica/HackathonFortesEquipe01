using FortesEstoque.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FortesEstoque.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            UsuarioBusiness usuarios = new UsuarioBusiness();
            return View();
        }
    }
}