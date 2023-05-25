using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using Projeto01.Models;
using Projeto01.Services;

namespace Projeto01.Controllers
{
    public class ExemplosController : Controller
    {
        private readonly IListasService _service;
        public ExemplosController(IListasService service)
        {
            _service = service;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        //action que retorna um texto puro no navegador
        public string MostrarTexto()
        {
            return "Desenvimento Web Com Aspnet core";
        }

        [Route("primeirapagina")]
        public ViewResult MostrarPagina()
        {
            return View();
        }

        public FileResult ExibirPdf()
        {
            return File("~/pdf/react.pdf","application/pdf");
        }

        public FileResult ExibirImagem()
        {
            return File("~/images/men.jpg","image/jpg");
        }

        //usuado para renderizar um formulario/ cuja a view fracamente tipada (weakly typed view)
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(IFormCollection form)
        {
            try
            {
                Produto produto = new Produto()
                {
                    Codigo = int.Parse(form["txtCodigo"]!),
                    Descricao = form["txtDescricao"],
                    Preco = double.Parse(form["txtPreco"]!)

                };

                return View("Resultado", produto);
            }
            catch (Exception ex)
            {

                return View("_Error",ex);
            }

        }
        [HttpGet]
        public IActionResult CadastroModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroModel(Produto produto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                if(produto.Preco <= 0)
                {
                    throw new InvalidOperationException("O preco deve ser maiorque zero");
                }
                return View("Resultado", produto);
            }
            catch (Exception ex)
            {

                return View("_Error", ex);
            }
        }

        //view fortemente tipada usando tag helpers
        [HttpGet]
        public IActionResult CadastroModelTag()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroModelTag(Produto produto)
        {
            try
            {
                if (produto.Preco <= 0)
                {
                    ModelState.AddModelError("Preco","O Preco deve ser maior que zero(0)");
                }
                if (!ModelState.IsValid)
                {
                    return View();
                }
                if (produto.Preco <= 0)
                {
                    throw new InvalidOperationException("O preco deve ser maiorque zero");
                }
                return View("Resultado", produto);
            }
            catch (Exception ex)
            {

                return View("_Error", ex);
            }
        }
        public IActionResult ListarProdutos()
        {
            //ListasServices service = new ListasServices();

            IEnumerable<Produto> produtos = _service.MostrarListaProdutos();    
            return View(produtos);
        }
            

    }

     
}
