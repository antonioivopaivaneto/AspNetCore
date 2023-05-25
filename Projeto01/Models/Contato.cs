using System.ComponentModel.DataAnnotations;

namespace Projeto01.Models
{
    public class Contato
    {
        [Required(ErrorMessage = "CPF e Requirido")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Nome e Requirido")]
        public string Nome { get; set;}

        [Required(ErrorMessage = "Date e Requirido")]

        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Telefone e Requirido")]       
        public string Telefone { get; set;} 
    
    }
}
