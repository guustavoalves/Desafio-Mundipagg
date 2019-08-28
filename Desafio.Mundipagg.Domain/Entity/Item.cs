using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Infra.Base;

namespace Desafio.Mundipagg.Domain.Entity
{
    public class Item : BaseEntity
    {
        public string Titulo { get; set; }        
        public string Localizacao { get; set; }
        public StatusItem Status { get; set; }

        public void Emprestar()
        {
            if (Status == StatusItem.Disponivel)
            {
                Status = StatusItem.Emprestado;
            }
            else
            {
                throw new ItemNaoEstaDisponivelException();
            }
        }

        public void Devolver()
        {
            if (Status == StatusItem.Emprestado)
            {
                Status = StatusItem.Disponivel;
            }
            else
            {
                throw new ItemNaoEstaEmprestadoException();
            }
        }
    }
    public enum StatusItem
    {
        Disponivel = 1,
        Emprestado = 2
    }

    public class ItemNaoEstaEmprestadoException : Exception
    {
        public override string Message
        {
            get { return "Item não está emprestado"; }
        }
    }

    public class ItemNaoEstaDisponivelException : Exception
    {
        public override string Message
        {
            get { return "Item não está disponível"; }
        }
    }
}
