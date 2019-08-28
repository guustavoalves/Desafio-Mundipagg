using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Mundipagg.Domain.Entity
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
    }
}
