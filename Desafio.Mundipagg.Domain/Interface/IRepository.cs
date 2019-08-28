using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Mundipagg.Domain.Interface
{
    public interface IRepository<T> where T : class
    {
        List<T> Obter();

        void Inserir();

        void Excluir(string id);

        void Alterar(string id);
    }
}
