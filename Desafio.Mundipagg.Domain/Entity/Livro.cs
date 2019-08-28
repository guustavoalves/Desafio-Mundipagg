using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Mundipagg.Domain.Entity
{
    public class Livro : Item
    {
        public string Autor { get; set; }
        public DateTime? AnoEdicao { get; set; }
        public string Editora { get; set; }
    }
}
