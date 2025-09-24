using Microsoft.EntityFrameworkCore;
using techstorecloud.Modelos;

namespace techstorecloud.Data
{
    public class ProdutosRepository : IProdutosRepository
    {

        private readonly AppDbContext _context;

        public ProdutosRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CriarProduto(Produto produto)
        {
            if (produto == null)
            {
                throw new ArgumentNullException(nameof(produto));
            }

            _context.Produtos.Add(produto);
        }

        public void DeletarProduto(Produto produto)
        {
            _context.Produtos.Remove(produto);
        }

        public Produto GetProdutoPorId(int id)
        {
            return _context.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Produto> GetProdutos()
        {
            return _context.Produtos.ToList();
        }

        public bool SalvarMudancas()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
