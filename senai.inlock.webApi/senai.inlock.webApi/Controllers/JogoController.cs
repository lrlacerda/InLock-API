using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositoris;
using System.Data;

namespace senai.inlock.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class JogoController : ControllerBase
    {
        private IJogoRepository _jogoRepository { get; set; }

        public JogoController()
        {
            _jogoRepository = new JogoRepository();
        }

        [HttpGet]
        //[Authorize(Roles = "2, 1")]
        public IActionResult Get()
        {
            try
            {
                List<JogoDomain> listaJogo = _jogoRepository.Listar();

                return Ok(listaJogo);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }

        }

        [HttpPost]
        public IActionResult Post(JogoDomain nonoJogo)
        {
            try
            {
                _jogoRepository.Cadastrar(nonoJogo);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _jogoRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        [HttpPut("{id}")] 
        public IActionResult Put(int id, JogoDomain jogo) 
        {
            try
            {
                JogoDomain jogoExistente = _jogoRepository.BuscarPorId(id);

                if (jogoExistente == null)
                {
                    return NotFound();
                }

                jogo.IdJogo = id;

                _jogoRepository.Atualizar(id, jogo);

                return NoContent(); 
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }
    }
}
