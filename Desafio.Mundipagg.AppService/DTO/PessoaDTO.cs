using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Entity;

namespace Desafio.Mundipagg.AppService.DTO
{
    public class PessoaDTO
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public Endereco End { get; set; }
        public List<Telefone> Telefones { get; set; }

        public PessoaDTO()
        {
            End = new Endereco();
            Telefones = new List<Telefone>();
        }

        public static IEnumerable<PessoaDTO> Criar(IEnumerable<Pessoa> pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                var pessoaDTO = new PessoaDTO
                {
                    Id = pessoa.Id.ToString(),
                    Nome = pessoa.Nome,
                    Cpf = pessoa.Cpf,
                    Email = pessoa.Email,
                    End = pessoa.End,
                    Telefones = pessoa.Telefones
                };
                yield return pessoaDTO;
            }
        }

        public static PessoaDTO Criar(Pessoa pessoa)
        {
            var pessoaDTO = new PessoaDTO
            {
                Id = pessoa.Id.ToString(),
                Nome = pessoa.Nome,
                Cpf = pessoa.Cpf,
                Email = pessoa.Email,
                End = pessoa.End,
                Telefones = pessoa.Telefones
            };
            return pessoaDTO;
        }

        public static Pessoa Criar(PessoaDTO pessoa)
        {
            return new Pessoa
            {
                Nome = pessoa.Nome,
                Cpf = pessoa.Cpf,
                Email = pessoa.Email,
                End = pessoa.End,
                Telefones = pessoa.Telefones
            };
        }
    }
}
