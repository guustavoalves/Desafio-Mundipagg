using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Mundipagg.Domain.Entity
{
    public class Midia : Item
    {
        public string Genero { get; set; }
        public string Diretor { get; set; }
        public DateTime? AnoLancamento { get; set; }
        public TipoMidia Tipo { get; set; }
    }

    public enum TipoMidia
    {
        CD = 1,
        DVD = 2
    }
}
