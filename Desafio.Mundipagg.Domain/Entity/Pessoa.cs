using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Infra.Base;

namespace Desafio.Mundipagg.Domain.Entity
{
    public class Pessoa : BaseEntity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }        
        public Endereco End { get; set; }
        public List<Telefone> Telefones { get; set; }

        public Pessoa()
        {
            End = new Endereco();
            Telefones = new List<Telefone>();
        }
    }
}
