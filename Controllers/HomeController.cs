using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DadosSensoresMvc.Models;


namespace DadosSensoresMvc.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			IList<Models.DadosSensores> listaDadosSensores = new List<Models.DadosSensores>();

			listaDadosSensores.Add(new DadosSensores()
			{
				Data = DateTime.Now,
				Temperatura = 18.10f,
				Umidade = 19.00f
			});

			listaDadosSensores.Add(new DadosSensores()
			{
				Data = DateTime.UtcNow,
				Temperatura = 91.00f,
				Umidade = 32.00f
			});

			return View(listaDadosSensores);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
