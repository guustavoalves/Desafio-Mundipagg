using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Mundipagg.Domain.Entity
{
    public class Telefone
    {
        public string DDD { get; set; }
        public string Numero { get; set; }
        public TipoTelefone Tipo { get; set; }         
    }
    public enum TipoTelefone
    {        
        Celular = 1,
        Residencial = 2,
        Comercial = 3
    }
}
