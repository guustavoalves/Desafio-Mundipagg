using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Mundipagg.UI.Web.Models
{
    public class Midia
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Localizacao { get; set; }
        public string Status { get; set; }
        public string Genero { get; set; }
        public string Diretor { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? AnoLancamento { get; set; }
        public string Tipo { get; set; }
    }
}
