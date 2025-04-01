using Eveent_.Domains;

namespace Eveent_.Interfaces
{
    public interface IComentarioEventosRepository
    {
        void Cadastrar(ComentarioEvento comentarioEvento);
        void Deletar(Guid id);
        ComentarioEvento BuscarPorIdUsuario(Guid idUsuario, Guid IdEventos);
        List<ComentarioEvento> Listar(Guid id);
    }
}
 