using Eveent_.Context;
using Eveent_.Domains;
using Eveent_.Interfaces;

namespace Eveent_.Repositories
{
    public class EventoRepository : IEventosRepository
    {
        private readonly Eveent_Context _context;

        public EventoRepository(Eveent_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Eventos evento)
        {
            try
            {
                Eventos eventoBuscado = _context.Eventos.Find(id)!;

                if (eventoBuscado != null)
                {
                    eventoBuscado.TituloDeEventos = evento.TituloDeEventos;
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Eventos BuscarPorId(Guid id)
        {
            try
            {
                Eventos eventoBuscado = _context.Eventos.Find(id)!;
                return eventoBuscado;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Eventos novoEvento)
        {
            try
            {
                _context.Eventos.Add(novoEvento);

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
                Eventos eventoBuscado = _context.Eventos.Find(id)!;

                if (eventoBuscado != null)
                {
                    _context.Eventos.Remove(eventoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Eventos> Listar()
        {
            try
            {
                List<Eventos> listaEvento = _context.Eventos.ToList();
                return listaEvento;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Eventos> ListarPorId(Guid id)
        {
            try
            {
                List<Eventos> listaEvento = _context.Eventos.Where(p => p.IdEventos == id).ToList();
                return listaEvento;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Eventos> ListarProximosEventos()
        {
            try
            {
                List<Eventos> listarEventosProximos = _context.Eventos.Where(e => e.DataEvento > DateTime.Now).OrderBy(e => e.DataEvento).ToList();
                return listarEventosProximos;
            }
            catch (Exception)
            {
                throw;
            }   
        }
    }
}