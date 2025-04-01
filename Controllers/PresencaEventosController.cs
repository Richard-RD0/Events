using Eveent_.Domains;
using Eveent_.Interfaces;
using Eveent_.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Eveent_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]

    public class PresencasEventosController : ControllerBase
    {
        private IPresencaRepository _presencasEventosRepository;

        public PresencasEventosController(IPresencaRepository presencasEventosRepository)
        {
            _presencasEventosRepository = presencasEventosRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Presenca> ListaPresencasEventos = _presencasEventosRepository.Listar();
                return Ok(ListaPresencasEventos);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost]

        public IActionResult Post(Presenca presenca) 
        {
            try
            {
                _presencasEventosRepository.Inscrever(presenca);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]

        public IActionResult Put(Guid Id, Presenca presencas)
        {
            try
            {
                _presencasEventosRepository.Atualizar(Id, presencas);
                return NoContent();
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
                _presencasEventosRepository.Deletar(Id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpGet("ListarMinhas/{Id}")]
        public IActionResult GetByMe(Guid Id)
        {
            try
            {
                return Ok(_presencasEventosRepository.ListarMinhas(Id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("BuscarPorId/{id}")]
        public IActionResult GetById(Guid id)
        {

            try
            {
                return Ok(_presencasEventosRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }

}