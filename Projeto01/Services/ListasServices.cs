using Projeto01.Models;

namespace Projeto01.Services
{
    public class ListasServices : IListasService
    {
        public IEnumerable<Produto> MostrarListaProdutos()
        {
            return new List<Produto>()
            {
                new Produto() { Codigo = 1,Descricao = "Mouse",Preco = 100},
                new Produto() { Codigo = 2,Descricao = "Teclado Gamer",Preco = 200},
                new Produto() { Codigo = 3,Descricao = "Monitor",Preco = 1000},


            }; 
        }
    }
}
