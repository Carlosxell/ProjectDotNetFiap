using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DadosSensoresMvc.Repository;
using DadosSensoresMvc.Models;

namespace DadosSensoresMvc.Repository
{
	public class DadosSensoresRepository
	{
		private readonly DataBaseContext context;

		public DadosSensoresRepository()
		{
			context = new DataBaseContext();
		}

		public IList<DadosSensores> Listar()
		{
			return context.DadosSensores.ToList();
		}

		public DadosSensores Consultar(int id)
		{
			return context.DadosSensores.Find(id);
		}

		public void Inserir(DadosSensores dadosSensores)
		{
			context.DadosSensores.Add(dadosSensores);
			context.SaveChanges();
		}

		public void Alterar(DadosSensores dadosSensores)
		{
			context.DadosSensores.Update(dadosSensores);
			context.SaveChanges();
		}

		public void Excluir(int id)
		{
			var dadosSensores = new DadosSensores()
			{
				IdDados = id
			};

			context.DadosSensores.Remove(dadosSensores);
			context.SaveChanges();
		}
	}
}
