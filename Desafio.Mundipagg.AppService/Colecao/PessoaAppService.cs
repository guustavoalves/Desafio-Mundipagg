using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Entity;
using Desafio.Mundipagg.Domain.Repository;
using Desafio.Mundipagg.AppService.DTO;

namespace Desafio.Mundipagg.AppService.Colecao
{
    public class PessoaAppService
    {        
        public static IEnumerable<PessoaDTO> Obter()
        {
            return PessoaDTO.Criar(new PessoaRepository().Obter());
        }

        public static PessoaDTO ObterPorId(string id)
        {
            return PessoaDTO.Criar(new PessoaRepository().ObterPorId(id));
        }

        public static void Inserir(PessoaDTO pessoa)
        {
            var repository = new PessoaRepository(PessoaDTO.Criar(pessoa));                
            repository.Inserir();            
        }

        public static void Alterar(string id, PessoaDTO pessoa)
        {
            var repository = new PessoaRepository(PessoaDTO.Criar(pessoa));                         
            repository.Alterar(id);
        }

        public static void Excluir(string id)
        {
            new PessoaRepository().Excluir(id);
        }
    }
}
