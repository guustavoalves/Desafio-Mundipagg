using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Interface;
using Desafio.Mundipagg.Domain.Entity;
using Desafio.Mundipagg.Infra.Context;

namespace Desafio.Mundipagg.Domain.Repository
{
    public class MidiaRepository : IRepository<Midia>
    {
        public Midia Midia { get; set; }
        private MongoDbContext<Midia> context;

        public MidiaRepository()
        {            
            context = new MongoDbContext<Midia>("midia");
        }

        public MidiaRepository(Midia midia) : this()
        {
            this.Midia = midia;
        }

        public void Alterar(string id)
        {
            context.Update(Midia, id);
        }

        public void Excluir(string id)
        {
            context.Delete(id);
        }

        public List<Midia> Obter()
        {
            return context.Find();
        }

        public Midia ObterPorId(string id)
        {
            return context.FindById(id);
        }

        public void Inserir()
        {
            context.Insert(Midia);
        }
    }
}
