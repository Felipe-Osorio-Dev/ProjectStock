using System.ComponentModel.DataAnnotations;

namespace StockAPI.Dto.Requests
{
    public class CreateProductDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome do Produto é Obrigatório.")]
        [StringLength(50, ErrorMessage = "Nome do produto Invalido. Máximo de 50 caracteres são permitidos.")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ean é Obrigatório")]
        [RegularExpression("^\\d{13}$", ErrorMessage = "Ean Invalido, apenas numeros são permitidos.")]
        public string EAN { get; set; }

        [Required(ErrorMessage = "Quantidade é Obrigatória.")]
        [Range(1, 999999, ErrorMessage = "Quantidade invalida. O produto deve conter no minimo 1 e max 999999 para estoque.")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Data de Validade do produto é Obrigatória.")]
        public DateOnly Validate { get; set; }
    }
}
