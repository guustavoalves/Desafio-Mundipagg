using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Mundipagg.UI.Web.Models
{
    public class PessoaAPI
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public Endereco End { get; set; }
        public List<Telefone> Telefones { get; set; }

        public PessoaAPI()
        {
            Telefones = new List<Telefone>();
        }
    }    
}
