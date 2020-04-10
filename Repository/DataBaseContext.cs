using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.Extensions.Configuration;
// using Oracle.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DadosSensoresMvc.Models;

namespace DadosSensoresMvc.Repository
{
	public class DataBaseContext: DbContext
	{
		public Context(DbContextOptions options): base(options)
		{}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseOracle(config.GetConnectionString("OracleConnection"));
			}
		}

		public DbSet<DadosSensores> DadosSensores { get; set; }

		public DbSet<Contato> Contato { get; set; }
	}
}
