using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Interface;
using Desafio.Mundipagg.Domain.Entity;
using Desafio.Mundipagg.Infra.Context;

namespace Desafio.Mundipagg.Domain.Repository
{
    public class PessoaRepository : IRepository<Pessoa>
    {
        public Pessoa Pessoa { get; set; }
        private MongoDbContext<Pessoa> context;

        public PessoaRepository()
        {            
            context = new MongoDbContext<Pessoa>("pessoa");
        }

        public PessoaRepository(Pessoa pessoa) : this()
        {
            this.Pessoa = pessoa;
        }

        public void Alterar(string id)
        {            
            context.Update(Pessoa, id);
        }

        public void Excluir(string id)
        {            
            context.Delete(id);
        }

        public List<Pessoa> Obter()
        {
            return context.Find();
        }

        public Pessoa ObterPorId(string id)
        {
            return context.FindById(id);
        }

        public void Inserir()
        {
            context.Insert(Pessoa);
        }
    }
}
