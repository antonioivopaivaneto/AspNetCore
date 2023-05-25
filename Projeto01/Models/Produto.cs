using System.ComponentModel.DataAnnotations;

namespace Projeto01.Models
{
    public class Produto
    {
        [Display(Name = "Código do Produto:")]
        [Range(1, 1000,ErrorMessage = "Valor precisa estar entre 1 e 1000")]
        [Required]
        public int Codigo { get; set; }

        [Display(Name = "Descrição:")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Descrição e Requirido")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "O valor precisa ser entre 4 e 50")]
        public string? Descricao { get; set; }

        [Display(Name = "Valor:")]
        [Required]

        public double Preco { get; set; }
    }
}
