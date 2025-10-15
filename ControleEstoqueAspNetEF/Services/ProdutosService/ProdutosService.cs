using ControleEstoqueAspNetEF.Data;
using ControleEstoqueAspNetEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoqueAspNetEF.Services.ProdutosService
{
    public class ProdutosService : IProdutosInterface
    {
        private readonly AppDbContext _appDbContext;

        public ProdutosService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Produtos ObterProdutoPorId(int id)
        {
            var produto = _appDbContext.Produtos.Find(id);
            if (produto == null)
                return null!;

            return produto;
        }

        public List<Produtos> ObterTodosProdutos()
        {
            var listaProdutos = _appDbContext.Produtos.ToList();
            return listaProdutos;
        }

        public List<Produtos> ObterProdutoPorDescricao(string texto, string campo)
        {
            var listaProdutos = new List<Produtos>();

            if (campo.ToLower() == "nome")
                listaProdutos = _appDbContext.Produtos.Where(p => p.Nome!.Contains(texto)).ToList();

            if (campo.ToLower() == "marca")
                listaProdutos = _appDbContext.Produtos.Where(p => p.Marca!.Contains(texto)).ToList();

            if (campo.ToLower() == "sabor")
                listaProdutos = _appDbContext.Produtos.Where(p => p.Sabor!.Contains(texto)).ToList();

            if (campo.ToLower() == "preco")
                listaProdutos = _appDbContext.Produtos.Where(p => p.Preco.ToString().Contains(texto)).ToList();

            if (campo.ToLower() == "fabricante")
                listaProdutos = _appDbContext.Produtos.Where(p => p.Fabricante!.Contains(texto)).ToList();

            if (campo.ToLower() == "datavencimento")
                listaProdutos = _appDbContext.Produtos.AsEnumerable().Where(p => p.DataVencimento.ToString("yyyy-MM-dd").Contains(texto)).ToList();


            if (campo.ToLower() == "estoque")
                listaProdutos = _appDbContext.Produtos.Where(p => p.QuantidadeEstoque.ToString().Contains(texto)).ToList();

            if (campo.ToLower() == "unmedida")
                listaProdutos = _appDbContext.Produtos.Where(p => p.UnidadeMedida!.Contains(texto)).ToList();

            return listaProdutos;
        }

        public void CriarProduto(Produtos produto)
        {
            _appDbContext.Produtos.Add(produto);
            _appDbContext.SaveChanges();
        }

        public void AtualizarProduto(Produtos produto)
        {
            _appDbContext.Produtos.Update(produto);
            _appDbContext.SaveChanges();
        }

        public void ExcluirProduto(int id)
        {
            var produto = ObterProdutoPorId(id);

            if (produto == null)
                return;

            _appDbContext.Produtos.Remove(produto);
            _appDbContext.SaveChanges();
        }
    }
}
