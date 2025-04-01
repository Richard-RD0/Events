using Eveent_.Domains;
using Eveent_.Interfaces;
using Eveent_.Context;

namespace Eveent_.Repositories
{
    public class ComentarioEventoRepository : IComentarioEventosRepository
    {
        private readonly Eveent_Context _context;

        public ComentarioEventoRepository(Eveent_Context context)
        {
            _context = context;
        }

        public ComentarioEvento BuscarPorIdUsuario(Guid IdUsuario, Guid IdEventos)
        {
            try
            {
                ComentarioEvento comentarioEventoBuscado = _context.ComentarioEvento.Find(IdUsuario, IdEventos)!;
                return comentarioEventoBuscado;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Cadastrar(ComentarioEvento comentarioEvento)
        {
            try
            {
                _context.ComentarioEvento.Add(comentarioEvento);
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
                ComentarioEvento comentarioEventoBuscado = _context.ComentarioEvento.Find(id)!;

                if (comentarioEventoBuscado != null)
                {
                    _context.ComentarioEvento.Remove(comentarioEventoBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ComentarioEvento> Listar(Guid id)
        {
            try
            {
                List<ComentarioEvento> listaComentarioEvento = _context.ComentarioEvento.ToList();
                return listaComentarioEvento;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}