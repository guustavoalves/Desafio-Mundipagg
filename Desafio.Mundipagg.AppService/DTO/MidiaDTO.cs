using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Entity;

namespace Desafio.Mundipagg.AppService.DTO
{
    public class MidiaDTO
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Localizacao { get; set; }
        public StatusItem Status { get; set; }
        public string Genero { get; set; }
        public string Diretor { get; set; }
        public DateTime? AnoLancamento { get; set; }
        public TipoMidia Tipo { get; set; }

        public static Midia Criar(MidiaDTO midia)
        {
            return new Midia
            {
                Titulo = midia.Titulo,
                AnoLancamento = midia.AnoLancamento,
                Diretor = midia.Diretor,
                Genero = midia.Genero,
                Tipo = midia.Tipo,
                Localizacao = midia.Localizacao,
                Status = StatusItem.Disponivel
            };
        }

        public static IEnumerable<MidiaDTO> Criar(IEnumerable<Midia> midias)
        {
            foreach(var midia in midias)
            {
                var midiaDTO = new MidiaDTO
                {
                    AnoLancamento = midia.AnoLancamento,
                    Diretor = midia.Diretor,
                    Genero = midia.Genero,
                    Id = midia.Id.ToString(),
                    Localizacao = midia.Localizacao,
                    Tipo = midia.Tipo,
                    Status = midia.Status,
                    Titulo = midia.Titulo
                };
                yield return midiaDTO;
            }
        }

        public static MidiaDTO Criar(Midia midia)
        {
                var midiaDTO = new MidiaDTO
                {
                    AnoLancamento = midia.AnoLancamento,
                    Diretor = midia.Diretor,
                    Genero = midia.Genero,
                    Id = midia.Id.ToString(),
                    Localizacao = midia.Localizacao,
                    Tipo = midia.Tipo,
                    Status = midia.Status,
                    Titulo = midia.Titulo
                };
                return midiaDTO;
        }
    }
}
