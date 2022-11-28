using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna
{
     public class Partido
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Sigla { get; set; }
        public public List<Candidato> Candidatos { get; set; }
        public public DateTime DataCriacao { get; set; }

    }
}
