using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosSensoresMvc.Models
{
	public class Contato
	{
		public int IdContato { get; set; }

		[Required(ErrorMessage = "E-mail é obrigatório")]
		[EmailAddress(ErrorMessage = "Formato de e-mail inválido")]
		public String Email { get; set; }

		[Required(ErrorMessage = "Nome é obrigatório")]
		[StringLength(100, MinimumLength = 3, ErrorMessage = "O Tamanho minimo para a mensagem é de 3 caracteres e máximo de 100 caracteres")]
		public String Nome { get; set; }

		[Required(ErrorMessage = "Mensagem é obrigatória")]
		[StringLength(300, MinimumLength = 8, ErrorMessage = "O Tamanho minimo para a mensagem é de 8 caracteres e máximo de 300 caracteres")]
		public String Mensagem { get; set; }
	}
}
