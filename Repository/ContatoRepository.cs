using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DadosSensoresMvc.Models;
using DadosSensoresMvc.Repository;

namespace DadosSensoresMvc.Repository
{
	public class ContatoRepository
	{
		private readonly DataBaseContext context;

		public ContatoRepository()
		{
			context = new DataBaseContext();
		}

		public IList<DadosSensores> Listar()
		{
			return context.DadosSensores.ToList();
		}

		public Contato Consultar(int id)
		{
			return context.Contato.Find(id);
		}

		public void Inserir(Contato contato)
		{
			context.Contato.Add(contato);
			context.SaveChanges();
		}

		public void Alterar(Contato contato)
		{
			context.Contato.Update(contato);
			context.SaveChanges();
		}

		public void Excluir(int id)
		{
			var contato = new Contato()
			{
				IdContato = id
			};

			context.Contato.Remove(contato);
			context.SaveChanges();
		}
	}
}
