using Projeto01.Models;

namespace Projeto01.Services
{
    public interface IContatoService
    {
        IEnumerable<Contato> MostrarListaContato();
    }
}
