using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosSensoresMvc.Models
{
	[Table("DADOSSENSORES")]
	public class DadosSensores
	{
		[Key]
		[Column("IDDADOS")]
		public int IdDados { get; set; }

		[Required(ErrorMessage = "Data obrigatória")]
		[DataType(DataType.DateTime, ErrorMessage = "Data inválida")]
		[Column("DATA")]
		public DateTime Data { get; set; }

		[Required(ErrorMessage = "Temperatura obrigatória")]
		// [MinLength(2, ErrorMessage = "Quantidade minima de 2 caracteres")]
		// [MaxLength(4, ErrorMessage = "Quantidade máximo de 4 caracteres")]
		[Column("TEMPERATURA")]
		public float Temperatura { get; set; }

		[Required(ErrorMessage = "Umidade obrigatória")]
		// [MaxLength(4, ErrorMessage = "Quantidade máximo de 4 caracteres")]
		// [MinLength(2, ErrorMessage = "Quantidade minima de 2 caracteres")]
		[Column("UMIDADE")]
		public float Umidade { get; set; }
	}
}
