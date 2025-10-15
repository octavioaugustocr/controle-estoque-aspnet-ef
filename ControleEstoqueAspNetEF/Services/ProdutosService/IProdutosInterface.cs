using ControleEstoqueAspNetEF.Models;

namespace ControleEstoqueAspNetEF.Services.ProdutosService
{
    public interface IProdutosInterface
    {
        Produtos ObterProdutoPorId(int id);

        List<Produtos> ObterTodosProdutos();

        List<Produtos> ObterProdutoPorDescricao(string texto, string campo);

        void CriarProduto(Produtos produto);

        void AtualizarProduto(Produtos produto);

        void ExcluirProduto(int id);
    }
}
