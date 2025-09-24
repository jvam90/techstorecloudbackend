using Microsoft.AspNetCore.Mvc;
using techstorecloud.Data;
using techstorecloud.DTOs;
using techstorecloud.Mappers;

namespace techstorecloud.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private IProdutosRepository _repositorio;

        public ProdutosController(IProdutosRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProdutoLeituraDto>> GetProdutos()
        {
            var produtos = _repositorio.GetProdutos();
            return Ok(produtos.Select(ProdutoMapper.ToReadDto));
        }

        [HttpGet("{id}")]
        public ActionResult<ProdutoLeituraDto> GetProdutoPorId(int id)
        {
            var produto = _repositorio.GetProdutoPorId(id);
            if (produto == null)
            {
                return NotFound();
            }

            return Ok(ProdutoMapper.ToReadDto(produto));
        }

        [HttpPost]
        public ActionResult<ProdutoLeituraDto> CriarProduto(ProdutoCadastroDto produtoCadastroDto)
        {
            var produto = ProdutoMapper.ToPlatform(produtoCadastroDto);
            _repositorio.CriarProduto(produto);
            _repositorio.SalvarMudancas();

            var produtoLeituraDto = ProdutoMapper.ToReadDto(produto);
            return CreatedAtAction(nameof(GetProdutos), new { id = produtoLeituraDto.Id }, produtoLeituraDto);
        }

        [HttpDelete("{id}")]
        public ActionResult ApagarProduto(int id)
        {
            var produto = _repositorio.GetProdutoPorId(id);
            if (produto == null)
            {
                return NotFound();
            }

            _repositorio.DeletarProduto(produto);
            _repositorio.SalvarMudancas();

            return NoContent();
        }
    }
}
