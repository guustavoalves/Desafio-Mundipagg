using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Desafio.Mundipagg.AppService.Colecao;
using Desafio.Mundipagg.AppService.DTO;

namespace Desafio.Mundipagg.WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {        
        // GET: api/Pessoas
        /// <summary>
        /// Retorna uma lista com todas as pessoas
        /// </summary>        
        /// <returns></returns>
        /// <response code="200">Lista retornada com sucesso</response>
        /// <response code="400">Se der algum erro</response>  
        /// <response code="404">Se não existir pessoa para retornar</response>          
        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult Get()
        {
            try
            {                
                var retorno = PessoaAppService.Obter();

                if (retorno.Count() > 0)
                {
                    return Ok(retorno);
                }
                else
                {
                    return NotFound();
                }
            }            
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Pessoas/5
        /// <summary>
        /// Retorna uma pessoa específica
        /// </summary>       
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">Pessoa retornada com sucesso</response>
        /// <response code="400">Se der algum erro</response>  
        /// <response code="404">Se não existir a pessoa com o código passado</response>    
        [HttpGet("{id}", Name = "GetPessoa")]
        [ProducesResponseType(200)]
        public IActionResult Get(string id)
        {
            try
            {
                var retorno = PessoaAppService.ObterPorId(id);

                if (retorno != null) 
                {
                    return Ok(retorno);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Pessoas        
        /// <summary>
        /// Cria uma nova pessoa
        /// </summary>  
        /// <param name="pessoa"></param>
        /// <returns></returns>
        /// <response code="201">Pessoa foi criada com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        [HttpPost]
        [ProducesResponseType(201)]
        public IActionResult Post([FromBody] PessoaDTO pessoa)
        {
            try
            {
                PessoaAppService.Inserir(pessoa);
                return Created(String.Empty, pessoa);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }

        // PUT: api/Pessoas/5
        /// <summary>
        /// Atualiza uma pessoa
        /// </summary>        
        /// <param name="id"></param>
        /// <param name="pessoa"></param>
        /// <returns></returns>
        /// <response code="204">Pessoa foi atualizada com sucesso</response>
        /// <response code="400">Se der algum erro</response>       
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        public IActionResult Put(string id, [FromBody] PessoaDTO pessoa)
        {
            try
            {
                PessoaAppService.Alterar(id, pessoa);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/ApiWithActions/5
        /// <summary>
        /// Deleta uma pessoa
        /// </summary>        
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="204">Pessoa foi deletada com sucesso</response>
        /// <response code="400">Se der algum erro</response>        
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        public IActionResult Delete(string id)
        {
            try
            {
                PessoaAppService.Excluir(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
