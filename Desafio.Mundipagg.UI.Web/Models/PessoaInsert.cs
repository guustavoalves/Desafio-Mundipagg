using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Mundipagg.UI.Web.Models
{
    public class PessoaInsert
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string DddTelefone { get; set; }
        public string NumeroTelefone { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
    }
}
