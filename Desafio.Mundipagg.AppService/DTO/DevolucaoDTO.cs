using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Entity;

namespace Desafio.Mundipagg.AppService.DTO
{
    public class DevolucaoDTO
    {
        public string Id{ get; set; }
        public TipoItem Tipo { get; set; }
    }
}
