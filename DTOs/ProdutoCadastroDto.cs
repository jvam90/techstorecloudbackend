using System.ComponentModel.DataAnnotations;

namespace techstorecloud.DTOs
{
    public class ProdutoCadastroDto
    {
        [Required]
        public string Nome { get; set; } = string.Empty;
        [Required]
        public string Preco { get; set; } = string.Empty;
        [Required]
        public string Categoria { get; set; } = string.Empty;
        [Required]
        public string Estoque { get; set; } = string.Empty;
    }
}
