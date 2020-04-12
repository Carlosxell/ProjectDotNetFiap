using System;
using System.IO;
using DadosSensoresMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Oracle.EntityFrameworkCore;
using Oracle.DataAccess.Client;

namespace DadosSensoresMvc.Repository
{
	public class DataBaseContext: DbContext
	{

		// Comentário para o erick aprender GIT
		protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
		{
			var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
			optBuilder.UseOracle(config.GetConnectionString("OracleConnection"), b => b.UseOracleSQLCompatibility("11"));
			// optBuilder.UseOracle("Data Source=oracle.fiap.com.br,1433;Network Library=DBMSSOCN;Initial Catalog=FIAP;User ID=RM82824;Password=141189;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DadosSensores>().Property(p => p.IdDados).UseOracleIdentityColumn();

			base.OnModelCreating(modelBuilder);
		}

		public DbSet<DadosSensores> DadosSensores { get; set; }

		public DbSet<Contato> Contato { get; set; }
	}
}
