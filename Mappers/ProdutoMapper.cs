using techstorecloud.DTOs;
using techstorecloud.Modelos;

namespace techstorecloud.Mappers
{
    public class ProdutoMapper
    {
        public static ProdutoLeituraDto ToReadDto(Produto produto)
        {
            if (produto == null)
            {
                return null;
            }

            return new ProdutoLeituraDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Preco = produto.Preco,
                Categoria = produto.Categoria,
                Estoque = produto.Estoque,
            };
        }

        public static Produto ToPlatform(ProdutoCadastroDto produtoCadastroDto)
        {
            if (produtoCadastroDto == null)
            {
                return null;
            }

            return new Produto
            {
                Nome = produtoCadastroDto.Nome,
                Preco = produtoCadastroDto.Preco,
                Categoria = produtoCadastroDto.Categoria,
                Estoque = produtoCadastroDto.Estoque
            };
        }
    }
}
