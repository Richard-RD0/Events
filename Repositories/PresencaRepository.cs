using Eveent_.Domains;
using Eveent_.Interfaces;
using Eveent_.Context;

namespace Eveent_.Repositories
{
    public class PresencasRepository : IPresencaRepository
    {
        private readonly Eveent_Context _context;

        public PresencasRepository(Eveent_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Presenca presenca)
        {
            try
            {
                Presenca presencaBuscado = _context.Presenca.Find(id)!;

                if (presencaBuscado != null)
                {
                    presencaBuscado.Situacao = presenca.Situacao;
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Presenca BuscarPorId(Guid id)
        {
            try
            {
                Presenca presencaBuscado = _context.Presenca.Find(id)!;
                return presencaBuscado;
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
                Presenca presencaBuscado = _context.Presenca.Find(id)!;

                if (presencaBuscado != null)
                {
                    _context.Presenca.Remove(presencaBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Inscrever(Presenca inscreverPresenca)
        {
            try
            {
                _context.Presenca.Add(inscreverPresenca);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Presenca> Listar()
        {
            try
            {
                List<Presenca> listaPresenca = _context.Presenca.ToList();
                return listaPresenca;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Presenca> ListarMinhas(Guid id)
        {
            try
            {
                List<Presenca> listaPresenca = _context.Presenca.Where(p => p.IdUsuario == id).ToList();
                return listaPresenca;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}