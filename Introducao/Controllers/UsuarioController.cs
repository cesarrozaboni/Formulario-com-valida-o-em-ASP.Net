using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Usuario()
        {
            var usuario = new Usuario();

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario (Usuario usuario)
        {
            //Exemplo de validação
            /*
            if (string.IsNullOrEmpty(usuario.usuNome))
            {
                ModelState.AddModelError("usuNome", "Este campo é obrigatório!");
            }
            if (usuario.usuSenha != usuario.usuConfirmaSenha)
            {
                ModelState.AddModelError("", "As senhas informadas são diferentes!");
            }
            */
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico( string usuLogin)
        {
            var bdExemplo = new Collection<string>
            {
                "Hugo",
                "Freitas",
                "Paula"
            };
            //Verifica se os dados do banco de dados são diferentes do login informado pelo usuario, para fazer um novo cadastro
            return Json(bdExemplo.All(x => x.ToLower() != usuLogin.ToLower()), JsonRequestBehavior.AllowGet);
        }

    }
}