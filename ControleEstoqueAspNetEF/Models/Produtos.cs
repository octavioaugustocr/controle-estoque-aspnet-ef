using System.ComponentModel.DataAnnotations;

namespace ControleEstoqueAspNetEF.Models
{
    public class Produtos
    {
        [Range(0, int.MaxValue, ErrorMessage = "Informe o id do produto.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do produto.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe a marca do produto.")]
        public string? Marca { get; set; }

        [Required(ErrorMessage = "Informe o sabor do produto.")]
        public string? Sabor { get; set; }

        [Required(ErrorMessage = "Informe o preço do produto.")]
        [Range(0, double.MaxValue, ErrorMessage = "O preço não pode ser negativo.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Informe o fabricante do produto.")]
        public string? Fabricante { get; set; }

        [Required(ErrorMessage = "Informe a data de vencimento do produto.")]
        public DateOnly DataVencimento { get; set; }

        [Required(ErrorMessage = "Informe a quantidade em estoque.")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade não pode ser negativo.")]
        public int QuantidadeEstoque { get; set; }

        [Required(ErrorMessage = "Informe a unidade do produto.")]
        [RegularExpression(@"^.{2}$", ErrorMessage = "A unidade deve ter exatamente 2 caracteres.")]
        public string? UnidadeMedida { get; set; } = string.Empty;
    }
}
