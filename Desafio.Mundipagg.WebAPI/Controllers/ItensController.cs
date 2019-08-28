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
    public class ItensController : ControllerBase
    {
        // GET: api/itens
        /// <summary>
        /// Retorna uma lista com todas os itens
        /// </summary>        
        /// <returns></returns>
        /// <response code="200">Retornada com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        /// <response code="404">Se não existir item para retornar</response>          
        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult Get()
        {
            try
            {
                var retorno = ItemAppService.Obter();

                if (retorno.Count() > 0)
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

        // GET: api/itens/livros
        /// <summary>
        /// Retorna uma lista com todas os livros
        /// </summary>        
        /// <returns></returns>
        /// <response code="200">Retornada com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        /// <response code="404">Se não existir livro para retornar</response>          
        [HttpGet("livros")]
        [ProducesResponseType(200)]
        public IActionResult GetLivros()
        {
            try
            {
                var retorno = ItemAppService.ObterLivros();

                if (retorno.Count() > 0)
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

        // GET: api/itens/livros
        /// <summary>
        /// Retorna uma lista com todas os livros
        /// </summary>        
        /// <returns></returns>
        /// <response code="200">Retornada com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        /// <response code="404">Se não existir livro para retornar</response>          
        [HttpGet("livros/{id}")]
        [ProducesResponseType(200)]
        public IActionResult GetLivro(string id)
        {
            try
            {
                var retorno = ItemAppService.ObterLivro(id);

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

        // GET: api/itens/midias
        /// <summary>
        /// Retorna uma lista com todas as midias
        /// </summary>        
        /// <returns></returns>
        /// <response code="200">Retornada com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        /// <response code="404">Se não existir midia para retornar</response>          
        [HttpGet("midias")]
        [ProducesResponseType(200)]
        public IActionResult GetMidias()
        {
            try
            {
                var retorno = ItemAppService.ObterMidias();

                if (retorno.Count() > 0)
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

        // GET: api/itens/midias/1
        /// <summary>
        /// Retorna uma midia
        /// </summary>        
        /// <returns></returns>
        /// <response code="200">Retornada com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        /// <response code="404">Se não existir midia para retornar</response>          
        [HttpGet("midias/{id}")]
        [ProducesResponseType(200)]
        public IActionResult GetMidia(string id)
        {
            try
            {
                var retorno = ItemAppService.ObterMidia(id);

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

        // GET: api/itens/emprestimos
        /// <summary>
        /// Retorna uma lista com todos os emprestimos
        /// </summary>        
        /// <returns></returns>
        /// <response code="200">Retornada com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        /// <response code="404">Se não existir emprestimo para retornar</response>          
        [HttpGet("emprestimos")]
        [ProducesResponseType(200)]
        public IActionResult GetEmprestimos()
        {
            try
            {
                var retorno = ItemAppService.ObterEmprestimos();

                if (retorno.Count() > 0)
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

        // GET: api/itens/emprestimos
        /// <summary>
        /// Retorna um emprestimo
        /// </summary>        
        /// <returns></returns>
        /// <response code="200">Retornado com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        /// <response code="404">Se não existir emprestimo para retornar</response>          
        [HttpGet("emprestimos/{id}")]
        [ProducesResponseType(200)]
        public IActionResult GetEmprestimo(string id)
        {
            try
            {
                var retorno = ItemAppService.ObterEmprestimo(id);

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

        // POST: api/itens/livros        
        /// <summary>
        /// Cria um novo livro
        /// </summary>  
        /// <param name="livro"></param>
        /// <returns></returns>
        /// <response code="201">Criado com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        [HttpPost("livros")]
        [ProducesResponseType(201)]
        public IActionResult PostLivro([FromBody] LivroDTO livro)
        {
            try
            {
                ItemAppService.InserirLivro(livro);
                return Created(String.Empty, livro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/midias        
        /// <summary>
        /// Cria uma nova mídia
        /// </summary>  
        /// <param name="midia"></param>
        /// <returns></returns>
        /// <response code="201">Criada com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        [HttpPost("midias")]
        [ProducesResponseType(201)]
        public IActionResult PostMidia([FromBody] MidiaDTO midia)
        {
            try
            {
                ItemAppService.InserirMidia(midia);
                return Created(String.Empty, midia);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/livros        
        /// <summary>
        /// Atualiza um livro
        /// </summary>  
        /// <param name="id"></param>
        /// <param name="livro"></param>
        /// <returns></returns>
        /// <response code="204">Atualizado com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        [HttpPut("livros/{id}")]
        [ProducesResponseType(204)]
        public IActionResult PutLivro(string id, [FromBody] LivroDTO livro)
        {
            try
            {
                ItemAppService.AlterarLivro(id, livro);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/midias        
        /// <summary>
        /// Atualiza uma mídia
        /// </summary>  
        /// <param name="id"></param>
        /// <param name="midia"></param>
        /// <returns></returns>
        /// <response code="204">Criada com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        [HttpPut("midias/{id}")]
        [ProducesResponseType(204)]
        public IActionResult PutMidia(string id, [FromBody] MidiaDTO midia)
        {
            try
            {
                ItemAppService.AlterarMidia(id, midia);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/itens/emprestimos    
        /// <summary>
        /// Realiza o emprestimo de um item
        /// </summary>          
        /// <param name="emprestimo"></param>
        /// <returns></returns>
        /// <response code="201">Emprestimo realizado com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        [HttpPost("emprestimos")]
        [ProducesResponseType(201)]
        public IActionResult PostEmprestimo([FromBody] EmprestimoDTO emprestimo)
        {
            try
            {
                ItemAppService.Emprestar(emprestimo);
                return Created(String.Empty, emprestimo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/itens/devolucoes     
        /// <summary>
        /// Realiza a devolução do item
        /// </summary>          
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="204">Devolução realizado com sucesso</response>
        /// <response code="400">Se der algum erro</response>
        [HttpPut("devolucoes/{id}")]
        [ProducesResponseType(204)]
        public IActionResult PutDevolucao(string id)
        {
            try
            {
                ItemAppService.Devolver(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/ApiWithActions/5
        /// <summary>
        /// Deleta um livro
        /// </summary>        
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="204">Deletado com sucesso</response>
        /// <response code="400">Se der algum erro</response>        
        [HttpDelete("livros/{id}")]
        [ProducesResponseType(204)]
        public IActionResult DeleteLivro(string id)
        {
            try
            {
                ItemAppService.ExcluirLivro(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/ApiWithActions/5
        /// <summary>
        /// Deleta uma midia
        /// </summary>        
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="204">Deletado com sucesso</response>
        /// <response code="400">Se der algum erro</response>        
        [HttpDelete("midias/{id}")]
        [ProducesResponseType(204)]
        public IActionResult DeleteMidia(string id)
        {
            try
            {
                ItemAppService.ExcluirMidia(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
