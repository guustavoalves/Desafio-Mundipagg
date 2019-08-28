using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Entity;

namespace Desafio.Mundipagg.AppService.DTO
{
    public class LivroDTO
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Localizacao { get; set; }
        public string Autor { get; set; }
        public DateTime? AnoEdicao { get; set; }
        public StatusItem Status { get; set; }
        public string Editora { get; set; }

        public static Livro Criar(LivroDTO livro)
        {
            return new Livro
            {
                Titulo = livro.Titulo,
                AnoEdicao = livro.AnoEdicao,
                Autor = livro.Autor,
                Editora = livro.Editora,
                Localizacao = livro.Localizacao,
                Status = StatusItem.Disponivel
            };
        }

        public static IEnumerable<LivroDTO> Criar(IEnumerable<Livro> livros)
        {
            foreach(var livro in livros)
            {
                var livroDTO = new LivroDTO
                {
                    AnoEdicao = livro.AnoEdicao,
                    Autor = livro.Autor,
                    Editora = livro.Editora,
                    Localizacao = livro.Localizacao,
                    Titulo = livro.Titulo,
                    Id = livro.Id.ToString(),
                    Status = livro.Status
                };
                yield return livroDTO;
            }
        }

        public static LivroDTO Criar(Livro livro)
        {
             var livroDTO = new LivroDTO
                {
                    AnoEdicao = livro.AnoEdicao,
                    Autor = livro.Autor,
                    Editora = livro.Editora,
                    Localizacao = livro.Localizacao,
                    Titulo = livro.Titulo,
                    Id = livro.Id.ToString(),
                    Status = livro.Status
                };
                return livroDTO;
        }
    }
}
