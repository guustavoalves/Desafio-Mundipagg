using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Entity;

namespace Desafio.Mundipagg.AppService.DTO
{
    public class EmprestimoDTO
    {        
        public string Id { get; set; }
        public string IdItem { get; set; }
        public string IdPessoa { get; set; }
        public TipoItem TipoItem { get; set; }

        public static Emprestimo Criar(EmprestimoDTO emprestimo)
        {
            return new Emprestimo
            {
                IdItem = emprestimo.IdItem,
                IdPessoa = emprestimo.IdPessoa,
                Data = DateTime.Now,
                Status = StatusEmprestimo.Emprestado,
                Tipo = emprestimo.TipoItem
            };
        }
    }
}
