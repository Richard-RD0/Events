using api_filmes_senai.Domains;

namespace Eveent_.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuarios novoUsuario);
        Usuarios BuscarPorId(Guid id);
        Usuarios BuscarPorEmailESenha(string email, string senha);
    }
}
 