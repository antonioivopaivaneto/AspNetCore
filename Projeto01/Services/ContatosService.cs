using Projeto01.Models;

namespace Projeto01.Services
{
    public class ContatosService : IContatoService

    {
        public IEnumerable<Contato> MostrarListaContato()
        {
            return new List<Contato>()
            {
                new Contato() {Cpf = "454.454.545.45", Nome = "Jose da Couve" ,DataNascimento= new DateTime(1996, 7, 16),Telefone ="(11) 9 7070-7070" }
            };
        }
    }
}
