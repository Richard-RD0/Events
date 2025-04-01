using Eveent_.Domains;
using Eveent_.Interfaces;
using Eveent_.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Event_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ComentarioEventoController : ControllerBase
    {
        private readonly IComentarioEventosRepository _ComentarioEventoRepository;

        public ComentarioEventoController(IComentarioEventosRepository comentarioEventoRepository)
        {
            _ComentarioEventoRepository = comentarioEventoRepository;
        }

        [HttpGet("BuscarPorIdDoUsuario/{IdUsuario},{IdEventos}")]
        public IActionResult GetById(Guid IdUsuario, Guid IdEventos)
        {
            try
            {
                ComentarioEvento comentarioBuscado = _ComentarioEventoRepository.BuscarPorIdUsuario(IdUsuario, IdEventos);
                return Ok(comentarioBuscado);


            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public IActionResult Post(ComentarioEvento comentarioEvento)
        {

            try
            {
                _ComentarioEventoRepository.Cadastrar(comentarioEvento);
                return Created();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("{Id}")]

        public IActionResult Delete(Guid Id)
        {
            try
            {
                _ComentarioEventoRepository.Deletar(Id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult Get(Guid Id)
        {
            try
            {
                List<ComentarioEvento> ListarComentarioEvento = _ComentarioEventoRepository.Listar(Id);
                return Ok(ListarComentarioEvento);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}