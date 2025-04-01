using api_filmes_senai.Domains;
using Eveent_.Domains;

namespace Eveent_.Interfaces
{
    public interface IPresencaRepository
    {
        List<Presenca> Listar();
        void Atualizar(Guid id, Presenca presenca);
        Presenca BuscarPorId(Guid id);
        List<Presenca> ListarMinhas(Guid id);
        void Inscrever(Presenca inscricao);
        void Deletar(Guid id);

    }
}
 