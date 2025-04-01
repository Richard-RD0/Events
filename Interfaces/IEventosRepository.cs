using Eveent_.Domains;

namespace Eveent_.Interfaces
{
    public interface IEventosRepository
    {
        void Cadastrar(Eventos evento);
        List<Eventos> Listar();
        void Atualizar(Guid id, Eventos evento);
        void Deletar(Guid id);
        Eventos BuscarPorId(Guid id);
        List<Eventos> ListarProximosEventos();
        List<Eventos> ListarPorId(Guid id);
    }
}
 