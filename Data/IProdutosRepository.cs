using techstorecloud.Modelos;

namespace techstorecloud.Data
{
    public interface IProdutosRepository
    {
        bool SalvarMudancas();
        IEnumerable<Produto> GetProdutos();
        Produto GetProdutoPorId(int id);
        void CriarProduto(Produto produto);
        void DeletarProduto(Produto produto);
    }
}
