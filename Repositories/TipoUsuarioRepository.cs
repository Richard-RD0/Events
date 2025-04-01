using Eveent_.Domains;
using Eveent_.Controllers;
using Eveent_.Interfaces;
using Eveent_.Context;

namespace Eveent_.Repositories
{
    public class TipoUsuarioRepository : ITiposUsuariosRepository
    {
        private readonly Eveent_Context _context;

        public TipoUsuarioRepository(Eveent_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TiposUsuarios tipoUsuario)
        {
            try
            {
                TiposUsuarios tipoUsuarioBuscado = _context.TiposUsuarios.Find(id)!;

                if (tipoUsuarioBuscado != null)
                {
                    tipoUsuarioBuscado.TituloTipoUsuario = tipoUsuario.TituloTipoUsuario;
                }
                _context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public TiposUsuarios BuscarPorId(Guid id)
        {
            try
            {
                TiposUsuarios tipoUsuarioBuscado = _context.TiposUsuarios.Find(id)!;
                return tipoUsuarioBuscado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(TiposUsuarios tipoUsuario)
        {
            try
            {
                _context.TiposUsuarios.Add(tipoUsuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                TiposUsuarios tipoUsuarioBuscado = _context.TiposUsuarios.Find(id)!;

                if (tipoUsuarioBuscado != null)
                {
                    _context.TiposUsuarios.Remove(tipoUsuarioBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<TiposUsuarios> Listar()
        {
            try
            {
                List<TiposUsuarios> listaTipoUsuario = _context.TiposUsuarios.ToList();
                return listaTipoUsuario;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}