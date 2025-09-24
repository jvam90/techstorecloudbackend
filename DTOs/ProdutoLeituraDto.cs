namespace techstorecloud.DTOs
{
    public class ProdutoLeituraDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Preco { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Estoque { get; set; } = string.Empty;
    }
}
