using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Entity;

namespace Desafio.Mundipagg.AppService.DTO
{
    public class EmprestimoRetornoDTO
    {
        public string Id { get; set; }
        public string IdItem { get; set; }
        public string Titulo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Situacao { get; set; }
        public DateTime Data { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public string Tipo { get; set; }

        public static EmprestimoRetornoDTO Criar(Emprestimo emprestimo, Pessoa pessoa, string titulo)
        {
            var emp = new EmprestimoRetornoDTO
            {
                Email = pessoa.Email,
                Id = emprestimo.Id.ToString(),
                Nome = pessoa.Nome,
                Situacao = Enum.GetName(typeof(StatusEmprestimo), emprestimo.Status),
                Telefone = pessoa.Telefones[0].DDD + pessoa.Telefones[0].Numero,
                Data = emprestimo.Data,
                DataDevolucao = emprestimo.DataDevolucao,
                Tipo = Enum.GetName(typeof(TipoItem), emprestimo.Tipo),
                Titulo = titulo,
                IdItem = emprestimo.IdItem
            };
            return emp;
        }
    }
}
