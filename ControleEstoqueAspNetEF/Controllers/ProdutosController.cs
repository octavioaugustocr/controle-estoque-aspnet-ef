using ControleEstoqueAspNetEF.Data;
using ControleEstoqueAspNetEF.Models;
using ControleEstoqueAspNetEF.Services.ProdutosService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoqueAspNetEF.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutosInterface _produtosInterface;

        public ProdutosController(IProdutosInterface produtosInterface)
        {
            _produtosInterface = produtosInterface;
        }

        public IActionResult Index()
        {
            var listaProdutos = _produtosInterface.ObterTodosProdutos();
            return View(listaProdutos);
        }

        public IActionResult AdicionarProduto()
        {
            return View();
        }

        public IActionResult ConsultarProduto(int id)
        {
            var produto = _produtosInterface.ObterProdutoPorId(id);
            return View(produto);
        }

        public IActionResult ObterProdutoPorDescricao(string texto, string campo)
        {
            ViewBag.Texto = texto;
            ViewBag.Campo = campo;

            var listaProdutos = _produtosInterface.ObterProdutoPorDescricao(texto, campo);

            return View("Index", listaProdutos);
        }

        public IActionResult CriarProduto(Produtos produto)
        {
            if (!ModelState.IsValid)
                return View("AdicionarProduto");

            _produtosInterface.CriarProduto(produto);

            return RedirectToAction("Index");
        }

        public IActionResult EditarProduto(int id)
        {
            var produto = _produtosInterface.ObterProdutoPorId(id);
            return View(produto);
        }

        public IActionResult ExcluirProduto(int id)
        {
            var produto = _produtosInterface.ObterProdutoPorId(id);
            return View(produto);
        }

        public IActionResult SalvarProduto(Produtos produto)
        {
            if (!ModelState.IsValid)
                return View("EditarProduto", produto);

            if (produto == null)
                return null!;

            _produtosInterface.AtualizarProduto(produto);
            return RedirectToAction("Index");
        }

        public IActionResult ExcluirConfirmar(int id)
        {
            _produtosInterface.ExcluirProduto(id);

            return RedirectToAction("Index");
        }
    }
}