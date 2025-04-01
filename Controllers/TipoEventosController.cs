using Eveent_.Domains;
using Eveent_.Interfaces;
using Eveent_.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Event_Plus.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TipoEventosController : ControllerBase
    {
        private ITiposEventosRepository _tipoEventosRepository { get; set; }

        public TipoEventosController(ITiposEventosRepository tipoEventosRepository)
        {

            _tipoEventosRepository = tipoEventosRepository;
        }

        ////// <summary>
        /// Lista Tipo de Eventos
        /// </summary>
        /// <returns>Listar os Tipos de Eventos</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_tipoEventosRepository.Listar());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_tipoEventosRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Cadastrar os Tipo Eventos
        /// </summary>
        /// <param name="novoTipoEvento">Tipo Evento cadastrado</param>
        /// <returns>Novo Tipo Evento</returns>
        [HttpPost]
        public IActionResult Post(TiposEventos novoTipoEvento)
        {

            try
            {
                _tipoEventosRepository.Cadastrar(novoTipoEvento);

                return StatusCode(201, novoTipoEvento);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        /// <summary>
        /// Deletar um Tipo Evento
        /// </summary>
        /// <param name="id">Id do Tipo de Evento</param>
        /// <returns>Linha vazia</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {

            try
            {
                _tipoEventosRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        /// <summary>
        /// Atualizar um Tipo De Evento
        /// </summary>
        /// <param name="id">Id do TipoEvento</param>
        /// /// <param name="tipoEvento">Titulo do Filme</param>
        /// <returns>Tipo Evento Atualizado</returns>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, TiposEventos tipoEvento)
        {
            try
            {
                _tipoEventosRepository.Atualizar(id, tipoEvento);
                return StatusCode(204, tipoEvento);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }




}