using System.ComponentModel.DataAnnotations;

namespace techstorecloud.Modelos
{
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }
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
