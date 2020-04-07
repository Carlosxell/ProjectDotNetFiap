using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.Extensions.Configuration;
using Oracle.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DadosSensoresMvc.Models;

namespace DadosSensoresMvc.Repository
{
	public class DataBaseContext: System.Data.Entity.DbContext
	{
		// public Context() : base("name=OracleConnectionString")
		// {
		// }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
				optionsBuilder.UseOracle(config.GetConnectionString("RazorPagesMovieContext"));
			}

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

			modelBuilder.HasDefaultSchema("PF0954");

			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}

		public System.Data.Entity.DbSet<DadosSensores> DadosSensores { get; set; }

		public System.Data.Entity.DbSet<Contato> Contato { get; set; }
	}
}
