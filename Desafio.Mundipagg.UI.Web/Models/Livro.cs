using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Mundipagg.UI.Web.Models
{
    public class Livro
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Localizacao { get; set; }        
        public string Autor { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? AnoEdicao { get; set; }

        public string Status { get; set; }
        public string Editora { get; set; }
    }
}
