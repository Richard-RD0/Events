using System.Diagnostics.Eventing.Reader;
using Eveent_.Domains;
using Eveent_.Interfaces;
using Eveent_.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Event_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EventoController : ControllerBase
    {
        private readonly IEventosRepository _EventosRepository;

        public EventoController(IEventosRepository EventosRepository)
        {
            _EventosRepository = EventosRepository;
        }

        [HttpPost]
        public IActionResult Post(Eventos eventoRepository)
        {
            try
            {
                _EventosRepository.Cadastrar(eventoRepository);
                return Created();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public IActionResult Put(Guid Id, Eventos evento)
        {
            try
            {
                _EventosRepository.Atualizar(Id, evento);
                return NoContent();

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(Guid Id)
        {
            try
            {
                Eventos EventoBuscado = _EventosRepository.BuscarPorId(Id);
                return Ok(EventoBuscado);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }



        [HttpDelete]
        public IActionResult Delete(Guid Id)
        {
            try
            {
                _EventosRepository.Deletar(Id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Eventos> ListaEvento = _EventosRepository.Listar();
                return Ok(ListaEvento);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{ListarId}")]
        public IActionResult Get(Guid Id)
        {
            try
            {
                List<Eventos> ListaEventoPorID = _EventosRepository.ListarPorId(Id);
                return Ok(ListaEventoPorID);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{ListarProximoEvento}")]
        public IActionResult ListarProximoEvento()
        {
            try
            {
                List<Eventos> ListaProximoEvento = _EventosRepository.ListarProximosEventos();
                return Ok(ListaProximoEvento);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}