using Projeto01.Models;

namespace Projeto01.Services
{
    public interface IListasService
    {
        IEnumerable<Produto> MostrarListaProdutos();
    }
}
