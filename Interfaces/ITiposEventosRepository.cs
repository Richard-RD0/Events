using Eveent_.Domains;

namespace Eveent_.Interfaces
{
    public interface ITiposEventosRepository
    {
        void Cadastrar(TiposEventos tiposEventos);
        void Atualizar(Guid id, TiposEventos tiposEventos);
        void Deletar(Guid id);
        TiposEventos BuscarPorId(Guid id);
        List<TiposEventos> Listar();

    }
}
 