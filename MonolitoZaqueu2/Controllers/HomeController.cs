using MonolitoZaqueu2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonolitoZaqueu2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProdutosService produtoService = new ProdutosService();
        public ActionResult Home()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

         public ActionResult Produtos()
        {
            var listaDeProdutos = produtoService.ObterProdutos();


            return View(listaDeProdutos);
        }
    }
}