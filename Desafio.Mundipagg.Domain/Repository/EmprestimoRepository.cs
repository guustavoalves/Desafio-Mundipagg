using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Interface;
using Desafio.Mundipagg.Domain.Entity;
using Desafio.Mundipagg.Infra.Context;

namespace Desafio.Mundipagg.Domain.Repository
{
    public class EmprestimoRepository : IRepository<Emprestimo>
    {
        public Emprestimo Emprestimo { get; set; }
        private MongoDbContext<Emprestimo> context;

        public EmprestimoRepository()
        {            
            context = new MongoDbContext<Emprestimo>("emprestimo");
        }

        public EmprestimoRepository(Emprestimo emprestimo) : this()
        {
            this.Emprestimo = emprestimo;
        }

        public void Alterar(string id)
        {
            context.Update(Emprestimo, id);
        }

        public void Excluir(string id)
        {
            context.Delete(id);
        }

        public List<Emprestimo> Obter()
        {
            return context.Find();
        }

        public Emprestimo ObterPoId(string id)
        {
            return context.FindById(id);
        }

        public void Inserir()
        {
            context.Insert(Emprestimo);
        }
    }
}
