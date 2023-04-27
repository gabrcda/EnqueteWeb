using Microsoft.AspNetCore.Mvc;
using EnqueteWeb.Models;
namespace EnqueteWeb.Controllers;

public class EnqueteController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Responda()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Responda(RespostaUsuario resposta)
    {
        if(ModelState.IsValid)
        {
            Repositorio.adicionarResposta(resposta);
            return View("Obrigado");
        }
        else
        {
            return View(resposta);
        }
    }

        public ActionResult Resultado()
    {
        return View(Repositorio.Respostas);
    }
        
}
