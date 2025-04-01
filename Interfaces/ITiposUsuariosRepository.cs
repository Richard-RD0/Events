using Eveent_.Domains;

namespace Eveent_.Interfaces
{
    public interface ITiposUsuariosRepository
    {
        void Cadastrar(TiposUsuarios tiposUsuarios);
        void Atualizar(Guid id, TiposUsuarios tiposUsuarios);
        void Deletar(Guid id);
        TiposUsuarios BuscarPorId(Guid id);
        List<TiposUsuarios> Listar();
    }
}
 