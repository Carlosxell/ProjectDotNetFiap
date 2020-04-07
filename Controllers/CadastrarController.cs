using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DadosSensoresMvc.Repository;

namespace DadosSensoresMvc.Controllers
{
  public class CadastrarController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Cadastrar(Models.DadosSensores dadosSensores)
    {
      if (ModelState.IsValid)
      {
        DadosSensoresRepository dadosSen = new DadosSensoresRepository();
        dadosSen.Inserir(dadosSensores);

        return RedirectToAction("Index", "Home");
      }
      else
      {
        return View("Cadastrar", dadosSensores);
      }
    }
  }
}