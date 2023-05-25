using Microsoft.AspNetCore.Mvc;
using Projeto01.Models;
using Projeto01.Services;

namespace Projeto01.Controllers
{
    public class ContatosController : Controller
    {
        private readonly IContatoService _service;
        public ContatosController(IContatoService service) 
        { 
            _service = service;
        }


        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Contato contato)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(contato);
                }

            }catch (Exception ex)
            {
                return View("_Error", ex);
            }
           return View("ContatoSalvo",contato);
        }

        public IActionResult ListarContatos()
        {
            IEnumerable<Contato> contato = _service.MostrarListaContato();

            return View(contato);
        }

    }
}
