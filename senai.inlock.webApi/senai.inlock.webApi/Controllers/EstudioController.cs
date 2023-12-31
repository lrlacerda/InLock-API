﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositoris;

namespace senai.inlock.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository { get; set; }

        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }

        [HttpGet]
        [Authorize(Roles = "2, 1")]

        public IActionResult Get()
        {
            try
            {
                List<EstudioDomain> listaEstudio = _estudioRepository.Listar();

                return Ok(listaEstudio);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                EstudioDomain estudio = _estudioRepository.BuscarPorId(id);

                if (estudio == null)
                {
                    return NotFound();
                }
                return Ok(estudio);
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        [HttpPost]
        [Authorize(Roles = "2, 1")]
        public IActionResult Post(EstudioDomain nonoEstudio)
        {
            try
            {
                _estudioRepository.Cadastrar(nonoEstudio);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "2")]
        public IActionResult Delete(int id)
        {
            try
            {
                _estudioRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(EstudioDomain estudio)
        {
            try
            {
                EstudioDomain estudioExistente = _estudioRepository.BuscarPorId(estudio.IdEstudio);

                if (estudioExistente == null)
                {
                    return NotFound();
                }
                _estudioRepository.Atualizar(estudio);

                return NoContent();
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }
    }
}
