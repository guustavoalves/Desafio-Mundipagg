using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Interface;
using Desafio.Mundipagg.Domain.Entity;
using Desafio.Mundipagg.Infra.Context;

namespace Desafio.Mundipagg.Domain.Repository
{
    public class LivroRepository : IRepository<Livro>
    {
        public Livro Livro { get; set; }
        private MongoDbContext<Livro> context;

        public LivroRepository()
        {            
            context = new MongoDbContext<Livro>("livro");
        }

        public LivroRepository(Livro livro) : this()
        {
            this.Livro = livro;
        }

        public void Alterar(string id)
        {
            context.Update(Livro, id);
        }

        public void Excluir(string id)
        {
            context.Delete(id);
        }

        public List<Livro> Obter()
        {
            return context.Find();
        }

        public Livro ObterPorId(string id)
        {
            return context.FindById(id);
        }

        public void Inserir()
        {
            context.Insert(Livro);
        }
    }
}
