using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Entity;

namespace Desafio.Mundipagg.AppService.DTO
{
    public class ItemDTO
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public string Localizacao { get; set; }
        public string Status { get; set; }

        public static IEnumerable<ItemDTO> Criar(IEnumerable<Livro> livros, IEnumerable<Midia> midias)
        {
            foreach (var livro in livros)
            {
                var itemDTO = new ItemDTO
                {
                    Id = livro.Id.ToString(),
                    Titulo = livro.Titulo,
                    Localizacao = livro.Localizacao,
                    Status = (livro.Status == StatusItem.Disponivel) ? "Disponível" : "Emprestado",
                    Tipo = "Livro"
                };
                yield return itemDTO;
            }
            foreach (var midia in midias)
            {
                var itemDTO = new ItemDTO
                {
                    Id = midia.Id.ToString(),
                    Titulo = midia.Titulo,
                    Localizacao = midia.Localizacao,
                    Status = (midia.Status == StatusItem.Disponivel) ? "Disponível" : "Emprestado",
                    Tipo = (midia.Tipo == TipoMidia.CD) ? "CD" : "DVD"
                };
                yield return itemDTO;
            }
        }
    }
}
