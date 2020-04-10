using System;
using System.IO;
using DadosSensoresMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Oracle.EntityFrameworkCore;

namespace DadosSensoresMvc.Repository
{
	public class DataBaseContext: DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
			optionsBuilder.UseOracle(config.GetConnectionString("OracleConnection"));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<DadosSensores> DadosSensores { get; set; }

		public DbSet<Contato> Contato { get; set; }
	}
}
