using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Infra.Base;
using MongoDB.Bson;

namespace Desafio.Mundipagg.Domain.Entity
{
    public class Emprestimo : BaseEntity
    {
        public string IdItem { get; set; }
        public string IdPessoa { get; set; }
        public DateTime Data { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public StatusEmprestimo Status { get; set; }
        public TipoItem Tipo { get; set; }

        public void Devolver()
        {
            if (Status == StatusEmprestimo.Emprestado)
            {
                Status = StatusEmprestimo.Devolvido;
                DataDevolucao = DateTime.Now;
            }
            else
            {
                throw new ItemJaDevolvidoException();
            }
        }
    }
    public enum StatusEmprestimo
    {
        Emprestado = 1,
        Devolvido = 2
    }

    public enum TipoItem
    {
        CD = 1,
        DVD = 2,
        Livro = 3
    }
    public class ItemJaDevolvidoException : Exception
    {
        public override string Message
        {
            get { return "Item já foi devolvido"; }
        }
    }
}

