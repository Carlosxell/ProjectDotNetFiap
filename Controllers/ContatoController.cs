using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DadosSensoresMvc.Controllers
{
  public class ContatoController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Contato(Models.Contato contato)
    {
      if (ModelState.IsValid)
      {
        return RedirectToAction("Index", "Home", contato);
      }
      else
      {
        return View("Contato", contato);
      }
    }
  }
}