using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                pesId = 1,
                pesNome = "Cesar Rozaboni",
                pesTipo = "Administrador"
            };
            //Usando viewData
            ViewData["PesID"] = pessoa.pesId;
            ViewData["PesNome"] = pessoa.pesNome;
            ViewData["PesTipo"] = pessoa.pesTipo;

            //Usando viewBag

            ViewBag.Id = pessoa.pesId;
            ViewBag.Nome = pessoa.pesNome;
            ViewBag.Tipo = pessoa.pesTipo;

            //Para usar viewTipada passar a classe por parametro e fazer a chamada no front

            return View(pessoa);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Meu()
        {
            ViewBag.Message = "Minha pagina viewBag";

            return View();
        }
        //ViewData
        /*
        [HttpPost]
        public ActionResult Lista( int pesId, string pesNome, string pesTipo)
        {
            ViewData["pesId"] = pesId;
            ViewData["pesNome"] = pesNome;
            ViewData["pesTipo"] = pesTipo;
            return View();
        }
        */

        //Form collection
        /*
    public ActionResult Lista(FormCollection form)
    {
        ViewData["pesId"] = form["pesId"];
        ViewData["pesNome"] = form["pesNome"];
        ViewData["pesTipo"] = form["pesTipo"];
        return View();

    }
    */
        // view tipada com objeto da classe
        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
}